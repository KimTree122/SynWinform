using MyDataSer.Method;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyDataSer
{
    public class GetStudentData
    {
        public DataTable GetStudent()
        {
            string sql = string.Format("SELECT TOP 50  hrcode, hrname, ID FROM dbo.hrgeneral ORDER BY hrcode DESC");
            return SQLHelper.ExecuteDataTable(sql);
        }

        public void PostData()
        {
             HttpParam hp = new HttpParam();
            hp.Url = "http://192.168.61.58:1277/Ntol/NtolData/GetTestData";
            IDictionary<string, string> idt = new Dictionary<string, string>();
            idt.Add("hrcode", "xf101102");
            hp.myParam = idt;
            string r = HttpHelper.PostHelper(hp);
        }

    }
}
