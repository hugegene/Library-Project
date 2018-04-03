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
    public partial class BorrowBooks_SearchForCustomer : Form
    {
        int customerID;

        SA45Team13bLibraryEntities context;
        public int CustomerID
        {
            get
            {
                return customerID;
            }
        }
        public BorrowBooks_SearchForCustomer()
        {
            InitializeComponent();
        }

        private void BorrowBooks_SearchForCustomer_Load(object sender, EventArgs e)
        {
            context = new SA45Team13bLibraryEntities();
            dataGridView1.DataSource = context.LibraryMembers.ToList();          


        }

        private void textBox1_TextChanged(object sender, EventArgs e) // search by customerName
        {
            
            dataGridView1.DataSource = context.LibraryMembers.Where(x => x.CustomerName.Contains(textBox1.Text)).ToList();
           
             
        }

        private void button1_Click(object sender, EventArgs e) 
        {
          
          
        }

        private void button2_Click(object sender, EventArgs e) 
        {
           
        }

        private void ChooseCustomerButton(object sender, EventArgs e) //choose customer
        {
            customerID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButtonn(object sender, EventArgs e) // cancel
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SearchByDocumentNo(object sender, EventArgs e) // search by NRIC/FIN
        {
            
            dataGridView1.DataSource = context.LibraryMembers.Where(x => x.DocumentNo.Contains(textBox2.Text)).ToList();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
