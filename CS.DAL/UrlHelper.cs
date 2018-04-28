using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CS.DAL
{
    public static class UrlHelper
    {
        private static readonly string BaseUrl = ConfigurationManager.AppSettings["Url"];

        public static class BaseInfoUrl
        {
            private static readonly string FristLayer = BaseUrl + ConfigurationManager.AppSettings["BaseInfo"]+"/";

            public static class UserInfoUrl
            {
                private static readonly string SecondLayer = FristLayer+ ConfigurationManager.AppSettings["BaseInfo"]+"/";

                public static string GetUserInfo = SecondLayer + "GetUserInfo";
            }

            public static class DictionaryUrl
            {
                private static readonly string SecondLayer = FristLayer + ConfigurationManager.AppSettings["BaseInfo"] + "/";

                public static string GetDicByType= SecondLayer + "GetDictionary";
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

        }

    }
}
