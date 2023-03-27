using System;
using System.Windows.Forms;

namespace BSM
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageSellerAdmin().Show();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new Books("admin").Show();
        }

        private void SoldBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SoldBooks().Show();
        }

        private void AddSellerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditAdmin().Show();
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

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
