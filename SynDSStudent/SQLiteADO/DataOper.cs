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
                if (stu.aod == "1")
                {
                    string sqlins = string.Format("INSERT INTO  DSstudent  (ID , dsid , dsno , dsname , dsidno ) VALUES ('{0}','{1}','{2}','{3}','{4}')", stu.id, stu.dsid, stu.dsno, stu.dsname, stu.dsidno);
                    sqlarr.Add(sqlins);
                }
                else
                {
                    string sqldel = string.Format("DELETE from DSstudent WHERE dsid = '{0}'", stu.dsid);
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
                string sqldel = string.Format("INSERT INTO  DShist  (ID , dsno , histype , rectime ) VALUES ('{0}','{1}','{2}','{3}')", his.ID, his.dsno, his.histype, his.rectime);
                arr.Add(sqldel);
            }
            initsql.ExecuteSqlTran(arr);
        }

        public void UpdataVer(DsPostVerid dpv,int datatype)
        {
            string sql = string.Format("UPDATE DSdataver SET serstuid = '{0}', serhisid = '{1}' WHERE datatype = '{2}'", dpv.serid, dpv.dbid,datatype);
            initsql.SQLiteNonQuery(sql);
        }

        internal DsPostVerid GetLocalID(string soh)
        {
            string sql = string.Format("SELECT * FROM DSdataver WHERE datatype = '{0}'",soh);
            DataTable dt = initsql.SQLiteGetTable(sql);
            DsPostVerid dv = new DsPostVerid
            {
                 serid =int.Parse(dt.Rows[0]["serstuid"].ToString()) , dbid = dt.Rows[0]["serhisid"].ToString() };
            return dv;
        }

        public DSstu GetStuByID(string sid)
        {
            string sql = string.Format("SELECT * FROM DSstudent  WHERE IDcard = '{0}'",sid);
            DataTable dt = initsql.SQLiteGetTable(sql);
            DSstu ds = DataSwitch.DTToObject<DSstu>(dt);
            return ds;
        }

        public List<DsHistory> GetHisbyID(string sid)
        {
            string sql = string.Format("SELECT * FROM DShist WHERE stuid = '{0}'",sid);
            DataTable dt = initsql.SQLiteGetTable(sql);
            List<DsHistory> hislist = DataSwitch.DTToList<DsHistory>(dt);
            return hislist;
        }

    }
}
