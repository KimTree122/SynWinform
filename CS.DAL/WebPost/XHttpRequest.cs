using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.DAL.WebPost
{
    public class XHttpRequest
    {
        XWebClient client = new XWebClient();
        public XHttpRequest()
        {
            client.Headers["Accept"] = "application/json";
            client.Timeout = 30000;//30秒
        }
        /// <summary>
        /// WebClient通信对象
        /// </summary>
        public WebClient Client
        {
            get
            {
                return client;
            }
        }
        /// <summary>
        /// Post FromBody方式提供数据
        /// </summary>
        /// <param name="url">WebApi请求地址</param>
        /// <param name="values">参数</param>
        /// <remarks>当values只有一个参数时(即WebApi接口只有一个输入参数)，name要置"",否则无法传递</remarks>
        public string PostFromBody(string url, NameValueCollection values)
        {
            try
            {
                byte[] responseData = client.UploadValues(url, values);//得到返回字符流  
                return Encoding.UTF8.GetString(responseData);
            }
            catch { }
            return null;
        }
        /// <summary>
        /// Post 默认方式提供数据
        /// </summary>
        /// <param name="url">WebApi请求地址</param>
        /// <param name="data">请求数据 如id=5&parent=0</param>
        public ApiResult<string> PostData(string url, string data)
        {
            ApiResult<string> result = new ApiResult<string>();
            result.code = HttpStatusCode.BadRequest;
            try
            {
                // 转化成二进制数组
                byte[] byteArray = Encoding.UTF8.GetBytes(data);
                // 上传数据，并获取返回的二进制数据.
                byte[] responseData = client.UploadData(url, "POST", byteArray);
                string text = Encoding.UTF8.GetString(responseData);
                result = JsonConvert.DeserializeObject<ApiResult<string>>(text);
            }
            catch { }
            return result;
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName">文件</param>
        /// <returns></returns>
        public ApiResult<string> UploadFile(string url, string fileName)
        {
            ApiResult<string> result = new ApiResult<string>();
            result.code = HttpStatusCode.BadRequest;
            try
            {
                byte[] responseData = client.UploadFile(url, "POST", fileName);//得到返回字符流  
                string text = Encoding.UTF8.GetString(responseData);
                result = JsonConvert.DeserializeObject<ApiResult<string>>(text);
            }
            catch { }
            return result;
        }
        /// <summary>
        /// Get请求获取数据
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public string GetData(string url)
        {
            string text = null;
            try
            {
                using (Stream data = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        text = reader.ReadToEnd();
                        reader.Close();
                    }
                    data.Close();
                }
            }
            catch { }
            return text;
        }
    }
}

