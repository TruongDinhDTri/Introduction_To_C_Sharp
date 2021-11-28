using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANC_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_click_panelDashBoard_form1_home_Click(object sender, EventArgs e)
        {

        }

        private void panelGroups_form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button_click_panelFunction_form1_groups_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void button_click_panelFunction_form1_chat_MouseEnter(object sender, EventArgs e)
        {
            panelChat_form1.Visible = true;
        }
        
        int chat = 0;
        private void button_click_panelFunction_form1_groups_Click(object sender, EventArgs e)
        {
            

        }
        private void button_click_panelFunction_form1_chat_Click(object sender, EventArgs e)
        {
            if (chat % 2 == 0)
            {
                panelChat_form1.Visible = true;
                chat++;
            }
            else if (chat % 2 != 0)
            {

                panelChat_form1.Visible = false;
                chat++;
            }
        }

        private void pictureBox_click_flowLayoutPanelmain_form1_hinh1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }
    }
}
