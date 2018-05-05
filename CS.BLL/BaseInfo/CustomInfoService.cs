using CS.DAL;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class CustomInfoService : PostService<CustomInfo,CustomInfo>
    {
        public List<CustomInfo> GetAllCustomInfos(int userid)
        {
            string url = UrlHelper.BaseInfoUrl.CustomInUrl.GetAllCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build(); ;
            return GetEntities(url, tools);
        }

        public int AddCustomInfo(CustomInfo serverType)
        {
            string url = UrlHelper.BaseInfoUrl.CustomInUrl.AddCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("customInfo", DataSwitch.DataToJson(serverType)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt();
        }

        public bool UpdateCustomInfo(CustomInfo serverType)
        {
            string url = UrlHelper.BaseInfoUrl.CustomInUrl.UpdatCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("customInfo", DataSwitch.DataToJson(serverType)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool DeleteCustomInfo(CustomInfo serverType)
        {
            string url = UrlHelper.BaseInfoUrl.CustomInUrl.DeleteCustomInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("customInfo", DataSwitch.DataToJson(serverType)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public int FindCustomByTel(string tel)
        {
            string url = UrlHelper.BaseInfoUrl.CustomInUrl.FindCustomByTel;
            HttpTools tools = new HttpTools();
            tools.AddParam("tel", tel).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() ;
        }

    }
}
