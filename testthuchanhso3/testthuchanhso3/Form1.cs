using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testthuchanhso3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("Pie Chart ");

            
            
            chart1.Series["s1"].Points.AddXY(label7.Text, "15");
            chart1.Series["s1"].Points.AddXY("Đơn bị hủy", "34");
            chart1.Series["s1"].Points.AddXY("Đơn chưa thanh toán", "35");
            chart1.Series["s1"].Points.AddXY("Đơn đã thanh toán", "36");
            chart1.Series["s1"].Points.AddXY("Đơn đã giao", "36");
            chart1.Series["s1"].Points.AddXY("Đơn đang hoàn", "36");
            chart1.Series["s1"].Points.AddXY("Đơn đã hoàn", "36");


        }
       
        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
