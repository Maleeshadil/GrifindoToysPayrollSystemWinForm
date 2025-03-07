namespace GrifindoToysPayrollSystem
{
    partial class frmSalary
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSave = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.btnClose = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbSalaryDetails = new System.Windows.Forms.GroupBox();
            this.lbIsValidNo2 = new System.Windows.Forms.Label();
            this.lbIsValidNo1 = new System.Windows.Forms.Label();
            this.lbIsValidEdate = new System.Windows.Forms.Label();
            this.lbIsValidSdate = new System.Windows.Forms.Label();
            this.tbOverTimeH = new System.Windows.Forms.TextBox();
            this.tbAbsent = new System.Windows.Forms.TextBox();
            this.tbSalaryEdate = new System.Windows.Forms.TextBox();
            this.tbSalarySdate = new System.Windows.Forms.TextBox();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.lbOverTime = new System.Windows.Forms.Label();
            this.lbAbsentNo = new System.Windows.Forms.Label();
            this.lbSSEdate = new System.Windows.Forms.Label();
            this.lbSSdate = new System.Windows.Forms.Label();
            this.lbEmpId = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbSalaryDetails.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(115)))));
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.pnlMain);
            this.pnlFooter.Location = new System.Drawing.Point(0, 0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 480);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 3;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(643, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 33);
            this.btnSave.TabIndex = 307;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderSize = 3;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(719, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 305;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(243)))), ((int)(((byte)(193)))));
            this.pnlMain.Controls.Add(this.gbSalaryDetails);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 440);
            this.pnlMain.TabIndex = 0;
            // 
            // gbSalaryDetails
            // 
            this.gbSalaryDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.gbSalaryDetails.Controls.Add(this.lbIsValidNo2);
            this.gbSalaryDetails.Controls.Add(this.lbIsValidNo1);
            this.gbSalaryDetails.Controls.Add(this.lbIsValidEdate);
            this.gbSalaryDetails.Controls.Add(this.lbIsValidSdate);
            this.gbSalaryDetails.Controls.Add(this.tbOverTimeH);
            this.gbSalaryDetails.Controls.Add(this.tbAbsent);
            this.gbSalaryDetails.Controls.Add(this.tbSalaryEdate);
            this.gbSalaryDetails.Controls.Add(this.tbSalarySdate);
            this.gbSalaryDetails.Controls.Add(this.tbEmployeeID);
            this.gbSalaryDetails.Controls.Add(this.lbOverTime);
            this.gbSalaryDetails.Controls.Add(this.lbAbsentNo);
            this.gbSalaryDetails.Controls.Add(this.lbSSEdate);
            this.gbSalaryDetails.Controls.Add(this.lbSSdate);
            this.gbSalaryDetails.Controls.Add(this.lbEmpId);
            this.gbSalaryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSalaryDetails.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalaryDetails.ForeColor = System.Drawing.Color.Black;
            this.gbSalaryDetails.Location = new System.Drawing.Point(33, 59);
            this.gbSalaryDetails.Name = "gbSalaryDetails";
            this.gbSalaryDetails.Padding = new System.Windows.Forms.Padding(10);
            this.gbSalaryDetails.Size = new System.Drawing.Size(733, 345);
            this.gbSalaryDetails.TabIndex = 343;
            this.gbSalaryDetails.TabStop = false;
            this.gbSalaryDetails.Text = "Employee Salary";
            // 
            // lbIsValidNo2
            // 
            this.lbIsValidNo2.AutoSize = true;
            this.lbIsValidNo2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidNo2.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidNo2.Location = new System.Drawing.Point(349, 322);
            this.lbIsValidNo2.Name = "lbIsValidNo2";
            this.lbIsValidNo2.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidNo2.TabIndex = 374;
            this.lbIsValidNo2.Text = "Error";
            this.lbIsValidNo2.Visible = false;
            // 
            // lbIsValidNo1
            // 
            this.lbIsValidNo1.AutoSize = true;
            this.lbIsValidNo1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidNo1.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidNo1.Location = new System.Drawing.Point(349, 265);
            this.lbIsValidNo1.Name = "lbIsValidNo1";
            this.lbIsValidNo1.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidNo1.TabIndex = 374;
            this.lbIsValidNo1.Text = "Error";
            this.lbIsValidNo1.Visible = false;
            // 
            // lbIsValidEdate
            // 
            this.lbIsValidEdate.AutoSize = true;
            this.lbIsValidEdate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidEdate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidEdate.Location = new System.Drawing.Point(349, 203);
            this.lbIsValidEdate.Name = "lbIsValidEdate";
            this.lbIsValidEdate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidEdate.TabIndex = 374;
            this.lbIsValidEdate.Text = "Error";
            this.lbIsValidEdate.Visible = false;
            // 
            // lbIsValidSdate
            // 
            this.lbIsValidSdate.AutoSize = true;
            this.lbIsValidSdate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidSdate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidSdate.Location = new System.Drawing.Point(349, 140);
            this.lbIsValidSdate.Name = "lbIsValidSdate";
            this.lbIsValidSdate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidSdate.TabIndex = 374;
            this.lbIsValidSdate.Text = "Error";
            this.lbIsValidSdate.Visible = false;
            // 
            // tbOverTimeH
            // 
            this.tbOverTimeH.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOverTimeH.Location = new System.Drawing.Point(352, 296);
            this.tbOverTimeH.Multiline = true;
            this.tbOverTimeH.Name = "tbOverTimeH";
            this.tbOverTimeH.Size = new System.Drawing.Size(200, 23);
            this.tbOverTimeH.TabIndex = 5;
            this.tbOverTimeH.TextChanged += new System.EventHandler(this.tbOverTimeH_TextChanged);
            this.tbOverTimeH.Validating += new System.ComponentModel.CancelEventHandler(this.tbOverTimeH_Validating);
            // 
            // tbAbsent
            // 
            this.tbAbsent.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAbsent.Location = new System.Drawing.Point(352, 239);
            this.tbAbsent.Multiline = true;
            this.tbAbsent.Name = "tbAbsent";
            this.tbAbsent.Size = new System.Drawing.Size(200, 23);
            this.tbAbsent.TabIndex = 4;
            this.tbAbsent.TextChanged += new System.EventHandler(this.tbAbsent_TextChanged);
            this.tbAbsent.Validating += new System.ComponentModel.CancelEventHandler(this.tbAbsent_Validating);
            // 
            // tbSalaryEdate
            // 
            this.tbSalaryEdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalaryEdate.Location = new System.Drawing.Point(352, 177);
            this.tbSalaryEdate.Multiline = true;
            this.tbSalaryEdate.Name = "tbSalaryEdate";
            this.tbSalaryEdate.Size = new System.Drawing.Size(200, 23);
            this.tbSalaryEdate.TabIndex = 3;
            this.tbSalaryEdate.TextChanged += new System.EventHandler(this.tbSalaryEdate_TextChanged);
            this.tbSalaryEdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalaryEdate_Validating);
            // 
            // tbSalarySdate
            // 
            this.tbSalarySdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarySdate.Location = new System.Drawing.Point(352, 114);
            this.tbSalarySdate.Multiline = true;
            this.tbSalarySdate.Name = "tbSalarySdate";
            this.tbSalarySdate.Size = new System.Drawing.Size(200, 23);
            this.tbSalarySdate.TabIndex = 2;
            this.tbSalarySdate.TextChanged += new System.EventHandler(this.tbSalarySdate_TextChanged);
            this.tbSalarySdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalarySdate_Validating);
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeID.Location = new System.Drawing.Point(352, 55);
            this.tbEmployeeID.Multiline = true;
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.Size = new System.Drawing.Size(200, 23);
            this.tbEmployeeID.TabIndex = 1;
            // 
            // lbOverTime
            // 
            this.lbOverTime.AutoSize = true;
            this.lbOverTime.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverTime.ForeColor = System.Drawing.Color.Black;
            this.lbOverTime.Location = new System.Drawing.Point(19, 303);
            this.lbOverTime.Name = "lbOverTime";
            this.lbOverTime.Size = new System.Drawing.Size(200, 18);
            this.lbOverTime.TabIndex = 375;
            this.lbOverTime.Text = "Number of Overtime Hours";
            // 
            // lbAbsentNo
            // 
            this.lbAbsentNo.AutoSize = true;
            this.lbAbsentNo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbsentNo.ForeColor = System.Drawing.Color.Black;
            this.lbAbsentNo.Location = new System.Drawing.Point(19, 246);
            this.lbAbsentNo.Name = "lbAbsentNo";
            this.lbAbsentNo.Size = new System.Drawing.Size(176, 18);
            this.lbAbsentNo.TabIndex = 375;
            this.lbAbsentNo.Text = "Number of Absent Days";
            // 
            // lbSSEdate
            // 
            this.lbSSEdate.AutoSize = true;
            this.lbSSEdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSEdate.ForeColor = System.Drawing.Color.Black;
            this.lbSSEdate.Location = new System.Drawing.Point(19, 184);
            this.lbSSEdate.Name = "lbSSEdate";
            this.lbSSEdate.Size = new System.Drawing.Size(280, 18);
            this.lbSSEdate.TabIndex = 375;
            this.lbSSEdate.Text = "Salary Cycle End Date (MM-dd-yyyy)";
            // 
            // lbSSdate
            // 
            this.lbSSdate.AutoSize = true;
            this.lbSSdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSdate.ForeColor = System.Drawing.Color.Black;
            this.lbSSdate.Location = new System.Drawing.Point(13, 121);
            this.lbSSdate.Name = "lbSSdate";
            this.lbSSdate.Size = new System.Drawing.Size(304, 18);
            this.lbSSdate.TabIndex = 375;
            this.lbSSdate.Text = " Salary Cycle Start Date (MM-dd-yyyy)";
            // 
            // lbEmpId
            // 
            this.lbEmpId.AutoSize = true;
            this.lbEmpId.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpId.ForeColor = System.Drawing.Color.Black;
            this.lbEmpId.Location = new System.Drawing.Point(19, 62);
            this.lbEmpId.Name = "lbEmpId";
            this.lbEmpId.Size = new System.Drawing.Size(96, 18);
            this.lbEmpId.TabIndex = 375;
            this.lbEmpId.Text = "Employee ID";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.pnlHeader.Controls.Add(this.picbClose);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 28);
            this.pnlHeader.TabIndex = 342;
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
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lbHeader.Location = new System.Drawing.Point(331, 4);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(156, 21);
            this.lbHeader.TabIndex = 175;
            this.lbHeader.Text = "Employee Salary";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.gbSalaryDetails.ResumeLayout(false);
            this.gbSalaryDetails.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbSalaryDetails;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picbClose;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbIsValidNo1;
        private System.Windows.Forms.Label lbIsValidEdate;
        private System.Windows.Forms.Label lbIsValidSdate;
        private System.Windows.Forms.Label lbAbsentNo;
        private System.Windows.Forms.Label lbSSEdate;
        private System.Windows.Forms.Label lbSSdate;
        private System.Windows.Forms.Label lbEmpId;
        private System.Windows.Forms.Label lbIsValidNo2;
        private System.Windows.Forms.Label lbOverTime;
        private System.Windows.Forms.TextBox tbAbsent;
        private System.Windows.Forms.TextBox tbSalaryEdate;
        private System.Windows.Forms.TextBox tbSalarySdate;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.TextBox tbOverTimeH;
        private Resources.RoundedButton btnClose;
        private Resources.RoundedButton btnSave;
    }
}