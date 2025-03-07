namespace GrifindoToysPayrollSystem
{
    partial class MonthlyReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.empSalaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.payRollSystemDataSet = new GrifindoToysPayrollSystem.PayRollSystemDataSet();
            this.empSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empSalaryTableAdapter = new GrifindoToysPayrollSystem.PayRollSystemDataSetTableAdapters.EmpSalaryTableAdapter();
            this.panelheader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.PanelBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.empSalaryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSalaryBindingSource)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.PanelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // empSalaryBindingSource1
            // 
            this.empSalaryBindingSource1.DataMember = "EmpSalary";
            this.empSalaryBindingSource1.DataSource = this.payRollSystemDataSet;
            // 
            // payRollSystemDataSet
            // 
            this.payRollSystemDataSet.DataSetName = "PayRollSystemDataSet";
            this.payRollSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empSalaryBindingSource
            // 
            this.empSalaryBindingSource.DataMember = "EmpSalary";
            this.empSalaryBindingSource.DataSource = this.payRollSystemDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 70;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.empSalaryBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GrifindoToysPayrollSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(628, 465);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // empSalaryTableAdapter
            // 
            this.empSalaryTableAdapter.ClearBeforeFill = true;
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
            this.panelheader.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(212, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(175, 16);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Monthly Salary Report";
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
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.reportViewer1);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 35);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(628, 465);
            this.PanelBody.TabIndex = 2;
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 500);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MothlyReport";
            this.Load += new System.EventHandler(this.MothlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empSalaryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSalaryBindingSource)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.PanelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PayRollSystemDataSet payRollSystemDataSet;
        private System.Windows.Forms.BindingSource empSalaryBindingSource;
        private PayRollSystemDataSetTableAdapters.EmpSalaryTableAdapter empSalaryTableAdapter;
        private System.Windows.Forms.BindingSource empSalaryBindingSource1;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picbClose;
        private System.Windows.Forms.Panel PanelBody;
    }
}