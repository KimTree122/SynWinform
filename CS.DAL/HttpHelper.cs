using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CS.DAL
{
    public class HttpHelper : IHttpHelper
    {

        public static string GetHttpResponse(string url, int Timeout)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = Timeout;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }


        /// 创建POST方式的HTTP请求  
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<object, object> parameters, int timeout, CookieCollection cookies)
        {
            HttpWebRequest request = null;
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //设置代理UserAgent和超时
            //request.UserAgent = userAgent;
            //request.Timeout = timeout; 

            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            //发送POST数据  
            if (!(parameters == null || parameters.Count == 0))
            {
                StringBuilder buffer = new StringBuilder();
                int i = 0;
                foreach (string key in parameters.Keys)
                {
                    if (i > 0)
                    {
                        buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                    }
                    else
                    {
                        buffer.AppendFormat("{0}={1}", key, parameters[key]);
                        i++;
                    }
                }
                byte[] data = Encoding.UTF8.GetBytes(buffer.ToString());
                try
                {
                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                    string[] values = request.Headers.GetValues("Content-Type");
                    return request.GetResponse() as HttpWebResponse;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;

        }


        /// <summary>
        /// 获取请求的数据
        /// </summary>
        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();

            }
        }


        /// 将本地文件上传到指定的服务器(HttpWebRequest方法)  
        /// </summary>  
        /// <param name="address">文件上传到的服务器</param>  
        /// <param name="fileNamePath">要上传的本地文件（全路径）</param>  
        /// <param name="saveName">文件上传后的名称</param>  
        /// <param name="progressBar">上传进度条</param>  
        /// <returns>成功返回1，失败返回0</returns>  
        /*
        private int Upload_Request(string address, string fileNamePath, string saveName, ProgressBar progressBar)
        {
            int returnValue = 0;

            // 要上传的文件  
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);

            //时间戳  
            string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("/r/n--" + strBoundary + "/r/n");

            //请求头部信息  
            StringBuilder sb = new StringBuilder();
            //sb.Append("--");
            //sb.Append(strBoundary);
            //sb.Append("/r/n");
            //sb.Append("Content-Disposition: form-data; name=/"");  
            //sb.Append("file");
            //sb.Append("/"; filename =/ "");
            //sb.Append(saveName);
            //sb.Append("/"");  
            //sb.Append("/r/n");
            //sb.Append("Content-Type: ");
            //sb.Append("application/octet-stream");
            //sb.Append("/r/n");
            //sb.Append("/r/n");
            string strPostHeader = sb.ToString();
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(strPostHeader);

            // 根据uri创建HttpWebRequest对象  
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
            httpReq.Method = "POST";

            //对发送的数据不使用缓存  
            httpReq.AllowWriteStreamBuffering = false;

            //设置获得响应的超时时间（300秒）  
            httpReq.Timeout = 300000;
            httpReq.ContentType = "multipart/form-data; boundary=" + strBoundary;
            long length = fs.Length + postHeaderBytes.Length + boundaryBytes.Length;
            long fileLength = fs.Length;
            httpReq.ContentLength = length;
            try
            {
                progressBar.Maximum = int.MaxValue;
                progressBar.Minimum = 0;
                progressBar.Value = 0;

                //每次上传4k  
                int bufferLength = 4096;
                byte[] buffer = new byte[bufferLength];

                //已上传的字节数  
                long offset = 0;

                //开始上传时间  
                DateTime startTime = DateTime.Now;
                int size = r.Read(buffer, 0, bufferLength);
                Stream postStream = httpReq.GetRequestStream();

                //发送请求头部消息  
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size;
                    progressBar.Value = (int)(offset * (int.MaxValue / length));
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds;
                    lblTime.Text = "已用时：" + second.ToString("F2") + "秒";
                    if (second > 0.001)
                    {
                        lblSpeed.Text = " 平均速度：" + (offset / 1024 / second).ToString("0.00") + "KB/秒";
                    }
                    else
                    {
                        lblSpeed.Text = " 正在连接…";
                    }
                    lblState.Text = "已上传：" + (offset * 100.0 / length).ToString("F2") + "%";
                    lblSize.Text = (offset / 1048576.0).ToString("F2") + "M/" + (fileLength / 1048576.0).ToString("F2") + "M";
                    Application.DoEvents();
                    size = r.Read(buffer, 0, bufferLength);
                }
                //添加尾部的时间戳  
                postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                postStream.Close();

                //获取服务器端的响应  
                WebResponse webRespon = httpReq.GetResponse();
                Stream s = webRespon.GetResponseStream();
                StreamReader sr = new StreamReader(s);

                //读取服务器端返回的消息  
                String sReturnString = sr.ReadLine();
                s.Close();
                sr.Close();
                if (sReturnString == "Success")
                {
                    returnValue = 1;
                }
                else if (sReturnString == "Error")
                {
                    returnValue = 0;
                }

            }
            catch
            {
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }

            return returnValue;
        }
        */


        /// WebClient上传文件至服务器，默认不自动改名   
        /// </summary>   
        /// <param name="fileNamePath">文件名，全路径格式</param>   
        /// <param name="uriString">服务器文件夹路径</param>   
        public void UpLoadFile(string fileNamePath, string uriString)
        {
            UpLoadFile(fileNamePath, uriString, false);
        }

        /// WebClient上传文件至服务器   
        /// </summary>   
        /// <param name="fileNamePath">文件名，全路径格式</param>   
        /// <param name="uriString">服务器文件夹路径</param>   
        /// <param name="IsAutoRename">是否自动按照时间重命名</param>   
        public void UpLoadFile(string fileNamePath, string uriString, bool IsAutoRename)
        {
            string fileName = fileNamePath.Substring(fileNamePath.LastIndexOf("//") + 1);
            string NewFileName = fileName;
            if (IsAutoRename)
            {
                NewFileName = DateTime.Now.ToString("yyMMddhhmmss") + DateTime.Now.Millisecond.ToString() + fileNamePath.Substring(fileNamePath.LastIndexOf("."));
            }

            string fileNameExt = fileName.Substring(fileName.LastIndexOf(".") + 1);
            if (uriString.EndsWith("/") == false) uriString = uriString + "/";

            uriString = uriString + NewFileName;
            //Utility.LogWriter log = new Utility.LogWriter();
            //log.AddLog(uriString, "Log");   
            //log.AddLog(fileNamePath, "Log");   
            /**//**/
                /**//// 创建WebClient实例  
            WebClient myWebClient = new WebClient();
            myWebClient.Credentials = CredentialCache.DefaultCredentials;
            // 要上传的文件   
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            //FileStream fs = OpenFile();   
            BinaryReader r = new BinaryReader(fs);
            byte[] postArray = r.ReadBytes((int)fs.Length);
            Stream postStream = myWebClient.OpenWrite(uriString, "PUT");


            try
            {

                //使用UploadFile方法可以用下面的格式   
                //myWebClient.UploadFile(uriString,"PUT",fileNamePath);   


                if (postStream.CanWrite)
                {
                    postStream.Write(postArray, 0, postArray.Length);
                    postStream.Close();
                    fs.Dispose();
                    //log.AddLog("上传日志文件成功！", "Log");
                }
                else
                {
                    postStream.Close();
                    fs.Dispose();
                    //log.AddLog("上传日志文件失败，文件不可写！", "Log");
                }

            }
            catch (Exception err)
            {
                postStream.Close();
                fs.Dispose();
                //Utility.LogWriter log = new Utility.LogWriter();   
                //log.AddLog(err, "上传日志文件异常！", "Log");
                throw err;
            }
            finally
            {
                postStream.Close();
                fs.Dispose();
            }
        }


        /// 下载服务器文件至客户端   
        /// </summary>   
        /// <param name="URL">被下载的文件地址，绝对路径</param>   
        /// <param name="Dir">另存放的目录</param>   
        public void Download(string URL, string Dir)
        {
            WebClient client = new WebClient();
            string fileName = URL.Substring(URL.LastIndexOf("//") + 1);  //被下载的文件名  

            string Path = Dir + fileName;   //另存为的绝对路径＋文件名   
            //Utility.LogWriter log = new Utility.LogWriter();
            try
            {
                WebRequest myre = WebRequest.Create(URL);
            }
            catch (Exception err)
            {
                //MessageBox.Show(exp.Message,"Error");    
                //log.AddLog(err, "下载日志文件异常！", "Log");
            }

            try
            {
                client.DownloadFile(URL, fileName);
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(fs);
                byte[] mbyte = r.ReadBytes((int)fs.Length);

                FileStream fstr = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);

                fstr.Write(mbyte, 0, (int)fs.Length);
                fstr.Close();

            }
            catch (Exception err)
            {
                //MessageBox.Show(exp.Message,"Error");   
                //log.AddLog(err, "下载日志文件异常！", "Log");
            }
        }
    }
}
