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
   
    public partial class BorrowBooksRevised : Form
    {
        SA45Team13bLibraryEntities context;
        LibraryMember lM;
        List<BookList> bL;
        BookList book;
        string BorrowSucessfulMessage = "These books are borrowed:\tDue on:\n";

        public BorrowBooksRevised()
        {
            InitializeComponent();
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e) //CustomerID textBox changed
        {
            textBox2.Text = null;

            List<int> IDList = context.LibraryMembers.Select(x => x.CustomerID).ToList();
            foreach (int i in IDList)
            {
                if (i.ToString() == textBox1.Text)
                {
                    lM = context.LibraryMembers.Where(x => x.CustomerID == i).First();
                    textBox2.Text = lM.CustomerName;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Borrow button
        {
            if (textBox2.Text == "") // validate: check for no selected customer 
            {
                MessageBox.Show("No customer account selected");
            }
            else if (dataGridView1.DataSource == null) // validate: check for no selected books
            {
                MessageBox.Show("No books are selected for borrowing");
            }
            else
            {
                try
                {
                    Boolean IssueSucess = false;
                    using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
                    {
                        // update IssueTrans
                        IssueTran IT = new IssueTran();

                        IT.CustomerID = Convert.ToInt32(textBox1.Text);
                        context.IssueTrans.Add(IT);
                        context.SaveChanges();

                        // update booklist and BookIssued
                        foreach (BookList b in bL)
                        {
                            b.Loaned++;

                            BookIssued BI = new BookIssued();
                            BI.TransactionNo = IT.TransactionNo;
                            BI.ISBN = b.ISBN;
                            BI.BookTitle = b.BookTitle;
                            BI.DateBorrow = DateTime.Now.Date;
                            BI.DateDue = DateTime.Now.Date.AddDays(14);
                            context.BookIssueds.Add(BI);
                            BorrowSucessfulMessage += string.Format("{0}\t\t{1}\n", b.BookTitle.PadRight(20).Substring(0,20), BI.DateDue);
                        }
                        context.SaveChanges();
                        ts.Complete();
                        
                        MessageBox.Show(BorrowSucessfulMessage);

                        IssueSucess = true;                      
                    }

                    if (IssueSucess)
                    {
                        new TransReceiptForm().ShowDialog();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //ISBN textBox changed
        {
            textBox4.Text = null;

            List<string> ISBNList = context.BookLists.Select(x => x.ISBN).ToList();
            foreach (string ISBN in ISBNList)
            {
                if (ISBN == textBox3.Text)
                {
                    book = context.BookLists.Where(x => x.ISBN == ISBN).First();
                    textBox4.Text = book.BookTitle;
                }
            }
        }
        bool CheckForDoubleBooking() 
        {
            if (dataGridView1.RowCount != 0) 
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[3].Value.ToString() == textBox3.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool CheckForbookAvaliablity() 
        {
            if (book.Loaned == book.TotalStock || book.Loaned > book.TotalStock)
            {
                return false;
            }
            else return true;
        }
        

        private void AddButton(object sender, EventArgs e) // Add button
        {
            if (textBox4.Text == "") //validate: check for selected books
            {
                MessageBox.Show("No Books are chosen");
            }
            
            else if (!CheckForbookAvaliablity()) //validate: check if books is availiable
            {
                MessageBox.Show("Please wait for books to be returned");
            }
           
            else if (CheckForDoubleBooking()) //checking for booking of the same book more than once
            {
                MessageBox.Show("You cannot borrow the same book more than 1 time");
            }
            else 
            {
                bL.Add(book);
                dataGridView1.DataSource = bL.ToList();

            }
        }

        private void RemoveButton(object sender, EventArgs e) // Remove button
        {
            if (dataGridView1.DataSource != null)
            {
               
                bL.Remove(dataGridView1.CurrentRow.DataBoundItem as BookList);
                dataGridView1.DataSource = bL.ToList();
            }
            else
            {
                MessageBox.Show("No books selected yet");
            }
        }
        
        private void CancelButtonn(object sender, EventArgs e) //cancel button
        {
            this.Close();
        }

        private void SearchForBooksButton(object sender, EventArgs e) //Search for Books
        {
            string ISBNCode;
            BooksSearcher bs = new ManageBooks();

            if (bs.SearchForBookID(out ISBNCode) == DialogResult.OK)
            {
                textBox3.Text = ISBNCode;
            }
        }

        private void BorrowBooksRevised_Load(object sender, EventArgs e)
        {
            context = new SA45Team13bLibraryEntities();
            bL = new List<BookList>();
        }

        private void SearchForCustomerButton(object sender, EventArgs e) // search for customers
        {
            BorrowBooks_SearchForCustomer searchCust = new BorrowBooks_SearchForCustomer();

            if (searchCust.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = searchCust.CustomerID.ToString(); 
                
            }
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    public interface BooksSearcher
    {
        DialogResult SearchForBookID(out string ISBN); // open up new GUI, return an ISBN code
    }

}
