using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CS.DAL
{
    public class FileLoadHelper
    {

        //time:0,speed:1,state:2 size:3
        public delegate void StautsChange(int type, string msg);
        private StautsChange stautsChange;

        public FileLoadHelper(StautsChange stauts)
        {
            stautsChange = stauts;
        }

        /// <summary> 
        /// 将本地文件上传到指定的服务器(HttpWebRequest方法) 
        /// </summary> 
        /// <param name="address">文件上传到的服务器</param> 
        /// <param name="fileNamePath">要上传的本地文件（全路径）</param> 
        /// <param name="progressBar">上传进度条</param> 
        /// <returns>成功返回1，失败返回0</returns> 
        public int Upload_Request(string address, string fileNamePath, ProgressBar progressBar)
        {
            int returnValue = 0;
            // 要上传的文件 
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            // 根据uri创建HttpWebRequest对象 
            address = string.Concat(address, "?filename=", Path.GetFileName(fileNamePath));
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
            httpReq.Method = "POST";
            //对发送的数据不使用缓存 
            httpReq.AllowWriteStreamBuffering = false;
            //设置获得响应的超时时间（30秒） 
            httpReq.Timeout = 30000;
            long fileLength = fs.Length;
            httpReq.ContentLength = fileLength;
            try
            {
                progressBar.Maximum = (int)fs.Length;
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
                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size;
                    progressBar.Value = (int)offset;
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds;
                    stautsChange(0, "已用时：" + second.ToString("F2") + "秒");
                    if (second > 0.1)
                    {
                        stautsChange(0, " 平均速度：" + (offset / 1024 / second).ToString("0.00") + "KB/秒");
                    }
                    else
                    {
                        stautsChange(0, " 正在连接…");
                    }
                    stautsChange(0, "已上传：" + (offset * 100.0 / fileLength).ToString("F2") + "%");
                    stautsChange(0, (offset / 1048576.0).ToString("F2") + "M/" + (fileLength / 1048576.0).ToString("F2") + "M");
                    Application.DoEvents();
                    size = r.Read(buffer, 0, bufferLength);
                }
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }
            return returnValue;
        }

        /// <summary> 
        /// 将本地文件上传到指定的服务器(WebClient方法) 
        /// </summary> 
        /// <param name="address">文件上传到的服务器</param> 
        /// <param name="fileNamePath">要上传的本地文件（全路径）</param> 
        /// <param name="progressBar">上传进度条</param> 
        /// <returns>成功返回1，失败返回0</returns> 
        public int Upload_Client(string address, string fileNamePath, ProgressBar progressBar)
        {
            WebClient wc = new WebClient();
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            address = string.Concat(address, "?filename=", Path.GetFileName(fileNamePath));
            Stream poststream = wc.OpenWrite(address, "POST");
            byte[] buffer = new byte[1024];
            int mum = (int)fs.Length;
            progressBar.Maximum = mum;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            //已上传的字节数 
            long offset = 0;
            int length = fs.Read(buffer, 0, buffer.Length);//读取长度
            //开始上传时间 
            DateTime startTime = DateTime.Now;
            while (length > 0)
            {
                poststream.Write(buffer, 0, length);
                offset += length;
                progressBar.Value = (int)offset;
                TimeSpan span = DateTime.Now - startTime;
                double second = span.TotalSeconds;
                Console.WriteLine("已用时：" + second.ToString("F2") + "秒");
                if (second > 0.1)
                {
                    Console.WriteLine(" 平均速度：" + (offset / 1024 / second).ToString("0.00") + "KB/秒");
                }
                else
                {
                    Console.WriteLine(" 正在连接…");
                }
                Console.WriteLine("已上传：" + (offset * 100.0 / mum).ToString("F2") + "%");
                Console.WriteLine((offset / 1048576.0).ToString("F2") + "M/" + (mum / 1048576.0).ToString("F2") + "M");
                Application.DoEvents();
                length = fs.Read(buffer, 0, buffer.Length);
            }
            poststream.Close();
            if (wc.QueryString.ToString() == "Success")
                return 1;
            else
                return 0;
        }

        public string PostWebRequest(string postUrl, string paramData)
        {
            string ret = string.Empty;
            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(paramData); //转化
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
                webReq.Method = "POST";
                webReq.ContentType = "application/x-www-form-urlencoded";

                webReq.ContentLength = byteArray.Length;
                Stream newStream = webReq.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);//写入参数
                newStream.Close();
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.Default);
                ret = sr.ReadToEnd();
                sr.Close();
                response.Close();
                newStream.Close();
            }
            catch (Exception)
            {
                return string.Empty;
            }
            return ret;
        }

    }
}
