using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynDSStudent
{
    public  class HttpAPI
    {
        public static string GetServerVersion()
        {
            return AppSetting.GetAppConfig("Url")+  "StudentVer";
        }

        public static string GetServerStudentCount()
        {
            return AppSetting.GetAppConfig("Url") + "StudentCount";
        }

        public static string GetStudentLst()
        {
            return AppSetting.GetAppConfig("Url") + "StudentLst";
        }
    }
}
