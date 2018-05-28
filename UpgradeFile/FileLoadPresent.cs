using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            string str = Secret_string.DecryptDES(json);
            PostData<SysVer, SysVer> postData = JsonConvert.DeserializeObject<PostData<SysVer, SysVer>>(str);
            return postData;
        }

        public int DownLoadFile(string filename,string tolocal, System.Windows.Forms.ProgressBar prog)
        {
            string Url = url + "/FileLoad/FileLoad/DownFile";
            Dictionary<object, object> pairs = new Dictionary<object, object>();
            string fn = filename.Substring(filename.LastIndexOf('/')+1);
            pairs.Add("filePath", filename);
            pairs.Add("fileName", fn);
            return helper.FileDownLoad(Url, tolocal, pairs, prog);
        }

        public void UnZipFile(string path)
        {

        }

        public static class Secret_string
        {
            //默认密钥向量
            private static byte[] Keys = { 0x12, 0x34, 0x56, 0x77, 0x90, 0xAB, 0xCD, 0xEF };
            private static string encryptKey = "FsQyCbcx";

            public static string EncryptDES(string encryptString)//, string encryptKey)
            {
                try
                {
                    byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                    byte[] rgbIV = Keys;
                    byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                    DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                    MemoryStream mStream = new MemoryStream();
                    CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                    cStream.Write(inputByteArray, 0, inputByteArray.Length);
                    cStream.FlushFinalBlock();
                    return Convert.ToBase64String(mStream.ToArray());
                }
                catch
                {
                    return encryptString;
                }
            }

            public static string DecryptDES(string decryptString)//, string decryptKey)
            {
                try
                {
                    byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey);
                    byte[] rgbIV = Keys;
                    byte[] inputByteArray = Convert.FromBase64String(decryptString);
                    DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                    MemoryStream mStream = new MemoryStream();
                    CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                    cStream.Write(inputByteArray, 0, inputByteArray.Length);
                    cStream.FlushFinalBlock();
                    return Encoding.UTF8.GetString(mStream.ToArray());
                }
                catch
                {
                    return decryptString;
                }
            }

            #region   对数据进行MD5 32位加密
            /// <summary>  
            /// 对数据进行MD5 32位加密 
            /// </summary>  
            /// <param name="encryptstring">需要加密的字符串</param>  
            /// <returns></returns>  
            public static string GetMD5(string encryptstring)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] bytValue, bytHash;
                bytValue = System.Text.Encoding.UTF8.GetBytes(encryptstring);
                bytHash = md5.ComputeHash(bytValue);
                md5.Clear();
                string pwd = "";
                for (int i = 0; i < bytHash.Length; i++)
                {
                    pwd += bytHash[i].ToString("X").PadLeft(2, '0');
                }
                return pwd.ToLower();
            }
            #endregion

            #region   对数据进行MD5 16位加密
            /// <summary>  
            /// MD5 16位加密  
            /// </summary>  
            /// <param name="encryptstring">需要加密的字符串</param>  
            /// <returns></returns>  
            public static string GetMd5Short(string encryptstring)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string pwd = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(encryptstring)), 4, 8);
                pwd = pwd.Replace("-", "");
                return pwd.ToLower(); ;
            }
            #endregion
        }

    }
}
