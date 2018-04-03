using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddNewBookForm : Form
    {
        public AddNewBookForm()
        {
            InitializeComponent();
        }

        private void AddNewBookForm_Load(object sender, EventArgs e)
        {
            SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();
            
            // ShelfComboBox
            ShelfComboBox.SelectedIndex = 0;
            ShelfComboBox.SelectedItem = ShelfComboBox.Items[0];
            
        }

        bool ValidateValues(out String err)
        {
            err = "";

            if (String.IsNullOrEmpty(TitleTextBox.Text) || TitleTextBox.Text.Length > 255)
            {
                err = "Enter Valid Title";
                return false;
            }

            if (String.IsNullOrEmpty(AuthorTextBox.Text) || AuthorTextBox.Text.Length > 50)
            {
                err = "Enter Valid Author";
                return false;
            }

            if (String.IsNullOrEmpty(PublisherTextBox.Text) || PublisherTextBox.Text.Length > 50)
            {
                err = "Enter Valid Publisher";
                return false;
            }

            // ISBN has a specific string size
            if (String.IsNullOrEmpty(ISBNTextBox.Text) || !ManageBooks.IsValidISBN(ISBNTextBox.Text))
            {
                err = "Enter Valid ISBN (Exactly 10/13 Digits)";
                return false;
            }

            if (String.IsNullOrEmpty(LanguageTextBox.Text) || LanguageTextBox.Text.Length > 13)
            {
                err = "Enter Valid Language";
                return false;
            }

            if (String.IsNullOrEmpty(GenreTextBox.Text) || GenreTextBox.Text.Length > 20)
            {
                err = "Enter Valid Genre";
                return false;
            }

            // No Negative Prices
            Double price;
            if (!Double.TryParse(BookCostTextBox.Text, out price) || price < 0)
            {
                err = "Enter Valid Price (Greater than or equal to 0)";
                return false;
            }

            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String errorMessage;

            // Get Entity Context
            SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();

            // Display error if values are invalid
            if (!ValidateValues(out errorMessage))
            {
                MessageBox.Show(errorMessage, "Unable to add new Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Continue to add book
            BookList book = new BookList();
            book.BookTitle = TitleTextBox.Text;
            book.Author = AuthorTextBox.Text;
            book.Publisher = PublisherTextBox.Text;
            book.ISBN = ISBNTextBox.Text;
            book.Loaned = 0;
            book.TotalStock = (short)StockNumericUpDown.Value;
            book.Language = LanguageTextBox.Text;
            book.Genre = GenreTextBox.Text;
            book.BookCost = (float)Double.Parse(BookCostTextBox.Text);
            if (ShelfComboBox.SelectedValue != null)
                book.Shelf = ShelfComboBox.SelectedValue.ToString();
            else
                book.Shelf = "1";

            context.BookLists.Add(book);
            context.SaveChanges();

            // Display message
            MessageBox.Show("Book Added Sucessfully");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
