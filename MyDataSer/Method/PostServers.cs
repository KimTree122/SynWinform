using DSstudentOffline.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSstudentOffline.Method
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

        public static void PostStudentAllData()
        {
            GetDB gdb = new GetDB();
            HttpHelper hh = new HttpHelper();
            //hh.HttpPost(gdb.AllData());
        }


        private static void GetMaxDiffDataInDB()
        {
            GetDB gdb = new GetDB();
            HttpHelper hh = new HttpHelper();
            //hh.HttpPost(gdb.DiffData());
        }



       



    }
}
