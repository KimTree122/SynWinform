using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DsParkOffLine
{
    public class DBSQLhelper
    {
        public SQLiteConnection conn;
        public SQLiteCommand cmd;

        private string path;
        private string DSdb = "DSdb.sqlite";

        public DBSQLhelper()
        {
            path = Application.StartupPath + "\\" + DSdb;
            CheckDB();
        }

        private void CheckDB()
        {
            bool cf = File.Exists(path);
            if (!cf) SQLiteConnection.CreateFile(DSdb);
            conn = new SQLiteConnection("Data Source=DSdb.sqlite;Version=3;");
            conn.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = conn;
            if (!cf) CreatTable();
        }

        public void CreatTable()
        {
            string sql = string.Format("CREATE table DSstudent (ID int, dsid varchar(50), dsno varchar(50), dsname varchar(50), dsidno varchar(50)) ");
            SQLiteNonQuery(sql);
            sql = string.Format("CREATE table DShist (ID int, dsno varchar(50), histype varchar(50), rectime varchar(50)) ");
            SQLiteNonQuery(sql);
            sql = string.Format("CREATE table DSdataver (serstuid int, serhisid int,datatype int) ");
            SQLiteNonQuery(sql);
            sql = string.Format("INSERT INTO DSdataver(serstuid, serhisid,datatype) VALUES (0,0,0)");
            SQLiteNonQuery(sql);
            sql = string.Format("INSERT INTO DSdataver(serstuid, serhisid,datatype) VALUES (2,0,1)");
            SQLiteNonQuery(sql);
        }

        /// <summary>
        /// 执行SQL返回datatable
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>datatable</returns>
        public DataTable SQLiteGetTable(string sql)
        {
            SQLiteDataAdapter command = new SQLiteDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            command.Fill(ds, "T0");
            return ds.Tables[0];
        }

        /// <summary>
        /// 执行SQL返回受影响行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>受影响行数</returns>
        public int SQLiteNonQuery(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
            //SQLiteCommand command = new SQLiteCommand(sql, conn);
            //return command.ExecuteNonQuery();

        }

        /// <summary>
        /// 执行SQL返回第一行第一列数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>受影响行数</returns>
        public object SQLExecuteScalar(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>
        public void ExecuteSqlTran(ArrayList SQLStringList)
        {
            SQLiteTransaction tx = conn.BeginTransaction();
            cmd.Transaction = tx;
            try
            {
                for (int n = 0; n < SQLStringList.Count; n++)
                {
                    string strsql = SQLStringList[n].ToString();
                    if (strsql.Trim().Length > 1)
                    {
                        cmd.CommandText = strsql;
                        cmd.ExecuteNonQuery();
                    }
                }
                tx.Commit();
            }
            catch (System.Data.SQLite.SQLiteException E)
            {
                tx.Rollback();
                throw new Exception(E.Message);
            }
        }
        
    }
}
