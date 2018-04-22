using CS.DAL;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class BaseInfoService
    {
        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();

            }
        }

        public string GetUserInfo(string name,string post)
        {
            string url = UrlHelper.BaseInfoUrl.UserInfo.GetName;

            HttpTools tools = new HttpTools();
            tools.addPar("name", name).addPar("post", post).dicParameter();

            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                return GetResponseString(res);
            }
            return "";
        }


    }
}
