using CS.DAL;
using CS.Models;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CS.BLL.FileLoad
{
    public class FileLoadService:PostService<SysVer, SysVer>
    {
        public delegate void Uploadstate(int type, string msg);
        private Uploadstate uploadstate;

        public FileLoadService(Uploadstate us)
        {
            uploadstate = us;
        }

        public FileLoadService() { }

        public int UpLoadFile(string filenamepath, string filePath, ProgressBar bar)
        {
           string url = UrlHelper.FileLoadUrl.FileLoad.UpLoadFile;
            return Upload_Request(url, filenamepath, filePath, bar);
        }

        private int Upload_Request(string address, string fileNamePath, string filePath, ProgressBar progressBar = null)
        {
            int returnValue = 0;
            // 要上传的文件 
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            // 根据uri创建HttpWebRequest对象 
            address = string.Concat(address, "?filename=", Path.GetFileName(fileNamePath)
                + "&filePath=" + filePath);
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
                if (progressBar !=null)
                {
                    progressBar.Maximum = (int)fs.Length;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                }
               
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
                    if (progressBar != null)
                    {
                        progressBar.Value = (int)offset;
                    }
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds;
                    uploadstate(0, "已用时：" + second.ToString("F2") + "秒");
                    if (second > 0.1)
                    {
                        uploadstate(0, " 平均速度：" + (offset / 1024 / second).ToString("0.00") + "KB/秒");
                    }
                    else
                    {
                        uploadstate(0, " 正在连接…");
                    }
                    uploadstate(0, "已上传：" + (offset * 100.0 / fileLength).ToString("F2") + "%");
                    uploadstate(0, (offset / 1048576.0).ToString("F2") + "M/" + (fileLength / 1048576.0).ToString("F2") + "M");
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
                sReturnString = Secret_string.DecryptDES(sReturnString);
                if (sReturnString == null) 
                {
                    returnValue = 0;
                    return returnValue;
                }
                if (sReturnString.IndexOf("1") > 0)
                {
                    returnValue = 1;
                }
                else if (sReturnString.IndexOf("0") >0)
                {
                    returnValue = 0;
                }
            }
            catch (Exception ex)
            {
                uploadstate(0,ex.ToString());
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }
            return returnValue;
        }

        public int AddSysVer(SysVer sysVer)
        {
            string url = UrlHelper.BaseInfoUrl.SysVerUrl.AddSysVer;
            HttpTools tools = new HttpTools();
            tools.AddParam("sysver", DataSwitch.DataToJson(sysVer)).Build();
            HttpWebResponse res = HttpHelper.CreatePostHttpResponse(url, tools.dic, 3000, null);
            if (res != null)
            {
                string json = DataSwitch.GetResponseString(res);
                PostData<SysVer, SysVer> postData = DataSwitch.JsonToObj<PostData<SysVer, SysVer>>(json);
                if (postData.Msg != General.reFail) return int.Parse(postData.Msg);
            }
            return General.intFail;
        }

        public SysVer GetNewSysVer()
        {
            string url = UrlHelper.BaseInfoUrl.SysVerUrl.GetNewSysVer;
            HttpTools tools = new HttpTools();
            tools.AddParam("programtype", "winform").Build();
            return GetEntity(url, tools);
        }

    }
}
