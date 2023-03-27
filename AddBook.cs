using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSM_DB.Entity;
using BSM_DB.Operation;

namespace BSM
{
    public partial class AddBook : Form
    {
        int userID;
        public AddBook()
        {
            InitializeComponent();
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;
            SyncData();
        }

        public void SyncData()
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            dataGridView1.DataSource = bookDataAccess.GetAllBooks();
        }

        public bool validation()
        {            
            
            if (bookNameTextBox.Text == "")
            {
                MessageBox.Show("Book Name cannot be empty");
                return false;
            }
            else if (authorTextBox.Text == "")
            {
                MessageBox.Show("Author cannot be empty");
                return false;
            }
            else if (genreComboBox.Text == "")
            {
                MessageBox.Show("please select genre");
                return false;
            }
            else if (publicationTextBox.Text == "")
            {
                MessageBox.Show("publication cannot be empty");
                return false;
            }
            else if (quantityTextBox.Text == "")
            {
                MessageBox.Show("quantity cannot be empty");
                return false;
            }
            else if (priceTextBox.Text == "")
            {
                MessageBox.Show("price cannot be empty");
                return false;
            }
            return true;
        }

        public Book GetTextBoxToBookObj()
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            Book book = new Book();
            if (idTextBox.Text != "")
            {
                book.BookId = Convert.ToInt32(idTextBox.Text);
            }
            book.BookName = bookNameTextBox.Text;
            book.Author = authorTextBox.Text;
            book.Genre = genreDataAccess.GetGenreIdByName(genreComboBox.Text).ToString();
            book.Publication = publicationTextBox.Text;
            book.Price = Convert.ToInt32(priceTextBox.Text);
            book.Quantity = Convert.ToInt32(quantityTextBox.Text);

            return book;
        }

        public AddBook(int userID)
        {
            InitializeComponent();
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            genreComboBox.DataSource = genreDataAccess.GetAllGenreName();
            genreComboBox.SelectedItem = null;
            this.userID = userID;
            SyncData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SellerDashboard(userID).Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (validation() == true && bookDataAccess.BookExists(GetTextBoxToBookObj()) == false)
            {
                bookDataAccess = new BookDataAccess();
                String flag = bookDataAccess.AddNewBook(GetTextBoxToBookObj());
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            idTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            bookNameTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            authorTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            genreComboBox.SelectedItem = genreDataAccess.GetGenreNameById(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            publicationTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            quantityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (validation() == true && idTextBox.Text!="")
            {
                bookDataAccess = new BookDataAccess();
                String flag = bookDataAccess.UpdateBook(GetTextBoxToBookObj());
                MessageBox.Show(flag);
                SyncData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            BookDataAccess bookDataAccess = new BookDataAccess();
            if (validation() == true && bookDataAccess.BookExists(GetTextBoxToBookObj()) == true)
            {
                bookDataAccess = new BookDataAccess();
                String flag = bookDataAccess.deleteBook(idTextBox.Text);
                MessageBox.Show(flag);
                SyncData();
            }
            else
            {
                MessageBox.Show("this book does not exist");
            }
        }
    }
}
