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

        public Presenter()
        {
            hc = new HttpConnect();
            gdb = new GetDB();
        }

        public string UploadAllstudentdata()
        {
            DataTable dt = (DataTable) gdb.GetStudentData("", "alldata");
            string json= JsonConvert.SerializeObject(dt);
            Posts p1 = new Posts { ID = 1, Jsons = json };
            string Smaxid = hc.GetSerStuMaxID();
            string dbmaxid = gdb.GetStudentData("", "ver").ToString();
            DsPostVerid dpv = new DsPostVerid { serid =StrToInt(Smaxid), dbid = dbmaxid };
            Posts p2 = CreatPost(2, dpv);
            hc.PostStudentData(p1);
            return hc.PostStudentData(p2);
        }

        private Posts CreatPost(int id, object obj) 
        {
            string json = JsonConvert.SerializeObject(obj);
            return new Posts { ID = id, Jsons = json };
        }

        public string UploadDiffStudentdata()
        {
            string json = hc.GetSerStuJsonByPostid("2");
            Posts p = DataSwitch.JsonToObject<Posts>(json);
            DsPostVerid dpv = DataSwitch.JsonToObject<DsPostVerid>(p.Jsons);

            DataTable dt = (DataTable)gdb.GetStudentData(dpv.dbid, "byid");
            if (dt.Rows.Count == 0) return "未有更新项";
            string postjson = JsonConvert.SerializeObject(dt);
            string dbmaxid = gdb.GetStudentData("", "ver").ToString();
            Posts p1 = new Posts { ID = dpv.serid + 1, Jsons = postjson };
            dpv.serid = dpv.serid + 1;
            dpv.dbid = dbmaxid;
            Posts p2 = CreatPost(2,dpv);
            hc.PostStudentData(p1);
            return hc.PostStudentData(p2);
        }

        public string UploadVerData(string sid, string cid)
        {
            //DataTable dt =(DataTable) gdb.GetStudentData(cid, "byid");
            //string dbmaxid = gdb.GetStudentData("", "ver").ToString();
            ////string pjson = DTtoPostdata(dbmaxid, dt);
            //return hc.PostStudentData(ChangePostdata(StrToInt(sid), pjson));
            return "";
        }

        public string GetVerData(string sid) 
        {
            string str = "";
            string serjsonstr = hc.GetSerStuJsonByPostid(sid);
            Posts p = DataSwitch.JsonToObject<Posts>(serjsonstr);
            DsPostVerid dps = DataSwitch.JsonToObject<DsPostVerid>(p.Jsons);
            int count = 1;
            //foreach (DataRow item in dps.DSAllstudentDT.Rows)
            //{
            //    str+=count+"--"+ item["dsname"].ToString()+"\r\n";
            //    count++;
            //}
            return serjsonstr;
        }

        public string GetanduploadHisData(string sid, string cid)
        {
            DataTable dt = (DataTable)gdb.GetStudentData(cid, "his");
            string dbmaxid = dt.Rows[dt.Rows.Count - 1]["ID"].ToString();
            Posts p = CreatPost(StrToInt(sid) + 1, dt);

            return "";
        }

        public string UploadHisData()
        {
            DataTable dbmid = (DataTable)gdb.GetStudentData("", "hisid");
            string serid = hc.GetSerHisMaxID();
            return GetanduploadHisData(serid, dbmid.Rows[0]["ID"].ToString());
        }

        public string GetSerStuMaxID()
        {
            return hc.GetSerStuMaxID();
        }

        public string GetSerHisMaxID()
        {
            return hc.GetSerHisMaxID();
        }

        //private string DTtoPostdata(string dbmaxID, DataTable dt)
        //{
        //    DsPostData dpd = new DsPostData { Mmaxid = dbmaxID, DSAllstudentDT = dt };
        //    return JsonConvert.SerializeObject(dpd);
        //}


        private int StrToInt(string s)
        {
            int i = 0;
            int.TryParse(s, out i);
            return i;
        }

        internal string GetHisData(string p)
        {
            return hc.GetSerHisMaxIDJson(p);
        }
    }
}
