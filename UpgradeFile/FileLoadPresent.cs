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

        public bool CompareVer(int userid,ref List<string> list, ref List<string> dis)
        {
            string param = "userid=" + userid;
            string json = helper.PostWebRequest(url,param, Encoding.UTF8);
            PostData<string, string> post = JsonConvert.DeserializeObject<PostData<string,string>>(json);
            if (post != null)
            {
                if (post.MCount == 0) return false;
                string[] discrits = post.DList[0].Split(',');
                string newver = discrits[0];
                
                string currentver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

                if (newver == currentver) return false;

                for (int i = 1; i < discrits.Count(); i++)
                {
                    dis.Add(discrits[i]);
                }
                for (int i = 1; i < post.DList.Count(); i++)
                {
                    list.Add(post.DList[i]);
                }
                return true;
            }
            return false;
        }
    }
}
