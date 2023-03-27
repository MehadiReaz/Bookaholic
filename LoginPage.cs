using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSM_DB.Operation;

namespace BSM
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void showpasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("Seller ID cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                int flag = userDataAccess.UserVerification(UserNameTextBox.Text, passwordTextBox.Text);
                if (flag == 0)
                {
                    MessageBox.Show("Incorrect ID or Password\nPlease try again with correct ID & Password", "Error",MessageBoxButtons.OKCancel);
                }
                else if (flag == 1)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (flag == 2)
                {
                    this.Hide();
                    new SellerDashboard(UserNameTextBox.Text).Show();
                }

            }
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
