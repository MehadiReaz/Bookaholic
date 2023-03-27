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
    public partial class Books : Form
    {
        int userID;
        private String userType;
        public Books()
        {
            InitializeComponent();
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            List<String> genres = genreDataAccess.GetAllGenreName();
            genres.Add("All genres");
            genreComboBox.DataSource = genres; 
            genreComboBox.SelectedItem = "All genres";
            SyncData();
        }

        public void SyncData()
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (genreComboBox.Text == "All genres")
            {                
                AvailableBooksDataGridView.DataSource = bookDataAccess.GetAllBooks();
            }
            else
            {
                GenreDataAccess genreDataAccess = new GenreDataAccess();
                AvailableBooksDataGridView.DataSource = bookDataAccess.GetBooksByGenre(genreDataAccess.GetGenreIdByName(genreComboBox.Text));
            }
        }

        public Books(int userID)
        {
            InitializeComponent();
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;
            SyncData();
            this.userID = userID;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (userType=="admin")
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
        public Books(string userType)
        {
            InitializeComponent();
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;
            SyncData();
            this.userType = userType;
        }

        

        private void Books_Load(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            AvailableBooksDataGridView.DataSource = bookDataAccess.GetAllBooks();
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncData();
        }
    }
}
