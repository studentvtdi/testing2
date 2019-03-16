using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_and_merge_inside
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void callMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Youcalled yow = new Youcalled();
            //yow.Show();

            Youcalled insida = new Youcalled();
            insida.MdiParent = this;
            insida.Show();

        }
    }
}
