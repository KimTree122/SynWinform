using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CS.DAL
{
    public class UrlHelper
    {
        private static readonly string BaseUrl = ConfigurationManager.AppSettings["Url"];

        public static class BaseInfoUrl
        {
            private static readonly string FristLayer = BaseUrl + ConfigurationManager.AppSettings["BaseInfo"] + "/";

            public static class UserInfoUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";
                //userid
                public static string GetAllUserInfo = SecondLayer + "GetAllUserInfo";
                public static string AddUserInfo = SecondLayer + "AddUserInfo";
                public static string UpdateUserInfo = SecondLayer + "UpdateUserInfo";
                public static string DeleteUserInfo = SecondLayer + "DeleteUserInfo";
                public static string GetUserInfoByAccount = SecondLayer + "GetUserInfoByAccount";
            }

            public static class DictionaryUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";

                public static string GetDicByType = SecondLayer + "GetDictionary";
                public static string AddDicByType = SecondLayer + "AddDictionary";
                public static string Updatedictionary = SecondLayer + "Updatedictionary";
                public static string DeleteSysdic = SecondLayer + "DeleteSysdic";
            }

            public static class AuthorityUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";

                public static string GetAllAuthority = SecondLayer + "GetAllAuthority";
                public static string AddAuthority = SecondLayer + "AddAuthority";
                public static string UpdateAuthority = SecondLayer + "UpdateAuthority";
                public static string DeleteAuthority = SecondLayer + "DeleteAuthority";
            }

            public static class UserAuthUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";

                public static string GetUserAuth = SecondLayer + "GetUserAuth";
                public static string AddUserAuth = SecondLayer + "AddUserAuth";
                public static string DelteUserAuth = SecondLayer + "DelteUserAuth";
                public static string CopyUserAuth = SecondLayer + "CopyUserAuth";
            }

            public static class ServerTypeUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";

                public static string GetAllServerType = SecondLayer + "GetAllServerType";
                public static string AddServerType = SecondLayer + "AddServerType";
                public static string UpdatServerType = SecondLayer + "UpdatServerType";
                public static string DeleteServerType = SecondLayer + "DeleteServerType";
            }

            public static class CustomInfoUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";

                public static string GetAllCustomInfo = SecondLayer + "GetAllCustomInfo";
                public static string AddCustomInfo = SecondLayer + "AddCustomInfo";
                public static string UpdatCustomInfo = SecondLayer + "UpdatCustomInfo";
                public static string DeleteCustomInfo = SecondLayer + "DeleteCustomInfo";
                public static string CountCustomTel = SecondLayer + "CountCustomTel";
                public static string FindCustomByTel = SecondLayer + "FindCustomByTel";
                public static string FindCustomByid = SecondLayer + "FindCustomByid";
            }

        }

        public static class WorkUrl
        {
            private static readonly string FristLayer = BaseUrl+
                ConfigurationManager.AppSettings["Work"] + "/";
            public static class CheckInBLL
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["WorkBLL"] + "/";

                public static string GetCustomHistory = SecondLayer + "GetCustomHistory";
                public static string AddCheckInMT = SecondLayer + "AddCheckInMT";
                public static string UpdateCheckInMT = SecondLayer + "UpdateCheckInMT";
                public static string AddCheckInDT = SecondLayer + "AddCheckInDT";
                public static string UpdateCheckInDT = SecondLayer + "UpdateCheckInDT";
                public static string GetQRnumber = SecondLayer + "GetSerNumber";
                public static string GetCheckInByMTid = SecondLayer + "GetCheckInByMTid";
                public static string GetCustomidByQR = SecondLayer + "GetCustomidByQR";
            }
        }

    }
}
