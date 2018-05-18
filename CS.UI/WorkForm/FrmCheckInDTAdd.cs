using CS.Models.BaseInfo;
using CS.Models.Work;
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

namespace CS.UI.WorkForm
{
    public partial class FrmCheckInDTAdd : MetroForm
    {
        public FrmCheckInDTAdd()
        {
            InitializeComponent();
        }
        private List<Sysdic> cmbdatasource;
        private int checkinid;

        public delegate int AddCheckInDT(CheckInDT dT);

        private AddCheckInDT addCheckIn;

        public FrmCheckInDTAdd(int checkid, List<Sysdic> sysdics,AddCheckInDT add)
        {
            InitializeComponent();
            checkinid = checkid;
            cmbdatasource = sysdics;
            addCheckIn = add;
        }

        private void FrmCheckInDTAdd_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            SysdicSer.ComboBoxBindbyData(Cmb_stauts, cmbdatasource);
        }

        private void Btn_enter_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            CheckInDT dT = new CheckInDT {
                Rating = ratingStar.Rating,
                CheckData = DateTime.Now.ToShortDateString(),
                CheckInID = checkinid,
                delflag = false,
                GoodsStauts = (int)Cmb_stauts.SelectedValue,
                Meno = rtxb_memo.Text.Trim(),
                ServerPay = (int) nud_cost.Value
            };
            int id = addCheckIn(dT);
            if (id > 0) this.Close();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
