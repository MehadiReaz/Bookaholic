using BSM_DB.Entity;
using BSM_DB.Operation;
using System;
using System.Windows.Forms;

namespace BSM
{
    public partial class ManageSellerEmp : Form
    {
        int userID;
        public ManageSellerEmp()
        {
            InitializeComponent();
        }
        public ManageSellerEmp(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            SyncData();
        }
        public void SyncData()
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            User user = userDataAccess.GetUserById(userID);
            idTextBox.Text = user.Id.ToString();
            nameTextBox.Text = user.Name.ToString();
            userNameTextBox.Text = user.UserName.ToString();
            emailTextBox.Text = user.Email.ToString();
            passwordTextBox.Text = user.Password.ToString();
            dateTimePickerDoB.Text = user.DoB.ToString();
            comboBoxBloodGroup.SelectedItem = user.BloodGroup.ToString();
            if (user.Gender=="Male")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SellerDashboard(userID).Show();
        }
        private void ManageSellerEmp_Load(object sender, EventArgs e)
        {
            
        }
        private void ManageSellerEmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            User user = new User();
            user.Id = Convert.ToInt32(idTextBox.Text);
            user.Name = nameTextBox.Text;
            user.UserName = userNameTextBox.Text;
            user.Email = emailTextBox.Text;
            user.Password = passwordTextBox.Text;
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
            userDataAccess = new UserDataAccess();
            String flag = userDataAccess.UpdateUserSelf(user);
            MessageBox.Show(flag);
            SyncData();
        }
        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if (userDataAccess.UserNameExists(userNameTextBox.Text,userID) == true)
            {
                MessageBox.Show("This username already exists\nPlease try another username");
                SyncData();
            }
        }
    }
}
