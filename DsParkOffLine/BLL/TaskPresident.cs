using DsParkOffLine.ADO;
using DsParkOffLine.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DsParkOffLine
{
    public class TaskPresident
    {
        private DataCenter dc;
        public delegate void ShowComDial();
        public delegate void ChangeProBarValue(int i);
        private ShowComDial scd;

        public TaskPresident() 
        {
            dc = new DataCenter();
        }

        public void LoadSerDataThread( ShowComDial s)
        {
            scd = s;
            new Thread(LoadStudentData).Start();

        }


        public void ThreadTest(ChangeProBarValue tt)
        {
            for (int i = 0; i <=100 ; i++)
            {
                tt(i);
                Thread.Sleep(100);
            }
        }

        public void LoadStudentData()
        {
            //DataTable dt = dc.GetAllStudents();
            //if (dt.Rows.Count == 0) return;
            //dc.DelDBStudent();
            //dc.InsDBstudent(dt);
            //DataTable hdt = dc.GetHistory();
            //dc.DelDBHis();
            //dc.InsDBHistory(hdt);
            //scd();
        }

        public DSstu GetStuInSqlite(string str)
        {
            return dc.GetDSstubyNO(str);
        }

        public List<DsHistory> GetDSHisInSqlite(string stuid)
        {
            return dc.GetDShislist(stuid);
        }

        public ImportExcelCls GetImport(string txt)
        {
            DataTable dt = dc.GetHis(txt);
            if (dt.Rows.Count == 0) return new ImportExcelCls { dsid = "0" };
            DataRow dr = dt.Rows[0];
            return new ImportExcelCls
            {
                dsid = dr["dsid"].ToString(),
                dsno = dr["dsno"].ToString(),
                kms = dr["kms"].ToString(),
                ks = dr["ks"].ToString(),
                ke = dr["ke"].ToString(),
                ky = dr["ky"].ToString(),
                skilldate = dr["skilldate"].ToString(),
                sex = dr["sex"].ToString(),
                checkin = dr["checkin"].ToString(),
                trainercode = dr["trainercode"].ToString(),
                name = dr["name"].ToString()
            };
        }

        public bool CheckConnect()
        {
            return SerSQLhelper.TestConnect();
        }


        internal void importData(ParkStudent parkStudent)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            string[] files = ofd.FileNames;
            foreach (var str in files)
            {
                string filetype =str.Substring(str.LastIndexOf('.')+1);
                switch (filetype)
                {
                    case "xls": ExcelImport(str, parkStudent);
                        break;
                    case "sqlite": CopySqlite(str, parkStudent);
                        break;
                }
            }
        }

        private void CopySqlite(string str, ParkStudent parkStudent)
        {
            
        }

        private void ExcelImport(string str, ParkStudent parkStudent)
        {
            ImportFile.ImoprtExcel(str, parkStudent);
        }

    }
}
