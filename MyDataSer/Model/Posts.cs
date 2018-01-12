using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DSstudentOffline.Model
{
    public class Posts
    {
        public int ID { get; set; }
        public string Jsons { get; set; }
    }
    public class DSstudent
    {
        public int id { get; set; }
        public string dsid { get; set; }
        public string dsno { get; set; }
        public string dsname { get; set; }
        public string dsidno { get; set; }
        public string aod { get; set; }					
    }

    public class DsPostVerid 
    {
        public int serid { get; set; }
        public string dbid { get; set; }
    }

    public class DsHistory
    {
        public int ID { get; set; }
        public string dsno { get; set; }
        public string histype { get; set; }
        public string rectime { get; set; }
    }

}
