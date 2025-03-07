namespace GrifindoToysPayrollSystem
{
    partial class EmployeeLists
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
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.btnEdit = new GrifindoToysPayrollSystem.Resources.RoundedButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.picbClose = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(243)))), ((int)(((byte)(193)))));
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.FullName});
            this.EmployeeListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeListView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListView.ForeColor = System.Drawing.Color.Black;
            this.EmployeeListView.FullRowSelect = true;
            this.EmployeeListView.GridLines = true;
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(0, 28);
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.OwnerDraw = true;
            this.EmployeeListView.Scrollable = false;
            this.EmployeeListView.Size = new System.Drawing.Size(400, 360);
            this.EmployeeListView.TabIndex = 1;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            this.EmployeeListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.EmployeeListView_DrawColumnHeader);
            this.EmployeeListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.EmployeeListView_DrawItem);
            this.EmployeeListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.EmployeeListView_DrawSubItem);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "Employee ID";
            this.EmployeeID.Width = 200;
            // 
            // FullName
            // 
            this.FullName.Text = "Full Name";
            this.FullName.Width = 200;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(115)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnEdit);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 387);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(400, 43);
            this.pnlFooter.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(322, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 301;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderSize = 3;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(242, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 33);
            this.btnEdit.TabIndex = 300;
            this.btnEdit.Text = "Select";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lbHeader.Location = new System.Drawing.Point(77, 4);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(211, 21);
            this.lbHeader.TabIndex = 176;
            this.lbHeader.Text = "Current Employee List";
            // 
            // picbClose
            // 
            this.picbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClose.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_close_;
            this.picbClose.Location = new System.Drawing.Point(372, 2);
            this.picbClose.Name = "picbClose";
            this.picbClose.Size = new System.Drawing.Size(26, 26);
            this.picbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbClose.TabIndex = 177;
            this.picbClose.TabStop = false;
            this.picbClose.Click += new System.EventHandler(this.picbClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlHeader.Controls.Add(this.picbClose);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 28);
            this.pnlHeader.TabIndex = 0;
            // 
            // EmployeeLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.EmployeeListView);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listBox";
            this.Load += new System.EventHandler(this.EmployeeLists_Load);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView EmployeeListView;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.PictureBox picbClose;
        private System.Windows.Forms.Panel pnlHeader;
        private Resources.RoundedButton btnEdit;
        private Resources.RoundedButton btnClose;
    }
}