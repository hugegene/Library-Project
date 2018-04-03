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
    public partial class GenerateReports : Form
    {
        SA45Team13bLibraryEntities ctx = new SA45Team13bLibraryEntities();
        public GenerateReports()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Generate overall book list grouped by Genre
        {
            var qrybooklist = from x in ctx.BookLists select x; //using all data in BookList table

            BookListByGenre crBG = new BookListByGenre();
            crBG.SetDataSource(qrybooklist);
            crystalReportViewer1.ReportSource = crBG;
        }

        private void genreBorrowTrend_btn_Click(object sender, EventArgs e) //Generate CrossTab report of Genre of books borrowed per month
        {
            var qryGenreTrend = from x in ctx.GenreBorrowViews select x; //pull data from created view GenreBorrowViews

            GenreBorrowTrend crGBT = new GenreBorrowTrend();
            crGBT.SetDataSource(qryGenreTrend);
            crystalReportViewer1.ReportSource = crGBT;
        }

        private void requestedBooks_btn_Click(object sender, EventArgs e) //Generate report of Requested Books 
        {
            var qryRequestedBooks = from x in ctx.BookRequesteds
                                    select new
                                    {
                                        x.RequestedBookTitle,
                                        x.RequestedBookAuthor,
                                        RequestedBookRemarks = x.RequestedBookRemarks ?? "", //replace null values of Remarks as empty string
                                    };

            RequestedBooksRpt crRB = new RequestedBooksRpt();
            crRB.SetDataSource(qryRequestedBooks);
            crystalReportViewer1.ReportSource = crRB;
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
