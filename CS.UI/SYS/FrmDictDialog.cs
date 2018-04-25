
using CS.BLL.BaseInfo;
using CS.Models;
using CS.Models.BaseInfo;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.SYS
{
    public partial class FrmDictDialog : MetroForm
    {
        public delegate void Reload(Sysdic cs );

        private Reload reload;
        private bool Add;
        private BaseInfoService baseInfoService = new BaseInfoService();


        private Sysdic cSDic;

        public FrmDictDialog()
        {
            InitializeComponent();
        }

        public FrmDictDialog(Reload reLoad , Sysdic cS)
        {
            Add = false;
            reload = reLoad;
            cSDic = cS;
            InitializeComponent();
        }

        public FrmDictDialog(Reload reLoad)
        {
            Add = true;
            reload = reLoad;
            InitializeComponent();
        }


        private void FrmDictDialog_Load(object sender, EventArgs e)
        {
            if (Add)
            {
                this.Text = "新增";
            }
            else
            {
                this.Text = "编辑";
                txb_key.Text = cSDic.Dickey;
                txb_meno.Text = cSDic.DicMeno;
                txb_order.Text = cSDic.Dicsetp.ToString();
                txb_type.Text = cSDic.Dicname;
                txb_value.Text = cSDic.Dicval;
                txb_type.Tag = cSDic.id;
            }
        }

        private void SaveData()
        {
            if (Add)
            {
                AddDic();
            }
            else
            {
                UpdateDic();
            }
        }

        private void UpdateDic()
        {
            bool update = baseInfoService.UpdateDictionary(GetCsdic());
            string msg = update ? "成功" : "失败";
            MetroMessageBox.Show(this,"更新"+ msg ,"提示");
            if (update)
            {
                reload(GetCsdic());
                this.Close();
            }
        }

        private void AddDic()
        {
            int dicid = baseInfoService.AddDictionary(GetCsdic());
            string msg = dicid != 0 ? "成功" : "失败";
            MetroMessageBox.Show(this,"新增"+msg,"提示");
            if (dicid != 0)
            {
                txb_type.Tag = dicid;
                reload(GetCsdic());
                this.Close();
            }
            
        }

        private Sysdic GetCsdic()
        {
            Sysdic cSDicTionary = new Sysdic {  Dickey = txb_key.Text, DicMeno = txb_meno.Text, Dicsetp = int.Parse(txb_order.Text),  Dicname = txb_type.Text,  Dicval = txb_value.Text , id  = Add ? 0 : (int)txb_type.Tag };
            return cSDicTionary;
        }

        private void mtile_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
