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
    public partial class OverallSalarySummary : Form
    {
        //Get start date from setSalaryCycle 
        public static string startDate;

        //Get end date from setSalaryCycle 
        public static string endDate;

        //Get EmployeeId from employee lists
        private int EmployeeID;

        // Variable to differentiate between report types
        private string reportType;

        public OverallSalarySummary(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
        }

        private void OverallSalarySummary_Load(object sender, EventArgs e){

            

            SetSalaryCycle setSalaryCycle = new SetSalaryCycle();

            if (setSalaryCycle.ShowDialog() == DialogResult.OK)
            {
                // Ensure startDate and endDate are set after the dialog box closes
                if (!string.IsNullOrWhiteSpace(startDate) && !string.IsNullOrWhiteSpace(endDate))
                {
                    //Set Current date
                    string currentDate = Utility.GetCurrentDate();                   

                    // Load salary data based on selected dates
                    LoadOverallSalaryData();                          
                    

                    // Pass data to the RDLC report
                    ReportDataSource rds = new ReportDataSource("DataSet1", MainForm.ds.Tables["EmpSalaries"]);

                    overallSalaryReport.LocalReport.DataSources.Clear();

                    overallSalaryReport.LocalReport.DataSources.Add(rds);

                    // Extract the employee's full name for the parameter
                    string employeeFullName = string.Empty;
                  
                    if (MainForm.ds.Tables["EmpSalaries"].Rows.Count > 0)
                    {
                        employeeFullName = MainForm.ds.Tables["EmpSalaries"].Rows[0]["fullName"].ToString();
                        
                    }
                    // Set the parameter for FullName And Date And ReportHeader
                    ReportParameter fullNameParameter = new ReportParameter("FullName", employeeFullName);

                    ReportParameter dateParameter = new ReportParameter("Date", currentDate);

                    ReportParameter reportType = new ReportParameter("ReportType", "Overall");

                    overallSalaryReport.LocalReport.SetParameters(new ReportParameter[] { fullNameParameter, dateParameter, reportType });
                    

                    this.overallSalaryReport.RefreshReport();
                }
               
            }
            else
            {
                MessageBox.Show("You must enter a valid Start and End dates to view the report", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void LoadOverallSalaryData()
        {
            try
            {
                // Clear existing data in the dataset if any
                MainForm.clearDs("EmpSalaries");

                MainForm.con.Open();                
               

                // The SQL query to select employee salary data for the specified between start date and end date
                string query = @"
                      SELECT                     
                      e.EmployeeID,
                      e.fullName,
                      MIN(s.StartDate) AS StartDate,
                      MAX(s.EndDate) AS EndDate,
                      SUM(s.NoPayValue) AS NoPayValue,
                      SUM(s.BasePayValue) AS BasePayValue,
                      SUM(s.GrossPayValue) AS GrossPayValue,
                      SUM(s.NoOfAbsentDays) AS NoOfAbsentDays, 
                      SUM(s.NoOfOvertimeHours) AS NoOfOvertimeHours                      
                      FROM EmpSalaries s
                      JOIN
                      EmployeesData e ON s.EmployeeID=e.EmployeeID
                      WHERE
                      s.EmployeeID = @EmployeeID AND
                      s.StartDate >= @StartDate AND s.EndDate <= @EndDate
                      GROUP BY 
                      e.EmployeeID, e.fullName";
                MainForm.cmd.CommandText = query;

                // Add parameters to the command to prevent SQL injection
               
                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                MainForm.cmd.Parameters.AddWithValue("@StartDate", startDate);
                MainForm.cmd.Parameters.AddWithValue("@EndDate", endDate);

                MainForm.da = new System.Data.SqlClient.SqlDataAdapter(MainForm.cmd);

                MainForm.da.Fill(MainForm.ds, "EmpSalaries");

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

        private void overallSalaryReport_Load(object sender, EventArgs e)
        {

        }
        
    }
}
