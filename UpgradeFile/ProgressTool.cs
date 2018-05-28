using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpgradeFile
{
    public class ProgressTool
    {
        public void KillProcess(string processname)
        {
            Process[] allProcess = Process.GetProcesses();
            foreach (Process p in allProcess)
            {
                if (p.ProcessName.ToLower() + ".exe" == processname.ToLower())
                {
                    for (int i = 0; i < p.Threads.Count; i++)
                        p.Threads[i].Dispose();
                    p.Kill();

                    break;
                }
            }

        }
        ///  
        /// 运行应用程序目录下的进程  
        ///  
        /// 进程名称  
        public void RunProcess(string processname)
        {
            Process[] allProcess = Process.GetProcesses();
            bool isRun = false;
            foreach (Process p in allProcess)
            {
                if (p.ProcessName.ToLower() + ".exe" == processname.ToLower())
                {
                    isRun = true;
                    break;
                }
            }
            if (isRun == false)
            {
                if (File.Exists(Application.StartupPath + "\\" + processname))
                    Process.Start(Application.StartupPath + "\\" + processname);
            }
        }
    }
}
