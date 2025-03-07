using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GrifindoToysPayrollSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
              

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter Password";
                return;
            }
            
            pnlErrorPass.Visible = false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Enter User Name";
                return;
            }
           
            pnlErrorUser.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123Abs@";


            if (txtUserName.Text.ToLower() != username && txtPassword.Text != password)
            {

                pnlErrorUser.Visible = true;
                pnlErrorPass.Visible = true;
                txtUserName.Focus();
                return;

            }
            else if (txtUserName.Text.ToLower() != username)
            {
                pnlErrorUser.Visible = true;
                txtUserName.Focus();
                return;
            }
            else if (txtPassword.Text != password)
            {
                pnlErrorPass.Visible = true;
                txtPassword.Focus();

                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("You have successfully logged in.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbHideShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;               
                picbHideShow.Image = Properties.Resources.pass_visible;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                picbHideShow.Image = Properties.Resources.pass_hide;
            }
        }

       
    }
}
