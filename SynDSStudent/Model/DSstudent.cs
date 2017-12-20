using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SynDSStudent
{
    public class DSstudent
    {
        public string 人员编号 { get; set; }
        public string 人员姓名 { get; set; }
        public string 人员性别 { get; set; }
        public string 证件类型 { get; set; }
        public string 证件号码 { get; set; }
        public string 部门 { get; set; }
        public string 联系电话 { get; set; }
        public string 地址 { get; set; }
        public int 新增 { get; set; }
    }

    public class DSstu
    {
        public int id { get; set; }
        public string dsno { get; set; }
        public string dsname { get; set; }
        public string dsid { get; set; }
        public string dsmphone { get; set; }
        public string dsadd { get; set; }
    }

    public class Posts
    {
        public int ID { get; set; }
        public string Jsons { get; set; }
    }

    public class DsPostData
    {
        public string Mmaxid { get; set; }
        public DataTable DSAllstudentDT { get; set; }
    }

    public class DsHistory
    {
        public int operid { get; set; }
        public string form { get; set; }
        public string oper { get; set; }
        public string opertime { get; set; }
        public int stuid { get; set; }
    }

    public class Dsver 
    {
        public string serstuid { get; set; }
        public string serhisid { get; set; }
    }

}
