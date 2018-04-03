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
    public partial class QueryForBooksForm : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        PictureBox[] pics;
        
        PictureBox selectedShelf;
        int shelfNum = 5;

        

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (selectedShelf != null)
            {
                selectedShelf.Visible = !selectedShelf.Visible;
            }
            else
            {
                myTimer.Stop();
                MessageBox.Show("No shelves information are stored");
            }
        }

        public QueryForBooksForm()
        {
            InitializeComponent();
        }

        public QueryForBooksForm(int shelfNum) : this()
        {
            pics = new PictureBox[]{ pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10};
            this.shelfNum = shelfNum;
            this.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void QueryForBooksForm_Load(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 200;
            myTimer.Start();

            selectedShelf = pics[shelfNum - 1];

            foreach (PictureBox p in this.panel1.Controls)
            {
                p.Visible = false;
            }

        }

       

        private void toolStripButton1_Click(object sender, EventArgs e) // back button
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
