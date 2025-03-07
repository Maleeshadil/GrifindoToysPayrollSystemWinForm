namespace GrifindoToysPayrollSystem
{
    partial class AllEmployeeSalarySummary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.btnViewReport = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbSalaryReport = new System.Windows.Forms.GroupBox();
            this.lvAllEmpSalarySum = new System.Windows.Forms.ListView();
            this.lbIsValidEdate = new System.Windows.Forms.Label();
            this.lbIsValidSdate = new System.Windows.Forms.Label();
            this.tbSalaryEdate = new System.Windows.Forms.TextBox();
            this.tbSalarySdate = new System.Windows.Forms.TextBox();
            this.lbSSEdate = new System.Windows.Forms.Label();
            this.lbSSdate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbSalaryReport.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnViewReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 480);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderSize = 3;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(712, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 315;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.btnViewReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.btnViewReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnViewReport.BorderRadius = 5;
            this.btnViewReport.BorderSize = 3;
            this.btnViewReport.FlatAppearance.BorderSize = 0;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btnViewReport.ForeColor = System.Drawing.Color.Black;
            this.btnViewReport.Location = new System.Drawing.Point(576, 444);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(130, 33);
            this.btnViewReport.TabIndex = 314;
            this.btnViewReport.Text = "Vew Report";
            this.btnViewReport.TextColor = System.Drawing.Color.Black;
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(243)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.gbSalaryReport);
            this.panel2.Controls.Add(this.lbIsValidEdate);
            this.panel2.Controls.Add(this.lbIsValidSdate);
            this.panel2.Controls.Add(this.tbSalaryEdate);
            this.panel2.Controls.Add(this.tbSalarySdate);
            this.panel2.Controls.Add(this.lbSSEdate);
            this.panel2.Controls.Add(this.lbSSdate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 440);
            this.panel2.TabIndex = 0;
            // 
            // gbSalaryReport
            // 
            this.gbSalaryReport.Controls.Add(this.lvAllEmpSalarySum);
            this.gbSalaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSalaryReport.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalaryReport.ForeColor = System.Drawing.Color.Black;
            this.gbSalaryReport.Location = new System.Drawing.Point(0, 192);
            this.gbSalaryReport.Name = "gbSalaryReport";
            this.gbSalaryReport.Size = new System.Drawing.Size(800, 228);
            this.gbSalaryReport.TabIndex = 382;
            this.gbSalaryReport.TabStop = false;
            this.gbSalaryReport.Text = "All Employe Salary Report";
            // 
            // lvAllEmpSalarySum
            // 
            this.lvAllEmpSalarySum.ForeColor = System.Drawing.Color.Black;
            this.lvAllEmpSalarySum.HideSelection = false;
            this.lvAllEmpSalarySum.Location = new System.Drawing.Point(0, 25);
            this.lvAllEmpSalarySum.Name = "lvAllEmpSalarySum";
            this.lvAllEmpSalarySum.Size = new System.Drawing.Size(800, 197);
            this.lvAllEmpSalarySum.TabIndex = 0;
            this.lvAllEmpSalarySum.UseCompatibleStateImageBehavior = false;
            this.lvAllEmpSalarySum.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvAllEmpSalarySum_DrawColumnHeader);
            this.lvAllEmpSalarySum.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvAllEmpSalarySum_DrawItem);
            this.lvAllEmpSalarySum.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvAllEmpSalarySum_DrawSubItem);
            // 
            // lbIsValidEdate
            // 
            this.lbIsValidEdate.AutoSize = true;
            this.lbIsValidEdate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidEdate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidEdate.Location = new System.Drawing.Point(348, 152);
            this.lbIsValidEdate.Name = "lbIsValidEdate";
            this.lbIsValidEdate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidEdate.TabIndex = 378;
            this.lbIsValidEdate.Text = "Error";
            this.lbIsValidEdate.Visible = false;
            // 
            // lbIsValidSdate
            // 
            this.lbIsValidSdate.AutoSize = true;
            this.lbIsValidSdate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidSdate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidSdate.Location = new System.Drawing.Point(348, 89);
            this.lbIsValidSdate.Name = "lbIsValidSdate";
            this.lbIsValidSdate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidSdate.TabIndex = 379;
            this.lbIsValidSdate.Text = "Error";
            this.lbIsValidSdate.Visible = false;
            // 
            // tbSalaryEdate
            // 
            this.tbSalaryEdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalaryEdate.Location = new System.Drawing.Point(351, 126);
            this.tbSalaryEdate.Multiline = true;
            this.tbSalaryEdate.Name = "tbSalaryEdate";
            this.tbSalaryEdate.Size = new System.Drawing.Size(200, 23);
            this.tbSalaryEdate.TabIndex = 2;
            this.tbSalaryEdate.TextChanged += new System.EventHandler(this.tbSalaryEdate_TextChanged);
            this.tbSalaryEdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalaryEdate_Validating);
            // 
            // tbSalarySdate
            // 
            this.tbSalarySdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarySdate.Location = new System.Drawing.Point(351, 63);
            this.tbSalarySdate.Multiline = true;
            this.tbSalarySdate.Name = "tbSalarySdate";
            this.tbSalarySdate.Size = new System.Drawing.Size(200, 23);
            this.tbSalarySdate.TabIndex = 1;
            this.tbSalarySdate.TextChanged += new System.EventHandler(this.tbSalarySdate_TextChanged);
            this.tbSalarySdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalarySdate_Validating);
            // 
            // lbSSEdate
            // 
            this.lbSSEdate.AutoSize = true;
            this.lbSSEdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSEdate.ForeColor = System.Drawing.Color.Black;
            this.lbSSEdate.Location = new System.Drawing.Point(18, 133);
            this.lbSSEdate.Name = "lbSSEdate";
            this.lbSSEdate.Size = new System.Drawing.Size(280, 18);
            this.lbSSEdate.TabIndex = 380;
            this.lbSSEdate.Text = "Salary Cycle End Date (MM-dd-yyyy)";
            // 
            // lbSSdate
            // 
            this.lbSSdate.AutoSize = true;
            this.lbSSdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSdate.ForeColor = System.Drawing.Color.Black;
            this.lbSSdate.Location = new System.Drawing.Point(10, 70);
            this.lbSSdate.Name = "lbSSdate";
            this.lbSSdate.Size = new System.Drawing.Size(304, 18);
            this.lbSSdate.TabIndex = 381;
            this.lbSSdate.Text = " Salary Cycle Start Date (MM-dd-yyyy)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.panel3.Controls.Add(this.picbClose);
            this.panel3.Controls.Add(this.lbHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 28);
            this.panel3.TabIndex = 343;
            // 
            // picbClose
            // 
            this.picbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClose.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_close_;
            this.picbClose.Location = new System.Drawing.Point(767, 1);
            this.picbClose.Name = "picbClose";
            this.picbClose.Size = new System.Drawing.Size(26, 26);
            this.picbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbClose.TabIndex = 176;
            this.picbClose.TabStop = false;
            this.picbClose.Click += new System.EventHandler(this.picbClose_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Black;
            this.lbHeader.Location = new System.Drawing.Point(255, 4);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(274, 21);
            this.lbHeader.TabIndex = 175;
            this.lbHeader.Text = "All Employee Salary Summary";
            // 
            // AllEmployeeSalarySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllEmployeeSalarySummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllEmployeeSalarySummary";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSalaryReport.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picbClose;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbIsValidEdate;
        private System.Windows.Forms.Label lbIsValidSdate;
        public System.Windows.Forms.TextBox tbSalaryEdate;
        public System.Windows.Forms.TextBox tbSalarySdate;
        private System.Windows.Forms.Label lbSSEdate;
        private System.Windows.Forms.Label lbSSdate;
        private System.Windows.Forms.GroupBox gbSalaryReport;
        private System.Windows.Forms.ListView lvAllEmpSalarySum;
        private Resources.RoundedButton btnClose;
        private Resources.RoundedButton btnViewReport;
    }
}