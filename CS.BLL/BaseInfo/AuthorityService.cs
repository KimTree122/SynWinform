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
            tools.AddParam("userid", userid);
            return GetEntities(url,tools);
        }

        public int AddAuthority(Authority authority)
        {
            string url = UrlHelper.BaseInfoUrl.AuthorityUrl.AddAuthority;
            HttpTools tools = new HttpTools();
            tools.AddParam("authority", authority).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt();
        }
    }
}
