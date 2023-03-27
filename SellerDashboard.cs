using BSM_DB.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSM
{
    public partial class SellerDashboard : Form
    {
        int userID;
        public SellerDashboard()
        {
            InitializeComponent();
        }

        public SellerDashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;          
            
        }

        public SellerDashboard(string userName)
        {
            InitializeComponent();
            UserDataAccess userDataAccess = new UserDataAccess();
            this.userID = userDataAccess.GetUserIdByUserName(userName);
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Books().Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddBook(userID).Show();
        }

        private void SellBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SellBook(userID).Show();
        }

        private void SoldBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SoldBooks().Show();
        }

        private void EditSellerInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageSellerEmp(userID).Show();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" MEHADI HASAN REAZ             ID: 20-42841-1\n FAHMIDA HOSSAIN LIANA      ID: 19-39485-1 \n MD. MAHEDI HASAN               ID: 19-41166-2", "TASK COMPLETED BY:", MessageBoxButtons.OK);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

        private void SellerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
