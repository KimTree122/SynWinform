using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SynDSStudent
{
    public class HttpConnect
    {
        private string host = "http://120.78.188.216:8001";
        private string salt = @"&salt=lOZVMROz1R1luHyRU9AKNO6aOR8BHV6WhHc6sI3XJaz6IXQ0qyYxg1KAsDvLeALZDNwSV4ozGtSXWS1rYWzk90LKkMIrqtJ9rZLdBJQZohiVOgHVhO3JJ45SvYL";


        private delegate string Getdata(int id);
        private delegate string GetMaxid();


        private string HttpPost(string URI, Posts posts)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(URI);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(posts);//将实体类Posts序列化json字符串
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            //post的结果
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }

        private string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json;charset=UTF-8";
            //请求结果
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }


        private string GetSerStuDatabyid(int id)
        {
            string url = host + @"/posts?id=" + id + salt;
            return HttpGet(url);
        }

        private string GetStuMaxID()
        {
            string url = host + @"/maxid"+ salt;
            return HttpGet(url);
        }

        private string GetHisDatabyid(int id)
        {
            string url = host + @"/operates?id=" + id + salt;
            return HttpGet(url);
        }

        private string GetHisMaxID()
        {
            string url = host + @"/maxid" + salt;
            return HttpGet(url);
        }

        public Posts GetAllStu() 
        {
            string Serjson = GetSerStuDatabyid(1);
            Posts p = DataSwitch.JsonToObject<Posts>(Serjson);
            return p;
        }

        public DsPostVerid GetSerStuVer()
        {
            return GetVer(GetSerStuDatabyid, 2);
        }

        public DsPostVerid GetSerHisVer()
        {
            return GetVer(GetHisDatabyid,1); 
        }

        private DsPostVerid GetVer(Getdata gd,int soh)
        {
            string Verjson = gd(soh);
            Posts p = DataSwitch.JsonToObject<Posts>(Verjson);
            DsPostVerid dpv = DataSwitch.JsonToObject<DsPostVerid>(p.Jsons);
            return dpv; 
        }

        public List<Posts> StuDiff(DsPostVerid sdpv, DsPostVerid ldpv)
        {
            return GetDiffdata(sdpv, ldpv,GetSerStuDatabyid);
        }

        public List<Posts> HisData(DsPostVerid sdpv, DsPostVerid ldpv)
        {
            return GetDiffdata(sdpv, ldpv, GetHisDatabyid);
        }

        private List<Posts> GetDiffdata(DsPostVerid sdpv, DsPostVerid ldpv, Getdata gd)
        {
            List<Posts> plist = new List<Posts>();
            for (int i = ldpv.serid; i <= sdpv.serid; i++)
            {
                string postjson = gd(i);
                Posts p = DataSwitch.JsonToObject<Posts>(postjson);
                plist.Add(p);
            }
            return plist;
        }

    }
}
