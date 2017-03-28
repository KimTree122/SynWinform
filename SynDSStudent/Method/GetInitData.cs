using SynDSStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynDSStudent
{
    class GetInitData
    {
        public InitData LoadInitData(string LocaCount,bool DB)
        {
            InitData id = new InitData();

            string SerVer =HttpData.Deserialize<string>( HttpData.GetHttp(HttpAPI.GetServerVersion()));
            string SerCount =HttpData.Deserialize<string>( HttpData.GetHttp(HttpAPI.GetServerStudentCount()));
            string LocaVer = AppSetting.GetAppConfig("UpdateID");

            id.LocCount = LocaCount;
            id.LocVer = LocaVer;
            id.SerVer = SerVer;
            id.SerCount = SerCount;

            string stauts = "";
            if (SerVer == "" || SerCount == "")
            {
                stauts += "连接互联网失败，请检测网络。\r\n";
            }

            if (LocaVer == "0" || LocaCount == "0")
            {
                stauts += "本地数据未更新，请‘全部获取’一次\r\n";
            }

            if (!DB)
            {
                stauts += "未找到本机数据库，设置好路径。 \r\n";
            }
            if (stauts == "")
            {
                stauts = "初始化正常";
            }
            id.InitStaut = stauts;

            return id;

        }


    }
}
