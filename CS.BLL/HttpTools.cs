using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.BLL
{
    public struct  HttpTools
    {
        private List<object> keys ;
        private List<object> values ;
        public Dictionary<object, object> dic ;


        public  HttpTools AddParam(object key, object value)
        {
            if (keys == null)
            {
                keys = new List<object>();
                values = new List<object>();
                dic = new Dictionary<object, object>();
            }
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
}
