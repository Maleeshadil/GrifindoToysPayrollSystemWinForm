namespace GrifindoToysPayrollSystem
{
    partial class SetSalaryCycle
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
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.lbIsValidEDate = new System.Windows.Forms.Label();
            this.lbIsValidSDate = new System.Windows.Forms.Label();
            this.tbEDate = new System.Windows.Forms.TextBox();
            this.tbSDate = new System.Windows.Forms.TextBox();
            this.BtnOk = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.lbEDate = new System.Windows.Forms.Label();
            this.lbSDate = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.PanelContainer.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelContainer.Controls.Add(this.lbIsValidEDate);
            this.PanelContainer.Controls.Add(this.lbIsValidSDate);
            this.PanelContainer.Controls.Add(this.tbEDate);
            this.PanelContainer.Controls.Add(this.tbSDate);
            this.PanelContainer.Controls.Add(this.BtnOk);
            this.PanelContainer.Controls.Add(this.lbEDate);
            this.PanelContainer.Controls.Add(this.lbSDate);
            this.PanelContainer.Controls.Add(this.PanelTitleBar);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(417, 271);
            this.PanelContainer.TabIndex = 0;
            this.PanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContainer_Paint);
            // 
            // lbIsValidEDate
            // 
            this.lbIsValidEDate.AutoSize = true;
            this.lbIsValidEDate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidEDate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidEDate.Location = new System.Drawing.Point(4, 179);
            this.lbIsValidEDate.Name = "lbIsValidEDate";
            this.lbIsValidEDate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidEDate.TabIndex = 369;
            this.lbIsValidEDate.Text = "Error";
            this.lbIsValidEDate.Visible = false;
            // 
            // lbIsValidSDate
            // 
            this.lbIsValidSDate.AutoSize = true;
            this.lbIsValidSDate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidSDate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidSDate.Location = new System.Drawing.Point(4, 125);
            this.lbIsValidSDate.Name = "lbIsValidSDate";
            this.lbIsValidSDate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidSDate.TabIndex = 368;
            this.lbIsValidSDate.Text = "Error";
            this.lbIsValidSDate.Visible = false;
            // 
            // tbEDate
            // 
            this.tbEDate.Location = new System.Drawing.Point(210, 144);
            this.tbEDate.Name = "tbEDate";
            this.tbEDate.Size = new System.Drawing.Size(195, 25);
            this.tbEDate.TabIndex = 5;
            this.tbEDate.TextChanged += new System.EventHandler(this.tbEDate_TextChanged);
            this.tbEDate.Validating += new System.ComponentModel.CancelEventHandler(this.tbEDate_Validating);
            // 
            // tbSDate
            // 
            this.tbSDate.Location = new System.Drawing.Point(210, 90);
            this.tbSDate.Name = "tbSDate";
            this.tbSDate.Size = new System.Drawing.Size(195, 25);
            this.tbSDate.TabIndex = 4;
            this.tbSDate.TextChanged += new System.EventHandler(this.tbSDate_TextChanged);
            this.tbSDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDate_Validating);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnOk.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnOk.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnOk.BorderRadius = 5;
            this.BtnOk.BorderSize = 2;
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.Color.Black;
            this.BtnOk.Location = new System.Drawing.Point(140, 203);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(150, 40);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "OK";
            this.BtnOk.TextColor = System.Drawing.Color.Black;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lbEDate
            // 
            this.lbEDate.AutoSize = true;
            this.lbEDate.Location = new System.Drawing.Point(4, 151);
            this.lbEDate.Name = "lbEDate";
            this.lbEDate.Size = new System.Drawing.Size(184, 18);
            this.lbEDate.TabIndex = 2;
            this.lbEDate.Text = "Salary Cycle End Date:";
            // 
            // lbSDate
            // 
            this.lbSDate.AutoSize = true;
            this.lbSDate.Location = new System.Drawing.Point(4, 97);
            this.lbSDate.Name = "lbSDate";
            this.lbSDate.Size = new System.Drawing.Size(200, 18);
            this.lbSDate.TabIndex = 2;
            this.lbSDate.Text = "Salary Cycle Start Date:";
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.HotPink;
            this.PanelTitleBar.Controls.Add(this.btnClose);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(417, 50);
            this.PanelTitleBar.TabIndex = 0;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons8_close_24;
            this.btnClose.Location = new System.Drawing.Point(381, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SetSalaryCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 271);
            this.Controls.Add(this.PanelContainer);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetSalaryCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Salary Cycle Date ";
            this.Activated += new System.EventHandler(this.GetSalaryReport_Activated);
            this.Load += new System.EventHandler(this.SetSalaryCycle_Load);
            this.ResizeEnd += new System.EventHandler(this.GetSalaryReport_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.GetSalaryReport_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GetSalaryReport_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lbSDate;
        private Resources.RoundedButton BtnOk;
        private System.Windows.Forms.Label lbEDate;
        private System.Windows.Forms.TextBox tbEDate;
        private System.Windows.Forms.TextBox tbSDate;
        private System.Windows.Forms.Label lbIsValidEDate;
        private System.Windows.Forms.Label lbIsValidSDate;
    }
}