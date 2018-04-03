using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class BooksByGenre : Form
    {
        public BooksByGenre()
        {
            InitializeComponent();
        }

        private void BooksByGenre_Load(object sender, EventArgs e)
        {
            Lib24Entities ctx = new Lib24Entities();

            var qrybooklist = from x in ctx.BookLists select x;

            BookGenre crBG = new BookGenre();
            crBG.SetDataSource(qrybooklist);
            crystalReportViewer1.ReportSource = crBG;
        }
    }
}
