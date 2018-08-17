using CS.DAL;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class UserInfoService :PostService<UserInfo,UserInfo>
    {
        public List<UserInfo> GetAllUserinfo(int userid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserInfoUrl.GetAllUserInfo;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build();
            return GetList(url, tools);
        }



        public int Adduserinfo(UserInfo userInfo)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserInfoUrl.AddUserInfo;
            HttpTools t = new HttpTools();
            t.AddParam("userinfo", DataSwitch.DataToJson( userInfo)).Build();
            string msg = GetMsg(url, t);
            return msg.ToInt();
        }

        public bool Updateuserinfo(UserInfo userInfo)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserInfoUrl.UpdateUserInfo;
            HttpTools t = new HttpTools();
            t.AddParam("userinfo", DataSwitch.DataToJson(userInfo)).Build();
            string msg = GetMsg(url, t);
            return msg.ToInt() > 0;
        }

        public bool Deleteuserinfo(UserInfo userInfo)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserInfoUrl.DeleteUserInfo;
            HttpTools t = new HttpTools();
            t.AddParam("userinfo", DataSwitch.DataToJson(userInfo)).Build();
            string msg = GetMsg(url, t);
            return msg.ToInt() > 0;
        }

        public UserInfo GetUserInfoByAccount(string account, string pwd)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserInfoUrl.GetUserInfoByAccount;
            HttpTools t = new HttpTools();
            t.AddParam("account", account).AddParam("pwd", pwd).Build();
            return GetEntity(url,t);
        }

    }
}
