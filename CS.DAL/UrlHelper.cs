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

            public static class UserInfo
            {
                private static readonly string SecondLayer = FristLayer+ ConfigurationManager.AppSettings["BaseInfo"]+"/";

                public static string GetName = SecondLayer + "GetUserInfo";
            }
        }

    }
}
