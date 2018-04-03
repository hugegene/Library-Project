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
    public partial class Manage_MembersModify : Form
    {
        SA45Team13bLibraryEntities context;
        ManageMembers m;
        public Manage_MembersModify()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text == "" || textBox6.Text == "" || comboBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Error!Please fill the blanks with (*).");
            }
            else
            {
                context = new SA45Team13bLibraryEntities();
                int i = Int32.Parse(textBox1.Text);
                LibraryMember lb = new LibraryMember();
                lb = context.LibraryMembers.Where(x => x.CustomerID == i).First();
                lb.CustomerName = textBox2.Text;
                lb.Age = Int16.Parse(textBox3.Text);
                lb.Address = textBox4.Text;
                lb.PostalCode = textBox5.Text;
                lb.DocumentNo = textBox6.Text;
                lb.DocumentType = comboBox1.Text;
                lb.PhoneNumber = textBox8.Text;
                lb.EmailAddress = textBox9.Text;
                lb.AltPhoneNumber = textBox10.Text;
                context.SaveChanges();
                MessageBox.Show("Submit success!");
                this.Close();
            }


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            m = new ManageMembers();
            this.Close();
        }
    }
}
