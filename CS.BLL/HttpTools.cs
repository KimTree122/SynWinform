using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL
{
    public  class HttpTools
    {
        private List<object> keys = new List<object>();
        private List<object> values = new List<object>();
        public Dictionary<object, object> dic = new Dictionary<object, object>();


        public  HttpTools addPar(object key, object value)
        {
            keys.Add(key);
            values.Add(value);
            return this;
        }

        public void dicParameter()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                dic.Add(keys[i], values[i]);
            }
        }
    }
}
