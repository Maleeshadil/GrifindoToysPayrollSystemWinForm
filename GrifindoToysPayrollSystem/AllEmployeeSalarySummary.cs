using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class AllEmployeeSalarySummary : Form
    {
        public AllEmployeeSalarySummary()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeListView()
        {
            // Enable scroll bars by ensuring the Scrollable property is set to true
            lvAllEmpSalarySum.Scrollable = true;

            // Set the View property to Details, so the ListView shows columns
            lvAllEmpSalarySum.View = View.Details;

            // Enable full row select
            lvAllEmpSalarySum.FullRowSelect = true;

            // Enable grid lines
            lvAllEmpSalarySum.GridLines = true;

            // Enable owner-drawing for custom rendering
            lvAllEmpSalarySum.OwnerDraw = true;

            // Set custom header colors           
            lvAllEmpSalarySum.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(lvAllEmpSalarySum_DrawColumnHeader);
            lvAllEmpSalarySum.DrawItem += new DrawListViewItemEventHandler(lvAllEmpSalarySum_DrawItem);
            lvAllEmpSalarySum.DrawSubItem += new DrawListViewSubItemEventHandler(lvAllEmpSalarySum_DrawSubItem);

            // Clear existing columns
            lvAllEmpSalarySum.Columns.Clear();

            // Add required columns with precise widths
            lvAllEmpSalarySum.Columns.Add("EmpID", 100, HorizontalAlignment.Left);
            lvAllEmpSalarySum.Columns.Add("FullName", 250, HorizontalAlignment.Left);
            lvAllEmpSalarySum.Columns.Add("TotalNoPayValue", 250, HorizontalAlignment.Left);
            lvAllEmpSalarySum.Columns.Add("TotalBasePayValue", 250, HorizontalAlignment.Left);
            lvAllEmpSalarySum.Columns.Add("TotalGrossPayValue", 210, HorizontalAlignment.Left);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            GetAllEmpSalarySum();
        }

        private void GetAllEmpSalarySum()
        {
            try
            {
                lvAllEmpSalarySum.Items.Clear();

                // Clear existing data in the dataset if any
                if (MainForm.ds.Tables["EmpSalary"] != null)
                {
                    MainForm.ds.Tables["EmpSalary"].Clear();
                }
                MainForm.con.Open();
                string query = @"
                      SELECT
                      e.EmployeeID,
                      e.fullName,
                      SUM(s.NoPayValue) AS TotalNoPayValue,
                      SUM(s.BasePayValue) AS TotalBasePayValue,
                      SUM(s.GrossPayValue) AS TotalGrossPayValue
                      FROM EmpSalary s
                      JOIN
                      EmployeesData e ON s.EmployeeID=e.EmployeeID
                      WHERE                     
                      s.StartDate >= @StartDate AND s.EndDate <= @EndDate
                      GROUP BY 
                      e.EmployeeID, e.fullName
                ";
                MainForm.cmd.CommandText = query;
                MainForm.cmd.Parameters.AddWithValue("@StartDate", tbSalarySdate.Text);
                MainForm.cmd.Parameters.AddWithValue("@EndDate", tbSalaryEdate.Text);
                MainForm.da = new System.Data.SqlClient.SqlDataAdapter(MainForm.cmd);
                MainForm.da.Fill(MainForm.ds, "EmpSalary");
                MainForm.cmd.Parameters.Clear();
                MainForm.con.Close();

                if (MainForm.ds.Tables["EmpSalary"].Rows.Count > 0)
                {

                    // Loop through each row in the "EmpSalary" table
                    foreach (DataRow row in MainForm.ds.Tables["EmpSalary"].Rows)
                    {
                        string employeeID = row["EmployeeID"].ToString();
                        string empFullName = row["fullName"].ToString();
                        decimal totalNoPayValue = Convert.ToDecimal(row["TotalNoPayValue"]);
                        decimal totalBasePayValue = Convert.ToDecimal(row["TotalBasePayValue"]);
                        decimal totalGrossPayValue = Convert.ToDecimal(row["TotalGrossPayValue"]);

                        string totalnopayValueStr = totalNoPayValue.ToString("C", new CultureInfo("en-GB")).Replace("£", "£ ");
                        string totalbasePayVlutr = totalBasePayValue.ToString("C", new CultureInfo("en-GB")).Replace("£", "£ ");
                        string totalgrossPayValueStr = totalGrossPayValue.ToString("C", new CultureInfo("en-GB")).Replace("£", "£ ");

                        ListViewItem item = new ListViewItem(employeeID);
                        item.SubItems.Add(empFullName);
                        item.SubItems.Add(totalnopayValueStr);
                        item.SubItems.Add(totalbasePayVlutr);
                        item.SubItems.Add(totalgrossPayValueStr);
                        lvAllEmpSalarySum.Items.Add(item);

                    }
                }

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("An error occurred while loading employee data: " + ex);
            }

        }

        private void lvAllEmpSalarySum_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void lvAllEmpSalarySum_DrawItem(object sender, DrawListViewItemEventArgs e)
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

        private void lvAllEmpSalarySum_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Center-align text in subitems
            e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, Brushes.Black, e.SubItem.Bounds,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            e.DrawDefault = false;
        }
       

        private void tbSalarySdate_Validating(object sender, CancelEventArgs e)
        {

            ValidateInput(tbSalarySdate, lbIsValidSdate, Validator.IsValidDate, "Invalid date format.please enter in this format (MM/dd/yyy)");
        }

        private void tbSalaryEdate_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tbSalaryEdate, lbIsValidEdate, Validator.IsValidDate, "Invalid date format.please enter in this format (MM/dd/yyy)");

        }
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
        private void ValidateInput(TextBox textBox, Label errorLabel, Func<string, bool> validateMethod, string errorMessage)
        {
            while (!validateMethod(textBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = errorMessage;
                textBox.Focus();
                return;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
