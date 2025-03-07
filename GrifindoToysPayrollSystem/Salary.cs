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
    public partial class frmSalary : Form
    {
        //Get EmployeeID from employee lists
        private int EmployeeID;
        public frmSalary(int employeeID)
        {
            InitializeComponent();

            EmployeeID = employeeID;

            tbEmployeeID.Text = EmployeeID.ToString();
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             
        //store the government's Tax rate as a constant
        private const double GovernmentTaxRate = 0.20;

        //Method to calculate no pay value for an employee
        private double CalculateNoPayValue(double totalSalary, int salaryCycleDateRange, int noOfAbsentDays)
        {
            double noPayValue = (totalSalary / salaryCycleDateRange) * noOfAbsentDays;
            return noPayValue;
        }

        //Method to calculate base pay value for an employee
        private double CalculateBasePayvalue(double monthlySalary, double allowances, double overtimeRate, int noOfOvertimeHours)
        {
            double basePayValue = monthlySalary + allowances + (overtimeRate * noOfOvertimeHours);
            return basePayValue;
        }

        //Method to calculate gross pay value for an employee
        private double CalculateGrossPay(double basePayValue, double noPayValue)
        {
            double grossPayValue = basePayValue - (noPayValue + (basePayValue * GovernmentTaxRate));
            return grossPayValue;
        }

        // Handles TextChanged events for various input fields,
        //dynamically updating corresponding error labels by hiding them when the input is modified or corrected
        private void tbSalarySdate_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidSdate.Text != "")
            {
                lbIsValidSdate.Visible = false;
                return;
            }
        }

        private void tbSalaryEdate_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidEdate.Text != "")
            {
                lbIsValidEdate.Visible = false;
                return;
            }
        }

        private void tbAbsent_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidNo1.Text != "")
            {
                lbIsValidNo1.Visible = false;
                return;
            }
        }

        private void tbOverTimeH_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidNo2.Text != "")
            {
                lbIsValidNo2.Visible = false;
                return;
            }
        }

        //Validation methods for various input fields, using the ValidateInput method
        private void tbSalarySdate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbSalarySdate, lbIsValidSdate, Validator.IsValidDate, "Invalid date format.please enter in this format (MM/dd/yyy)");
           
        }

        private void tbSalaryEdate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbSalaryEdate, lbIsValidEdate, Validator.IsValidDate, "Invalid date format.please enter in this format (MM/dd/yyy)");
            
        }

        private void tbAbsent_Validating(object sender, CancelEventArgs e)
        {
            Validate(tbAbsent, lbIsValidNo1, Validator.IsValid, "Please enter a valid non-negative integer within the allowed range.", 0, 5);
        }

        private void tbOverTimeH_Validating(object sender, CancelEventArgs e)
        {
            Validate(tbOverTimeH, lbIsValidNo2, Validator.IsValid, "Please enter a valid non-negative integer within the allowed range.", 0, 24);
        }

        //Validates the input fields and displays an error message if the input is invalid
        private void ValidateInput(TextBox textBox, Label errorLabel, Func<string, bool> validateMethod, string errorMessage)
        {
            // Continuously validate the input until it meets the validation criteria
            while (!validateMethod(textBox.Text))
            {
                // Display the error message and set focus back to the TextBox
                errorLabel.Visible = true;

                errorLabel.Text = errorMessage;

                textBox.Focus();
                return;
            }


        }
        private void Validate(TextBox textBox, Label errorLabel, Func<string, int, int, bool> validateMethod, string errorMessage, int minValue, int maxValue)
        {
            while (!validateMethod(textBox.Text, minValue, maxValue))
            {
                errorLabel.Visible = true;

                errorLabel.Text = errorMessage;

                textBox.Focus();
                return;
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            CalculateSalary();

            // Closes the current form after calulate the salary
            this.Close();

            // Opens the EmployeeLists form with "salary" If need calculate the salary for anbother employee
            DialogResult result = MessageBox.Show("Would you like to calculate the salary for another employee?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                EmployeeLists employeeLists = new EmployeeLists("Salary");
                employeeLists.Show();
            }
            else
            {
                // Closes the current form 
                this.Close();
            }
           
        }

        private void CalculateSalary()
        {     

            var setting = Setting.GetSettings();

            int absentDays;
            int overtimeHours;

            decimal dMonthlySalary = 0;
            decimal dOTRate = 0;
            decimal dAllowance = 0;

            DateTime startDate = DateTime.MinValue.Date;
            DateTime endDate = DateTime.MinValue.Date;
            try
            {
                MainForm.con.Open();

                //The SQL command to calculate employee salary
                MainForm.cmd.CommandText = "SELECT monthlySalary,OTRate,allowance FROM EmployeesData WHERE EmployeeID = @EmployeeID";

                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                SqlDataReader reader = MainForm.cmd.ExecuteReader();

                if (reader.Read())
                {                    

                    dMonthlySalary = (decimal)reader["monthlySalary"];

                    dOTRate = (decimal)reader["OTRate"];

                    dAllowance = (decimal)reader["allowance"];
                }
                reader.Close();

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();

                MainForm.con.Close();


                // Convert decimal values to double for further calculations
                double MonthlySalaray = (double)dMonthlySalary;

                double OTRate = (double)dOTRate;

                double Allowance = (double)dAllowance;

                // Parse the start and end dates from string to DateTime objects
                startDate = DateTime.Parse(tbSalarySdate.Text);

                endDate = DateTime.Parse(tbSalaryEdate.Text);

                //Calculate the number of days in the salary cycle date range
                int salaryCycleDateRange = (endDate - startDate).Days + 1;

                if (startDate < setting.BeginDate || endDate > setting.EndDate || salaryCycleDateRange > setting.SalaryCycleDateRange)
                {
                    // Display an error message if the date range is invalid
                    MessageBox.Show("Invalid date range. Please enter a date range within the defined salary cycle.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    return;
                }

                absentDays = Convert.ToInt32(tbAbsent.Text);

                overtimeHours = Convert.ToInt32(tbOverTimeH.Text);

                // Calculate the no-pay value based on the monthly salary, salary cycle date range, and absent days
                double noPayValue = CalculateNoPayValue(MonthlySalaray, salaryCycleDateRange, absentDays);

                // Calculate the base pay value based on the monthly salary, allowance ,OTRate,overtimehours
                double basePayValue = CalculateBasePayvalue(MonthlySalaray, Allowance, OTRate, overtimeHours);

                // Calculate the gross pay value based on the base pay value and no pay values
                double grossPayValue = CalculateGrossPay(basePayValue, noPayValue);
              
                MainForm.con.Open();

                //The SQL command to insert employee salary details
                MainForm.cmd.CommandText = "INSERT INTO EmpSalaries (EmployeeID,StartDate,EndDate,NoPayValue,BasePayValue,GrossPayValue,NoOfAbsentDays,NoOfOvertimeHours) VALUES (@EmployeeID,@StartDate,@EndDate,@NoPayValue,@BasePayValue,@GrossPayValue,@NoOfAbsentDays,@NoOfOvertimeHours)";

                // Add parameters to the command to prevent SQL injection
                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                MainForm.cmd.Parameters.AddWithValue("@StartDate", startDate);
                MainForm.cmd.Parameters.AddWithValue("@EndDate", endDate);
                MainForm.cmd.Parameters.AddWithValue("@NoPayValue", noPayValue);
                MainForm.cmd.Parameters.AddWithValue("@BasePayValue", basePayValue);
                MainForm.cmd.Parameters.AddWithValue("@GrossPayValue", grossPayValue);
                MainForm.cmd.Parameters.AddWithValue("@NoOfAbsentDays", tbAbsent.Text);
                MainForm.cmd.Parameters.AddWithValue("@NoOfOvertimeHours", tbOverTimeH.Text);

                MainForm.cmd.ExecuteNonQuery();

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();
                
                MainForm.con.Close();

                MessageBox.Show("The salary calculation has been successfully completed.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while calculating salary: {ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

       
    }
}
