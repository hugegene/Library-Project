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
    public partial class Manage_AddMembers : Form
    {
        SA45Team13bLibraryEntities context;
        LibraryMember m;
        public Manage_AddMembers()
        {
            InitializeComponent();
        }
        private void Confirm_Click_1(object sender, EventArgs e)
        {
            m = new LibraryMember();
            context = new SA45Team13bLibraryEntities();
            if (CustomerNameBox.Text == "" || AddressBox.Text == "" || DocumentNoBox.Text == "" || DocumentTypeBox.Text == "" || AgeBox.Text == "")
            {
                MessageBox.Show("Error!Please fill the blanks with (*).");
            }
            else if ( System.Text.RegularExpressions.Regex.IsMatch(AgeBox.Text,"[^0-9]"))
            {
                MessageBox.Show("Please enter correct age.");
            }
            else
            {
                m.CustomerName = CustomerNameBox.Text;
                m.Age =Int16.Parse(AgeBox.Text);
                m.Address = AddressBox.Text;
                m.PostalCode = PostalCodeBox.Text;
                m.DocumentNo = DocumentNoBox.Text;
                m.DocumentType = DocumentTypeBox.Text;
                m.PhoneNumber = PhoneNumberBox.Text;
                m.EmailAddress = EmailAddressBox.Text;
                m.AltPhoneNumber = AltPhoneNumberBox.Text;
                context.LibraryMembers.Add(m);
                context.SaveChanges();
                MessageBox.Show("Submit success!");
                Refresh();
                this.Close();
            }
        }


        private void AddMembers_Load_1(object sender, EventArgs e)
        {
            DocumentTypeBox.Items.Add("FIN");
            DocumentTypeBox.Items.Add("NRIC");
            DocumentTypeBox.Items.Add("PASSPORT");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
