using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SynDSStudent.SQLiteADO
{
    public class DataOper
    {
        private InitSQLite initsql;

        public DataOper()
        {
            initsql = new InitSQLite();
        }

        public void InsandDelStuData(List<DSstu> stulist)
        {
            ArrayList sqlarr = new ArrayList();
            foreach (var stu in stulist)
            {
                if (stu.dsadd == "1")
                {
                    string sqlins = string.Format("INSERT INTO DSstudent (ID, DsNO, DsName, IDcard, MPhone) VALUES ('{0}','{1}','{2}','{3}','{4}')",stu.dsid,stu.dsno,stu.dsname,stu.dsid,stu.dsmphone);
                    sqlarr.Add(sqlins);
                }
                else
                {
                    string sqldel = string.Format("DELETE dbo.DSstudent WHERE IDcard = '{0}'",stu.dsid);
                    sqlarr.Add(sqldel);
                }
            }
            initsql.ExecuteSqlTran(sqlarr);
        }

        public void InsertHisData(List<DsHistory> hislist)
        {
            ArrayList arr = new ArrayList();
            foreach (var his in hislist)
            {
                string sqldel = string.Format("INSERT INTO DShist (operid, form, oper, opertime, stuid) VALUES  ('{0}','{1}','{2}','{3}','{4}')",his.operid,his.form,his.oper,his.opertime,his.stuid);
                arr.Add(sqldel);
            }
            initsql.ExecuteSqlTran(arr);
        }

        public void UpdataVer(DsPostVerid dpv)
        {
            string sql = string.Format("UPDATE dbo.DSdataver SET serstuid = '{0}', serhisid = '{1}'",dpv.serid,dpv.dbid);
            initsql.SQLiteNonQuery(sql);
        }

        public DsPostVerid GetLocalID()
        {
            string sql = string.Format("SELECT * FROM dbo.DSdataver");
            DataTable dt = initsql.SQLiteGetTable(sql);
            DsPostVerid dv = new DsPostVerid
            {
                 serid =int.Parse(dt.Rows[0]["serstuid"].ToString()) , dbid = dt.Rows[0]["serhisid"].ToString() };
            return dv;
        }

        public DSstu GetStuByID(string sid)
        {
            string sql = string.Format("SELECT * FROM dbo.DSstudent  WHERE IDcard = '{0}'",sid);
            DataTable dt = initsql.SQLiteGetTable(sql);
            DSstu ds = DataSwitch.DTToObject<DSstu>(dt);
            return ds;
        }

        public List<DsHistory> GetHisbyID(string sid)
        {
            string sql = string.Format("SELECT * FROM dbo.DShist WHERE stuid = '{0}'",sid);
            DataTable dt = initsql.SQLiteGetTable(sql);
            List<DsHistory> hislist = DataSwitch.DTToList<DsHistory>(dt);
            return hislist;
        }
    }
}
