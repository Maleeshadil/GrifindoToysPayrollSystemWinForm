namespace GrifindoToysPayrollSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hamMenu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.EmployeeContaineer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnEmp = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.pnlViewEmployee = new System.Windows.Forms.Panel();
            this.btnViewEmployee = new System.Windows.Forms.Button();
            this.SalaryContaineer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSalary = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnCalSalary = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnMonthkySalary = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnOverallSummary = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnAllSummary = new System.Windows.Forms.Button();
            this.SettingContaineer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlUpdateSetting = new System.Windows.Forms.Panel();
            this.btnUpdateSetting = new System.Windows.Forms.Button();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnlLogOut = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.EmployeeMenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SalaryMenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SettingMenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamMenu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.EmployeeContaineer.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlViewEmployee.SuspendLayout();
            this.SalaryContaineer.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SettingContaineer.SuspendLayout();
            this.panel17.SuspendLayout();
            this.pnlUpdateSetting.SuspendLayout();
            this.pnlLogIn.SuspendLayout();
            this.pnlLogOut.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.hamMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 38);
            this.panel1.TabIndex = 0;
            // 
            // hamMenu
            // 
            this.hamMenu.BackColor = System.Drawing.Color.Transparent;
            this.hamMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamMenu.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons8_menu_32__1_1;
            this.hamMenu.Location = new System.Drawing.Point(16, 3);
            this.hamMenu.Name = "hamMenu";
            this.hamMenu.Size = new System.Drawing.Size(32, 32);
            this.hamMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hamMenu.TabIndex = 0;
            this.hamMenu.TabStop = false;
            this.hamMenu.Click += new System.EventHandler(this.hamMenu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.sidebar.Controls.Add(this.pnlMenu);
            this.sidebar.Controls.Add(this.EmployeeContaineer);
            this.sidebar.Controls.Add(this.SalaryContaineer);
            this.sidebar.Controls.Add(this.SettingContaineer);
            this.sidebar.Controls.Add(this.pnlLogIn);
            this.sidebar.Controls.Add(this.pnlLogOut);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 38);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(210, 516);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Location = new System.Drawing.Point(5, 33);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(192, 42);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.btnMenu.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_home;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-12, -21);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(227, 91);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "    Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // EmployeeContaineer
            // 
            this.EmployeeContaineer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.EmployeeContaineer.Controls.Add(this.panel10);
            this.EmployeeContaineer.Controls.Add(this.panel7);
            this.EmployeeContaineer.Controls.Add(this.panel3);
            this.EmployeeContaineer.Controls.Add(this.panel9);
            this.EmployeeContaineer.Controls.Add(this.pnlViewEmployee);
            this.EmployeeContaineer.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeContaineer.Location = new System.Drawing.Point(5, 81);
            this.EmployeeContaineer.Name = "EmployeeContaineer";
            this.EmployeeContaineer.Size = new System.Drawing.Size(192, 42);
            this.EmployeeContaineer.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnEmp);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(192, 42);
            this.panel10.TabIndex = 1;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.Enabled = false;
            this.btnEmp.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnEmp.ForeColor = System.Drawing.Color.Black;
            this.btnEmp.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_employees;
            this.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.Location = new System.Drawing.Point(-7, -21);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEmp.Size = new System.Drawing.Size(214, 91);
            this.btnEmp.TabIndex = 0;
            this.btnEmp.Text = "   Employee";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAddEmp);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 42);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 42);
            this.panel7.TabIndex = 1;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnAddEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnAddEmp.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmp.Location = new System.Drawing.Point(-12, -21);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddEmp.Size = new System.Drawing.Size(227, 91);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditEmp);
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 42);
            this.panel3.TabIndex = 1;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnEditEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmp.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnEditEmp.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmp.Location = new System.Drawing.Point(-12, -21);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditEmp.Size = new System.Drawing.Size(227, 91);
            this.btnEditEmp.TabIndex = 0;
            this.btnEditEmp.Text = "Edit Employee";
            this.btnEditEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnRemoveEmp);
            this.panel9.Location = new System.Drawing.Point(0, 126);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(192, 42);
            this.panel9.TabIndex = 1;
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnRemoveEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnRemoveEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmp.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnRemoveEmp.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEmp.Location = new System.Drawing.Point(-12, -21);
            this.btnRemoveEmp.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRemoveEmp.Size = new System.Drawing.Size(227, 91);
            this.btnRemoveEmp.TabIndex = 0;
            this.btnRemoveEmp.Text = "Remove Employee";
            this.btnRemoveEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEmp.UseVisualStyleBackColor = false;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // pnlViewEmployee
            // 
            this.pnlViewEmployee.Controls.Add(this.btnViewEmployee);
            this.pnlViewEmployee.Location = new System.Drawing.Point(0, 168);
            this.pnlViewEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pnlViewEmployee.Name = "pnlViewEmployee";
            this.pnlViewEmployee.Size = new System.Drawing.Size(192, 42);
            this.pnlViewEmployee.TabIndex = 1;
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnViewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnViewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployee.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnViewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnViewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewEmployee.Location = new System.Drawing.Point(-12, -21);
            this.btnViewEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnViewEmployee.Size = new System.Drawing.Size(227, 91);
            this.btnViewEmployee.TabIndex = 0;
            this.btnViewEmployee.Text = "View Employee";
            this.btnViewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewEmployee.UseVisualStyleBackColor = false;
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            // 
            // SalaryContaineer
            // 
            this.SalaryContaineer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.SalaryContaineer.Controls.Add(this.panel12);
            this.SalaryContaineer.Controls.Add(this.panel13);
            this.SalaryContaineer.Controls.Add(this.panel14);
            this.SalaryContaineer.Controls.Add(this.panel15);
            this.SalaryContaineer.Controls.Add(this.panel16);
            this.SalaryContaineer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalaryContaineer.Location = new System.Drawing.Point(5, 129);
            this.SalaryContaineer.Name = "SalaryContaineer";
            this.SalaryContaineer.Size = new System.Drawing.Size(192, 45);
            this.SalaryContaineer.TabIndex = 241;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSalary);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(192, 42);
            this.panel12.TabIndex = 1;
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.btnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalary.Enabled = false;
            this.btnSalary.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.Black;
            this.btnSalary.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icon_payroll;
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(-12, -21);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(219, 91);
            this.btnSalary.TabIndex = 0;
            this.btnSalary.Text = "    Salary";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnCalSalary);
            this.panel13.Location = new System.Drawing.Point(0, 42);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(192, 42);
            this.panel13.TabIndex = 1;
            // 
            // btnCalSalary
            // 
            this.btnCalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnCalSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnCalSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalSalary.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnCalSalary.ForeColor = System.Drawing.Color.Black;
            this.btnCalSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalSalary.Location = new System.Drawing.Point(-12, -21);
            this.btnCalSalary.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalSalary.Name = "btnCalSalary";
            this.btnCalSalary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCalSalary.Size = new System.Drawing.Size(227, 91);
            this.btnCalSalary.TabIndex = 0;
            this.btnCalSalary.Text = "Calulation Salary";
            this.btnCalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalSalary.UseVisualStyleBackColor = false;
            this.btnCalSalary.Click += new System.EventHandler(this.btnCalSalary_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnMonthkySalary);
            this.panel14.Location = new System.Drawing.Point(0, 84);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(192, 42);
            this.panel14.TabIndex = 1;
            // 
            // btnMonthkySalary
            // 
            this.btnMonthkySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnMonthkySalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthkySalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnMonthkySalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthkySalary.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnMonthkySalary.ForeColor = System.Drawing.Color.Black;
            this.btnMonthkySalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthkySalary.Location = new System.Drawing.Point(-12, -21);
            this.btnMonthkySalary.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonthkySalary.Name = "btnMonthkySalary";
            this.btnMonthkySalary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMonthkySalary.Size = new System.Drawing.Size(227, 91);
            this.btnMonthkySalary.TabIndex = 0;
            this.btnMonthkySalary.Text = "Monthly Report";
            this.btnMonthkySalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthkySalary.UseVisualStyleBackColor = false;
            this.btnMonthkySalary.Click += new System.EventHandler(this.btnMonthkySalary_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnOverallSummary);
            this.panel15.Location = new System.Drawing.Point(0, 126);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(192, 42);
            this.panel15.TabIndex = 1;
            // 
            // btnOverallSummary
            // 
            this.btnOverallSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnOverallSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverallSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnOverallSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverallSummary.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnOverallSummary.ForeColor = System.Drawing.Color.Black;
            this.btnOverallSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverallSummary.Location = new System.Drawing.Point(-12, -21);
            this.btnOverallSummary.Margin = new System.Windows.Forms.Padding(0);
            this.btnOverallSummary.Name = "btnOverallSummary";
            this.btnOverallSummary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnOverallSummary.Size = new System.Drawing.Size(227, 91);
            this.btnOverallSummary.TabIndex = 0;
            this.btnOverallSummary.Text = "Overall Report";
            this.btnOverallSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverallSummary.UseVisualStyleBackColor = false;
            this.btnOverallSummary.Click += new System.EventHandler(this.btnOverallSummary_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnAllSummary);
            this.panel16.Location = new System.Drawing.Point(0, 168);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(192, 42);
            this.panel16.TabIndex = 1;
            // 
            // btnAllSummary
            // 
            this.btnAllSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnAllSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnAllSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSummary.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnAllSummary.ForeColor = System.Drawing.Color.Black;
            this.btnAllSummary.Location = new System.Drawing.Point(-12, -21);
            this.btnAllSummary.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllSummary.Name = "btnAllSummary";
            this.btnAllSummary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAllSummary.Size = new System.Drawing.Size(227, 91);
            this.btnAllSummary.TabIndex = 0;
            this.btnAllSummary.Text = "All Salary Summary";
            this.btnAllSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllSummary.UseVisualStyleBackColor = false;
            this.btnAllSummary.Click += new System.EventHandler(this.btnAllSummary_Click);
            // 
            // SettingContaineer
            // 
            this.SettingContaineer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.SettingContaineer.Controls.Add(this.panel17);
            this.SettingContaineer.Controls.Add(this.pnlUpdateSetting);
            this.SettingContaineer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingContaineer.Location = new System.Drawing.Point(5, 180);
            this.SettingContaineer.Name = "SettingContaineer";
            this.SettingContaineer.Size = new System.Drawing.Size(192, 42);
            this.SettingContaineer.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnSetting);
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(192, 42);
            this.panel17.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Enabled = false;
            this.btnSetting.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(-12, -21);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(219, 91);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "    Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnlUpdateSetting
            // 
            this.pnlUpdateSetting.Controls.Add(this.btnUpdateSetting);
            this.pnlUpdateSetting.Location = new System.Drawing.Point(0, 42);
            this.pnlUpdateSetting.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUpdateSetting.Name = "pnlUpdateSetting";
            this.pnlUpdateSetting.Size = new System.Drawing.Size(192, 42);
            this.pnlUpdateSetting.TabIndex = 1;
            // 
            // btnUpdateSetting
            // 
            this.btnUpdateSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(231)))), ((int)(((byte)(180)))));
            this.btnUpdateSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
            this.btnUpdateSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSetting.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnUpdateSetting.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSetting.Location = new System.Drawing.Point(-12, -21);
            this.btnUpdateSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateSetting.Name = "btnUpdateSetting";
            this.btnUpdateSetting.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUpdateSetting.Size = new System.Drawing.Size(227, 91);
            this.btnUpdateSetting.TabIndex = 0;
            this.btnUpdateSetting.Text = "Update Setting";
            this.btnUpdateSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSetting.UseVisualStyleBackColor = false;
            this.btnUpdateSetting.Click += new System.EventHandler(this.btnUpdateSetting_Click);
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogIn.Location = new System.Drawing.Point(5, 228);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(192, 42);
            this.pnlLogIn.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_login;
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.Location = new System.Drawing.Point(-12, -21);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogIn.Size = new System.Drawing.Size(219, 91);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "    Log In";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pnlLogOut
            // 
            this.pnlLogOut.Controls.Add(this.btnLogOut);
            this.pnlLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogOut.Location = new System.Drawing.Point(5, 276);
            this.pnlLogOut.Name = "pnlLogOut";
            this.pnlLogOut.Size = new System.Drawing.Size(192, 42);
            this.pnlLogOut.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Enabled = false;
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icons_logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(-12, -21);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(219, 91);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "    Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 42);
            this.panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::GrifindoToysPayrollSystem.Properties.Resources.icon_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-12, -21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(219, 91);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "    Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeMenuTransition
            // 
            this.EmployeeMenuTransition.Interval = 10;
            this.EmployeeMenuTransition.Tick += new System.EventHandler(this.EmployeeMenuTransition_Tick);
            // 
            // SalaryMenuTransition
            // 
            this.SalaryMenuTransition.Interval = 10;
            this.SalaryMenuTransition.Tick += new System.EventHandler(this.SalaryMenuTransition_Tick);
            // 
            // SettingMenuTransition
            // 
            this.SettingMenuTransition.Interval = 10;
            this.SettingMenuTransition.Tick += new System.EventHandler(this.SettingMenuTransition_Tick);
            // 
            // SideBarTransition
            // 
            this.SideBarTransition.Interval = 3;
            this.SideBarTransition.Tick += new System.EventHandler(this.SideBarTransition_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GrifindoToysPayrollSystem.Properties.Resources.Designer__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 554);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "GrifindoToys Payroll System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hamMenu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.EmployeeContaineer.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnlViewEmployee.ResumeLayout(false);
            this.SalaryContaineer.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.SettingContaineer.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.pnlUpdateSetting.ResumeLayout(false);
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogOut.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.PictureBox hamMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.FlowLayoutPanel EmployeeContaineer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Panel pnlViewEmployee;
        private System.Windows.Forms.Button btnViewEmployee;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.FlowLayoutPanel SalaryContaineer;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnCalSalary;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnMonthkySalary;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnOverallSummary;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnAllSummary;
        private System.Windows.Forms.FlowLayoutPanel SettingContaineer;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnlUpdateSetting;
        private System.Windows.Forms.Button btnUpdateSetting;
        private System.Windows.Forms.Timer EmployeeMenuTransition;
        private System.Windows.Forms.Timer SalaryMenuTransition;
        private System.Windows.Forms.Timer SettingMenuTransition;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
    }
}

