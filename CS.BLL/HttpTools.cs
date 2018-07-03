using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.BLL
{
    public  class HttpTools
    {
        private List<object> keys = new List<object>();
        private List<object> values = new List<object>();
        public Dictionary<object, object> dic = new Dictionary<object, object>();


        public  HttpTools AddParam(object key, object value)
        {
            keys.Add(key);
            values.Add(value);
            return this;
        }

        public void Build()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                dic.Add(keys[i], values[i]);
            }
        }

    }

    public class PostHelper
    {
        private List<string> keylist = new List<string>();
        private List<object> valuelist = new List<object>();


        public PostHelper AddParam(string key, object value)
        {
            keylist.Add(key);
            valuelist.Add(value);
            return this;
        }

        public string Response(string url)
        {
            Dictionary<object, object> dic = new Dictionary<object, object>();
            for (int i = 0; i < keylist.Count; i++)
            {
                dic.Add(keylist[i], valuelist[i]);
            }

            string res = "";

            keylist.Clear();
            valuelist.Clear();
            return res;
        }
    }
}
