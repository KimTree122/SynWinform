using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SynDSStudent.Method
{
    public class InitSetting
    {
        public SQLiteConnection conn;
        public SQLiteCommand cmd; 

        private string path;
        private string DSdb = "DSdb";

        public InitSetting() 
        {
            path = Application.StartupPath+"//"+DSdb;
        }

        public void CheckDB()
        {
            bool cf = File.Exists(path);
            if (!cf) SQLiteConnection.CreateFile(DSdb);
            conn = new SQLiteConnection("Data Source=" + path);
            conn.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = conn;
            CreatTable();
        }

        public void CreatTable()
        {
            string sql = string.Format("CREATE table DSstudent (ID int, DsNO varchar(50), DsName varchar(50), IDcard varchar(50), MPhone varchar(50))");
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }





    }
}
