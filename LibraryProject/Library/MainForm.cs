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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }

        private void SubMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show this form when the other windows are closed
            this.Show();
        }

        private void ManageBooksButton_Click(object sender, EventArgs e)
        {
            // Instantiate a new Window
            ManageBooks manageBooksForm = new ManageBooks();
            manageBooksForm.IsLibrarian = true;

            // When the Manage Books form closes, Bring the Main window Back
            manageBooksForm.FormClosed += SubMenuForm_FormClosed;

            // Hide this form and Show the Manage Books Form
            this.Hide();
            manageBooksForm.Show();
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
           
            // Instantiate a new Window
            BorrowBooksRevised borrowBooksForm = new BorrowBooksRevised();

            // When the BorrowBooks form closes, Bring the Main window Back
            borrowBooksForm.FormClosed += SubMenuForm_FormClosed;

            // Hide this form and Show the Manage Books Form
            this.Hide();
            borrowBooksForm.Show();
            
        }

        private void ManageMembersButton_Click(object sender, EventArgs e)
        {
            ManageMembers managemembers = new ManageMembers();
            // When the Manage Books form closes, Bring the Main window Back
            managemembers.FormClosed += SubMenuForm_FormClosed;

            // Hide this form and Show the Manage Books Form
            this.Hide();
            managemembers.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            // Instantiate a new Window

            GenerateReports reportGenerator = new GenerateReports();

            // When the Manage Books form closes, Bring the Main window Back
            reportGenerator.FormClosed += SubMenuForm_FormClosed;

            // Hide this form and Show the Manage Books Form
            this.Hide();
            reportGenerator.Show();
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            // Instantiate a new Window
           
            ReturnBooks returnbooks = new ReturnBooks();

            // When the Manage Books form closes, Bring the Main window Back
            returnbooks.FormClosed += SubMenuForm_FormClosed;

            // Hide this form and Show the Manage Books Form
            this.Hide();
            returnbooks.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Close on Escape
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            // Manage Books
            else if (keyData == (Keys.Control | Keys.D1))
            {
                ManageBooksButton_Click(null, null);
            }
            // Manage Members
            else if (keyData == (Keys.Control | Keys.D2))
            {
                ManageMembersButton_Click(null, null);
            }
            // Borrow Books
            else if (keyData == (Keys.Control | Keys.D3))
            {
                BorrowBookButton_Click(null, null);
            }
            // Return Books
            else if (keyData == (Keys.Control | Keys.D4))
            {
                ReturnBookButton_Click(null, null);
            }
            // Reports
            else if (keyData == (Keys.Control | Keys.D5))
            {
                ReportsButton_Click(null, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
