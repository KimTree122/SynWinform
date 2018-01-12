using DSstudentOffline.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace DSstudentOffline.HttpConn
{
    public class HttpConnect
    {
        public string host = "http://120.78.188.216:8001";
        public string salt = @"&salt=lOZVMROz1R1luHyRU9AKNO6aOR8BHV6WhHc6sI3XJaz6IXQ0qyYxg1KAsDvLeALZDNwSV4ozGtSXWS1rYWzk90LKkMIrqtJ9rZLdBJQZohiVOgHVhO3JJ45SvYL";


        private string HttpPost(string URI, Posts posts)
        {
            //string URI = host + "/posts?" + salt;

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


        public string GetSerStuMaxID()
        {
            var url = host + @"/maxid?" + salt;
            return HttpGet(url);
        }

        public string GetSerHisMaxID()
        {
            var url = host + @"/operatesmaxid?" + salt;
            return HttpGet(url);
        }

        public string PostStudentData(Posts p)
        {
            string URI = host + "/posts?" + salt;
            return HttpPost(URI,p);
        }

        public string GetSerStuJsonByPostid(string id)
        {
            string url = host + @"/posts?id=" + id+salt;
            return HttpGet(url);
        }

        public string PostHisData(Posts p)
        {
            string URI = host + "/operates?" + salt;
            return HttpPost(URI, p);
        }

        public string GetSerHisMaxIDJson(string id)
        {
            string url = host + @"/operates?id=" + id + salt;
            return HttpGet(url);
        }

    }
}
