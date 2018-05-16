using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI
{
    public class SysdicSer
    {
        //ComboBoxBind
        //SysdicSer
        private static BaseInfoService baseInfo = new BaseInfoService();

        public static void ComboBoxBind(ComboBox box, string type)
        {
            List<Sysdic> sysdics = baseInfo.GetDicByType(type);
            box.DataSource = sysdics;
            box.DisplayMember = "Dicval";
            box.ValueMember = "id";
        }

        public static List<Sysdic> GetSysdicsbyType(string type)
        {
            List<Sysdic> sysdics = baseInfo.GetDicByType(type);
            return sysdics;
        }

    }
}
