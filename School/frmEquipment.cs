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
    public partial class frmEquipment : Form
    {
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CEIS400_0_0_Group_C_Project_DBDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this._CEIS400_0_0_Group_C_Project_DBDataSet.Equipment);

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
