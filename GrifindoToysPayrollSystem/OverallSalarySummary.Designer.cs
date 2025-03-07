namespace GrifindoToysPayrollSystem
{
    partial class OverallSalarySummary
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.overallSalaryReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelheader.Controls.Add(this.lbTitle);
            this.panelheader.Controls.Add(this.picbClose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(628, 35);
            this.panelheader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(212, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(175, 16);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Overall Salary Report";
            // 
            // picbClose
            // 
            this.picbClose.BackColor = System.Drawing.Color.Transparent;
            this.picbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClose.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons8_close_24;
            this.picbClose.Location = new System.Drawing.Point(592, 3);
            this.picbClose.Name = "picbClose";
            this.picbClose.Size = new System.Drawing.Size(24, 24);
            this.picbClose.TabIndex = 0;
            this.picbClose.TabStop = false;
            this.picbClose.Click += new System.EventHandler(this.picbClose_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelBody.Controls.Add(this.overallSalaryReport);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 35);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(628, 465);
            this.panelBody.TabIndex = 1;
            // 
            // overallSalaryReport
            // 
            this.overallSalaryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallSalaryReport.LocalReport.ReportEmbeddedResource = "GrifindoToysPayrollSystem.Report1.rdlc";
            this.overallSalaryReport.Location = new System.Drawing.Point(0, 0);
            this.overallSalaryReport.Name = "overallSalaryReport";
            this.overallSalaryReport.ServerReport.BearerToken = null;
            this.overallSalaryReport.Size = new System.Drawing.Size(628, 465);
            this.overallSalaryReport.TabIndex = 0;
            this.overallSalaryReport.Load += new System.EventHandler(this.overallSalaryReport_Load);
            // 
            // OverallSalarySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 500);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverallSalarySummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverallSalarySummary";
            this.Load += new System.EventHandler(this.OverallSalarySummary_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox picbClose;
        private Microsoft.Reporting.WinForms.ReportViewer overallSalaryReport;
        private System.Windows.Forms.Label lbTitle;
    }
}