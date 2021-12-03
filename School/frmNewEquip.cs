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
    public partial class frmNewEquip : Form
    {
        public frmNewEquip()
        {
            InitializeComponent();
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

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string stEquipNum = txtEquipNum.Text;
            string stName = txtName.Text;
            string stDescription = txtDescription.Text;
            string stCondition = cmbCondition.Text;

            decimal decPrice = Convert.ToDecimal(txtPrice.Text);
            int x = 0;
            int y = 0;
            
            if (Int32.TryParse(cmbSkill.Text, out x))
            {
                if (Int32.TryParse(txtEquipNum.Text, out y))
                {
                    _CEIS400_0_0_Group_C_Project_DBDataSetTableAdapters.EquipmentTableAdapter EquipmentTableAdapter =
                 new _CEIS400_0_0_Group_C_Project_DBDataSetTableAdapters.EquipmentTableAdapter();
                    EquipmentTableAdapter.Insert(y, stName, stDescription, stCondition, decPrice,x);

                    MessageBox.Show("Entry Accepted");
                }
            }

            txtEquipNum.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            cmbCondition.Text = "";
            txtPrice.Text = "";
            cmbSkill.Text = "";
        }
    }
}
