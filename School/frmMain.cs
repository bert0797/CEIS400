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
    public partial class frmMain : Form
    {
        public frmEmployee empForm = new frmEmployee();
        public frmEquipment eqpForm = new frmEquipment();
        public frmCheckOut checkOutForm = new frmCheckOut();
        public frmLog logForm = new frmLog();
        public frmNewEmployee newEmpForm = new frmNewEmployee();
        public frmNewEquip newEquipForm = new frmNewEquip();
        public frmMain()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            empForm.ShowDialog();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            empForm.ShowDialog();
            this.Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkOutForm.ShowDialog();
            this.Close();

        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            eqpForm.ShowDialog();
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            logForm.ShowDialog();
            this.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            newEmpForm.ShowDialog();
            this.Close();
        }

        private void btnNewEquip_Click(object sender, EventArgs e)
        {
            this.Hide();
            newEquipForm.ShowDialog();
            this.Close();
        }
    }
}
