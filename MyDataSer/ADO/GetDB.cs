using DSstudentOffline.Method;
using DSstudentOffline.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DSstudentOffline.ADO
{
    public class GetDB
    {
        public object GetStudentData(string id, string type)
        {
            string sql = string.Format("EXEC dbo.ParkDataGet '{0}','{1}'", id, type);
            return type == "ver"?  SQLHelper.ExecuteScalar(sql):SQLHelper.ExecuteDataTable(sql);
        }



        private Posts ChangePostdata(int pid, string dspost)
        {
            return new Posts { ID = pid, Jsons = dspost };
        }

        private int StrToInt(string s)
        {
            int i = 0;
            int.TryParse(s, out i);
            return i;
        }

        private string GetServerMaxID()
        {
            HttpHelper hp = new HttpHelper();
            var url = hp.host + @"/maxid?" + hp.salt;
            var result = hp.HttpGet(url);
            return result;
        }

    }
}
