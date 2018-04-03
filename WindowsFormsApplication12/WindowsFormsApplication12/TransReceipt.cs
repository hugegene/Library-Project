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
    public partial class TransReceipt : Form
    {
        public TransReceipt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lib24Entities ctx = new Lib24Entities();
            var maxTrans = ctx.BookIssueds.Max(x => x.TransactionNo);
            var qryReceipt1 = from x in ctx.BookIssueds where x.TransactionNo == maxTrans select new
            {
                x.TransactionNo,
                x.ISBN,
                x.BookTitle,
                x.DateBorrow,
                x.DateDue,
                DateActualReturn = x.DateActualReturn ?? DateTime.MinValue,
            };
            var qryReceipt2 = from x in ctx.IssueTrans where x.TransactionNo == maxTrans select x.CustomerID;
            int qryReceipt2CId = qryReceipt2.First();

            var qryReceipt3 = from x in ctx.LibraryMembers where x.CustomerID == qryReceipt2CId select x.CustomerName;
            string qryReceipt3CName = qryReceipt3.First();

            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(qryReceipt1);
            cr1.SetParameterValue("pMemberName", qryReceipt3CName);
            
            crystalReportViewer1.ReportSource = cr1; //CrystalReport3 TransactionReceipt
        }
    }
}
