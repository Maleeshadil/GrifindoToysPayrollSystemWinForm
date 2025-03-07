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
    public partial class EditEmployee : Form
    {
        //Get EmployeeId from Employee lists
        private int EmployeeID;       

        public EditEmployee(int SelectedID)
        {
            InitializeComponent();

            EmployeeID = SelectedID;

            LoadEmployeeData();

            
        }
             

        
        private void LoadEmployeeData()
        {
            try
            {
                // Clears all rows and columns from the "EmployeesData" table in the dataset if it exists
                MainForm.clearDs("EmployeesData");

                MainForm.con.Open();

                //The SQL command to load employee details
                MainForm.cmd.CommandText = "SELECT * FROM EmployeesData WHERE EmployeeID = @EmployeeID";

                // Add parameters to the command to prevent SQL injection
                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                MainForm.da = new SqlDataAdapter(MainForm.cmd);

                MainForm.da.Fill(MainForm.ds, "EmployeesData");

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();

                MainForm.con.Close();

                int rowCounts = MainForm.countRows("EmployeesData");

                int Row = 0;

                if (rowCounts > Row)
                {
                    DataRow row = MainForm.ds.Tables["EmployeesData"].Rows[0];

                    cmdTitle.Text = row["title"].ToString();

                    tbFname.Text = row["firstName"].ToString();

                    tbLname.Text = row["lastName"].ToString();

                    tbFullName.Text = row["fullName"].ToString();

                    tbNameWithInitials.Text = row["NameWithInitails"].ToString();

                    cmbIdCrdTypes.Text = row["idCardTypes"].ToString();

                    tbIdCardNo.Text = row["idCardNo"].ToString();

                    string gender = row["gender"].ToString().Trim();
                    if (gender == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }


                    if (row["dob"]!=DBNull.Value)
                    {
                        dtpDOB.Value = (DateTime)row["dob"];
                    }
                   
                    tbAddress.Text = row["address"].ToString();

                    if (row["dateofJoining"]!=DBNull.Value)
                    {
                        dtpJoningDate.Value = (DateTime)row["dateofJoining"];
                    }
                   
                    cmbJobTitelsTypes.Text = row["jobTitle"].ToString();

                    tbMonthlySalary.Text = row["monthlySalary"].ToString();

                    tbOTRate.Text = row["OTRate"].ToString();

                    tbAllowance.Text = row["allowance"].ToString();

                    tbPhoneNo.Text = row["phoneNumber"].ToString();

                    tbEmail.Text = row["Email"].ToString();                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // When the user leaves the TextBox, validate input and capitalize the first letter
        private void tbFname_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbFname, lbIsValidFname, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

            tbFname.Text =AddEmployee.FistLetterCapital(tbFname.Text);

        }

        private void tbLname_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbLname, lbIsValidLname, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

            tbLname.Text =AddEmployee.FistLetterCapital(tbLname.Text);
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbAddress, lbIsValidAddress, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

            tbAddress.Text =AddEmployee.FistLetterCapital(tbAddress.Text);
        }

        private void tbIdCardNo_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbIdCardNo, lbIsValidIdNo, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");
        }
        private void tbMonthlySalary_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbMonthlySalary, lbIsValidSalary, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

        }

        private void tbOTRate_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbOTRate, lbIsValidOT, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");
        }

        private void tbAllowance_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbAllowance, lbIsValidAllowance, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");
        }

        private void tbPhoneNo_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbPhoneNo, lbIsValidPhoneNo, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbEmail, lbIsValidEmail, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");
        }

        //Validates the input fields and displays an error message if the validation fails.
        private void ValidationInputField(TextBox textBox, Label errorLabel, Func<string, bool> validationMethod, string errorMessage)
        {
            // Check if the input does not meet the validation criteria
            if (validationMethod(textBox.Text))
            {
                // Display the error message and set focus back to the TextBox
                errorLabel.Visible = true;

                errorLabel.Text = errorMessage;

                textBox.Focus();
                return;
            }


        }

        private void FindFullName()
        {
            tbFullName.Text = $"{tbFname.Text} {tbLname.Text}";
        }

        private void findNameWithInitials()
        {
            // Split the full name into parts
            string[] names = tbFullName.Text.Trim().Split(' ');

            //get name count without last name
            int nameCount = names.Length - 1;

            // create variable get currentName
            int currentName = 0;

            //create variable to get initials character
            string initials = "";

            //define condition get initials values
            
            while (currentName < nameCount)
            {
                //create variable story current name 
                string tempName = names[currentName];
                
                if (tempName.Length > 0)                {
                    
                    if (initials.Length > 0)
                    {
                        // tempName 0 value story in initials  
                        initials = initials + "" + tempName[0].ToString().ToUpper();
                    }
                    else
                    {
                        initials = tempName[0].ToString().ToUpper();
                    }

                }
                
                currentName++;
            }

            // Combine initials with the last part of the name
            string nameWithInitials = $"{initials} {names[names.Length - 1]}".ToString();

            tbNameWithInitials.Text = nameWithInitials;

        }
        

        private void tbFname_TextChanged(object sender, EventArgs e)
        {
            FindFullName();
            if (tbFname.Text=="")
            {
                tbNameWithInitials.Text = "";
               
            }
            else
            {
                findNameWithInitials();
            }

            if (lbIsValidFname.Text != "")
            {
                lbIsValidFname.Visible = false;
                return;
            }
        }

        // Handles TextChanged events for various input fields,
        //dynamically updating corresponding error labels by hiding them when the input is modified or corrected
        private void tbLname_TextChanged(object sender, EventArgs e)
        {

            FindFullName();
            if (tbLname.Text == "")
            {
                tbNameWithInitials.Text = "";

            }
            else
            {
                findNameWithInitials();
            }

            if (lbIsValidLname.Text != "")
            {
                lbIsValidLname.Visible = false;
                return;
            }
        }

        private void tbIdCardNo_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidIdNo.Text != "")
            {
                lbIsValidIdNo.Visible = false;
                return;
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

            if (lbIsValidAddress.Text != "")
            {
                lbIsValidAddress.Visible = false;
                return;
            }

        }

        private void tbMonthlySalary_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidSalary.Text != "")
            {
                lbIsValidSalary.Visible = false;
                return;
            }
        }

        private void tbOTRate_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidOT.Text != "")
            {
                lbIsValidOT.Visible = false;
                return;
            }
        }

        private void tbAllowance_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidAllowance.Text != "")
            {
                lbIsValidAllowance.Visible = false;
                return;
            }
        }

        private void tbPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (lbIsValidPhoneNo.Text != "")
            {
                lbIsValidPhoneNo.Visible = false;
                return;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text != "")
            {
                lbIsValidEmail.Visible = false;
                return;
            }
        }

        //Validation methods for various input fields, using the ValidateInput method
        private void tbIdCardNo_Validating(object sender, CancelEventArgs e)
        {
            if (cmbIdCrdTypes.Text == "NIN")
            {
                ValidateInput(tbIdCardNo, lbIsValidIdNo, Validator.IsNationalInsuranceValid, "Invalid national insurance number.");
            }
            else if (cmbIdCrdTypes.Text == "Passport")
            {
                ValidateInput(tbIdCardNo, lbIsValidIdNo, Validator.IsValidPassport, "Invalid passport number. ");

            }
            else
            {
                ValidateInput(tbIdCardNo, lbIsValidIdNo, Validator.IsDrivingLicenceValid, "Invalid driving licence number. ");
            }
        }

        private void tbMonthlySalary_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbMonthlySalary, lbIsValidSalary, Validator.IsValidMonthlySalary, "Enter a Valid Salary(4digits&2decimals");
        }

        private void tbOTRate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbOTRate, lbIsValidOT, Validator.IsValidOTrate, "Enter a Valid OT Rate(2digits&2decimals)");
        }

        private void tbAllowance_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbAllowance, lbIsValidAllowance, Validator.IsValidAllowance, "Enter a Valid Allowance(3digits&2decimals)");
            
        }

        private void tbPhoneNo_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbPhoneNo, lbIsValidPhoneNo, Validator.IsValidPhoneNumber, "Enter a Valid Phone Number(eg:+44xxxxxxxx)");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbEmail, lbIsValidEmail, Validator.IsValidEmail, "Enter a Valid Email Address.");
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

        //click event for the Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
             if (CheckValidationErrors())
             {
                return;
             }
            else
            {
                // Updates the employee details 
                UpdateEmpDetails();

                // Closes the current form after the update
                this.Close();

                // Opens the EmployeeLists form with "Edit" If need edit another employee
                DialogResult result = MessageBox.Show("Would you like to edit another employee?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    // Clears all input fields for new data
                    ClearInputFileds();

                    // Opens the EmployeeLists form 
                    EmployeeLists employeeLists = new EmployeeLists("Edit");
                    employeeLists.Show();
                }
                else
                {
                    this.Close();
                }
            }

            


        }

        private void UpdateEmpDetails()
        {
            // Check if any required field is empty or invalid
            if (tbFname.Text == "" || tbLname.Text == "" || cmbJobTitelsTypes.Text == "Select" || tbFullName.Text == "" || tbNameWithInitials.Text == "" || cmbIdCrdTypes.Text == "Select" || tbIdCardNo.Text == "" ||
                  (rbMale.Checked == false && rbFemale.Checked == false) || dtpDOB.Value.ToShortDateString() == DateTime.Now.ToShortDateString() || tbAddress.Text == "" ||
                  cmbJobTitelsTypes.Text == "Select" || tbMonthlySalary.Text == "" || tbAllowance.Text == "" || tbOTRate.Text == "" || tbPhoneNo.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("All required fields must be completed.Please provide the missing information.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else{

                try
                {
                    MainForm.con.Open();

                    //The SQL command to update employee details
                    MainForm.cmd.CommandText = "UPDATE EmployeesData SET title=@title,firstName=@firstName,lastName=@lastName,fullName=@fullName,NameWithInitails=@NameWithInitails,idCardTypes=@idCardTypes," +
                        "idCardNo=@idCardNo,gender=@gender,dob=@dob,address=@address,dateofJoining=@dateofJoining,jobTitle=@jobTitle,monthlySalary=@monthlySalary,OTRate=@OTRate,allowance=@allowance,phoneNumber=@phoneNumber," +
                        "Email=@Email WHERE EmployeeID=@EmployeeID";

                    // Add parameters to the command to prevent SQL injection
                    MainForm.cmd.Parameters.AddWithValue("@title", cmdTitle.SelectedItem.ToString());
                    MainForm.cmd.Parameters.AddWithValue("@firstName", tbFname.Text);
                    MainForm.cmd.Parameters.AddWithValue("@lastName", tbLname.Text);
                    MainForm.cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);
                    MainForm.cmd.Parameters.AddWithValue("@NameWithInitails", tbNameWithInitials.Text);
                    MainForm.cmd.Parameters.AddWithValue("@idCardTypes", cmbIdCrdTypes.SelectedItem.ToString());
                    MainForm.cmd.Parameters.AddWithValue("@idCardNo", tbIdCardNo.Text);

                    string gender = "";

                    // Check if the Male radio button is selected.
                    if (rbMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    MainForm.cmd.Parameters.AddWithValue("@gender", gender);
                    MainForm.cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                    MainForm.cmd.Parameters.AddWithValue("@address", tbAddress.Text);
                    MainForm.cmd.Parameters.AddWithValue("@dateofJoining", dtpJoningDate.Value.Date);
                    MainForm.cmd.Parameters.AddWithValue("@jobTitle", cmbJobTitelsTypes.SelectedItem.ToString());
                    MainForm.cmd.Parameters.AddWithValue("@monthlySalary", tbMonthlySalary.Text);
                    MainForm.cmd.Parameters.AddWithValue("@OTRate", tbOTRate.Text);
                    MainForm.cmd.Parameters.AddWithValue("@allowance", tbAllowance.Text);
                    MainForm.cmd.Parameters.AddWithValue("@phoneNumber", tbPhoneNo.Text);
                    MainForm.cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                    MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);


                    MainForm.cmd.ExecuteNonQuery();

                    // Clear parameters from the command object to prevent parameter reuse issues
                    MainForm.cmd.Parameters.Clear();

                    MainForm.con.Close();

                    MessageBox.Show("Employee details have been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred while updating employee data: {ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }


        // Event handler for when the selected item in changes
        private void cmbIdCrdTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected ID card type is "NIN"
            if (cmbIdCrdTypes.Text == "NIN")
            {
                // Update the label text to "NIN No"
                lbIdCrdNo.Text = "NIN No";
            }
            else if (cmbIdCrdTypes.Text == "Driving License")
            {
                lbIdCrdNo.Text = "Driving License No:";

            }
            else if (cmbIdCrdTypes.Text == "Passport")
            {
                lbIdCrdNo.Text = "Passport:";
            }
        }
        private void ClearInputFileds()
        {
            cmdTitle.SelectedIndex = -1;

            tbFname.Text = "";

            tbLname.Text = "";

            tbFullName.Text = "";

            tbNameWithInitials.Text = "";

            cmbIdCrdTypes.SelectedIndex = -1;

            tbIdCardNo.Text = "";

            if (rbMale.Checked == true)
            {
                rbMale.Checked = false;
            }
            else
            {
                rbFemale.Checked = false;
            }

            dtpDOB.Value = DateTime.Now;

            tbAddress.Text = "";

            dtpJoningDate.Value = DateTime.Now;

            cmbJobTitelsTypes.SelectedIndex = -1;

            tbMonthlySalary.Text = "";

            tbOTRate.Text = "";

            tbAllowance.Text = "";

            tbPhoneNo.Text = "";

            tbEmail.Text = "";



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckValidationErrors()
        {
            // List of label-textbox pairs to check validation
            var validationControls = new List<(Label, TextBox)>
            {
                (lbIsValidFname, tbFname),
                (lbIsValidLname, tbLname),
                (lbIsValidAddress, tbAddress),
                (lbIsValidIdNo, tbIdCardNo),
                (lbIsValidSalary, tbMonthlySalary),
                (lbIsValidOT, tbOTRate),
                (lbIsValidAllowance, tbAllowance),
                (lbIsValidPhoneNo, tbPhoneNo),
                (lbIsValidEmail, tbEmail)
            };

            foreach (var (errorLabel, textBox) in validationControls)
            {
                if (errorLabel.Visible)  // If an error label is visible, there's an error
                {
                    MessageBox.Show("Please correct the highlighted errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return true; // Stop further execution
                }
            }

            return false; // No validation errors
        }





    }

}
