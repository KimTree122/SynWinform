using CS.DAL;
using CS.Models.BaseInfo;
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
            string url = UrlHelper.BaseInfoUrl.AuthorityUrl.GetAllAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build(); ;
            return GetEntities(url,tools);
        }

        public int AddAuthority(Authority authority)
        {
            string url = UrlHelper.BaseInfoUrl.AuthorityUrl.AddAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority",DataSwitch.DataToJson(authority)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt();
        }

        public List<Authority> GetOperAuthbyTag( int formtag,string authtypeName)
        {
            string url = UrlHelper.BaseInfoUrl.AuthorityUrl.GetOperAuthByTag;
            HttpTools tools = new HttpTools();
            tools.AddParam("authtypeName", authtypeName).AddParam("tag",formtag).Build();
            return GetEntities(url, tools);
        }

        public bool UpdateAuthority(Authority auth)
        {
            string url = UrlHelper.BaseInfoUrl.AuthorityUrl.UpdateAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority", DataSwitch.DataToJson(auth)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool DeleteAuthority(Authority auth)
        {
            string url = UrlHelper.BaseInfoUrl.AuthorityUrl.DeleteAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority", DataSwitch.DataToJson(auth)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public List<Authority> GetUserAuth(string userid)
        {
            string url = UrlHelper.BaseInfoUrl.UserAuthUrl.GetUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build();
            return GetEntities(url, tools);
        }

        public List<Authority> AddUserAuth(List<Authority> userAuths, string userid)
        {
            string url = UrlHelper.BaseInfoUrl.UserAuthUrl.AddUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("auth", DataSwitch.DataToJson(userAuths))
                .AddParam("userid", userid).Build();
            List<Authority> add = GetEntities(url, tools);
            return add;
        }

        public bool DeleteUserAuth(List<UserAuth> userAuths, string userid)
        {
            string url = UrlHelper.BaseInfoUrl.UserAuthUrl.DelteUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("userauthjson", DataSwitch.DataToJson(userAuths))
                .AddParam("userid", userid).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool CopyUserAuth(string userid, string copyuserid)
        {
            string url = UrlHelper.BaseInfoUrl.UserAuthUrl.CopyUserAuth;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid)
                .AddParam("copyuserid",copyuserid).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }
    }
}
