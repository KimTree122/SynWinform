using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpgradeFile
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private FileLoadPresent fileLoadPresent = new FileLoadPresent();

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_upgrade_Click(object sender, EventArgs e)
        {
            List<string> filelist = new List<string>();
            List<string> verdis = new List<string>();
            bool upgrade = fileLoadPresent.CompareVer(2,ref filelist, ref verdis);

        }
    }
}
