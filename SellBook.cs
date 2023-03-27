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
using BSM_DB.Entity;

namespace BSM
{
    public partial class SellBook : Form
    {
        int userID;
        public SellBook()
        {
            InitializeComponent();
            
            GenreDataAccess genreDataAccess = new GenreDataAccess();            
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;
            genreDataAccess = new GenreDataAccess();
            List<String> genres = genreDataAccess.GetAllGenreName();
            genres.Add("All genres");
            sortByGenreComboBox.DataSource = genres;
            sortByGenreComboBox.SelectedItem = "All genres";
            SyncData();
        }

        public SellBook(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;
            genreDataAccess = new GenreDataAccess();
            List<String> genres = genreDataAccess.GetAllGenreName();
            genres.Add("All genres");
            sortByGenreComboBox.DataSource = genres;
            sortByGenreComboBox.SelectedItem = "All genres";
            SyncData();
        }

        public void SyncData()
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            quantityTextBox.Text = "0";
            if (sortByGenreComboBox.Text == "All genres")
            {
                dataGridView1.DataSource = bookDataAccess.GetAllBooks();
            }
            else
            {
                GenreDataAccess genreDataAccess = new GenreDataAccess();
                dataGridView1.DataSource = bookDataAccess.GetBooksByGenre(genreDataAccess.GetGenreIdByName(sortByGenreComboBox.Text));
            }
        }

        public Invoice TextBoxToObj()
        {
            Invoice invoice = new Invoice();
            invoice.BookID = Convert.ToInt32(idTextBox.Text);
            invoice.Quantity = Convert.ToInt32(quantityTextBox.Text);
            invoice.SellDate = dateTimePickerDoB.Text;
            invoice.userID = userID;
            
            return invoice;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SellerDashboard(userID).Show();
        }

        private void SellBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sortByGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            idTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            BookNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            authorTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            genreComboBox.SelectedItem = genreDataAccess.GetGenreNameById(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            publicationTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (Convert.ToInt32(quantityTextBox.Text) > bookDataAccess.GetBookQuantity(idTextBox.Text))
            {
                bookDataAccess = new BookDataAccess();
                MessageBox.Show("Sell quantity can not be more then stock\nIn stock "+ bookDataAccess.GetBookQuantity(idTextBox.Text));
                quantityTextBox.Text = "0";
            }
            else if (Convert.ToInt32(quantityTextBox.Text) < 0)
            {
                bookDataAccess = new BookDataAccess();
                MessageBox.Show("Sell quantity can not be in the negative\nIn stock " + bookDataAccess.GetBookQuantity(idTextBox.Text));
                quantityTextBox.Text = "0";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Select book first");
            }
            else if (quantityTextBox.Text == "0")
            {
                MessageBox.Show("Quantity cannot be 0");
            }
            else
            {
                InvoiceDataAccess invoiceDataAccess = new InvoiceDataAccess();
                String flag = invoiceDataAccess.AddInvoice(TextBoxToObj());
                MessageBox.Show(flag);
                if(flag == "Invoice created successfully")
                {
                    BookDataAccess bookDataAccess = new BookDataAccess();
                    flag = bookDataAccess.SellBook(Convert.ToInt32(quantityTextBox.Text), idTextBox.Text);
                    MessageBox.Show(flag);
                }
                SyncData();
            }
        }
    }
}
