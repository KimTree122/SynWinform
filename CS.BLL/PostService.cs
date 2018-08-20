using CS.DAL;
using KNDBsys.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.BLL
{
    public class PostService<L,E> where L:class,new() where E : class,new()
    {

        private HttpWebResponse Response(string url, HttpTools tools)
        {
            return HttpHelper.CreatePostHttpResponse(url,tools.dic,3000,null); ;
        }

        private Stream ResponeStream(string url,HttpTools tools)
        {
            Stream s = HttpHelper.ResponseStream(url,tools.dic);
            return s;
        }

        private  byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        } 


        public List<L> GetList(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools); 
            if (res !=null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<L, DBNull> postData = DataSwitch.JsonToObj<PostData<L, DBNull>>(json);
                if (postData == null) return new List<L>();
                return postData.DList;
            }

            return new List<L>();
        }

        public E GetEntity(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull,E> postData = DataSwitch.JsonToObj<PostData<DBNull, E>>(json);
                if (postData == null) return new E();
                return postData.Entity;
            }
            return new E();
        }

        public string GetMsg(string url, HttpTools tools )
        {
            HttpWebResponse res = Response(url, tools);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull, DBNull> postData = DataSwitch.JsonToObj<PostData<DBNull, DBNull>>(json);
                if (postData == null) return "";
                return postData.Msg;
            }
            return "";
        }

        public PostData<L, E> GetPostData(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<L, E> postData = DataSwitch.JsonToObj<PostData<L, E>>(json);
                if (postData == null ) return new PostData<L, E>();
                return postData;
            }
            return new PostData<L, E>();
        }


    }
}
