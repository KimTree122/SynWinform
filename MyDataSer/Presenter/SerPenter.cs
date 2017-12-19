using MyDataSer.ADO;
using MyDataSer.HttpConn;
using MyDataSer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyDataSer
{
    public class Presenter
    {
        private HttpConnect hc;
        private GetDB gdb;
        private DataSwitch dswitch;

        public Presenter()
        {
            hc = new HttpConnect();
            gdb = new GetDB();
            dswitch = new DataSwitch();
        }

        public string UploadAllstudentdata()
        {
            DataTable dt = (DataTable) gdb.GetStudentData("", "alldata");
            string Smaxid = hc.GetSerMaxID();
            string dbmaxid = gdb.GetStudentData("", "ver").ToString();
            string pjson = DTtoPostdata(dbmaxid, dt);
            return hc.PostStudentData(ChangePostdata(1, pjson));
        }



        public string UploadDiffStudentdata()
        {
            string Smaxid = hc.GetSerMaxID();
            string maxidjson = hc.GetSerMaxIDJson(Smaxid);
            Posts maxpost = DataSwitch.JsonToObject<Posts>(maxidjson);
            DsPostData dps = DataSwitch.JsonToObject <DsPostData> (maxpost.Jsons);
            string dbmaxid = gdb.GetStudentData("", "ver").ToString();
            DataTable dt =(DataTable)gdb.GetStudentData(dps.Mmaxid, "byid");
            string pjson = DTtoPostdata(dbmaxid, dt);
            return hc.PostStudentData(ChangePostdata(StrToInt(Smaxid) + 1, pjson));
        }

        public string UploadVerData(string sid, string cid)
        {
            DataTable dt =(DataTable) gdb.GetStudentData(cid, "byid");
            string dbmaxid = gdb.GetStudentData("", "ver").ToString();
            string pjson = DTtoPostdata(dbmaxid, dt);
            return hc.PostStudentData(ChangePostdata(StrToInt(sid), pjson));
        }


        public string GetVerData(string sid) 
        {
            string str = "";
            string serjsonstr = hc.GetSerMaxIDJson(sid);
            Posts p = DataSwitch.JsonToObject<Posts>(serjsonstr);
            DsPostData dps = DataSwitch.JsonToObject<DsPostData>(p.Jsons);
            int count = 1;
            foreach (DataRow item in dps.DSAllstudentDT.Rows)
            {
                str+=count+"--"+ item["dsname"].ToString()+"\r\n";
                count++;
            }
            return str;
        }


        public string UploadHisData()
        {
            return "";
        }

        private string DTtoPostdata(string dbmaxID, DataTable dt)
        {
            DsPostData dpd = new DsPostData { Mmaxid = dbmaxID, DSAllstudentDT = dt };
            return JsonConvert.SerializeObject(dpd);
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

    }
}
