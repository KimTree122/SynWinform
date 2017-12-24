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
            string json = DataSwitch.DataToJson(dt);
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
            string postjson = DataSwitch.DataToJson(dt);
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

        public string GetanduploadHisData(DsPostVerid dpv)
        {
            DataTable dt = (DataTable)gdb.GetStudentData(dpv.dbid, "his");
            if (dt.Rows.Count > 0)
            {
                string dbmaxid = dt.Rows[dt.Rows.Count - 1]["ID"].ToString();
                Posts p = CreatPost(dpv.serid + 1, dt);
                return hc.PostHisData(p);
            }
            return "记录上传不成功";
        }

        public string UploadHisVer()
        {
            Posts sp = DataSwitch.JsonToObject<Posts>( hc.GetSerHisMaxIDJson("1"));
            DsPostVerid dpv = DataSwitch.JsonToObject<DsPostVerid>(sp.Jsons);
            dpv.serid = dpv.serid+1;
            DataTable maxdbiddt =(DataTable) gdb.GetStudentData("","hisid");
            string maxdbid = "";
            if (maxdbiddt.Rows.Count > 0)
            {
                maxdbid = maxdbiddt.Rows[0]["ID"].ToString();
                dpv.dbid = maxdbid;
                Posts p = CreatPost(1, dpv);
                return  hc.PostHisData(p);
            }
            return "";
        }

        public string UploadHisData()
        {
            string hisverjson = hc.GetSerHisMaxIDJson("1");
            Posts p = DataSwitch.JsonToObject<Posts>(hisverjson);
            DsPostVerid dpv = DataSwitch.JsonToObject<DsPostVerid>(p.Jsons);
            return GetanduploadHisData(dpv);
        }

        public string GetSerStuMaxID()
        {
            return hc.GetSerStuMaxID();
        }

        public string GetSerHisMaxID()
        {
            return hc.GetSerHisMaxID();
        }

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
