using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DsParkOffLine
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
        public string dsid { get; set; }
        public string dsno { get; set; }
        public string dsname { get; set; }
        public string dsidno { get; set; }
        public string aod { get; set; }
    }

    public class Posts
    {
        public int ID { get; set; }
        public string Jsons { get; set; }
    }

    public class DsPostVerid
    {
        public int serid { get; set; }
        public string dbid { get; set; }
    }

    public class DsHistory
    {
        public string id { get; set; }
        public string form { get; set; }
        public string oper { get; set; }
        public string rec { get; set; }
    }

}
