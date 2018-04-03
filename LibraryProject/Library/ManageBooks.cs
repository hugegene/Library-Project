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
    public partial class ManageBooks : Form, BooksSearcher
    {
        UInt32 _booksFound;
        public UInt32 BooksFound
        {
            get
            {
                return _booksFound;
            }

            set
            {
                _booksFound = value;

                // Set the results string (FilterLabel)
                if (BooksFound > 0)
                {
                    FilterLabel.Text = BooksFound + " Books Found";
                    FilterLabel.Size = new Size(FilterLabel.Size.Width, 40);
                }
                else
                {
                    FilterLabel.Text = "No Books Found";
                    FilterLabel.Size = new Size(FilterLabel.Size.Width, 40);
                }
            }
        }
        List<BookList> FilteredBooks = new List<BookList>();

        public Boolean IsLibrarian
        {
            set
            {
                AddBookToolStripButton.Visible = value;
                ModifyBookToolStripButton.Visible = value;
                RequestToolStripButton.Visible = !value;
                DeleteBookToolStripButton.Visible = value;
                //this.FormBorderStyle = value ? this.FormBorderStyle : FormBorderStyle.None;
            }
        }

        public static bool IsValidISBN(string code)
        {
            if (code.Length != 10 && code.Length != 13)
            {
                return false;
            }

            // Simple ISBN Check (10 Digit)
            if (code.Length == 10)
            {
                int i, s = 0, t = 0;
                short digit;
                for (i = 0; i < code.Length; i++)
                {
                    if (!Int16.TryParse(code[i].ToString(), out digit))
                    {
                        if (i == 9 && code[i] == 'X')
                        {
                            digit = 10;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    t += digit;
                    s += t;
                }

                return (s % 11) == 0;
            }
            // Simple ISBN Check (13 Digit)
            else
            {
                int i, t = 0;
                short digit = 0;

                for (i = 0; i < code.Length - 1 ; i++)
                {
                    if (!Int16.TryParse(code[i].ToString(), out digit))
                    {
                        return false;
                    }
                    t += digit * (i % 2 == 0 ? 1 : 3);
                }

                // Read the last digit
                if (!Int16.TryParse(code[i].ToString(), out digit))
                {
                    return false;
                }

                if ((10 - (t % 10)) < 10)
                {
                    return ((10 - (t % 10)) == digit);
                }
                else if ((10 - (t % 10)) == 10)
                {
                    return ((10 - (t % 10)) == 0);
                }
                else
                {
                    return false;
                }
            }
        }

        public ManageBooks()
        {
            InitializeComponent();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();

            // Disable Column Generation
            BooksDataGridView.AutoGenerateColumns = false;

            // Update DropDowns
            UpdateDropDowns();

            // Set Genre boxes
            LanguageComboBox.SelectedIndex = 0;
            GenreComboBox.SelectedIndex = 0;

            // Set the Label
            BooksFound = 0;

            // Display all the books
            FilterBooks(TitleTextBox.Text, AuthorTextBox.Text, ISBNTextBox.Text,
                PublisherTextBox.Text, LanguageComboBox.SelectedItem.ToString(),
                GenreComboBox.SelectedItem.ToString());
        }

        void FilterBooks(String title, String author, String isbn, String publisher, String language, String genre)
        {
            // Get Entity Context
            SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();

            // Get Filtered Books
            FilteredBooks = context.BookLists.Where(
                book => book.BookTitle.Contains(title)
                && book.Author.Contains(author)
                && book.ISBN.Contains(isbn)
                && book.Publisher.Contains(publisher)
                && language == "All" ? true : (book.Language == language)
            ).ToList();
            
            // Genre Check
            if (genre != "All")
            {
                FilteredBooks = FilteredBooks.Where(book => book.Genre == genre).ToList();
            }

            // Available books Check
            if (AvailableBooksOnlyCheckBox.Checked)
            {
                FilteredBooks = FilteredBooks.Where(book => book.TotalStock != book.Loaned).ToList();
            }

            // Get Number of Books
            BooksFound = (UInt32)FilteredBooks.Count;

            // Update Datagrid View with elements from first page
            BooksDataGridView.DataSource = FilteredBooks;
        }

        public DialogResult SearchForBookID(out String ISBN)
        {
            String SelectedISBN = "";

            // Setup the form
            IsLibrarian = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.FormClosed += ManageBooks_FormClosed;
            this.CancelSearchToolStripButton.Visible = true;
            this.UseSelectedToolStripButton.Visible = true;

            // Show the form
            if (this.ShowDialog() == DialogResult.OK)
            {
                // Get the selected Row (There's only one)
                SelectedISBN = BooksDataGridView.SelectedRows[0].Cells["ISBNColumn"].Value.ToString();
            }

            // Return the result
            ISBN = SelectedISBN;

            return String.IsNullOrEmpty(SelectedISBN) ? DialogResult.None : DialogResult.OK;
        }

        private void ManageBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (BooksDataGridView.SelectedRows.Count == 0)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }


            this.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void BooksDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }

        private void CancelSearchToolStripButton_Click(object sender, EventArgs e)
        {
            BooksDataGridView.ClearSelection();
            this.Close();
            this.Visible = false;
        }

        private void UseSelectedToolStripButton_Click(object sender, EventArgs e)
        {
            if (BooksDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row from the Table. Use the Filters to Find Books.");
            }
            else
            {
                this.Close();
            }
        }

        private void AddBookToolStripButton_Click(object sender, EventArgs e)
        {
            // Display Form
            if (new AddNewBookForm().ShowDialog() == DialogResult.OK)
            {
                // Update Dropdowns
                UpdateDropDowns();

                // Refresh Display 
                RefreshDisplay();
            }
        }

        private void UpdateDropDowns()
        {
            // Get Entity Context
            SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();

            // Fill LanguageComboBox and select all
            LanguageComboBox.Items.Clear();
            LanguageComboBox.Items.Add("All");
            LanguageComboBox.Items.AddRange(context.BookLists
                .Select(book => book.Language)
                .Distinct().ToArray());


            // Fill GenreComboBox
            GenreComboBox.Items.Clear();
            GenreComboBox.Items.Add("All");
            GenreComboBox.Items.AddRange(context.BookLists
                .Select(book => book.Genre)
                .Distinct().ToArray());
        }

        private void ModifyBookToolStripButton_Click(object sender, EventArgs e)
        {
            String SelectedISBN;
            String SelectedTitle;

            // Get the Selected Row, if any
            if (BooksDataGridView.SelectedRows.Count != 0)
            {
                // Get the selected Row (There's only one)
                SelectedISBN = BooksDataGridView.SelectedRows[0].Cells["ISBNColumn"].Value.ToString();
                SelectedTitle = BooksDataGridView.SelectedRows[0].Cells["TitleColumn"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Select a Book First");
                return;
            }

            // Display Form
            if (new ModifyBookForm(SelectedISBN, SelectedTitle).ShowDialog() == DialogResult.OK)
            {
                // Update Dropdowns
                UpdateDropDowns();

                // Refresh Display 
                RefreshDisplay();
            }
        }

        private void RefreshDisplay()
        {
            FilterBooks(
                TitleTextBox.Text,
                AuthorTextBox.Text,
                ISBNTextBox.Text,
                PublisherTextBox.Text,
                LanguageComboBox.SelectedItem == null ? "All" : LanguageComboBox.SelectedItem.ToString(),
                GenreComboBox.SelectedItem == null ? "All" : GenreComboBox.SelectedItem.ToString()
                );
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String SelectedShelf;
            // Get the Selected Row, if any
            if (BooksDataGridView.SelectedRows.Count != 0)
            {
                // Get the selected Row (There's only one)
                SelectedShelf = BooksDataGridView.SelectedRows[0].Cells["ShelfColumn"].Value.ToString();
                new QueryForBooksForm(Convert.ToInt32(SelectedShelf));
            }
            else
            {
                MessageBox.Show("Please Select a Book First");
                return;
            }
        }

        private void RequestToolStripButton_Click(object sender, EventArgs e)
        {
            new RequestBookForm().ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            AuthorTextBox.Text = "";
            ISBNTextBox.Text = "";
            PublisherTextBox.Text = "";
            LanguageComboBox.SelectedIndex = 0;
            GenreComboBox.SelectedIndex = 0;
            AvailableBooksOnlyCheckBox.Checked = false;
            RefreshDisplay();
        }

        private void DeleteBookToolStripButton_Click(object sender, EventArgs e)
        {
            SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();
            BookList bookToBeDeleted;

            int loaned;
            String selectedISBN;
            // Get the Selected Row, if any
            if (BooksDataGridView.SelectedRows.Count != 0)
            {
                // Get the selected Row (There's only one)
                loaned = Convert.ToInt32(BooksDataGridView.SelectedRows[0].Cells["LoanedColumn"].Value.ToString());
                selectedISBN = BooksDataGridView.SelectedRows[0].Cells["ISBNColumn"].Value.ToString();

                // Can't delete book which is still loaned out
                if (loaned == 0)
                {
                    // Confirm Deletion, otherwise cancel
                    if (MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo)
                            == DialogResult.No)
                    {
                        return;
                    }

                    // Delete the book
                    bookToBeDeleted = context.BookLists.Where(book => book.ISBN == selectedISBN).First();
                    context.BookLists.Remove(bookToBeDeleted);

                    context.SaveChanges();

                    // Refresh the display
                    RefreshDisplay();
                }
                else
                {
                    MessageBox.Show("Please Return All Loaned Books First");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Book First");
                return;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}