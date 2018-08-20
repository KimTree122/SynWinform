using CS.BLL.BaseInfo;
using FastReport;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.ReportReource
{
    public partial class FrmReportPrint : BaseTabFrom
    {
        public FrmReportPrint()
        {
            InitializeComponent();
        }

        private List<SysVer> sysVers = new List<SysVer>();
        private List<Sysdic> sysdics = new List<Sysdic>();

        private void FrmReportPrint_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                SysVer sysVer = new SysVer { id = i, filelist = i+"filelist", note = i+"note"
                , programtype = i+"programtype", sysver = i+"sysver", upgradedate = i+"upgradedate"};
                sysVers.Add(sysVer);

                Sysdic sysdic = new Sysdic { id = i, Dickey = i+"dickey", DicMeno = i+"dicmeno",
                 Dicname = i+"dicname", Dicsetp = i , Dicval = i+"dicval"};
                sysdics.Add(sysdic);

            }
        }

        private void btn_design_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.RegisterData(sysVers, "sysvers");
            report.RegisterData(sysdics, "sysdics");
            report.SetParameterValue("param1", "param1");
            report.SetParameterValue("param2", "param2");
            report.Load(GetReportsPath("printexample.frx"));
            report.Design();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            GetGUID();
        }

        private void GetGUID()
        {
            Attribute guid_attr = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(GuidAttribute));
            string guid = ((GuidAttribute)guid_attr).Value;

            //Assembly assembly = Assembly.LoadFile(exePath);
            //string guid = assembly.ManifestModule.ModuleVersionId.ToString();

            txb_path.Text = guid;
        }

        private void FilePrint()
        {
            PrintFileHelper printFile = new PrintFileHelper();
            string path = txb_path.Text.Trim();
            printFile.PrintFile(path);

        }

        private void FastReportPrint()
        {
            Report report = new Report();
            report.RegisterData(sysVers, "sysvers");
            report.RegisterData(sysdics, "sysdics");
            report.SetParameterValue("param1", "param1");
            report.SetParameterValue("param2", "param2");
            report.Load(GetReportsPath("printexample.frx"));
            report.Print();
        }

        public string GetReportsPath(string sReportName)
        {
            return FastReport.Utils.Config.ApplicationFolder + "ReportReource\\" + sReportName;
        }

        private void btn_printer_Click(object sender, EventArgs e)
        {
            //List<string> vs = Cprinter.GetLocalPrinter();

            //Externs.SetDefaultPrinter("Fax");
            
        }

        /// <summary>
        /// 获取所有打印机
        /// </summary>
        public class Cprinter
        {
            private static PrintDocument fPrintDocument = new PrintDocument();

            ///<summary>
            ///获取本地默认打印机名称
            ///</summary>
            public static string DefaultPrinter
            {
                get { return fPrintDocument.PrinterSettings.PrinterName; }
            }


            /// <summary>
            ///  获取本地打印机的列表，第一项就是默认打印机
            /// </summary>
            public static List<string> GetLocalPrinter()
            {
                List<string> fPrinters = new List<string>();
                fPrinters.Add(DefaultPrinter);  //默认打印机出现在列表的第一项
                foreach (string fPrinterName in PrinterSettings.InstalledPrinters)
                {
                    if (!fPrinters.Contains(fPrinterName))
                        fPrinters.Add(fPrinterName);
                }
                return fPrinters;
            }
        }

        /// <summary>
        /// 设置默认打印机
        /// </summary>
        class Externs
        {
            [DllImport("winspool.drv")]
            public static extern bool SetDefaultPrinter(String Name); //调用win api将指定名称的打印机设置为默认打印机  
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        BindingList<UserInfo> infos;
        private void LoadData()
        {
            UserInfoService infoService = new UserInfoService();
            List<UserInfo> userInfos = infoService.GetAllUserinfo(1);
            //IBindingList 
            infos = new BindingList<UserInfo>(userInfos);
            dgv.DataSource = infos;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo { delflag = false, Uaccount = "003",
                Uname = "sys" , UPost = "post", Upwd = "pwd", Utel ="333"};
            infos.Add(user);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //infos.RemoveAt(infos.Count - 1);
            infos[0].Uname = "aaa";
            dgv.Refresh();
        }
    }
}
