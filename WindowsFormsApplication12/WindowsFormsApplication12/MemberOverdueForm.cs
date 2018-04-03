using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class MemberOverdueForm : Form
    {
        public MemberOverdueForm()
        {
            InitializeComponent();
        }

        private void MemberOverdueForm_Load(object sender, EventArgs e)
        {
            Lib24Entities ctx = new Lib24Entities();

            var qryOverdue = from x in ctx.DueTrans select new
            {
                x.DueTranID,
                x.CustomerID,
                DueAmount = x.DueAmount?? 0,
                Remarks = x.Remarks?? "",
            };

            
            MembersOverdue crMO = new MembersOverdue();
            crMO.SetDataSource(qryOverdue);
            crystalReportViewer1.ReportSource = crMO;
        }
    }
}
