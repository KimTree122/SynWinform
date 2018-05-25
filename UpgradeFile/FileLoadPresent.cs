using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace UpgradeFile
{
    public class FileLoadPresent
    {
        private FileLoadHelper helper = new FileLoadHelper();
        private static readonly string url = ConfigurationManager.AppSettings["Url"];

        public PostData<SysVer, SysVer> GetNewVersion()
        {
            Dictionary<object, object> pairs = new Dictionary<object, object>();
            pairs.Add("programtype", "winform");
            string Url = url + "/BaseInfo/BaseInfo/GetNewSysVer";
            string json = helper.CreatePostHttpResponse(Url, pairs,3000,null);
            PostData<SysVer, SysVer> postData = JsonConvert.DeserializeObject<PostData<SysVer, SysVer>>(json);
            return postData;
        }

        public void DownLoadFile(string filename,string tolocal, System.Windows.Forms.ProgressBar prog)
        {
            string Url = url + "/FileLoad/FileLoad/DownFile";
            Dictionary<object, object> pairs = new Dictionary<object, object>();
            pairs.Add("filePath", filename);
            pairs.Add("fileName", filename);
            helper.FileDownLoad(Url, tolocal, pairs, prog);
        }



    }
}
