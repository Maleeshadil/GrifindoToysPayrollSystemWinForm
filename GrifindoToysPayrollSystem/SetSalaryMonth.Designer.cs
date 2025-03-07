namespace GrifindoToysPayrollSystem
{
    partial class SetSalaryMonth
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
            this.lbIsValidDate = new System.Windows.Forms.Label();
            this.btnOk = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.PanelContainer.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelContainer.Controls.Add(this.lbIsValidDate);
            this.PanelContainer.Controls.Add(this.btnOk);
            this.PanelContainer.Controls.Add(this.tbDate);
            this.PanelContainer.Controls.Add(this.lbDate);
            this.PanelContainer.Controls.Add(this.PanelTitleBar);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(417, 271);
            this.PanelContainer.TabIndex = 0;
            this.PanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContainer_Paint);
            // 
            // lbIsValidDate
            // 
            this.lbIsValidDate.AutoSize = true;
            this.lbIsValidDate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsValidDate.ForeColor = System.Drawing.Color.Red;
            this.lbIsValidDate.Location = new System.Drawing.Point(12, 152);
            this.lbIsValidDate.Name = "lbIsValidDate";
            this.lbIsValidDate.Size = new System.Drawing.Size(42, 15);
            this.lbIsValidDate.TabIndex = 369;
            this.lbIsValidDate.Text = "Error";
            this.lbIsValidDate.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnOk.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.btnOk.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnOk.BorderRadius = 5;
            this.btnOk.BorderSize = 2;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(134, 205);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 40);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.TextColor = System.Drawing.Color.Black;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbDate.Location = new System.Drawing.Point(218, 120);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(187, 25);
            this.tbDate.TabIndex = 2;
            this.tbDate.TextChanged += new System.EventHandler(this.tbDate_TextChanged);
            this.tbDate.Validating += new System.ComponentModel.CancelEventHandler(this.tbDate_Validating);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lbDate.Location = new System.Drawing.Point(12, 123);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(208, 18);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Enter the month(yyyy-MM):";
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.HotPink;
            this.PanelTitleBar.Controls.Add(this.picbClose);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(417, 50);
            this.PanelTitleBar.TabIndex = 0;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // picbClose
            // 
            this.picbClose.BackColor = System.Drawing.Color.Transparent;
            this.picbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClose.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons8_close_24;
            this.picbClose.Location = new System.Drawing.Point(381, 12);
            this.picbClose.Name = "picbClose";
            this.picbClose.Size = new System.Drawing.Size(24, 24);
            this.picbClose.TabIndex = 4;
            this.picbClose.TabStop = false;
            this.picbClose.Click += new System.EventHandler(this.picbClose_Click);
            // 
            // SetSalaryMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 271);
            this.Controls.Add(this.PanelContainer);
            this.Name = "SetSalaryMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetSalaryMonth";
            this.Activated += new System.EventHandler(this.SetSalaryMonth_Activated);
           
            this.ResizeEnd += new System.EventHandler(this.SetSalaryMonth_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.SetSalaryMonth_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SetSalaryMonth_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbDate;
        private Resources.RoundedButton btnOk;
        private System.Windows.Forms.PictureBox picbClose;
        private System.Windows.Forms.Label lbIsValidDate;
    }
}