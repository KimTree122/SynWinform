
using CS.Models.BaseInfo;
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
        public delegate void Reload();

        private Reload reload;
        private bool Add;
        private Di

        private CSDicTionary cSDic;

        public FrmDictDialog()
        {
            InitializeComponent();
        }

        public FrmDictDialog(bool add, Reload reLoad, CSDicTionary cS)
        {
            Add = add;
            reload = reLoad;
            cSDic = cS;
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
                txb_key.Text = cSDic.DicKeys;
                txb_meno.Text = cSDic.DicMeno;
                txb_order.Text = cSDic.DicOrder.ToString();
                txb_type.Text = cSDic.DicType;
                txb_value.Text = cSDic.DicVlaue;
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

        }

        private void AddDic()
        {
            CSDicTionary cSDicTionary = new CSDicTionary { DicKeys = txb_key.Text, DicMeno = txb_meno.Text, DicOrder = float.Parse(txb_order.Text), DicType = txb_type.Text, DicVlaue = txb_value.Text };




        }
    }
}
