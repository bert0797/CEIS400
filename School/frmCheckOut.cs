using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group_C_Project
{
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string stEmpNum = txtEmpNum.Text;
            int x = 0;
            if (Int32.TryParse(txtEquipID.Text, out x))
            {
                _CEIS400_0_0_Group_C_Project_DBDataSetTableAdapters.LogTableAdapter logTableAdapter =
                new _CEIS400_0_0_Group_C_Project_DBDataSetTableAdapters.LogTableAdapter();
                logTableAdapter.Insert(stEmpNum, x, DateTime.Today);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmM = new frmMain();
            frmM.ShowDialog(); //goto main page
            this.Close(); //Closes current form
        }
    }
}
