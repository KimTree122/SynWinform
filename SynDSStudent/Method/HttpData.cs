using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SynDSStudent
{
    public class HttpData
    {
        /// <summary>
        /// http上传数据
        /// </summary>
        /// <param name="url">网络地址</param>
        /// <param name="body">上传参数</param>
        /// <returns>返回string </returns>
        public static string PostHttp(string url, string body)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json; charset=utf-8  ";
                httpWebRequest.Method = "POST";
                httpWebRequest.Timeout = 20000;
                byte[] btBodys = Encoding.UTF8.GetBytes(body);
                httpWebRequest.ContentLength = btBodys.Length;
                httpWebRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                string responseContent = streamReader.ReadToEnd(); httpWebResponse.Close();
                streamReader.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();
                return responseContent;
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }

        /// <summary>
        /// http获取数据
        /// </summary>
        /// <param name="url">网络地址</param>
        /// <returns>返回string</returns>
        public static string GetHttp(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json; charset=utf-8  ";
                httpWebRequest.Method = "GET";
                httpWebRequest.Timeout = 20000;
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                string responseContent = streamReader.ReadToEnd(); httpWebResponse.Close();
                streamReader.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();
                return responseContent;
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }


        public static T Deserialize<T>(string data)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            return json.Deserialize<T>(data);
        }

        public static string saveLoad()
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("str");
            writer.WriteValue("123");
            writer.WriteEndObject();
            writer.Flush();
            string jsonText = sw.GetStringBuilder().ToString();
            return jsonText;
        }

    }
}
