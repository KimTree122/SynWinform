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

        //public void InsDBHistory(DataTable dt)
        //{
        //    ArrayList sqlarr = new ArrayList();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        string sqlins = string.Format("INSERT INTO  DShist  ( id ,form ,oper , rec,name,dsidno ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", dr["id"].ToString(), dr["form"].ToString(), dr["oper"].ToString(), dr["rec"].ToString(), dr["name"].ToString(), dr["dsidno"].ToString());
        //        sqlarr.Add(sqlins);
        //    }
        //    dbs.ExecuteSqlTran(sqlarr);
        //}

        public void InsOrUpdataDBHistory(List<ImportExcelCls> dshilist)
        {
            ArrayList sqlarr = new ArrayList();
            foreach (ImportExcelCls dh in dshilist)
            {
                string sql = "";
                if (CheckHisByDsNO(dh.dsno))
                {
                    sql = string.Format("INSERT INTO  DShist  ( name ,dsid ,dsno , trainercode,checkin,sex,skilldate, ky,ke,ks,kms) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", dh.name, dh.dsid, dh.dsno, dh.trainercode, dh.checkin, dh.sex, dh.skilldate, dh.ky, dh.ke, dh.ks, dh.kms);
                }
                else
                {
                    sql = string.Format("update DShist set skilldate = '{0}', ky = '{1}',ke = '{2}',ks = '{3}',kms = '{4}' where dsno = '{5}'",dh.skilldate,dh.ky,dh.ke,dh.ks,dh.kms,dh.dsno);
                }
                sqlarr.Add(sql);
            }
            dbs.ExecuteSqlTran(sqlarr);
        }

        public bool CheckHisByDsNO(string dsno)
        {
            string sql = string.Format("select count(*) from DShist where dsno = '{0}' ",dsno);
            object obj = dbs.SQLExecuteScalar(sql);
            if (obj == null) return true;
            int count = int.Parse(obj.ToString());
            return count > 0 ? false:true ;
        }

        public int CheckHisByDsid(string dsid)
        {
            string sql = string.Format("select count(*) from DShist where dsid = '{0}' ", dsid);
            object obj = dbs.SQLExecuteScalar(sql);
            if (obj == null) return 0;
            int count = int.Parse(obj.ToString());
            return count  ;
        }


        public DataTable GetHis(string txt)
        {
            string sql = string.Format("select * from DShist where dsno like '%{0}' or dsid = '{0}'", txt);
            return dbs.SQLiteGetTable(sql);
        }


        public DSstu GetDSstubyNO(string dsidno) 
        {
            string sql = string.Format("SELECT * FROM DSstudent  WHERE (dsno like '%{0}' or dsidno = '{0}')", dsidno);
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
            string sql = string.Format("SELECT * FROM  DShist WHERE id like '%{0}' order BY rec ", stuid);
            DataTable dt = dbs.SQLiteGetTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DsHistory dh = new DsHistory { id = dr["id"].ToString(), form = dr["form"].ToString(), oper = dr["oper"].ToString(), rec = dr["rec"].ToString(), dsidno = dr["dsidno"].ToString(),name = dr["name"].ToString() };
                dhlist.Add(dh);
            }
            return dhlist;
        }


        internal void DelDBHis()
        {
            string sqldel = string.Format("DELETE from DShist");
            dbs.SQLiteNonQuery(sqldel);
        }


        internal int InSDBHis(ImportExcelCls iE)
        {
            string sql = string.Format("INSERT INTO  DShist  ( name ,dsid ,dsno , trainercode,checkin,sex,skilldate, ky,ke,ks,kms) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", iE.name, iE.dsid, iE.dsno, iE.trainercode, iE.checkin, iE.sex, iE.skilldate, iE.ky, iE.ke,iE.ks, iE.kms);
            return dbs.SQLiteNonQuery(sql);
        }

        internal bool DelDBHisByDsID(string DsID)
        {
            string sql = string.Format("delete from DShist where dsid = '{0}' and dsno = ''", DsID);
            return dbs.SQLiteNonQuery(sql) > 0;
        }
    }
}
