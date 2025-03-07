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
    public partial class DeleteEmployee : Form
    {
        //Get EmployeeId from Employee lists
        private int EmployeeID;

        public DeleteEmployee(int selectedId)
        {
            InitializeComponent();

            EmployeeID = selectedId;

            LoadEmployeeData();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
           
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

                int Rows = 0;

                int rowCounts = MainForm.countRows("EmployeesData");


                if (rowCounts > Rows)
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

                    if (row["dob"] != DBNull.Value)
                    {
                        dtpDOB.Value = (DateTime)row["dob"];
                    }

                    tbAddress.Text = row["address"].ToString();

                    if (row["dateofJoining"] != DBNull.Value)
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmpDetails();
            this.Close();
        }


        private void DeleteEmpDetails()
        {
            try
            {
                MainForm.con.Open();

                MainForm.cmd.CommandText = "DELETE FROM EmployeesData  WHERE EmployeeID=@EmployeeID";

                // Add parameters to the command to prevent SQL injection
                MainForm.cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            
                MainForm.cmd.ExecuteNonQuery();

                // Clear parameters from the command object to prevent parameter reuse issues
                MainForm.cmd.Parameters.Clear();
                
                MainForm.con.Close();



                MessageBox.Show("Employee details has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
