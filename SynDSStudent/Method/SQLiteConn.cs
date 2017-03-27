using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SynDSStudent
{
    public class SQLiteConn
    {
        public  SQLiteConnection conn;
        public  SQLiteCommand cmd;

        private string Paht;

        /// <summary>
        /// 检查文件是否存在
        /// </summary>
        /// <returns>存在返回true,失败返回false</returns>
        public bool CheckDataBase()
        {
            Paht = Application.StartupPath + "//AccessCCDB";
            bool fileexit = File.Exists(Paht);
            return fileexit;
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>连接成功返回ture,失败返回false</returns>
        public bool ConnectSQLite()
        {
            bool checkSqlite = CheckDataBase();
            if (!checkSqlite) return checkSqlite;
            conn = new SQLiteConnection("Data Source=" + Paht);
            conn.Open();

            cmd = new SQLiteCommand();
            cmd.Connection = conn;
            return true;
        }

        /// <summary>
        /// 执行SQL返回受影响行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>受影响行数</returns>
        public  int SQLiteNonQuery(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 执行查询数据项
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回 SQLiteDataReader</returns>
        public SQLiteDataReader SQLiteQuery(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// 执行查询返回DT
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>DT</returns>
        public DataTable SQLiteGetTable(string sql)
        {
            SQLiteDataAdapter command = new SQLiteDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            command.Fill(ds, "T0");
            return ds.Tables[0];
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>        
        public  void ExecuteSqlTran(ArrayList SQLStringList)
        {
 
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
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

        public  object SQLExecuteScalar(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }

    }
}
