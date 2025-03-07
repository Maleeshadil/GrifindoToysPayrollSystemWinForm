namespace GrifindoToysPayrollSystem
{
    partial class Setting
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
            this.btnClose = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.btnSave = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbSeeting = new System.Windows.Forms.GroupBox();
            this.lbIsValidEdate = new System.Windows.Forms.Label();
            this.lbIsValidSdate = new System.Windows.Forms.Label();
            this.tbLeavesY = new System.Windows.Forms.TextBox();
            this.tbSalaryRange = new System.Windows.Forms.TextBox();
            this.tbSalarySdate = new System.Windows.Forms.TextBox();
            this.tbSalaryEdate = new System.Windows.Forms.TextBox();
            this.lbLeavesY = new System.Windows.Forms.Label();
            this.lbSRange = new System.Windows.Forms.Label();
            this.lbSSEdate = new System.Windows.Forms.Label();
            this.lbSSdate = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbSeeting.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(115)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.pnlMain);
            this.pnlFooter.Location = new System.Drawing.Point(0, 0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 480);
            this.pnlFooter.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(720, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 307;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(640, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 33);
            this.btnSave.TabIndex = 306;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(243)))), ((int)(((byte)(193)))));
            this.pnlMain.Controls.Add(this.gbSeeting);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 440);
            this.pnlMain.TabIndex = 0;
            // 
            // gbSeeting
            // 
            this.gbSeeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.gbSeeting.Controls.Add(this.lbIsValidEdate);
            this.gbSeeting.Controls.Add(this.lbIsValidSdate);
            this.gbSeeting.Controls.Add(this.tbLeavesY);
            this.gbSeeting.Controls.Add(this.tbSalaryRange);
            this.gbSeeting.Controls.Add(this.tbSalarySdate);
            this.gbSeeting.Controls.Add(this.tbSalaryEdate);
            this.gbSeeting.Controls.Add(this.lbLeavesY);
            this.gbSeeting.Controls.Add(this.lbSRange);
            this.gbSeeting.Controls.Add(this.lbSSEdate);
            this.gbSeeting.Controls.Add(this.lbSSdate);
            this.gbSeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSeeting.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeeting.Location = new System.Drawing.Point(28, 67);
            this.gbSeeting.Name = "gbSeeting";
            this.gbSeeting.Size = new System.Drawing.Size(744, 331);
            this.gbSeeting.TabIndex = 343;
            this.gbSeeting.TabStop = false;
            this.gbSeeting.Text = "Employee Salary Setting";
            // 
            // lbIsValidEdate
            // 
            this.lbIsValidEdate.AutoSize = true;
            this.lbIsValidEdate.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.lbIsValidEdate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidEdate.Location = new System.Drawing.Point(322, 143);
            this.lbIsValidEdate.Name = "lbIsValidEdate";
            this.lbIsValidEdate.Size = new System.Drawing.Size(47, 16);
            this.lbIsValidEdate.TabIndex = 374;
            this.lbIsValidEdate.Text = "Error";
            this.lbIsValidEdate.Visible = false;
            // 
            // lbIsValidSdate
            // 
            this.lbIsValidSdate.AutoSize = true;
            this.lbIsValidSdate.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.lbIsValidSdate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidSdate.Location = new System.Drawing.Point(322, 77);
            this.lbIsValidSdate.Name = "lbIsValidSdate";
            this.lbIsValidSdate.Size = new System.Drawing.Size(47, 16);
            this.lbIsValidSdate.TabIndex = 374;
            this.lbIsValidSdate.Text = "Error";
            this.lbIsValidSdate.Visible = false;
            // 
            // tbLeavesY
            // 
            this.tbLeavesY.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeavesY.Location = new System.Drawing.Point(359, 248);
            this.tbLeavesY.Multiline = true;
            this.tbLeavesY.Name = "tbLeavesY";
            this.tbLeavesY.Size = new System.Drawing.Size(200, 23);
            this.tbLeavesY.TabIndex = 4;
            // 
            // tbSalaryRange
            // 
            this.tbSalaryRange.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalaryRange.Location = new System.Drawing.Point(359, 178);
            this.tbSalaryRange.Multiline = true;
            this.tbSalaryRange.Name = "tbSalaryRange";
            this.tbSalaryRange.Size = new System.Drawing.Size(200, 23);
            this.tbSalaryRange.TabIndex = 3;
            this.tbSalaryRange.Click += new System.EventHandler(this.tbSalaryRange_Click);
            // 
            // tbSalarySdate
            // 
            this.tbSalarySdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarySdate.Location = new System.Drawing.Point(359, 51);
            this.tbSalarySdate.Multiline = true;
            this.tbSalarySdate.Name = "tbSalarySdate";
            this.tbSalarySdate.Size = new System.Drawing.Size(200, 23);
            this.tbSalarySdate.TabIndex = 1;
            this.tbSalarySdate.TextChanged += new System.EventHandler(this.tbSalarySdate_TextChanged);
            this.tbSalarySdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalarySdate_Validating);
            // 
            // tbSalaryEdate
            // 
            this.tbSalaryEdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalaryEdate.Location = new System.Drawing.Point(359, 117);
            this.tbSalaryEdate.Multiline = true;
            this.tbSalaryEdate.Name = "tbSalaryEdate";
            this.tbSalaryEdate.Size = new System.Drawing.Size(200, 23);
            this.tbSalaryEdate.TabIndex = 2;
            this.tbSalaryEdate.TextChanged += new System.EventHandler(this.tbSalaryEdate_TextChanged);
            this.tbSalaryEdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalaryEdate_Validating);
            // 
            // lbLeavesY
            // 
            this.lbLeavesY.AutoSize = true;
            this.lbLeavesY.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeavesY.ForeColor = System.Drawing.Color.Black;
            this.lbLeavesY.Location = new System.Drawing.Point(20, 251);
            this.lbLeavesY.Name = "lbLeavesY";
            this.lbLeavesY.Size = new System.Drawing.Size(240, 18);
            this.lbLeavesY.TabIndex = 4;
            this.lbLeavesY.Text = "New Number of Leaves Per Year";
            // 
            // lbSRange
            // 
            this.lbSRange.AutoSize = true;
            this.lbSRange.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSRange.ForeColor = System.Drawing.Color.Black;
            this.lbSRange.Location = new System.Drawing.Point(12, 185);
            this.lbSRange.Name = "lbSRange";
            this.lbSRange.Size = new System.Drawing.Size(232, 18);
            this.lbSRange.TabIndex = 3;
            this.lbSRange.Text = " New Salary Cycle Date Range";
            // 
            // lbSSEdate
            // 
            this.lbSSEdate.AutoSize = true;
            this.lbSSEdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSEdate.ForeColor = System.Drawing.Color.Black;
            this.lbSSEdate.Location = new System.Drawing.Point(20, 124);
            this.lbSSEdate.Name = "lbSSEdate";
            this.lbSSEdate.Size = new System.Drawing.Size(296, 18);
            this.lbSSEdate.TabIndex = 2;
            this.lbSSEdate.Text = "New SalayCycle End Date (MM/dd/yyyy)\r\n";
            // 
            // lbSSdate
            // 
            this.lbSSdate.AutoSize = true;
            this.lbSSdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSdate.ForeColor = System.Drawing.Color.Black;
            this.lbSSdate.Location = new System.Drawing.Point(20, 58);
            this.lbSSdate.Name = "lbSSdate";
            this.lbSSdate.Size = new System.Drawing.Size(304, 18);
            this.lbSSdate.TabIndex = 1;
            this.lbSSdate.Text = "New SalayCyle Start Date (MM/dd/yyyy)";
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
            this.picbClose.Location = new System.Drawing.Point(772, 1);
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
            this.lbHeader.Location = new System.Drawing.Point(284, 4);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(223, 21);
            this.lbHeader.TabIndex = 175;
            this.lbHeader.Text = "Employee Salary Setting";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.gbSeeting.ResumeLayout(false);
            this.gbSeeting.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picbClose;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.GroupBox gbSeeting;
        private System.Windows.Forms.Label lbIsValidEdate;
        private System.Windows.Forms.Label lbIsValidSdate;
        private System.Windows.Forms.Label lbLeavesY;
        private System.Windows.Forms.Label lbSRange;
        private System.Windows.Forms.Label lbSSEdate;
        private System.Windows.Forms.Label lbSSdate;
        private System.Windows.Forms.TextBox tbLeavesY;
        private System.Windows.Forms.TextBox tbSalaryRange;
        private System.Windows.Forms.TextBox tbSalarySdate;
        private System.Windows.Forms.TextBox tbSalaryEdate;
        private Resources.RoundedButton btnClose;
        private Resources.RoundedButton btnSave;
    }
}