﻿using KNDBsys.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.BLL
{
    public class DataSwitch
    {
        public static List<T> JsonToList<T>(string jsonlist)
        {
            try { return JsonConvert.DeserializeObject<List<T>>(jsonlist); }
            catch (Exception) { return default(List<T>); }
        }

        public static T JsonToObj<T>(string jsonobj)
        {
            try {
                string str = Secret_string.DecryptDES(jsonobj);
                return JsonConvert.DeserializeObject<T>(str);
            }
            catch (Exception) { return default(T); }
        }

        public static string DataToJson(object list)
        {
            return JsonConvert.SerializeObject(list);
        }

        public static string HttpPostData<L, E>(List<L> dlist, string msg = "", E obj = default(E))
        {
            PostData<L, E> postData = new PostData<L, E>
            {
                DList = dlist,
                MCount = dlist.Count,
                Msg = msg,
                Entity = obj
            };

            return DataToJson(postData);
        }

        public static string HttpPostData<L>(List<L> dlist, string msg = "")
        {
            PostData<L, DBNull> post = new PostData<L, DBNull>
            {
                DList = dlist,
                MCount = dlist.Count,
                Msg = msg
            };
            return DataToJson(post);
        }

        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();
            }
        }

       
    }
}
