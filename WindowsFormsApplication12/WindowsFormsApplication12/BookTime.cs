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
    public partial class BookTime : Form
    {
        public BookTime()
        {
            InitializeComponent();
        }

        private void BookTime_Load(object sender, EventArgs e)
        {
            Lib24Entities ctx = new Lib24Entities();

            var qrytime = from x in ctx.BookIssueds
                          select new
                          {
                              x.TransactionNo,
                              x.ISBN,
                              x.BookTitle,
                              x.DateBorrow,
                              x.DateDue,
                              DateActualReturn = x.DateActualReturn ?? DateTime.MinValue,
                          };

            BookBorrowTrend crBBT = new BookBorrowTrend();
            crBBT.SetDataSource(qrytime);
            crystalReportViewer1.ReportSource = crBBT;
        }
    }
}
