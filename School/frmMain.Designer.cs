namespace Group_C_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnEmpReport = new System.Windows.Forms.Button();
            this.btnManagerReport = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.lblChart = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewEquip = new System.Windows.Forms.Button();
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(11, 307);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(75, 38);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(11, 156);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 41);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnEmpReport
            // 
            this.btnEmpReport.Location = new System.Drawing.Point(98, 156);
            this.btnEmpReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmpReport.Name = "btnEmpReport";
            this.btnEmpReport.Size = new System.Drawing.Size(75, 41);
            this.btnEmpReport.TabIndex = 3;
            this.btnEmpReport.Text = "Employee Report";
            this.btnEmpReport.UseVisualStyleBackColor = true;
            // 
            // btnManagerReport
            // 
            this.btnManagerReport.Location = new System.Drawing.Point(98, 214);
            this.btnManagerReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagerReport.Name = "btnManagerReport";
            this.btnManagerReport.Size = new System.Drawing.Size(75, 41);
            this.btnManagerReport.TabIndex = 4;
            this.btnManagerReport.Text = "Manager Report";
            this.btnManagerReport.UseMnemonic = false;
            this.btnManagerReport.UseVisualStyleBackColor = true;
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(98, 307);
            this.btnEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(75, 41);
            this.btnEquipment.TabIndex = 6;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Enabled = false;
            this.lblChart.Location = new System.Drawing.Point(9, 291);
            this.lblChart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(178, 13);
            this.lblChart.TabIndex = 7;
            this.lblChart.Text = "Click below to view full spreadsheet:";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(187, 307);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 38);
            this.btnLog.TabIndex = 8;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aToolStripMenuItem7,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // aToolStripMenuItem7
            // 
            this.aToolStripMenuItem7.Name = "aToolStripMenuItem7";
            this.aToolStripMenuItem7.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem5.Text = " ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem6.Text = " ";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem7.Text = " ";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem8.Text = " ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.exitToolStripMenuItem.Text = "                Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnNewEquip
            // 
            this.btnNewEquip.Location = new System.Drawing.Point(201, 214);
            this.btnNewEquip.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewEquip.Name = "btnNewEquip";
            this.btnNewEquip.Size = new System.Drawing.Size(75, 41);
            this.btnNewEquip.TabIndex = 9;
            this.btnNewEquip.Text = "New Equipment";
            this.btnNewEquip.UseMnemonic = false;
            this.btnNewEquip.UseVisualStyleBackColor = true;
            this.btnNewEquip.Click += new System.EventHandler(this.btnNewEquip_Click);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(201, 156);
            this.btnNewEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(75, 41);
            this.btnNewEmp.TabIndex = 8;
            this.btnNewEmp.Text = "New Employee";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 368);
            this.Controls.Add(this.btnNewEquip);
            this.Controls.Add(this.btnNewEmp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.btnEquipment);
            this.Controls.Add(this.btnManagerReport);
            this.Controls.Add(this.btnEmpReport);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Equipment Application - Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnEmpReport;
        private System.Windows.Forms.Button btnManagerReport;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnNewEquip;
        private System.Windows.Forms.Button btnNewEmp;
    }
}