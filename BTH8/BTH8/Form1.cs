using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH8
{
    public partial class Form1 : Form
    {
        Rectangle rect;
       
        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;
        int line1, line2, line3, line4;
        Pen pen = new Pen(Color.Blue,3);
        SolidBrush brush1 = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LocationXY = e.Location;
            line1 = LocationXY.X;
            line2 = LocationXY.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(IsMouseDown==true)
            {
                LocationX1Y1 = e.Location;
                line3 = LocationX1Y1.X;
                line4 = LocationX1Y1.Y;
                Refresh();
            }
        }
        int s1, s2;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsMouseDown==true)
            {
                LocationX1Y1 = e.Location;
                s1 = LocationX1Y1.X;
                s2 = LocationX1Y1.Y;
                IsMouseDown = false;
            }
        }

        private void btnloadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog odl = new OpenFileDialog();
            if (odl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(odl.FileName);
               pictureBox1.Image = image;
               
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                
            }
            pictureBox1.Location = new Point(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_y.Text));
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
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pen.Width = Convert.ToInt32(numpensize.Text);
            if (radioButton_line.Checked == true)
            {
                e.Graphics.DrawLine(pen, line1, line2, line3, line4);
            }
            else if (rect != null && radioButton_Rectangle.Checked == true)
            {
                e.Graphics.DrawRectangle(pen, GetRect());

            }
            else if (rect != null && radioButton_FilRectangle.Checked == true)
            {
                e.Graphics.FillRectangle(brush1, GetRect());
            }
            else if (rect != null && radioButton_Elipse.Checked == true)
            {
                e.Graphics.DrawEllipse(pen, GetRect());
            }
            else if (rect != null && radioButton_FillElipse.Checked == true)
            {
                e.Graphics.FillEllipse(brush1, GetRect());
            }
            else if (rect != null && radioButton_String.Checked == true)
            {
                System.Drawing.Font f = new System.Drawing.Font("Arial", 14);
                e.Graphics.DrawString("Nhom16_ABCD", f, brush1,line1,line2);
            }

        }

        private void btnpencolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnpencolor.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
            brush1 = new SolidBrush(colorDialog1.Color);
            
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.White;
        }
    }
}
