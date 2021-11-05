using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmatrenlop
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;
        Pen p1 = new Pen(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            LocationXY = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            
        }

       
   

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           

        }

        private void btnmauve_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
            p1.Color = colorDialog1.Color;
            
        }
        
        private void btnloadanhnen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog odl = new OpenFileDialog();
            if (odl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(odl.FileName);
                picboxprofileinside.Image = image;
                picboxprofileinside.SizeMode = PictureBoxSizeMode.Zoom;
               
            }

            picboxprofileinside.Location = new Point(Convert.ToInt32(textBox_x.Text),Convert.ToInt32(textBox_y.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
        }

        private void pnlpaint_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void radioButton_duongthang_CheckedChanged(object sender, EventArgs e)
        {
            
          
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null && radioButton_hinhchunhat.Checked == true)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
            }
        }
        private Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return rect;

        }
    }
}
