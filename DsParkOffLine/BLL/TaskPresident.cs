using DsParkOffLine.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

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
            DataTable dt = dc.GetAllStudents();
            if (dt.Rows.Count == 0) return;
            dc.DelDBStudent();
            dc.InsDBstudent(dt);
            DataTable hdt = dc.GetHistory();
            dc.DelDBHis();
            dc.InsDBHistory(hdt);
            scd();
        }

        public DSstu GetStuInSqlite(string str)
        {
            return dc.GetDSstubyNO(str);
        }

        public List<DsHistory> GetDSHisInSqllite(string stuid)
        {
            return dc.GetDShislist(stuid);
        }

        public bool CheckConnect()
        {
            return SerSQLhelper.TestConnect();

        }

    }
}
