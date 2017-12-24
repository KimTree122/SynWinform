using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SynDSStudent.ReadCard
{
    class ReadIDCard
    {

    }

    public class ReadIDInfo
    {
        public string 姓名 { get; set; }
        public string 身份证 { get; set; }
        public string 户口地址 { get; set; }
        public string 出生日期 { get; set; }
        public string 身份证有效期 { get; set; }
        public string 性别 { get; set; }
        public bool 读取 { get; set; }
    }

    public class ReadIDCardClass
    {
        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int SDT_StartFindIDCard(int iPort, byte[] pucManaInfo, int iIfOpen);
        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int SDT_SelectIDCard(int iPort, byte[] pucManaMsg, int iIfOpen);
        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int SDT_ReadBaseMsg(int iPort, byte[] pucCHMsg, ref UInt32 puiCHMsgLen
            , byte[] pucPHMsg, ref UInt32 puiPHMsgLen, int iIfOpen);
        [DllImport("WltRS.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int GetBmp(byte[] filename, int t);


        public void Readcardinfo(out ReadIDInfo rif)
        {
            rif = new ReadIDInfo();
            rif.读取 = true;
            byte[] CardPUCIIN = new byte[255];
            byte[] pucManaMsg = new byte[255];
            byte[] pucCHMsg = new byte[255];
            byte[] pucPHMsg = new byte[3024];
            string wltname = "temp.wlt";
            UInt32 puiCHMsgLen = 0;
            UInt32 puiPHMsgLen = 0;

            int st = 0;
            //读卡操作
            st = SDT_StartFindIDCard(1001, CardPUCIIN, 1);
            if (st != 0x9f)
            {
                MessageBox.Show("寻卡失败!");
                rif.读取 = false;
                return;
            }
            st = SDT_SelectIDCard(1001, pucManaMsg, 1);
            if (st != 0x90)
            {
                MessageBox.Show("选卡失败!");
                rif.读取 = false;
                return;
            }
            st = SDT_ReadBaseMsg(1001, pucCHMsg, ref puiCHMsgLen, pucPHMsg, ref puiPHMsgLen, 1);
            if (st != 0x90)
            {
                MessageBox.Show("读取失败!");
                rif.读取 = false;
                return;
            }

            //显示结果
            string all = System.Text.ASCIIEncoding.Unicode.GetString(pucCHMsg);
            rif.姓名 = all.Substring(0, 8);
            rif.身份证 = all.Substring(61, 18);
            if (all.Substring(15, 1) == "1")
            {
                rif.性别 = "男";
            }
            else
            {
                rif.性别 = "女";
            }

            rif.户口地址 = all.Substring(26, 35);
            rif.出生日期 = all.Substring(18, 8);
            string dayend = all.Substring(102, 8);
            dayend = dayend.Insert(6, "-").Insert(4, "-");
            rif.身份证有效期 = dayend;
        }
    }

}
