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
    }
}
