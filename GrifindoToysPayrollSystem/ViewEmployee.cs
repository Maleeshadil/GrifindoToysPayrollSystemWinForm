using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class ViewEmployee : Form
    {
        //Get Employee from employee lsits
        private int EmployeeID;
        public ViewEmployee(int employeeID)
        {
            InitializeComponent(); 

            EmployeeID = employeeID;

            InitializeListView();

            tbEmployeID.Text = EmployeeID.ToString();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }
       

      
        private void InitializeListView()
        {
            // Enable scroll bars by ensuring the Scrollable property is set to true
            lvEmpList.Scrollable = true;

            // Set the View property to Details, so the ListView shows columns
            lvEmpList.View = View.Details;

            // Enable full row select
            lvEmpList.FullRowSelect = true;

            // Enable grid lines
            lvEmpList.GridLines = true;            

            // Set custom header colors
            lvEmpList.OwnerDraw = true;

            lvEmpList.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(lvSalaryReport_DrawColumnHeader);

            lvEmpList.DrawItem += new DrawListViewItemEventHandler(lvSalaryReport_DrawItem);

            lvEmpList.DrawSubItem += new DrawListViewSubItemEventHandler(lvSalaryReport_DrawSubItem);

            // Clear existing columns
            lvEmpList.Columns.Clear();

            // Add required columns with precise widths
            lvEmpList.Columns.Add("EmpID", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Title", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("First Name", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Full Name", 250, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Name With Initials", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("ID Card Types", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("ID Card No", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Gender", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Date of Birth", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Address", 200, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Date of Joining", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Job Title", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Monthly Salary", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("OT Rate", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Allowance", 100, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Phone Number", 150, HorizontalAlignment.Left);
            lvEmpList.Columns.Add("Email", 230, HorizontalAlignment.Left);           

            
        }
        private void lvSalaryReport_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Set custom header background color
            using (SolidBrush headerBackgroundBrush = new SolidBrush(Color.LightSteelBlue))
            {
                e.Graphics.FillRectangle(headerBackgroundBrush, e.Bounds);
            }

            // Set header text color and font
            using (Font headerFont = new Font("Arial", 9, FontStyle.Bold))
            {
                TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont, e.Bounds, Color.Black);
            }

            e.DrawDefault = false;
        }

        private void lvSalaryReport_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Set alternating row colors
            if (e.ItemIndex % 2 == 0)
            {
                e.Item.BackColor = Color.WhiteSmoke;
            }
            else
            {
                e.Item.BackColor = Color.Gainsboro;
            }

            e.DrawDefault = true;
        }

        private void lvSalaryReport_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Center-align text in subitems
            e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, Brushes.Black, e.SubItem.Bounds,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            e.DrawDefault = false;
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();

           
        }

        private void LoadEmployeeList()
        {
            try
            {
                // Clears all rows and columns from the "EmployeesData" table in the dataset if it exists
                MainForm.clearDs("EmployeesData");

                //The SQL command to load employee details
                MainForm.cmd.CommandText = "SELECT * FROM EmployeesData WHERE EmployeeID = @EmployeeID";

                // Add parameters to the command to prevent SQL injection
                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                MainForm.da = new SqlDataAdapter(MainForm.cmd);

                MainForm.da.Fill(MainForm.ds, "EmployeesData");

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();

                MainForm.con.Close();

                AddDataToListView();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAllView_Click(object sender, EventArgs e)
        {
            try
            {
                // Clears all rows and columns from the "EmployeesData" table in the dataset if it exists
                MainForm.clearDs("EmployeesData");

                MainForm.con.Open();

                MainForm.da = new SqlDataAdapter("SELECT * FROM EmployeesData ", MainForm.con);

                MainForm.da.Fill(MainForm.ds, "EmployeesData");

                MainForm.con.Close();

                AddDataToListView();

                tbEmployeID.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbEmployeID.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            tbEmployeID.Text = "";

            // Clear all existing items in the ListView
            lvEmpList.Items.Clear();
            
        }

        private void PicbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int SearchEmpID = Convert.ToInt32(tbSearchID.Text);

            try
            {
                // Clears all rows and columns from the "EmployeesData" table in the dataset if it exists
                MainForm.clearDs("EmployeesData");
                
                MainForm.cmd.CommandText = "SELECT * FROM EmployeesData WHERE EmployeeID = @EmployeeID";

                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", SearchEmpID);

                MainForm.da = new SqlDataAdapter(MainForm.cmd);

                MainForm.da.Fill(MainForm.ds, "EmployeesData");

                MainForm.cmd.Parameters.Clear();

                MainForm.con.Close();

                AddDataToListView();

                tbEmployeID.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employee data: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AddDataToListView()
        {
            // Clear all existing items in the ListView
            lvEmpList.Items.Clear();

            int rowCounts = MainForm.countRows("EmployeesData");

            int Row = 0;

            if (rowCounts > Row)
            {
                // Loop through each row in the EmployeesData table
                foreach (DataRow row in MainForm.ds.Tables["EmployeesData"].Rows)
                {
                    // Retrieve data from each column in the current row
                    string employeeId = row["EmployeeID"].ToString();
                    string title = row["title"].ToString();
                    string fname = row["firstName"].ToString();
                    string lname = row["lastName"].ToString();
                    string fullName = row["fullName"].ToString();
                    string nameWithInitials = row["NameWithInitails"].ToString();
                    string idCrdTypes = row["idCardTypes"].ToString();
                    string idCrdNo = row["idCardNo"].ToString();
                    string gender = row["gender"].ToString();
                    string dob = Convert.ToDateTime(row["dob"]).ToString("MM/dd/yyy");
                    string address = row["address"].ToString();
                    string dateOfJoning = Convert.ToDateTime(row["dateofJoining"]).ToString("MM/dd/yyy");
                    string jobTitle = row["jobTitle"].ToString();
                    string monthlySalary = row["monthlySalary"].ToString();
                    string OTRate = row["OTRate"].ToString();
                    string allowance = row["allowance"].ToString();
                    string phoneNo = row["phoneNumber"].ToString();
                    string email = row["Email"].ToString();

                    // Create a new ListViewItem with the Employee ID as the first column
                    ListViewItem item = new ListViewItem(employeeId);

                    // Add the subitems (other columns) to the ListViewItem
                    item.SubItems.Add(title);
                    item.SubItems.Add(fname);
                    item.SubItems.Add(lname);
                    item.SubItems.Add(fullName);
                    item.SubItems.Add(nameWithInitials);
                    item.SubItems.Add(idCrdTypes);
                    item.SubItems.Add(idCrdNo);
                    item.SubItems.Add(gender);
                    item.SubItems.Add(dob);
                    item.SubItems.Add(address);
                    item.SubItems.Add(dateOfJoning);
                    item.SubItems.Add(jobTitle);
                    item.SubItems.Add(monthlySalary);
                    item.SubItems.Add(OTRate);
                    item.SubItems.Add(allowance);
                    item.SubItems.Add(phoneNo);
                    item.SubItems.Add(email);

                    // Add the ListViewItem to the ListView 
                    lvEmpList.Items.Add(item);
                }

            }
        }
    }
}
