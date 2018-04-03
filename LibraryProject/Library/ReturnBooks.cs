using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Library
{
    public partial class ReturnBooks : Form
    {
       
        SA45Team13bLibraryEntities context = new SA45Team13bLibraryEntities();
        

        public ReturnBooks()
        {
            InitializeComponent();
            context = new SA45Team13bLibraryEntities();
            
        }

        //Refresh
        private void refresh()
        {
            dataGridView1.DataSource = null;
            SA45Team13bLibraryEntities lm = new SA45Team13bLibraryEntities();
            // Get Transactions which the CustomerID is involved in
            var query_getTransactionsrefresh = from x in lm.IssueTrans
                                        where x.CustomerID.ToString() == textBox1.Text
                                        select x.TransactionNo;

            // Get Books from Above Transactions Which are not returned
            var query_getBooksrefresh = from x in lm.BookIssueds
                                 where query_getTransactionsrefresh.ToList().Contains(x.TransactionNo)
                                 && x.DateActualReturn == null
                                 select new { x.ISBN, x.DateDue, x.BookTitle };

            // Display Books in Data Grid View
            dataGridView1.DataSource = query_getBooksrefresh.ToList();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
            

    }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Search_Click(object sender, EventArgs e)
        {
            BorrowBooks_SearchForCustomer searchCustforBook = new BorrowBooks_SearchForCustomer();

            if (searchCustforBook.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = searchCustforBook.CustomerID.ToString();
                // Get Transactions which the CustomerID is involved in
                var query_getTransactions = from x in context.IssueTrans
                                            where x.CustomerID.ToString() == textBox1.Text
                                            select x.TransactionNo;

                // Get Books from Above Transactions Which are not returned
                var query_getBooks = from x in context.BookIssueds
                                     where query_getTransactions.ToList().Contains(x.TransactionNo)
                                     && x.DateActualReturn == null
                                     select new { x.ISBN, x.DateDue, x.BookTitle };

                // Display Books in Data Grid View
                dataGridView1.DataSource = query_getBooks.ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BookIssued bookissue;
            BookList blist;
            DueTran dtran;

            String SelectedISBN;
            String SelectedTitle;

            // Get the Selected Row, if any
            if (dataGridView1.SelectedRows.Count != 0)
            {
                // Get the selected Row (There's only one)
                SelectedISBN = dataGridView1.SelectedRows[0].Cells["ISBNColumn"].Value.ToString();
                SelectedTitle = dataGridView1.SelectedRows[0].Cells["TitleColumn"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Search a Book First");
                return;
            }


            //Assign bookissue to the selected book in datagrid view
            string returnbook = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var selectedISBN = from x in context.BookIssueds where x.ISBN == returnbook select x;
            bookissue = selectedISBN.First();

            //Over Due Date           
            if (bookissue.DateDue < DateTime.Now)
            {
                var duetranupdate = from x in context.DueTrans
                                    where x.CustomerID.ToString() == textBox1.Text
                                    select x;
                dtran = duetranupdate.First();

                int payamount = 0;
                dtran.CustomerID = Int32.Parse(textBox1.Text);

                bookissue.DateActualReturn = DateTime.Now;
               
                TimeSpan noofDue = (DateTime.Now) - bookissue.DateDue;
                double noofDay = noofDue.TotalDays;

                //TimeSpan duedate = DateTime.Today - bookissue.DateDue;
                //MessageBox.Show(duedate.ToString());

                int overdate = (int)noofDay;
                if (overdate > 1)
                {
                    payamount = overdate;
                    dtran.DueAmount = payamount;
                }

                dtran.Remarks = "Find new; You are " + noofDay + "day late.";
                context.DueTrans.Add(dtran);

                var dateupdate = from x in context.BookIssueds where x.ISBN == returnbook select x;
                BookIssued bi = dateupdate.First();
                bi.DateActualReturn = DateTime.Now;

                MessageBox.Show("You are " + overdate + "days over due date!.. Pay Amount is: $"+payamount+"!");
                context.SaveChanges();
                refresh();
            }

            else
            {

                string returnbook1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var q = from x in context.BookLists where x.ISBN == returnbook1 select x;
                blist = q.ToList().First();
                blist.Loaned--;

                var dateupdate = from x in context.BookIssueds where x.ISBN == returnbook1 select x;
                BookIssued bi = dateupdate.First();
                bi.DateActualReturn = DateTime.Now;
                context.SaveChanges();
                MessageBox.Show("Thank You for Returning Your Book.");
                refresh();

            }
        }

        private void GetBookButton_Click(object sender, EventArgs e)
        {
            // Get Transactions which the CustomerID is involved in
            var query_getTransactions = from x in context.IssueTrans
                                        where x.CustomerID.ToString() == textBox1.Text
                                        select x.TransactionNo;

            // Get Books from Above Transactions Which are not returned
            var query_getBooks = from x in context.BookIssueds
                                 where query_getTransactions.ToList().Contains(x.TransactionNo)
                                 && x.DateActualReturn == null
                                 select new { x.ISBN, x.DateDue, x.BookTitle };

            // Display Books in Data Grid View
            dataGridView1.DataSource = query_getBooks.ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            String SelectedISBN;
            String SelectedTitle;

            // Get the Selected Row, if any
            if (dataGridView1.SelectedRows.Count != 0)
            {
                // Get the selected Row (There's only one)
                SelectedISBN = dataGridView1.SelectedRows[0].Cells["ISBNColumn"].Value.ToString();
                SelectedTitle = dataGridView1.SelectedRows[0].Cells["TitleColumn"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Search a Book First");
                return;
            }

            DueTran dd = new DueTran();
            dd.CustomerID = Int32.Parse(textBox1.Text);
            dd.DueAmount = 100;
            dd.Remarks = "You lost one book. So You have to pay $100.";
            context.DueTrans.Add(dd);

            BookList booklist;


            string returnbook1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var qq = from x in context.BookLists where x.ISBN == returnbook1 select x;
            booklist = qq.ToList().First();
            booklist.Loaned--;
            booklist.TotalStock--;
            var dateupdate = from x in context.BookIssueds where x.ISBN == returnbook1 select x;
            BookIssued bi = dateupdate.First();
            bi.DateActualReturn = DateTime.Now;
            context.SaveChanges();
            MessageBox.Show("We record U lost one book.");
            refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
    
}
