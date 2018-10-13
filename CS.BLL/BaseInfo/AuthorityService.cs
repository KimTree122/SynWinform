using CS.DAL;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class AuthorityService : PostService<Authority, Authority>
    {
        public List<Authority> GetAuthorities(int userid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.AuthorityUrl.GetAllAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build(); ;
            return GetList(url,tools);
        }

        public int AddAuthority(Authority authority)
        {
            string url = KNDBsysUrl.BaseInfoUrl.AuthorityUrl.AddAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority",DataSwitch.DataToJson(authority)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt();
        }

        public List<Authority> GetOperAuthbyTag( int formtag,string authtypeName)
        {
            string url = KNDBsysUrl.BaseInfoUrl.AuthorityUrl.GetOperAuthByTag;
            HttpTools tools = new HttpTools();
            tools.AddParam("authtypeName", authtypeName).AddParam("tag",formtag).Build();
            return GetList(url, tools);
        }

        public bool UpdateAuthority(Authority auth)
        {
            string url = KNDBsysUrl.BaseInfoUrl.AuthorityUrl.UpdateAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority", DataSwitch.DataToJson(auth)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool DeleteAuthority(Authority auth)
        {
            string url = KNDBsysUrl.BaseInfoUrl.AuthorityUrl.DeleteAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority", DataSwitch.DataToJson(auth)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public List<Authority> GetUserAuth(string userid,string port)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserAuthUrl.GetUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid)
                .AddParam("portType", port).Build();
            return GetList(url, tools);
        }

        public List<Authority> AddUserAuth(List<Authority> userAuths, string userid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserAuthUrl.AddUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("auth", DataSwitch.DataToJson(userAuths))
                .AddParam("userid", userid).Build();
            List<Authority> add = GetList(url, tools);
            return add;
        }

        public bool DeleteUserAuth(List<UserAuth> userAuths, string userid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserAuthUrl.DelteUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("userauthjson", DataSwitch.DataToJson(userAuths))
                .AddParam("userid", userid).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool CopyUserAuth(string userid, string copyuserid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.UserAuthUrl.CopyUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid)
                .AddParam("copyuserid",copyuserid).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }
    }
}
