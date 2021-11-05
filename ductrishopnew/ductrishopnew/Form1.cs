using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ductrishopnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnmen_Click(object sender, EventArgs e)
        {
            pnlmen.Visible = true;
        }

        private void btnmennewestsneaker_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
