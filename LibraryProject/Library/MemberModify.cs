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
    public partial class MemberModify : Form
    {
        SA45Team13bLibraryEntities context;
        ManageMembers m;
        public MemberModify()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            context = new SA45Team13bLibraryEntities();
            int i = Int32.Parse(textBox1.Text);
            LibraryMember lb = new LibraryMember();
            lb = context.LibraryMember.Where(x => x.CustomerID == i).First();
            lb.CustomerName = textBox2.Text;
            lb.Age = Int16.Parse(textBox3.Text);
            lb.Address = textBox4.Text;
            lb.PostalCode = textBox5.Text;
            lb.DocumentNo = textBox6.Text;
            lb.DocumentType = textBox7.Text;
            lb.PhoneNumber = textBox8.Text;
            lb.EmailAddress = textBox9.Text;
            lb.AltPhoneNumber = textBox10.Text;
            context.SaveChanges();
            MessageBox.Show("Submit success!");
            this.Close();
        }

        private void MemberModify_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            m = new ManageMembers();
            this.Close();
        }
    }
}
