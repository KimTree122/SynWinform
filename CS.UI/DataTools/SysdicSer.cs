using CS.BLL.BaseInfo;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI
{
    public class SysdicSer
    {

        private static BaseInfoService baseInfo = new BaseInfoService();

        public static void ComboBoxBindbyType(ComboBox box, string type)
        {
            List<Sysdic> sysdics = baseInfo.GetDicByType(type);
            ComboBoxBindbyData(box, sysdics);
        }

        public static void ComboBoxBindbyData(ComboBox box, List<Sysdic> sysdics)
        {
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
