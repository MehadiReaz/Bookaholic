using System;
using System.Windows.Forms;

namespace BSM
{
    public partial class AddSeller : Form
    {
        public AddSeller()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void AddSeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
