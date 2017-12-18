using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDataSer.Method
{
    public class PostServers
    {
        public static string GetServerMaxID()
        {
            HttpHelper hp = new HttpHelper();
            var url = hp.host + @"/maxid?" + hp.salt;
            var result = hp.HttpGet(url);
            return result;
        }

        private static void GetAllStudentsInDB()
        {
            
        }

        public static void PostData(string maxid ,string postjson)
        {
 
        }


        private static void GetMaxDiffDataInDB(string cid)
        {
 
        }



       



    }
}
