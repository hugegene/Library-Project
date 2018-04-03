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
    public partial class ManageMembers : Form
    {
        SA45Team13bLibraryEntities context;
        public string c;
        public int i = 0;
        public ManageMembers()
        {
            InitializeComponent();
            context = new SA45Team13bLibraryEntities();
            var qry = from x in context.LibraryMembers select new {x.CustomerID,x.CustomerName, x.Age, x.Address, x.PostalCode, x.DocumentNo, x.DocumentType, x.PhoneNumber, x.EmailAddress, x.AltPhoneNumber};
            dataGridView1.DataSource = qry.ToList();
        }

        private void Modify_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string[] sameAsDropDown = { "FIN", "NRIC", "PASSPORT" };
                Manage_MembersModify m = new Manage_MembersModify();
                m.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                m.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[2].Value == null)
                {
                    m.textBox3.Text = null;
                }
                else
                {
                    m.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                }
                m.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[4].Value == null)
                {
                    m.textBox5.Text = null;
                }
                else
                {
                    m.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
                m.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                for (int idx = 0; idx < sameAsDropDown.Length; idx++)
                {
                    if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == sameAsDropDown[idx])
                    {
                        m.comboBox1.SelectedIndex = idx;
                    }

                }
                m.comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[7].Value == null)
                {
                    m.textBox8.Text = null;
                }
                else
                {
                    m.textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                }
                if (dataGridView1.CurrentRow.Cells[8].Value == null)
                {
                    m.textBox9.Text = null;
                }
                else
                {
                    m.textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                }
                if (dataGridView1.CurrentRow.Cells[9].Value == null)
                {
                    m.textBox10.Text = null;
                }
                else
                {
                    m.textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                }

                m.ShowDialog();
                refresh();
            }

            else
            {
                MessageBox.Show("Please Search Member First");
                return;
            }
            }

    private void Add_Click(object sender, System.EventArgs e)
        {
            Manage_AddMembers a = new Manage_AddMembers();
            a.ShowDialog();
            refresh();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string xx = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                LibraryMember lb = context.LibraryMembers.Where(x => x.CustomerName == xx).First();
                context.LibraryMembers.Remove(lb);

                DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Success!");
                    context.SaveChanges();
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Please Search Member First");
                return;
            }
        }

        private void Search_Click(object sender, System.EventArgs e)
        {
            SA45Team13bLibraryEntities nm = new SA45Team13bLibraryEntities();
            var search = from x in nm.LibraryMembers where(x.CustomerID.ToString().Contains(SearchBox.Text) || x.CustomerName.ToString().Contains(SearchBox.Text)) select x;
            dataGridView1.DataSource = search.ToList();
        }

        private void Clear_Click(object sender, System.EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            dataGridView1.DataSource = null;
            SA45Team13bLibraryEntities lm = new SA45Team13bLibraryEntities();
            var qry = from x in context.LibraryMembers select new { x.CustomerID, x.CustomerName, x.Age, x.Address, x.PostalCode, x.DocumentNo, x.DocumentType, x.PhoneNumber, x.EmailAddress, x.AltPhoneNumber };
            dataGridView1.DataSource = qry.ToList();
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
