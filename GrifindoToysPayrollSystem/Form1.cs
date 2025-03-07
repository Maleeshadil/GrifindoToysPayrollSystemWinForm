using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrifindoToysPayrollSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
         
        }

        // Initialize a SQL Server connection with connection string details
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-U2RU9SL;Initial Catalog=PayRollSystem;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True");

        // Create a SqlCommand object for executing SQL queries and commands
        public static SqlCommand cmd = new SqlCommand();

        // Create a SqlDataAdapter object for filling a DataSet with data from the database
        public static SqlDataAdapter da = new SqlDataAdapter();

        // Create a DataSet to store data retrieved from the database
        public static DataSet ds = new DataSet();


        // Handles the transition for expanding or collapsing the Employee menu
        bool employeMenuExpand = false;

        private void EmployeeMenuTransition_Tick(object sender, EventArgs e)
        {
            if (employeMenuExpand==false)
            {
                // Expands the Employee menu container by increasing its height
                EmployeeContaineer.Height +=10;

                if (EmployeeContaineer.Height>=220)
                {
                    EmployeeMenuTransition.Stop();

                    employeMenuExpand = true;
                }
               


            }
            else
            {
                // Collapses the Employee menu container by decreasing its height
                EmployeeContaineer.Height -=10;

                if (EmployeeContaineer.Height <= 42)
                {
                    EmployeeMenuTransition.Stop();

                    employeMenuExpand = false;
                }   

            }
        }

        // Handles the transition for expanding or collapsing the Salary menu
        bool salaryMenuExpand = false;
        private void SalaryMenuTransition_Tick(object sender, EventArgs e)
        {
            if (salaryMenuExpand == false)
            {
                // Expands the Salary menu container by increasing its height
                SalaryContaineer.Height += 10;

                if (SalaryContaineer.Height >= 178)
                {
                    SalaryMenuTransition.Stop();

                    salaryMenuExpand = true;
                }



            }
            else
            {
                // Collapses the Salary menu container by decreasing its height
                SalaryContaineer.Height -= 10;

                if (SalaryContaineer.Height <= 42)
                {
                    SalaryMenuTransition.Stop();

                    salaryMenuExpand = false;
                }

            }
        }

        // Handles the transition for expanding or collapsing the Setting menu
        bool settingMenuExpand = false;

        private void SettingMenuTransition_Tick(object sender, EventArgs e)
        {
            if (settingMenuExpand == false)
            {
                // Expands the Setting menu container by increasing its height
                SettingContaineer.Height += 10;

                if (SettingContaineer.Height >= 90)
                {
                    SettingMenuTransition.Stop();

                    settingMenuExpand = true;
                }



            }
            else
            {
                // Collapses the Setting menu container by decreasing its height
                SettingContaineer.Height -= 10;

                if (SettingContaineer.Height <= 42)
                {
                    SettingMenuTransition.Stop();

                    settingMenuExpand = false;
                }

            }
        }

        // Handles the transition for expanding or collapsing the sidebar
        bool sidebarExpand = true;
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Collapses the sidebar by decreasing its width
                sidebar.Width -= 10;

                if (sidebar.Width <= 48)
                {
                    sidebarExpand = false;
                    SideBarTransition.Stop();

                }
            }
            else
            {
                // Expands the sidebar by increasing its width
                sidebar.Width += 10;

                if (sidebar.Width >= 210)
                {
                    sidebarExpand = true;
                    SideBarTransition.Stop();

                }
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            EmployeeMenuTransition.Start();
        }      

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SalaryMenuTransition.Start();
           


        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingMenuTransition.Start();
        }       

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                btnLogIn.Enabled = false;
                btnEmp.Enabled = true;
                btnEditEmp.Enabled = true;              
                btnRemoveEmp.Enabled = true;
                btnSetting.Enabled = true;
                btnSalary.Enabled = true;
                btnLogOut.Enabled = true;
                btnExit.Enabled = true;

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogIn.Enabled = true;
            btnEmp.Enabled = false;
            btnEditEmp.Enabled = false;
            btnRemoveEmp.Enabled = false;
            btnSetting.Enabled = false;
            btnSalary.Enabled = false;
            btnLogOut.Enabled = false;
            btnExit.Enabled = true;

            MessageBox.Show("You have successfully logged out.", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void hamMenu_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        // Opens the AddEmployee form to add a new employee
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            OpenForm(addEmployee);
            
           
        }

        // Opens the EmployeeLists form in Edit mode for editing employee details
        private void btnEditEmp_Click(object sender, EventArgs e)
        {

            EmployeeLists employeeLists = new EmployeeLists("Edit");
            OpenForm(employeeLists, false);
            
        }

        // Opens the EmployeeLists form in Delete mode for removing an employee
        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            EmployeeLists employeeLists = new EmployeeLists("Delete");            
            OpenForm(employeeLists, false);

        }

        // Opens the EmployeeLists form in View mode to view employee details
        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLists employeeLists = new EmployeeLists("View");          
            OpenForm(employeeLists, false);

            btnViewEmployee.BackColor = System.Drawing.Color.FromArgb(166, 231, 180);
        }

        // Opens the Setting form to update salary settings
        private void btnUpdateSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            OpenForm(setting);
            
        }

        // Opens the EmployeeLists form in Salary mode for calculating an employee's salary
        private void btnCalSalary_Click(object sender, EventArgs e)
        {
            EmployeeLists employeeLists = new EmployeeLists("Salary");
            OpenForm(employeeLists, false);

        }

        // Opens the EmployeeLists form in SalaryReport mode to view the monthly salary report
        private void btnMonthkySalary_Click(object sender, EventArgs e)
        {

            EmployeeLists employeeLists = new EmployeeLists("SalaryReport");
            OpenForm(employeeLists, false);
        }

        // Opens the EmployeeLists form in OverallReport mode to view the overall report
        private void btnOverallSummary_Click(object sender, EventArgs e)
        {
            EmployeeLists employeeLists = new EmployeeLists("OverallReport");
            OpenForm(employeeLists, false);
        }

        private void btnAllSummary_Click(object sender, EventArgs e)
        {
            AllEmployeeSalarySummary allEmployeeSalary = new AllEmployeeSalarySummary();
            OpenForm(allEmployeeSalary);          

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            sidebar.AutoScroll = true;
            sidebar.VerticalScroll.Visible = true;
        }

        // To keep track of non-MDI forms
        Form activeNonMdiForm = null;

        private void OpenForm(Form newForm, bool isMdiChild = true)
        {
            // If the form is supposed to be an MDI child
            if (isMdiChild)
            {
                // Close any active non-MDI form
                if (activeNonMdiForm != null)
                {
                    activeNonMdiForm.Close();
                    activeNonMdiForm = null;
                }

                // Close the currently active MDI child form, if any
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }

                // Set the new form as an MDI child
                newForm.MdiParent = this;                
                newForm.Show();
            }
            else
            {
                // Close the currently open non-MDI form, if any
                if (activeNonMdiForm != null)
                {
                    activeNonMdiForm.Close();
                }

                // Close the currently active MDI child form, if any
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                // If the new form is non-MDI (center screen), open it
                newForm.StartPosition = FormStartPosition.CenterScreen;

                newForm.Show();
                // Keep track of the current non-MDI form
                activeNonMdiForm = newForm;
            }
        }

        // Clears all rows and columns from the table in the dataset if it exists
        public static void clearDs(string tblName)
        {
            if (ds.Tables[tblName] != null)
            {
                ds.Tables[tblName].Rows.Clear();
                ds.Tables[tblName].Columns.Clear();
            }
        }
       
        public static int countRows(string tblName)
        {
            int count = ds.Tables[tblName].Rows.Count;
            return count;
        }
       

    }

    public static class Utility
    {
        public static string GetCurrentDate()
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Format the date as "MMMM-dd-yyyy"
            string formattedDate = currentDate.ToString("MMMM-dd-yyyy");

            return formattedDate;
        }
    }
}
