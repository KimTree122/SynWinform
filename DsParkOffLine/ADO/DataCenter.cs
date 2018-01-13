using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DsParkOffLine.ADO
{
    public class DataCenter
    {
        private DBSQLhelper dbs;

        public DataCenter() 
        {
            dbs = new DBSQLhelper();
        }

        public DataTable GetAllStudents()
        {
            string sql = string.Format("EXEC dbo.ParkDataGet '','alldata'");
            return SerSQLhelper.ExecuteDataTable(sql);
        }

        public DataTable GetHistory()
        {
            string sql = string.Format("EXEC dbo.ParkDataGet '','his'");
            return SerSQLhelper.ExecuteDataTable(sql);
        }

        public int DelDBStudent()
        {
            string sqldel = string.Format("DELETE from DSstudent");
            return dbs.SQLiteNonQuery(sqldel);
        }

        public void InsDBstudent(DataTable dt)
        {
            ArrayList sqlarr = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                string sqlins = string.Format("INSERT INTO  DSstudent  (ID , dsid , dsno , dsname , dsidno ) VALUES ('{0}','{1}','{2}','{3}','{4}')", dr["id"].ToString(), dr["dsid"].ToString(), dr["dsno"].ToString(), dr["dsname"].ToString(), dr["dsidno"].ToString());
                sqlarr.Add(sqlins);
            }
            dbs.ExecuteSqlTran(sqlarr);
        }

        public void InsDBHistory(DataTable dt)
        {
            ArrayList sqlarr = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                string sqlins = string.Format("INSERT INTO  DShist  ( id ,form ,oper , rec ) VALUES ('{0}','{1}','{2}','{3}')", dr["id"].ToString(), dr["form"].ToString(), dr["oper"].ToString(), dr["rec"].ToString());
                sqlarr.Add(sqlins);
            }
            dbs.ExecuteSqlTran(sqlarr);
        }


        public DSstu GetDSstubyNO(string dsidno) 
        {
            string sql = string.Format("SELECT * FROM DSstudent  WHERE (dsno = '{0}' or dsidno = '{0}')", dsidno);
            DataTable dt = dbs.SQLiteGetTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new DSstu { id = int.Parse(dr["ID"].ToString()), dsid = dr["dsid"].ToString(), dsno = dr["dsno"].ToString(), dsname = dr["dsname"].ToString(), dsidno = dr["dsidno"].ToString() };
            }
            return new DSstu();
        }

        public List<DsHistory> GetDShislist(string stuid)
        {
            List<DsHistory> dhlist = new List<DsHistory>();
            string sql = string.Format("SELECT * FROM  DShist WHERE id = '{0}' order BY rec ", stuid);
            DataTable dt = dbs.SQLiteGetTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DsHistory dh = new DsHistory { id = dr["id"].ToString(), form = dr["form"].ToString(), oper = dr["oper"].ToString(), rec = dr["rec"].ToString() };
                dhlist.Add(dh);
            }
            return dhlist;
        }


        internal void DelDBHis()
        {
            string sqldel = string.Format("DELETE from DShist");
            dbs.SQLiteNonQuery(sqldel);
        }
    }
}
