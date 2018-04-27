using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.UI
{
    public class SYSData
    {

    }
    public class SYSUser
    {
        public static int id { get; set; }
        public static string Name { get; set; }
        public static List<Authority> Funtion { get; set; }
        public static List<Authority> OperAuth { get; set; }
    } 
}
