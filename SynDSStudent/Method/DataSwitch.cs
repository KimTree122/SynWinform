using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SynDSStudent
{
    public class DataSwitch
    {
        /// <summary>
        /// 根据datatable生成实体类
        /// </summary>
        /// <typeparam name="T">实体类类型</typeparam>
        /// <param name="dt">datatable</param>
        /// <returns>实体类，如果dt数据大于0返回第一行，否则返回新建实体类</returns>
        public static T DTToObject<T>(DataTable dt) where T : class,new()
        {
            List<PropertyInfo> prlist = new List<PropertyInfo>();
            Type t = typeof(T);
            Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });

            DataRow dr;
            T ob = new T();
            if (dt.Rows.Count > 0)
            {
                dr = dt.Rows[0];
                prlist.ForEach(p => { if (dr[p.Name] != DBNull.Value) p.SetValue(ob, dr[p.Name].ToString(), null); });
            }

            return ob;
        }


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

        /// <summary>    
        /// DataTable 转换为List 集合    
        /// </summary>    
        /// <typeparam name="TResult">类型</typeparam>    
        /// <param name="dt">DataTable</param>    
        /// <returns></returns>    
        public static List<T> DTToList<T>(DataTable dt) where T : class, new()
        {
            //创建一个属性的列表    
            List<PropertyInfo> prlist = new List<PropertyInfo>();
            //获取TResult的类型实例  反射的入口    

            Type t = typeof(T);

            //获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表     
            Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });

            //创建返回的集合    

            List<T> oblist = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                //创建TResult的实例    
                T ob = new T();
                //找到对应的数据  并赋值    
                prlist.ForEach(p => { if (row[p.Name] != DBNull.Value) p.SetValue(ob, row[p.Name].ToString(), null); });
                //放入到返回的集合中.    
                oblist.Add(ob);
            }
            return oblist;
        }
    }
}
