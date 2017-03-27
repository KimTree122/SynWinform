using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SynDSStudent
{
    public class SQLiteOper
    {
        private SQLiteConn sconn;

        public SQLiteOper()
        {
            sconn = new SQLiteConn();
            sconn.ConnectSQLite();
        }


        public void InsterStudent(List<DSstudent> Stulst )
        {
            ArrayList al = new ArrayList();
            ArrayList ad = new ArrayList();

            string student = "";
            string dep = "";

            foreach (DSstudent ds in Stulst)
            {
                string guid = Guid.NewGuid().ToString("N").ToUpper();
                student = string.Format("insert into Person(Id, person_code, person_name, person_gender, person_englishname, person_birthday, " +
                    " person_card_type, person_card_no, person_dept_id, person_job_level, person_job_position, person_educational,"+
                    " person_nation, person_phone, person_email, person_address, person_dept_name) values "+
                    " ('{0}', '{1}', '{2}', '0', '', '0', '0', '{3}', '', '0', '', '', '', '{4}', '', '{5}', '')"
                    ,guid, ds.人员编号, ds.人员姓名, ds.证件号码, ds.联系电话, ds.地址);
                al.Add(student);
                dep = string.Format("insert into Dept_Staff (dept_id,staff_id) values ('','{0}')",guid);
                al.Add(dep);
            }
            sconn.ExecuteSqlTran(al);
            
        }


        public void DeleteStudent(List<DSstudent> stulst)
        {
            ArrayList da = new ArrayList();
            string student = "";
            string dep = "";
            foreach (DSstudent ds in stulst)
            {
                student = string.Format("select Id from Person where person_card_no = '{0}' and person_name = '{1}'", ds.证件号码, ds.人员姓名);

                DataTable dt = sconn.SQLiteGetTable(student);
                if (dt.Rows.Count == 0) continue;

                foreach (DataRow dr in dt.Rows)
                {
                    dep = string.Format("delete from Dept_Staff where staff_id = '{0}'", dr["Id"].ToString());
                    da.Add(dep);
                    student = string.Format("delete from Person where id = '{0}'", dr["Id"].ToString());
                    da.Add(student);
                }
            }
            sconn.ExecuteSqlTran(da);
        }


        public bool CheckTable()
        {
            string sql = string.Format("SELECT COUNT(*) FROM sqlite_master where type='table' and name='Student_Update'");
            int oj = int.Parse( sconn.SQLExecuteScalar(sql).ToString());
            return oj > 0 ? true : false;
        }


        public DataTable LocalDepGuid()
        {
            string sql = string.Format("select * from Person");
            DataTable dt = sconn.SQLiteGetTable(sql);
            return dt;
        }

        public string LocalStudentCount()
        {
            string sql = string.Format("select count(*) from Person");
            return sconn.SQLExecuteScalar(sql).ToString();
        }

    }
}
