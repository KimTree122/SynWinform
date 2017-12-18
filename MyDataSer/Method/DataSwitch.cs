using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDataSer
{
    public  class DataSwitch
    {
        /// <summary>
        /// Json字符串转成List数组
        /// </summary>
        /// <typeparam name="T">转换数据类型</typeparam>
        /// <param name="jsonstrlst">JSon字符串</param>
        /// <returns></returns>
        public static List<T> JsonToList<T>(string jsonstrlst)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(jsonstrlst);
            }
            catch (Exception)
            {
                return default(List<T>);
            }

        }

        /// <summary>
        /// Json字符串转换成实体类
        /// </summary>
        /// <typeparam name="T">实体类类型</typeparam>
        /// <param name="jsonstr">Json字符串</param>
        /// <returns></returns>
        public static T JsonToObject<T>(string jsonstr)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonstr);
            }
            catch (Exception)
            {
                return default(T);
            }

        }


    }
}
