using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.DAL.WebPost
{
    /// <summary>
    /// API结果
    /// </summary>
    /// where T:class,new()
    public class ApiResult<T>
    {

        public ApiResult()
        {
            this.msg = new List<string>();
        }
        /// <summary>
        /// 内容
        /// </summary>
        public HttpStatusCode code { set; get; }
        /// <summary>
        /// 消息
        /// </summary>
        public List<string> msg { set; get; }
        /// <summary>
        /// 消息数据
        /// </summary>
        //[JsonProperty("")]
        public T data
        {
            set; get;
        }
    }
}
