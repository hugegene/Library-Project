using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Library
{
    public partial class AddMembers : Form
    {
        SA45Team13bLibraryEntities context;
        LibraryMember m;
        public AddMembers()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
           m = new LibraryMember();
            using (TransactionScope ts = new TransactionScope())
            {
                context = new SA45Team13bLibraryEntities();
               
                m.CustomerName = textBox2.Text;
                var k = Int16.Parse(textBox3.Text); 
                m.Age = Int16.Parse(textBox3.Text);
                m.Address = textBox4.Text;
                m.PostalCode = textBox5.Text;
                m.DocumentNo = textBox6.Text;
                m.DocumentType = comboBox1.Text;
                m.PhoneNumber = textBox8.Text;
                m.EmailAddress = textBox9.Text;
                m.AltPhoneNumber = textBox10.Text;
                
                context.LibraryMember.Add(m);
                context.SaveChanges();
                ts.Complete();
                MessageBox.Show("Submit success!");
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMembers_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("FIN");
            comboBox1.Items.Add("NRIC");
            comboBox1.Items.Add("PASSPORT");
        }
    }
}
