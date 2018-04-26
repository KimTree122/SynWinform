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

        public List<Sysdic> GetDicByType(string type)
        {
            string url = UrlHelper.BaseInfoUrl.Dictionary.GetDicByType;
            HttpTools tools = new HttpTools();
            tools.AddParam("dictype", type).Build();
            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<Sysdic, DBNull> postData = DataSwitch.JsonToObj<PostData<Sysdic, DBNull>>(json);
                return postData.DList;
            } 
            return new List<Sysdic>();
        }

        public int AddDictionary(Sysdic cSDic)
        {
            string url = UrlHelper.BaseInfoUrl.Dictionary.AddDicByType;
            HttpTools tools = new HttpTools();
            tools.AddParam("dic", DataSwitch.DataToJson(cSDic)).Build();
            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull, DBNull> postData = DataSwitch.JsonToObj<PostData<DBNull, DBNull>>(json);
                if (postData.Msg != General.reFail) return int.Parse(postData.Msg);
            }
            return General.intFail;
        }

        public bool UpdateDictionary(Sysdic cSDic)
        {
            string url = UrlHelper.BaseInfoUrl.Dictionary.Updatedictionary;
            HttpTools tools = new HttpTools();
            tools.AddParam("dic", DataSwitch.DataToJson(cSDic)).Build();
            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull, DBNull> postData = DataSwitch.JsonToObj<PostData<DBNull, DBNull>>(json);
                if (postData.Msg != General.reFail) return true;
            }
            return false;
        }

        public bool DleteDictionary(Sysdic sysdic)
        {
            string url = UrlHelper.BaseInfoUrl.Dictionary.DeleteSysdic;
            HttpTools tools = new HttpTools();
            tools.AddParam("dic", DataSwitch.DataToJson(sysdic)).Build();
            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<DBNull, DBNull> postData = DataSwitch.JsonToObj<PostData<DBNull, DBNull>>(json);
                if (postData.Msg != General.reFail) return true;
            }
            return false;
        }

    }
}
