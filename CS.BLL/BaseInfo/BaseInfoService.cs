using CS.DAL;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class BaseInfoService
    {
        public string GetUserInfo()
        {
            string url = UrlHelper.BaseInfoUrl.UserInfo.GetName;
            string str = HttpHelper.GetHttpResponse(url, 200);
            if (str != null) return str;
            return "";
        }
    }
}
