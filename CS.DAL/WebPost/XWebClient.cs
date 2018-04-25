using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.DAL.WebPost
{
    class XWebClient: WebClient
    {
        public XWebClient()
        {
            this.Timeout = 30000;
        }
        /// <summary>
        /// 过期时间(默认30000毫秒)
        /// </summary>
        public int Timeout { get; set; }
        /// <summary>
        /// 重写GetWebRequest,添加WebRequest对象超时时间
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(address);
            //毫秒数。默认值是 100,000 毫秒（100 秒）
            request.Timeout = Timeout;
            //在写入超时或读取超时之前的毫秒数。默认值为 300,000 毫秒（5 分钟）
            request.ReadWriteTimeout = Timeout;
            return request;
        }
    }
}
