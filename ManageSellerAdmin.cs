using BSM_DB.Entity;
using BSM_DB.Operation;
using System;
using System.Windows.Forms;

namespace BSM
{
    public partial class ManageSellerAdmin : Form
    {
        String password;
        public ManageSellerAdmin()
        {
            InitializeComponent();
            SyncData();
        }

        public void SyncData()
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            dataGridView1.DataSource = userDataAccess.GetAllSellerUsers();
            dataGridView1.Columns[4].Visible = false;
        }

        public User TextBoxToObj(string type)
        {
            User user = new User();
            user.Id = Convert.ToInt32(idTextBox.Text);
            user.Name = nameTextBox.Text;
            user.UserName = userNameTextBox.Text;
            user.Email = emailTextBox.Text;
            if (type == "update")
            {
                user.Password = password;
            }
            else
            {
                user.Password = passwordTextBox.Text;
            }
            user.DoB = dateTimePickerDoB.Text;
            user.BloodGroup = comboBoxBloodGroup.Text;
            if (radioButtonMale.Checked == true)
            {
                user.Gender = "Male";
            }
            else
            {
                user.Gender = "Female";
            }
            user.UserType = "seller";
            return user;
        }

        private void ManageSellerAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            userNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            password = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePickerDoB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBoxBloodGroup.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Please select a user first");
            }
            else if (userDataAccess.UserNameExists(userNameTextBox.Text, Convert.ToInt32(idTextBox.Text)) == true)
            {
                MessageBox.Show("This username already exists\nPlease try another username");               
            }
            else
            {
                userDataAccess = new UserDataAccess();
                String flag = userDataAccess.UpdateUser(TextBoxToObj("update"));
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Please select a user first");
            }
            else if (userDataAccess.UserExists(Convert.ToInt32(idTextBox.Text)) == false)
            {
                MessageBox.Show("This user does not exists");
            }
            else
            {
                userDataAccess = new UserDataAccess();
                String flag = userDataAccess.DeleteUser(idTextBox.Text);
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (userDataAccess.UserNameExists(userNameTextBox.Text) == true)
            {
                MessageBox.Show("This username already exists\nPlease try another username");
            }
            else
            {
                userDataAccess = new UserDataAccess();
                String flag = userDataAccess.AddNewUser(TextBoxToObj("Add"));
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
    }
}
