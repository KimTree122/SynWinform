using CS.DAL;
using CS.Models;
using System;
using System.Collections.Generic;
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

        public List<L> GetEntities(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools); 
            if (res !=null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<L, DBNull> postData = DataSwitch.JsonToObj<PostData<L, DBNull>>(json);
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
                return postData;
            }
            return new PostData<L, E>();
        }



    }
}
