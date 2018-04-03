using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ModifyBookForm : Form
    {
        public SA45Team13bLibraryEntities context;
        public BookList SelectedBook;

        private ModifyBookForm()
        {
            InitializeComponent();
        }

        public ModifyBookForm(String ISBN, String Title)
        {
            InitializeComponent();

            context = new SA45Team13bLibraryEntities();
            SelectedBook =  context.BookLists.Single(
                book => book.ISBN == ISBN
                && book.BookTitle == Title
                );

            TitleTextBox.Text = SelectedBook.BookTitle;
            AuthorTextBox.Text = SelectedBook.Author;
            PublisherTextBox.Text = SelectedBook.Publisher;
            ISBNTextBox.Text = SelectedBook.ISBN;
            LanguageTextBox.Text = SelectedBook.Language;
            GenreTextBox.Text = SelectedBook.Genre;
            StockNumericUpDown.Value = SelectedBook.TotalStock;
            StockNumericUpDown.Minimum = SelectedBook.Loaned;
            BookCostTextBox.Text = SelectedBook.BookCost.ToString();
            ShelfComboBox.SelectedIndex = Int32.Parse(SelectedBook.Shelf) - 1;
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

            // ISBN has a specific check
            if (String.IsNullOrEmpty(ISBNTextBox.Text) || !ManageBooks.IsValidISBN(ISBNTextBox.Text) )
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

        private void ModifyBookForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            String errorMessage;

            // Display error if values are invalid
            if (!ValidateValues(out errorMessage))
            {
                MessageBox.Show(errorMessage, "Unable to modify Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Create the Connection (TODO : Get the connection string from elsewhere)
            String connectionString = "data source=(local);" 
                + "initial catalog=SA45Team13bLibrary;";

            // For Machines in the Lab (Hostname usually begins with "ISS")
            if (Environment.MachineName.StartsWith("ISS"))
            {
                connectionString += "User id=sa;"
                + "Password=Secret;";
            }
            // For 
            else
            {
                connectionString += "integrated security = SSPI;";
            }
                
            SqlConnection connection = new SqlConnection(connectionString);

            // Create the SQL Update Command
            SqlCommand cmd = new SqlCommand();
            String sqlQuery = "UPDATE BookList" 
                + " SET BookTitle=@Title,"
                + " Author=@Author,"
                + " Publisher=@Publisher,"
                + " ISBN=@ISBN,"
                + " Language=@Language,"
                + " Genre=@Genre,"
                + " TotalStock=@TotalStock,"
                + " Loaned=@Loaned,"
                + " BookCost=@BookCost"
                + " WHERE ISBN=@OldISBN AND BookTitle=@OldTitle";
            cmd.CommandText = sqlQuery;
            cmd.Connection = connection;

            // Display a message if update fails
            try
            {
                // Adding the parameters
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 254).Value = TitleTextBox.Text;
                cmd.Parameters.Add("@Author", SqlDbType.NVarChar, 49).Value = AuthorTextBox.Text;
                cmd.Parameters.Add("@Publisher", SqlDbType.NVarChar, 50).Value = PublisherTextBox.Text;
                cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 13).Value = ISBNTextBox.Text;
                cmd.Parameters.Add("@Language", SqlDbType.NVarChar, 13).Value = LanguageTextBox.Text;
                cmd.Parameters.Add("@Genre", SqlDbType.NVarChar, 20).Value = GenreTextBox.Text;
                cmd.Parameters.Add("@TotalStock", SqlDbType.SmallInt).Value = (short)StockNumericUpDown.Value;
                cmd.Parameters.Add("@Loaned", SqlDbType.SmallInt).Value = (short)StockNumericUpDown.Minimum;
                cmd.Parameters.Add("@BookCost", SqlDbType.Float).Value = Double.Parse(BookCostTextBox.Text);
                
                if (ShelfComboBox.SelectedValue != null)
                    cmd.Parameters.Add("@Shelf", SqlDbType.NVarChar, 50).Value = ShelfComboBox.SelectedValue.ToString();
                else
                    cmd.Parameters.Add("@Shelf", SqlDbType.NVarChar, 50).Value = "1";

                cmd.Parameters.Add("@OldISBN", SqlDbType.NVarChar, 13).Value = SelectedBook.ISBN;
                cmd.Parameters.Add("@OldTitle", SqlDbType.NVarChar, 254).Value = SelectedBook.BookTitle;

                connection.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("One or more fields violates database consistency" 
                    + Environment.NewLine + ex.Message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Close this form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
