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
    public partial class EmployeeLists : Form
    {
        private string name;
        public EmployeeLists(string empform)
        {
            
            InitializeComponent();
            name = empform;
            InitializeListView();
        }


        private void InitializeListView()
        {
            // Set custom header colors           
            EmployeeListView.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(EmployeeListView_DrawColumnHeader);
            EmployeeListView.DrawItem += new DrawListViewItemEventHandler(EmployeeListView_DrawItem);
            EmployeeListView.DrawSubItem += new DrawListViewSubItemEventHandler(EmployeeListView_DrawSubItem);
        }


        private void EmployeeLists_Load(object sender, EventArgs e)
        {           
                   
            LoadEmployeeList();

        }
        private void LoadEmployeeList()
        {
            try
            {
                if (MainForm.ds.Tables["EmployeesData"] != null)
                {
                    MainForm.ds.Tables["EmployeesData"].Clear();
                }

                MainForm.con.Open();

                MainForm.da = new SqlDataAdapter("SELECT EmployeeID,fullName FROM EmployeesData ", MainForm.con);

                MainForm.da.Fill(MainForm.ds, "EmployeesData");

                MainForm.con.Close();

                int currentRow = 0;

                int rowCount = MainForm.ds.Tables["EmployeesData"].Rows.Count;

                EmployeeListView.Items.Clear();

                while (currentRow < rowCount)
                {
                    string employeeId = MainForm.ds.Tables["EmployeesData"].Rows[currentRow]["EmployeeID"].ToString();

                    string fullName = MainForm.ds.Tables["EmployeesData"].Rows[currentRow]["fullName"].ToString();

                    ListViewItem item = new ListViewItem(employeeId);

                    item.SubItems.Add(fullName);

                    EmployeeListView.Items.Add(item);

                    currentRow++;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occurred while loading employee data: " + ex);
            }
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            this.Close();

            if (EmployeeListView.SelectedItems.Count > 0)
            {
                int SelectedID = int.Parse(EmployeeListView.SelectedItems[0].Text);

                // Switch statement to handle different actions based on the value of 'name'
                switch (name)
                {
                    // If the action is 'Edit', open the EditEmployee form and pass the selected EmployeeID
                    case "Edit":
                        EditEmployee editEmployee = new EditEmployee(SelectedID);

                        editEmployee.MdiParent = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                        editEmployee.Show();
                        break;
                    // If the action is 'Delete', open the EditEmployee form and pass the selected EmployeeID
                    case "Delete":
                        DeleteEmployee deleteEmployee = new DeleteEmployee(SelectedID);

                        deleteEmployee.MdiParent = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                        deleteEmployee.Show();
                        break;
                    // If the action is 'View', open the EditEmployee form and pass the selected EmployeeID
                    case "View":
                        ViewEmployee viewEmployee = new ViewEmployee(SelectedID);

                        viewEmployee.MdiParent = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                        viewEmployee.Show();
                        break;
                    // If the action is 'Salary', open the EditEmployee form and pass the selected EmployeeID
                    case "Salary":
                        frmSalary frmSalary = new frmSalary(SelectedID);

                        frmSalary.MdiParent = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                        frmSalary.Show();
                        break;
                    // If the action is 'SalaryReport', open the EditEmployee form and pass the selected EmployeeID
                    case "SalaryReport":
                       
                        MonthlyReport monthlyReport = new MonthlyReport(SelectedID);

                        monthlyReport.Show();                       
                        break;
                    // If the action is 'OverallReport', open the EditEmployee form and pass the selected EmployeeID
                    case "OverallReport":                       

                        OverallSalarySummary overallSalary = new OverallSalarySummary(SelectedID);

                        overallSalary.Show();
                        break;

                }



            }

        }



        private void EmployeeListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void EmployeeListView_DrawItem(object sender, DrawListViewItemEventArgs e)
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

        private void EmployeeListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Center-align text in subitems
            e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, Brushes.Black, e.SubItem.Bounds,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            e.DrawDefault = false;
        }

        
    }
}
