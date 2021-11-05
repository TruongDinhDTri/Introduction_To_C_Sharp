using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdattbaleforth3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT", typeof(Int32));
            dt.Columns.Add("Tensanpham", typeof(string));
            dt.Columns.Add("SIZE", typeof(string));
            dt.Columns.Add("Giatien", typeof(Int32));
            dt.Columns.Add("Soluong", typeof(Int32));
            dt.Columns.Add("Giamgia", typeof(Int32));
            dt.Columns.Add("Thanhtien", typeof(string));
            dataGridView1.DataSource = dt;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt1 = dt.Clone();
            dataGridView2.DataSource = dt1;
        }
        int num = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(num, "dddd", "dddd", 45454, 4, 5, "ddsds");
            num++;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt1.ImportRow(dt.Rows[0]);
        }
    }
}
