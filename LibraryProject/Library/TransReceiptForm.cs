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
    public partial class TransReceiptForm : Form
    {
        public TransReceiptForm()
        {
            InitializeComponent();
        }

        private void TransReceiptForm_Load(object sender, EventArgs e)
        {
            SA45Team13bLibraryEntities ctx = new SA45Team13bLibraryEntities();
            var maxTrans = ctx.BookIssueds.Max(x => x.TransactionNo); //pull data from max Transaction No.

            var qryReceipt1 = from x in ctx.BookIssueds
                              where x.TransactionNo == maxTrans
                              select new
                              {
                                  x.TransactionNo,
                                  x.ISBN,
                                  x.BookTitle,
                                  x.DateBorrow,
                                  x.DateDue,
                                  DateActualReturn = x.DateActualReturn ?? DateTime.MinValue,
                              };

            var qryReceipt2 = from x in ctx.IssueTrans where x.TransactionNo == maxTrans select x.CustomerID;
            int qryReceipt2CId = qryReceipt2.First(); //retrieve CustomerID that made latest transaction

            var qryReceipt3 = from x in ctx.LibraryMembers where x.CustomerID == qryReceipt2CId select x.CustomerName;
            string qryReceipt3CName = qryReceipt3.First(); //retreive CustomerName of made latest transaction

            TransReceipt crTR = new TransReceipt();
            crTR.SetDataSource(qryReceipt1);
            crTR.SetParameterValue("pMemberName", qryReceipt3CName);

            crystalReportViewer1.ReportSource = crTR;
        }
    }
}
