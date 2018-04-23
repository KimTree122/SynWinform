using CS.DAL;
using CS.Models;
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
        public string GetUserInfo(string name,string post)
        {
            string url = UrlHelper.BaseInfoUrl.UserInfo.GetName;

            HttpTools tools = new HttpTools();
            tools.AddParam("name", name).AddParam("post", post).Build();

            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null) return DataSwitch.GetResponseString(res);
            return "";
        }

        public List<CSDicTionary> GetDicByType(string type)
        {
            string url = UrlHelper.BaseInfoUrl.Dictionary.GetDicByType;
            HttpTools tools = new HttpTools();
            tools.AddParam("dictype", type).Build();
            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<CSDicTionary,DBNull> postData = DataSwitch.JsonToObj<PostData<CSDicTionary, DBNull>>(json);
                return postData.DList;
            } 
            return null;
        }


    }
}
