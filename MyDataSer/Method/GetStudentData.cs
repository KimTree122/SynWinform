using MyDataSer.Method;
using MyDataSer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyDataSer
{
    public class GetStudentData
    {
        public DataTable GetStudent(string did, string type)
        {
            string sql = string.Format("EXEC dbo.ParkDataGet '{0}','{1}'",did,type);
            return SQLHelper.ExecuteDataTable(sql);
        }


        public string PostAllData()
        {
            DataTable dt = GetStudent("","alldata");
            string jsondt = JsonConvert.SerializeObject(dt);
            HttpHelper hp = new HttpHelper();
            Posts ps = new Posts();
            ps.ID = 1;
            ps.Jsons = jsondt;
            return hp.HttpPost(ps);
        }

        public string GetMainMaxID()
        {
            HttpHelper hp = new HttpHelper();
            var url =hp.host+@"/maxid?"+hp.salt;
            var result = hp.HttpGet(url);
            return result;
        }

        public int GetJsonMaxID(string mid) 
        {
            HttpHelper hp = new HttpHelper();
            var url = hp.host + @"/posts?id=" + mid + hp.salt;
            string postjson = hp.HttpGet(url);
            Posts ps = DataSwitch.JsonToObject<Posts>(postjson);
            List<DSstudent> studentlist = DataSwitch.JsonToList<DSstudent>(ps.Jsons);
            int maxid = studentlist.Max(did => did.id);
            return maxid ;
        }

        public string PostdifferData(int maxid ,int did)
        {
            DataTable dt = GetStudent(did+"", "byID");
            string jsondt = JsonConvert.SerializeObject(dt);
            HttpHelper hp = new HttpHelper();
            Posts ps = new Posts();
            ps.ID = maxid+1;//测试用正式需+1
            ps.Jsons = jsondt;
            return hp.HttpPost(ps);
        }

    }
}
