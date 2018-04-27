using CS.DAL;
using CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.BLL
{
    public class PostService<T,S> where T:class,new() where S : class,new()
    {

        private HttpWebResponse Response(string url, HttpTools tools)
        {
            return HttpHelper.CreatePostHttpResponse(url,tools.dic,3000,null); ;
        }

        public List<T> GetEntities(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools); 
            if (res !=null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<T, DBNull> postData = DataSwitch.JsonToObj<PostData<T, DBNull>>(json);
                return postData.DList;
            }

            return new List<T>();
        }

        public S GetEntity(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull,S> postData = DataSwitch.JsonToObj<PostData<DBNull, S>>(json);
                return postData.Obj;
            }
            return new S();
        }

        public string GetMsg(string url, HttpTools tools )
        {
            HttpWebResponse res = Response(url, tools);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull, DBNull> postData = DataSwitch.JsonToObj<PostData<DBNull, DBNull>>(json);
                return postData.Msg;
            }
            return "";
        }

        public PostData<T, S> GetPostData(string url, HttpTools tools)
        {
            HttpWebResponse res = Response(url, tools);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<T, S> postData = DataSwitch.JsonToObj<PostData<T, S>>(json);
                return postData;
            }
            return new PostData<T, S>();
        }



    }
}
