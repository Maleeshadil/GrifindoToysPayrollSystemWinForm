using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }      


        //Validation methods for various input fields, using the ValidateInput method
        private void lbIdCardNo_Validating(object sender, CancelEventArgs e)
        {
            if (cmbIdCrdTypes.Text=="NIN")
            {
                ValidateInput(tbIdCardNo, lbIsValidIdNo, Validator.IsNationalInsuranceValid, "Invalid national insurance number.");
            }
            else if (cmbIdCrdTypes.Text=="Passport")
            {
                ValidateInput(tbIdCardNo, lbIsValidIdNo, Validator.IsValidPassport, "Invalid passport number. ");

            }
            else
            {
                ValidateInput(tbIdCardNo, lbIsValidIdNo, Validator.IsDrivingLicenceValid, "Invalid driving licence number.");
            }
        }

        private void tbMonthlySalary_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbMonthlySalary, lbIsValidSalary, Validator.IsValidMonthlySalary, "Enter a Valid Salary(4digits&2decimals");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbEmail, lbIsValidEmail, Validator.IsValidEmail, "Enter a Valid Email Address.");
        }
        private void tbOTRate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbOTRate, lbIsValidOT, Validator.IsValidOTrate, "Enter a Valid OT Rate(2digits & 2decimals)");
        }

        private void tbAllowance_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbAllowance, lbIsValidAllowance, Validator.IsValidAllowance, "Enter a Valid Allowance(3digits&2decimals)");
        }

        private void tbPhoneNo_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbPhoneNo, lbIsValidPhoneNo, Validator.IsValidPhoneNumber, "Enter a Valid Phone Number(eg:+44xxxxxxxx)");
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
        //dynamically updating corresponding error labels by hiding them when the input is modified or corrected.
        private void tbFname_TextChanged(object sender, EventArgs e)
        {
            FindFullName();

            findNameWithInitials();

            if (lbIsValidFname.Visible)
            {
                lbIsValidFname.Visible = false;
            }
           

        } 

        private void tbLname_TextChanged(object sender, EventArgs e)
        {
            FindFullName();

            findNameWithInitials();

            if (lbIsValidLname.Text != "")
            {
                lbIsValidLname.Visible = false;
                return;
            }
           
        }

        private void lbIdCardNo_TextChanged(object sender, EventArgs e)
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

        // When the user leaves the TextBox, validate input and capitalize the first letter
        private void tbFname_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbFname, lbIsValidFname, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

            tbFname.Text = FistLetterCapital(tbFname.Text);
        }

        private void tbLname_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbLname, lbIsValidLname, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

            tbLname.Text = FistLetterCapital(tbLname.Text);
        }
        private void tbAddress_Leave(object sender, EventArgs e)
        {
            ValidationInputField(tbAddress, lbIsValidAddress, Validator.IsNullEmptyOrWhiteSpace, "Cannot be Empty or WhiteSpace.");

            tbAddress.Text = FistLetterCapital(tbAddress.Text);
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

               
                if (tempName.Length > 0)
                {
                    
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

        // Converts the first letter of each word in a string to uppercase and the rest of the letters to lowercase.
        public static string FistLetterCapital(string name)
        {
            // Split the input string into an array of words based on spaces
            string[] names = name.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 0)
                {
                    // Capitalize the first letter and convert the remaining letters to lowercase
                    names[i] = names[i][0].ToString().ToUpper() + names[i].Substring(1).ToLower();
                }

            }
            // Join the words back into a single string, 
            string CapitialName = string.Join(" ", names);

            // Return the formatted string.
            return CapitialName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Call the AddEmployee Method 
            AddEmployeeDetails(); 
           

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

        private void AddEmployeeDetails()
        {
            if (tbFname.Text == "" || tbLname.Text == "" || cmbJobTitelsTypes.Text == "Select" || tbFullName.Text == "" || tbNameWithInitials.Text == "" || cmbIdCrdTypes.Text == "Select" || tbIdCardNo.Text == "" ||
                   (rbMale.Checked == false && rbFemale.Checked == false) || dtpDOB.Value.ToShortDateString() == DateTime.Now.ToShortDateString() || tbAddress.Text == "" ||
                   cmbJobTitelsTypes.Text == "Select" || tbMonthlySalary.Text == "" || tbAllowance.Text == "" || tbOTRate.Text == "" || tbPhoneNo.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("All required fields must be completed.Please provide the missing information.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    // Clear parameters from the command object to prevent parameter reuse issues
                    MainForm.cmd.Parameters.Clear();

                    MainForm.con.Open();

                    //The SQL command to insert employee details
                    MainForm.cmd.CommandText = "INSERT INTO EmployeesData (title,firstName,lastName,fullName,NameWithInitails,idCardTypes,idCardNo,gender,dob,address,dateofJoining,jobTitle,monthlySalary,OTRate,allowance,phoneNumber,Email)VALUES(@title,@firstName,@lastName,@fullName,@NameWithInitails,@idCardTypes,@idCardNo,@gender,@dob,@address,@dateofJoining,@jobTitle,@monthlySalary,@OTRate,@allowance,@phoneNumber,@Email)";

                    // Add parameters to the command to prevent SQL injection
                    MainForm.cmd.Parameters.AddWithValue("@title", cmdTitle.SelectedItem.ToString());
                    MainForm.cmd.Parameters.AddWithValue("@firstName", tbFname.Text);
                    MainForm.cmd.Parameters.AddWithValue("@lastName", tbLname.Text);
                    MainForm.cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);
                    MainForm.cmd.Parameters.AddWithValue("@NameWithInitails", tbNameWithInitials.Text);
                    MainForm.cmd.Parameters.AddWithValue("@idCardTypes", cmbIdCrdTypes.SelectedItem.ToString());
                    MainForm.cmd.Parameters.AddWithValue("@idCardNo", tbIdCardNo.Text);

                    string gender = "";
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

                    MainForm.cmd.ExecuteNonQuery();

                    MainForm.con.Close();

                    MessageBox.Show("The new employee has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputFileds();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred while adding employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            
        }        

        //Method to Clear all input fields 
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
            Close();
        }


    }

    public static class Validator
    {
        //Check if a given email address is a valid
        public static bool IsValidEmail(string email)
        {
            // Regular expression for validating email address
            // Format: Valid email address with alphanumeric characters before and after '@', a dot (.),
            // and at least 2 characters for the domain
            string pattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]{2,}$";

            // Create a Regex object with the specified pattern
            Regex regex = new Regex(pattern);

            // Return true if the input matches the pattern, otherwise false
            return regex.IsMatch(email);
        }

        //Check if a given date is a valid
        public static bool IsValidDate(string date)
        {
            // Regular expression for validating the date 
            // Format: Date in MM/DD/YYYY format
            string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$";
           
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(date);
        }

        //Check if a given month is a valid
        public static bool IsValidMonth(string date)
        {
            // Regular expression for validating the month 
            // Format: Date in YYYY-MM format
            string pattern = @"^\d{4}-(0[1-9]|1[0-2])$";
           
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(date);
        }

        //Checkj if a given phoneNumber is a valid
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for validating phone number 
            // Format: UK phone number starting with +44, followed by 10 digits excluding 0
            string pattern = @"^\+44[1-9][0-9]{9}$";
           
            Regex regex = new Regex(pattern);
           
            return regex.IsMatch(phoneNumber);
        }

        //Check if a given monthly salary is a valid range
        public static bool IsValidMonthlySalary(string monthlySalary)
        {
            // Regular expression for validating monthly salary
            // Format: 4 or 5 digits followed by a decimal point and exactly 2 decimal
            string pattern = @"^\d{4,5}\.\d{2}$";
           
            Regex regex = new Regex(pattern);
           
            return regex.IsMatch(monthlySalary);
        }

        //Check if a given OT rate is a valid range
        public static bool IsValidOTrate(string rate)
        {
            // Regular expression for validating  OT
            // Format:  2 digits followed by a decimal point and exactly 2 decimal places
            string pattern = @"^\d{2}\.\d{2}$";
           
            Regex regex = new Regex(pattern);
          
            return regex.IsMatch(rate);
        }

        //Check if a given allowance rate is a valid range
        public static bool IsValidAllowance(string rate)
        {
            // Regular expression for validating allownace
            // Format:  3 digits followed by a decimal point and exactly 2 decimal places
            string pattern = @"^\d{3}\.\d{2}$";
            
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(rate);
        }

        //Check if a given passport is valid format
        public static bool IsValidPassport(string passport)
        {
            // Regular expression for validating passport number
            // Format: Alphanumeric string with exactly 9 characters
            string pattern = @"^[A-Z0-9]{9}$";
           
            Regex regex = new Regex(pattern);
          
            return regex.IsMatch(passport);
        }

        //Check if a given driving licence is valid format
        public static bool IsDrivingLicenceValid(string drivingLicense)
        {
            // Regular expression for validating driving licence
            // Format: 5 uppercase letters, followed by 6 digits, 2 uppercase letters, 1 digit, and 2 uppercase letters
            string pattern = @"^[A-Z]{5}[0-9]{6}[A-Z]{2}[0-9]{1}[A-Z]{2}$";
           
            Regex regex = new Regex(pattern);
          
            return regex.IsMatch(drivingLicense);

        }

        // Check if a given national insurance number is valid 
        public static bool IsNationalInsuranceValid(string NIN)
        {
            // Regular expression for validating  national insurance number
            // Format: UK National Insurance number excluding invalid prefixes like BG, GB, etc. (e.g., AB123456C)
            // Pattern explained: 2 uppercase letters (A-CEGHJ-PR-TW-Z), followed by 6 digits, and an optional suffix A-D
            string pattern = @"^(?!BG|GB|KN|NK|NT|TN|ZZ)([A-CEGHJ-PR-TW-Z]{2})(\d{2})(\d{2})(\d{2})([A-D])$";
            
            Regex regex = new Regex(pattern);
          
            return regex.IsMatch(NIN);
        }      
        
        //This method check the non-negative integers
        public static bool IsValid(string number, int minValue, int maxValue)
        {
            // Format: Positive integers only
            string pattern = @"^\d+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(number);
        }

        public static bool IsNullEmptyOrWhiteSpace(string textbox)
        {
            return  string.IsNullOrWhiteSpace(textbox);

        }

       
    }
}
