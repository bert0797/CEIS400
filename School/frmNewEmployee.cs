using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_C_Project
{
    public partial class frmNewEmployee : Form
    {
        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            //
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmM = new frmMain();
            frmM.ShowDialog(); //goto main page
            this.Close(); //Closes current form
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {        
            string stEmpNum = txtNum.Text;
            string stFName = txtFName.Text;
            string stLName = txtLName.Text;
            int x = 0;
            if (Int32.TryParse(cmbSkill.Text, out x))
            {
                _CEIS400_0_0_Group_C_Project_DBDataSetTableAdapters.EmployeeTableAdapter EmployeeTableAdapter =
                new _CEIS400_0_0_Group_C_Project_DBDataSetTableAdapters.EmployeeTableAdapter();
                EmployeeTableAdapter.Insert(stEmpNum, stFName, stLName, x);

                MessageBox.Show("Entry Accepted");
            }

            txtNum.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            cmbSkill.Text = "";
        }
    }
}
