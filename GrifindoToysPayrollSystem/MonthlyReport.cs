using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class MonthlyReport : Form
    {
        //Get month from setSalary month form
        public static string Month;

        //Get employeId form employee lists
        private int EmployeeID;

        public MonthlyReport(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
        }

        private void MothlyReport_Load(object sender, EventArgs e)
        {
             

            SetSalaryMonth setSalaryMonth = new SetSalaryMonth();

            if (setSalaryMonth.ShowDialog()== DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(Month))
                {
                    string currentDate = Utility.GetCurrentDate(); ;

                    // Dynamically set the report header
                    //string reportHeader = "Monthly Salary Report";

                    // Load the salary data
                    monthlySalaryReoprtLoad();

                    // Pass data to the RDLC report
                    ReportDataSource rds = new ReportDataSource("DataSet1", MainForm.ds.Tables["EmpSalaries"]);

                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // Extract the employee's full name for the parameter
                    string employeeFullName = string.Empty;
                    if (MainForm.ds.Tables["EmpSalaries"].Rows.Count > 0)
                    {
                        employeeFullName = MainForm.ds.Tables["EmpSalaries"].Rows[0]["fullName"].ToString();
                    }

                    // Set the parameter for FullName,currentdate and reportType
                    ReportParameter fullNameParameter = new ReportParameter("FullName", employeeFullName);

                    ReportParameter dateParameter = new ReportParameter("Date", currentDate);

                    ReportParameter reportType = new ReportParameter("ReportType", "Monthly");

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dateParameter, fullNameParameter, reportType });                    

                    // Refresh the report
                    reportViewer1.RefreshReport();
                }
            }         
            else
            {
                MessageBox.Show("You must enter a valid month to view the report.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void monthlySalaryReoprtLoad()
        {
            try
            {
                // Clears all rows and columns from the "EmpSalary" table in the dataset if it exists
                MainForm.clearDs("EmpSalaries");

                MainForm.con.Open();

                //The SQL query to select employee salary data for the specified month
                string query = @"
                SELECT
                s.SalaryID,
                e.EmployeeID,
                e.fullName,
                s.NoPayValue, 
                s.BasePayValue,
                s.GrossPayValue,
                s.NoOfAbsentDays,
                s.NoOfOvertimeHours, 
                s.StartDate,
                s.EndDate
                FROM EmpSalaries s
                JOIN EmployeesData e ON s.EmployeeID = e.EmployeeID
                WHERE s.EmployeeID = @EmployeeID AND
                FORMAT(s.StartDate, 'yyyy-MM') = @Month";

                MainForm.cmd.CommandText = query;

                // Add parameters to the command to prevent SQL injection
                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                MainForm.cmd.Parameters.AddWithValue("@Month", Month);

                MainForm.da = new System.Data.SqlClient.SqlDataAdapter(MainForm.cmd);
                    
                MainForm.da.Fill(MainForm.ds,"EmpSalaries");

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();

                MainForm.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while loading report data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        

        private void picbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
