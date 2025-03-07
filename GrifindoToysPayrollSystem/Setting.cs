using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateSetting();
        }

        private void UpdateSetting()
        {
            try
            {               
     
                MainForm.con.Open();

                // Check if the setting with SettingId = 1 already exists
                MainForm.cmd.CommandText = "SELECT COUNT(*) FROM EmpSettings WHERE SettingId = @SettingId";

                MainForm.cmd.Parameters.AddWithValue("@SettingId", 1);

                // Execute the SQL command and get the count of rows
                int rowCount = (int)MainForm.cmd.ExecuteScalar();

                // If no setting exists, insert a new record into the EmpSettings table
                if (rowCount == 0)
                {
                    MainForm.cmd.CommandText = "INSERT INTO EmpSettings (SalaryCycleBeginDate, SalaryCycleEndDate, SalaryCycleDateRange, NumberOfLeavesPerYear)VALUES (@SalaryCycleBeginDate, @SalaryCycleEndDate, @SalaryCycleDateRange, @NumberOfLeavesPerYear)";

                    // Add parameters to the command to prevent SQL injection
                    MainForm.cmd.Parameters.AddWithValue("@SalaryCycleBeginDate", tbSalarySdate.Text);
                    MainForm.cmd.Parameters.AddWithValue("@SalaryCycleEndDate", tbSalaryEdate.Text);
                    MainForm.cmd.Parameters.AddWithValue("@SalaryCycleDateRange",tbSalaryRange.Text);
                    MainForm.cmd.Parameters.AddWithValue("@NumberOfLeavesPerYear", tbLeavesY.Text);

                    MainForm.cmd.ExecuteNonQuery();

                    // Clear parameters from the command object to prevent parameter reuse issues
                    MainForm.cmd.Parameters.Clear();

                    MessageBox.Show("Setting details has added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //The SQL command to update employee settings details
                MainForm.cmd.CommandText = "UPDATE  EmpSettings SET SalaryCycleBeginDate=@salaryCycleBeginDate,SalaryCycleEndDate=@salaryCycleEndDate,SalaryCycleDateRange=@salaryCycleDateRange,NumberOfLeavesPerYear=@numberOfLeavesPerYear WHERE SettingId=@Id";

                // Add parameters to the command to prevent SQL injection
                MainForm.cmd.Parameters.AddWithValue("@salaryCycleBeginDate", tbSalarySdate.Text);
                MainForm.cmd.Parameters.AddWithValue("@salaryCycleEndDate", tbSalaryEdate.Text);
                MainForm.cmd.Parameters.AddWithValue("@salaryCycleDateRange", tbSalaryRange.Text);
                MainForm.cmd.Parameters.AddWithValue("@numberOfLeavesPerYear", tbLeavesY.Text);
                MainForm.cmd.Parameters.AddWithValue("@Id", 1);
               
                MainForm.cmd.ExecuteNonQuery();

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();
                
                MainForm.con.Close();

                MessageBox.Show(" Setting details has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while setting details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static (int SalaryCycleDateRange, DateTime BeginDate, DateTime EndDate, int NoOfLeavesPerYear) GetSettings()
        {
            // Initialize variables to store settings values
            DateTime beginDate = DateTime.MinValue.Date;

            DateTime endDate = DateTime.MinValue.Date;

            int salaryCycleDateRange = 0;

            int noOfLeavesPerYear = 0;
            try
            {
                MainForm.con.Open();

                MainForm.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM EmpSettings", MainForm.con);

                MainForm.da.Fill(MainForm.ds, "EmpSettings");

                MainForm.con.Close();

                int rowCounts = MainForm.countRows("EmployeesData");

                int Row = 0;

                if (rowCounts > Row)
                {
                    // Retrieve the Begin Date as a string from 
                    string beginDateStr = MainForm.ds.Tables["EmpSettings"].Rows[0].ItemArray[1].ToString().Trim();

                    // Retrieve the End Date as a string from 
                    string endDateStr = MainForm.ds.Tables["EmpSettings"].Rows[0].ItemArray[2].ToString().Trim();

                    // Parse the Begin Date and End Date strings to DateTime
                    beginDate = DateTime.Parse(beginDateStr);

                    endDate = DateTime.Parse(endDateStr);

                    // Retrieve the Salary Cycle Date Range as an integer from
                    salaryCycleDateRange = Convert.ToInt32(MainForm.ds.Tables["EmpSettings"].Rows[0].ItemArray[3].ToString());

                    // Retrieve the Number of Leaves Per Year as an integer
                    noOfLeavesPerYear = Convert.ToInt32(MainForm.ds.Tables["EmpSettings"].Rows[0].ItemArray[4].ToString());


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loding setting details: {ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return the retrieved values as a tuple
            return (salaryCycleDateRange, beginDate, endDate, noOfLeavesPerYear);

        }
        private  int findDateRange(string beginDate, string endDate)
        {
            // Parse the beginDate string into a DateTime object
            DateTime start_date = DateTime.Parse(beginDate);

            // Parse the endDate string into a DateTime object
            DateTime end_date = DateTime.Parse(endDate);

            // Calculate the difference in days between the two dates and add 1 the range
            int dateRange = (end_date - start_date).Days+1;
            return dateRange;
        }

        private void tbSalaryRange_Click(object sender, EventArgs e)
        {

            int range = findDateRange(tbSalarySdate.Text,tbSalaryEdate.Text);

            tbSalaryRange.Text = range.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
