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
    public partial class SoldBooks : Form
    {
        private String userType;
        private int userID;
        public SoldBooks()
        {
            InitializeComponent();
        }

        public SoldBooks(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            UserDataAccess userDataAccess = new UserDataAccess();
            sortByUserNameComboBox.Text = userDataAccess.GetUserById(userID).UserName;
            sortByUserNameComboBox.Enabled = false;
            SyncData();
        }

        public void SyncData()
        {
            if(sortByUserNameComboBox.Text == "All Sellers")
            {
                InvoiceDataAccess invoiceDataAccess = new InvoiceDataAccess();
                sortByUserNameDataGridView.DataSource = invoiceDataAccess.GetAllInvoice();
            }
            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                int id = userDataAccess.GetUserIdByUserName(sortByUserNameComboBox.Text);

                InvoiceDataAccess invoiceDataAccess = new InvoiceDataAccess();
                sortByUserNameDataGridView.DataSource = invoiceDataAccess.GetInvoiceBySellerId(id);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (userType == "admin")
            {
                this.Hide();
                new AdminDashboard().Show();
            }
            else
            {
                this.Hide();
                new SellerDashboard(userID).Show();
            }
        }
        public SoldBooks(string userType)
        {
            InitializeComponent();
            this.userType = userType;
            UserDataAccess userDataAccess = new UserDataAccess();
            List<string> userNames = userDataAccess.GetAllSellerUsersNames();
            userNames.Add("All Sellers");
            sortByUserNameComboBox.DataSource = userNames;
            sortByUserNameComboBox.SelectedItem = "All Sellers";
            SyncData();

        }

        private void SoldBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sortByUserNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncData();
        }
    }
}
