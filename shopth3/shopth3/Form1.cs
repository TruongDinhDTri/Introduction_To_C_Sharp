using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopth3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();      ///Datatable belongs to datatable boughtproduct
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        


        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT", typeof(Int32));
            dt.Columns.Add("Tensanpham", typeof(string));
            dt.Columns.Add("SIZE", typeof(string));
            dt.Columns.Add("Giatien", typeof(Int32));
            dt.Columns.Add("Soluong", typeof(Int32));
            dt.Columns.Add("Giamgia", typeof(Int32));
            dt.Columns.Add("Thanhtien", typeof(string));


            dt1.Columns.Add("STT", typeof(Int32));
            dt1.Columns.Add("Tensanpham", typeof(string));
            dt1.Columns.Add("SIZE", typeof(string));
            dt1.Columns.Add("Giatien", typeof(Int32));
            dt1.Columns.Add("Soluong", typeof(Int32));
            dt1.Columns.Add("Giamgia", typeof(Int32));
            dt1.Columns.Add("Thanhtien", typeof(string));


            dt2.Columns.Add("STT", typeof(Int32));
            dt2.Columns.Add("Tensanpham", typeof(string));
            dt2.Columns.Add("SIZE", typeof(string));
            dt2.Columns.Add("Giatien", typeof(Int32));
            dt2.Columns.Add("Soluong", typeof(Int32));
            dt2.Columns.Add("Giamgia", typeof(Int32));
            dt2.Columns.Add("Thanhtien", typeof(string));







            ///////////////////////////////////////////////////////////////////////////////////////////////

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt1;
            dataGridView3.DataSource = dt2;      //////////datatable when it pays


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int men=1;
        int stt = 1;
        private void btnmen_Click(object sender, EventArgs e)
        {  if(men % 2 != 0)
            {
                pnlmen.Visible = true;
                men++;
            }
            else
            {
                pnlmen.Visible = false;
                men++;
            } 
                
        }
        
        private void btnmennewestsneaker_Click(object sender, EventArgs e)
        {
           
            pnlmennewestsneaker.Visible = true;
        }
        int boughtproduct;
        private void picboxairjoranretro12_Click(object sender, EventArgs e)
        {
            boughtproduct = 1;
            picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-1removebg.png");
            pnlnmennewestsneakerbuying.Visible = true;
            label20               .Visible = false;
            label8                .Visible = false;
            label6                .Visible = false;
            label7                .Visible = false;
            label9                .Visible = false;
            label12               .Visible = false;
            label10               .Visible = false;
            label11               .Visible = false;
            pictureBox7           .Visible = false;
            picboxairmax95se      .Visible = false;
            picboxKD14EP          .Visible = false;
            label15               .Visible = false;
            label16               .Visible = false;
            label13               .Visible = false;
            label14               .Visible = false;
            picboxkyrie7          .Visible = false;
            label5                .Visible = false;
            label19               .Visible = false;
            label18               .Visible = false;
            label17               .Visible = false;
            picboxnikelowbyyou    .Visible = false;
            label21               .Visible = false;
            label23               .Visible = false;
            label22               .Visible = false;
            label24               .Visible =  false;
            picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-1removebg.png");
            picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-2removebg.png");
            picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-3removebg.png");
            picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-4removebg.png");
            picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-5removebg.png");
            btnmennewestsneakerBACK.Visible = false;
            
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            picboxmennewestsneakerbuying.Image = picboxdetail1.Image;
        }

        private void picboxdetail2_Click(object sender, EventArgs e)
        {
            picboxmennewestsneakerbuying.Image = picboxdetail2.Image;
        }

        private void picboxdetail3_Click(object sender, EventArgs e)
        {
            picboxmennewestsneakerbuying.Image = picboxdetail3.Image;
        }

        private void picboxdetail4_Click(object sender, EventArgs e)
        {
            picboxmennewestsneakerbuying.Image = picboxdetail4.Image;

        }

        private void picboxdetail5_Click(object sender, EventArgs e)
        {
            picboxmennewestsneakerbuying.Image = picboxdetail5.Image;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void picboxairmax95se_Click(object sender, EventArgs e)
        {
            boughtproduct = 2;
            btnmennewestsneakerBACK.Visible = false;
            pnlnmennewestsneakerbuying.Visible = true;
            picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-1removebg.png");
            lbnameoftheshoe.Text = "Air Max 95 SE";
            lbdescription.Text = "Taking Inspiration from Human Body and aesthetics in 90s athetics.\n the Nike Air Max 95 SE mixes unbelievable comfort and head turning style with substainable design.\n Visible Air in the heel and forefoot cushions every step.";
            picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-1removebg.png");
            picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-2removebg.png");
            picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-3removebg.png");
            picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-4removebg.png");
            picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-5removebg.png");
            picboxairjoranretro12.Visible = false;
            label20.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            pictureBox7.Visible = false;
            picboxairmax95se.Visible = false;
            picboxKD14EP.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            picboxkyrie7.Visible = false;
            label5.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            picboxnikelowbyyou.Visible = false;
            label21.Visible = false;
            label23.Visible = false;
            label22.Visible = false;
            label24.Visible = false;


        }

        private void picboxKD14EP_Click(object sender, EventArgs e)
        {
            boughtproduct = 3;
            btnmennewestsneakerBACK.Visible = false;
            pnlnmennewestsneakerbuying.Visible = true;
            lbnameoftheshoe.Text = "KD14 EP";
            picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\KD14EP\kd14ep-1removebg.png");
            lbdescription.Text = "Kevin Durant lurks on the wing, waiting for the right time to strike before slicing his way through defences.\nThe KD14 EP is designed to help versatile, relentless players like KD feel fresh all game long.\nMulti-layer mesh and a midfoot strap help reduce the foot's movements inside the shoe.\nFull-length Zoom Air cushioning plus Cushlon foam give back energy for lasting performance ";
            picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\KD14EP\kd14ep-1removebg.png");
            picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\KD14EP\kd14ep-2removebg.png");
            picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\KD14EP\kd14ep-3removebg.png");
            picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\KD14EP\kd14ep-4removebg.png");
            picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\KD14EP\kd14ep-5removebg.png");
            picboxairjoranretro12.Visible = false;
            label20.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            pictureBox7.Visible = false;
            picboxairmax95se.Visible = false;
            picboxKD14EP.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            picboxkyrie7.Visible = false;
            label5.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            picboxnikelowbyyou.Visible = false;
            label21.Visible = false;
            label23.Visible = false;
            label22.Visible = false;
            label24.Visible = false;

        }

        private void picboxkyrie7_Click(object sender, EventArgs e)
        {
            boughtproduct = 4;
            btnmennewestsneakerBACK.Visible = false;
            pnlnmennewestsneakerbuying.Visible = true;
            lbnameoftheshoe.Text = "Kyrie Low 4 EP ";
            picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\Kyrielow4ep\kyrielow4ep-1removebg.png");
            lbdescription.Text = "Kyrie needs shoes that won't slow him down and help him connect to the court.\n The Kyrie Low 4 EP is stripped of all excess to keep it lean and lightweight while fully containing the foot and helping to eliminate movement inside the shoe.\n Cushlon foam and Zoom Air provide a smooth, responsive ride, and the data-informed traction keeps Kyrie low to the ground and in control.";
            picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\Kyrielow4ep\kyrielow4ep-1removebg.png");
            picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\Kyrielow4ep\Kyrielow4ep-2removebg.png");
            picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\Kyrielow4ep\kyirelow4ep-3removebg.png");
            picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\Kyrielow4ep\kyrielow4ep-4removebg.png");
            picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\Kyrielow4ep\kyrielow4ep-5removebg.png");
            picboxairjoranretro12.Visible = false;
            label20.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            pictureBox7.Visible = false;
            picboxairmax95se.Visible = false;
            picboxKD14EP.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            picboxkyrie7.Visible = false;
            label5.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            picboxnikelowbyyou.Visible = false;
            label21.Visible = false;
            label23.Visible = false;
            label22.Visible = false;
            label24.Visible = false;
        }
        private void btnmennewestsneakerbuyingBACK_Click(object sender, EventArgs e)
        {
            btnmennewestsneakerBACK.Visible = false;
            pnlnmennewestsneakerbuying.Visible = false ;
            picboxairjoranretro12.Visible = true;
            btnmennewestsneakerBACK.Visible = true;
            label20.Visible =true;
            label8.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            pictureBox7.Visible = true;
            picboxairmax95se.Visible = true;
            picboxKD14EP.Visible = true;
            label15.Visible =true;
            label16.Visible =true;
            label13.Visible =true;
            label14.Visible = true;
            picboxkyrie7.Visible = true;
            label5.Visible =  true;
            label19.Visible = true;
            label18.Visible = true;
            label17.Visible = true;
            picboxnikelowbyyou.Visible = true;
            label21.Visible = true;
            label23.Visible = true;
            label22.Visible = true;
            label24.Visible = true;
        }

        private void picboxnikelowbyyou_Click(object sender, EventArgs e)
        {
            boughtproduct = 5;
            btnmennewestsneakerBACK.Visible = false;
            pnlnmennewestsneakerbuying.Visible = true;
            lbnameoftheshoe.Text = "Air Force 1 Low By You  ";
            picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\Airforce1\airforce1-1removebg.png");
            lbdescription.Text = "The Nike Air Force 1 Low By You became an instant icon after its debut in 1982.\nNow you can make this classic your own with a colour palette inspired by the '80s and '90s and premium\nmaterials including smooth and rippled leather and a new, matching sidewall selection.\nIt's time to create a look that speaks to you.";
            picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\Airforce1\airforce1-1removebg.png");
            picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\Airforce1\airforce1-2removebg.png");
            picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\Airforce1\airforce1-3removebg.png");
            picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\Airforce1\airforce1-4removebg.png");
            picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\Airforce1\airforce1-5removebg.png");
            picboxairjoranretro12.Visible = false;
            label20.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            pictureBox7.Visible = false;
            picboxairmax95se.Visible = false;
            picboxKD14EP.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            picboxkyrie7.Visible = false;
            label5.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            picboxnikelowbyyou.Visible = false;
            label21.Visible = false;
            label23.Visible = false;
            label22.Visible = false;
            label24.Visible = false;
        }

        private void btnmennewestsneakerBACK_Click(object sender, EventArgs e)
        {
            pnlmennewestsneaker.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sizeshirt = "S";
        }
        
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            boughtproduct = 6;
            pnlmentshirtbuying.Visible = true;
            lbmentshirtname.Text = "Jordan";
            lbmentshirtname1.Text = "Men's Short Sleeve T-Shirt";
            lbmentshirtdescription.Text = "Add some dimension to your style with\nthis tie-dyed T-shirt from Jordan Brand.\nIt's made from structured heavyweight cotton withprinted and embroidered graphics";
            picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-1removebg.png");
            picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-1removebg.png");
            picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-2removebg.png");
            picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-3removebg.png");
            picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-4removebg.png");
            picboxdetail5mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-5removebg.png");
            picboxmentshirtjordan.Visible = false;
            label27        .Visible = false;
            label26        .Visible = false;
            label28        .Visible = false;
            picboxmentshirtjordanjumpman    .Visible = false;
            label29        .Visible = false;
            label30        .Visible = false;
            label31        .Visible = false;
            picboxmentshirtnikemax90    .Visible = false;
            label32        .Visible = false;
            label33        .Visible = false;
            label34        .Visible = false;
            picboxmentshirtnikeesc    .Visible = false;
            picboxmentshirtnikesportwear    .Visible = false;
            label36        .Visible = false;
            label35        .Visible = false;
            label37        .Visible = false;
            label39        .Visible = false;
            label38        .Visible = false;
            label40.Visible = false;

        }

        private void btnmentshirtBACK_Click(object sender, EventArgs e)
        {
            pnlmentshirt.Visible = false;
           
        }

        private void btnmentshirtbuying_Click(object sender, EventArgs e)
        {
            pnlmentshirtbuying.Visible = false ;
            picboxmentshirtjordan.Visible = true;
            label27.Visible = true;
            label26.Visible = true;
            label28.Visible = true;
            picboxmentshirtjordanjumpman.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            picboxmentshirtnikemax90.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            picboxmentshirtnikeesc.Visible = true;
            picboxmentshirtnikesportwear.Visible = true;
            label36.Visible = true;
            label35.Visible = true;
            label37.Visible = true;
            label39.Visible = true;
            label38.Visible = true;
            label40.Visible = true;


        }

        private void picboxdetail1mentshirt_Click(object sender, EventArgs e)
        {
            picboxdetailmainmentshirt.Image = picboxdetail1mentshirt.Image;
        }

        private void picboxdetail2mentshirt_Click(object sender, EventArgs e)
        {
            picboxdetailmainmentshirt.Image = picboxdetail2mentshirt.Image;
        }

        private void picboxdetail3mentshirt_Click(object sender, EventArgs e)
        {
            picboxdetailmainmentshirt.Image = picboxdetail3mentshirt.Image;
        }

        private void picboxdetail4mentshirt_Click(object sender, EventArgs e)
        {
            picboxdetailmainmentshirt.Image = picboxdetail4mentshirt.Image;
        }

        private void picboxdetail5mentshirt_Click(object sender, EventArgs e)
        {
            picboxdetailmainmentshirt.Image = picboxdetail5mentshirt.Image;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pnlmentshirt.Visible = true;
            pnlmennewestsneaker.Visible = false;
        }

        private void picboxmentshirtjordanjumpman_Click(object sender, EventArgs e)
        {
            boughtproduct=7;
            pnlmentshirtbuying.Visible = true;
            lbmentshirtname.Text = "Jordan";
            lbmentshirtname1.Text = "Jordan Jumpman Shirt";
            lbmentshirtdescription.Text = "Soar out the door in the Jordan Jumpman T-Shirt.It's made from soft,\ncomfortable fabric with an easy and relaxed fit.";
            picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\Jumpman\mentshirt-1jordanjumpremovebg.png");
            picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jumpman\mentshirt-1jordanjumpremovebg.png");
            picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jumpman\mentshirt-2jordanjumpremovebg.png");
            picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jumpman\mentshirt-3jordanjumpremovebg.png");
            picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jumpman\mentshirt-4jordanjumpremovebg.png");
            picboxdetail5mentshirt.Image = null;
            picboxmentshirtjordan.Visible = false;
            label27.Visible = false;
            label26.Visible = false;
            label28.Visible = false;
            picboxmentshirtjordanjumpman.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            picboxmentshirtnikemax90.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            picboxmentshirtnikeesc.Visible = false;
            picboxmentshirtnikesportwear.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            label37.Visible = false;
            label39.Visible = false;
            label38.Visible = false;
            label40.Visible = false;
        }

        private void picboxmentshirtnikemax90_Click(object sender, EventArgs e)
        {
            boughtproduct=8;
            pnlmentshirtbuying.Visible = true;
            lbmentshirtname.Text = "Jordan";
            lbmentshirtname1.Text = "Nike SportWear Max90";
            lbmentshirtdescription.Text = "The Nike Sportswear Max90 T-Shirt drapes you in comfort.\nLonger sleeves and a roomy fit through the body and hips give this Max90 \ntee a relaxed and casual look.";
            picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-1nikemax90removebg.png");
            picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-1nikemax90removebg.png");
            picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-2nikemax90removebg.png");
            picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-3nikemax90removebg.png");
            picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-4nikemax90removebg.png");
            picboxdetail5mentshirt.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-5nikemax90removebg.png");
            picboxmentshirtjordan.Visible = false;
            label27.Visible = false;
            label26.Visible = false;
            label28.Visible = false;
            picboxmentshirtjordanjumpman.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            picboxmentshirtnikemax90.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            picboxmentshirtnikeesc.Visible = false;
            picboxmentshirtnikesportwear.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            label37.Visible = false;
            label39.Visible = false;
            label38.Visible = false;
            label40.Visible = false;

        }

        private void picboxmentshirtnikeesc_Click(object sender, EventArgs e)
        {
            boughtproduct=9;
            pnlmentshirtbuying.Visible = true;
            lbmentshirtname.Text = "NIKE";
            lbmentshirtname1.Text = "Nike ESC";
            lbmentshirtdescription.Text = "Crafted in Milan, Italy to help complement your wardrobe,\nthe Nike ESC Tee is made from buttery-soft cotton for luxe comfort.\nErgonomic seams and carefully crafted patterns follow the\nlines of your body for fluid movement and a natural drape.";
            picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\NikeESC\mentshirt-1nikeescremovebg.png");
            picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\NikeESC\mentshirt-1nikeescremovebg.png");
            picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\NikeESC\mentshirt-2nikeescremovebg.png");
            picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\NikeESC\mentshirt-3nikeescremovebg.png");
            picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\NikeESC\mentshirt-4nikeescremovebg.png");
            picboxdetail5mentshirt.Image = Image.FromFile(@"Men\Tshirt\NikeESC\mentshirt-5nikeescremovebg.png");
            picboxmentshirtjordan.Visible = false;
            label27.Visible = false;
            label26.Visible = false;
            label28.Visible = false;
            picboxmentshirtjordanjumpman.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            picboxmentshirtnikemax90.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            picboxmentshirtnikeesc.Visible = false;
            picboxmentshirtnikesportwear.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            label37.Visible = false;
            label39.Visible = false;
            label38.Visible = false;
            label40.Visible = false;
        }

        private void picboxmentshirtnikesportwear_Click(object sender, EventArgs e)
        {
            boughtproduct=10;
            pnlmentshirtbuying.Visible = true;
            lbmentshirtname.Text = "NIKE";
            lbmentshirtname1.Text = "Nike SportWear";
            lbmentshirtdescription.Text = "The Nike Sportswear T-Shirt features our oversized Max-90 fit and heavyweight cotton jersey.\nPrinted with water-based ink, the flower Futura logo\non the chest helps you maintain a \nsunny disposition no matter what the weather.";
            picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-1sportwearremovebg.png");
            picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-1sportwearremovebg.png");
            picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-2sportwearremovebg.png");
            picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-3sportwearremovebg.png");
            picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-4sportwearremovebg.png");
            picboxdetail5mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-5sportwearremovebg.png");
            picboxmentshirtjordan.Visible = false;
            label27.Visible = false;
            label26.Visible = false;
            label28.Visible = false;
            picboxmentshirtjordanjumpman.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            picboxmentshirtnikemax90.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            picboxmentshirtnikeesc.Visible = false;
            picboxmentshirtnikesportwear.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            label37.Visible = false;
            label39.Visible = false;
            label38.Visible = false;
            label40.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int newrelease = 1;
        private void btnnewrelease_Click(object sender, EventArgs e)
        {
            pnlnewrelease.Visible = true;
            if (newrelease % 2 != 0)
            {
                pnlnewrelease.Visible = true;
                newrelease++;
            }
            else
            {
                pnlnewrelease.Visible = false;
                newrelease++;
            }
        }
        int women = 1;
        private void btnwomen_Click(object sender, EventArgs e)
        {
            pnlwomen.Visible = true;
            if (women % 2 != 0)
            {
                pnlwomen.Visible = true;
                women++;
            }
            else
            {
                pnlwomen.Visible =false;
                women++;
            }
        }
        int customise = 1;
        private void btncustomise_Click(object sender, EventArgs e)
        {
            pnlcustomise.Visible = true;
            if (customise % 2 != 0)
            {
                pnlcustomise.Visible = true;
                customise++;
            }
            else
            {
                pnlcustomise.Visible = false;
               customise++;
            }
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }
        int pick = 1;
        private void btndiscountselection_Click(object sender, EventArgs e)
        {
            if(pick %2 != 0)
            {
                pnldiscountdetail.Visible = true;
                pick++;
            }
            else
            {
                pnldiscountdetail.Visible = false;
                pick++;
            }
           
        }

        

        private void lnchitietdondamua_dagiam1_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void pnlhistorybuying1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        string s;
        private void btnshoesize37_Click(object sender, EventArgs e)
        {
             s = "EU37";
        }

        private void btnshoesize38_Click(object sender, EventArgs e)
        {
            s = "EU38";
        }

        private void btnshoesize39_Click(object sender, EventArgs e)
        {
            s = "EU39";
        }

        private void btnshoesize40_Click(object sender, EventArgs e)
        {
            s = "EU40";
        }

        private void btnshoesize41_Click(object sender, EventArgs e)
        {
            s = "EU41";
        }

        private void btnshoesize42_Click(object sender, EventArgs e)
        {
            s = "EU42";
        }

        private void btnshoesize43_Click(object sender, EventArgs e)
        {
            s = "EU43";
        }

        private void btnshoesize44_Click(object sender, EventArgs e)
        {
            s = "EU44";
        }

        private void btnshoesize45_Click(object sender, EventArgs e)
        {
            s = "EU45";
        }
        
        private void lbshopcartthanhtien1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnshoeaddtocart_Click(object sender, EventArgs e)
        {
                if (boughtproduct == 1)
                {
                        dt.Rows.Add(stt, "Air Jordan Retro 12", s, 5589000, numshopcartsoluong1.Value, 1, "5589000");
                        stt++;
                ////  pnlshopcartbuying1.Visible = true;
                ////  picboxshopcart1.Image = picboxdetail1.Image;
                ////  var gia0 = dt.Rows[0]["SIZE"];
                ////  var info1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                ////  string tien1 = String.Format(info1, "{0:c}", gia0);
                ////  lbshopcartdongia1.Text = tien1;
                ////  lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                //// Change int into VN Currentcy        
                }
                else if (boughtproduct == 2)
                {
                    dt.Rows.Add(stt, "Air Max 95 SE", s,3998000, numshopcartsoluong2.Value, 1, "3998000");
                    stt++;
                }
                else if (boughtproduct == 3)
                {
                    dt.Rows.Add(stt, "KD14EP", s, 4409000, numshopcartsoluong3.Value, 1, "4409000");
                    stt++;
                }
                else if (boughtproduct == 4)
                {
                    dt.Rows.Add(stt, "Kyrie Low 4 EP", s, 3829000, numshopcartsoluong4.Value, 1, "3829000");
                    stt++;
                }
                else if (boughtproduct == 5)
                {
                    dt.Rows.Add(stt, "Nike Low By You", s, 3239000, numshopcartsoluong5.Value, 1, "3239000");
                    stt++;
                }
                
        }
        
        private void numshopcartsoluong1_ValueChanged(object sender, EventArgs e)
        {
            
               dt.Rows[0]["Soluong"] = numshopcartsoluong1.Value;
               var gia10 = Convert.ToInt32(dt.Rows[0]["Giatien"]) * Convert.ToInt32(dt.Rows[0]["Soluong"]);
               var info10 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
               string tien10 = String.Format(info10, "{0:c}", gia10);
               dt.Rows[0]["Thanhtien"] = gia10;
               lbshopcartthanhtien1.Text = tien10;
            

        }
        string sizeshirt;
        private void btnmentshirtsizeXXS_Click(object sender, EventArgs e)
        {
            sizeshirt = "XXS";
        }

        private void btnmentshirtsizeXS_Click(object sender, EventArgs e)
        {
            sizeshirt = "XS";
        }

        private void btnmentshirtsizeM_Click(object sender, EventArgs e)
        {
            sizeshirt = "M";
        }

        private void btnmentshirtsizeL_Click(object sender, EventArgs e)
        {
            sizeshirt = "L";
        }

        private void btnmentshirtsizeXL_Click(object sender, EventArgs e)
        {
            sizeshirt = "XL";
        }

        private void btnmentshirtsizeXXL_Click(object sender, EventArgs e)
        {
            sizeshirt = "XXL";
        }
        
        private void btnmentshirtADDTOCART_Click(object sender, EventArgs e)
        {
            if(boughtproduct==6)
            {
                dt.Rows.Add(stt, "Men's Short Sleeve T-Shirt", sizeshirt, 919000, 1, 1, "919000");
                stt++;
            }
            else if (boughtproduct == 7)
            {
                dt.Rows.Add(stt, "Jordan Jumpman", sizeshirt, 659000, 1, 1, "659000");
                stt++;
            }
            else if (boughtproduct == 8)
            {
                dt.Rows.Add(stt, "Nike SportWear Max90", sizeshirt,919000, 1, 1, "919000");
                stt++;
            }
            else if (boughtproduct == 9)
            {
                dt.Rows.Add(stt, "Nike ESC", sizeshirt, 2299000, 1, 1, "2299000");
                stt++;
            }
            else if (boughtproduct == 10)
            {
                dt.Rows.Add(stt, "Nike SportWear", sizeshirt, 1190000, 1, 1, "1190000");
                stt++;
            }
        }
        int not;
        int shopcart = 1;
        private void btnshopcart_Click(object sender, EventArgs e)
        {
            if(demsocheck != dt.Rows.Count)
            {
                checkboxshopcartALL.Checked = false;
            }
            if(shopcart %2 != 0)
            {
                int sodong = dt.Rows.Count;
                int dem = 1;
                for (int i = 1; i <= sodong; i++)
                {
                    if (dem == 1)
                    {

                        lbshopcartinfo1.Text = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                        /////// Change int to Vietnam Currency
                        var gia = Convert.ToInt32(dt.Rows[0]["Giatien"]);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        string tien0 = String.Format(info, "{0:c}", gia);
                        //////
                        lbshopcartdongia1.Text = tien0;
                        lbshopcartthanhtien1.Text = tien0;
                        lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                        string tensanpham = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                        switch (tensanpham)
                        {
                            case "Air Jordan Retro 12":
                                picboxshopcart1.Image = picboxairjoranretro12.Image;
                                break;
                            case "Air Max 95 SE":
                                picboxshopcart1.Image = picboxairmax95se.Image;
                                break;
                            case "KD14EP":
                                picboxshopcart1.Image = picboxKD14EP.Image;
                                break;
                            case "Kyrie Low 4 EP":
                                picboxshopcart1.Image = picboxkyrie7.Image;
                                break;
                            case "Nike Low By You":
                                picboxshopcart1.Image = picboxnikelowbyyou.Image;
                                break;
                            case "Men's Short Sleeve T-Shirt":
                                picboxshopcart1.Image = picboxmentshirtjordan.Image;
                                break;
                            case "Jordan Jumpman":
                                picboxshopcart1.Image = picboxmentshirtjordanjumpman.Image;
                                break;
                            case "Nike SportWear Max90":
                                picboxshopcart1.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                                break;
                            case "Nike ESC":
                                picboxshopcart1.Image = picboxmentshirtnikeesc.Image;
                                break;
                            case "Nike SportWear":
                                picboxshopcart1.Image = picboxmentshirtnikesportwear.Image;
                                break;
                            default:
                                not = 1;
                                break;
                        }
                        dem++;
                        pnlshopcartbuying1.Visible = true;
                        checkboxshopcart1.Visible = true;
                    }
                    else if (dem == 2 && dem <= sodong)
                    {

                        lbshopcartinfo2.Text = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                        /////// Change int to Vietnam Currency
                        var gia1 = Convert.ToInt32(dt.Rows[1]["Giatien"]);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        string tien1 = String.Format(info, "{0:c}", gia1);
                        //////
                        lbshopcartdongia2.Text = tien1;
                        lbshopcartthanhtien2.Text = tien1;
                        lbshopcartSIZE2.Text = Convert.ToString(dt.Rows[1]["SIZE"]);
                        string tensanpham1 = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                        switch (tensanpham1)
                        {
                            case "Air Jordan Retro 12":
                                picboxshopcart2.Image = picboxairjoranretro12.Image;
                                break;
                            case "Air Max 95 SE":
                                picboxshopcart2.Image = picboxairmax95se.Image;
                                break;
                            case "KD14EP":
                                picboxshopcart2.Image = picboxKD14EP.Image;
                                break;
                            case "Kyrie Low 4 EP":
                                picboxshopcart2.Image = picboxkyrie7.Image;
                                break;
                            case "Nike Low By You":
                                picboxshopcart2.Image = picboxnikelowbyyou.Image;
                                break;
                            case "Men's Short Sleeve T-Shirt":
                                picboxshopcart2.Image = picboxmentshirtjordan.Image;
                                break;
                            case "Jordan Jumpman":
                                picboxshopcart2.Image = picboxmentshirtjordanjumpman.Image;
                                break;
                            case "Nike SportWear Max90":
                                picboxshopcart2.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                                break;
                            case "Nike ESC":
                                picboxshopcart2.Image = picboxmentshirtnikeesc.Image;
                                break;
                            case "Nike SportWear":
                                picboxshopcart2.Image = picboxmentshirtnikesportwear.Image;
                                break;
                            default:
                                not = 1;
                                break;
                        }
                        dem++;
                        pnlshopcartbuying2.Visible = true;
                        checkboxshopcart2.Visible = true;
                    }
                    else if (dem == 3 && dem <= sodong)
                    {
                        lbshopcartinfo3.Text = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                        /////// Change int to Vietnam Currency
                        var gia2 = Convert.ToInt32(dt.Rows[2]["Giatien"]);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        string tien2 = String.Format(info, "{0:c}", gia2);
                        //////
                        lbshopcartdongia3.Text = tien2;
                        lbshopcartthanhtien3.Text = tien2;
                        lbshopcartSIZE3.Text = Convert.ToString(dt.Rows[2]["SIZE"]);
                        string tensanpham2 = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                        switch (tensanpham2)
                        {
                            case "Air Jordan Retro 12":
                                picboxshopcart3.Image = picboxairjoranretro12.Image;
                                break;
                            case "Air Max 95 SE":
                                picboxshopcart3.Image = picboxairmax95se.Image;
                                break;
                            case "KD14EP":
                                picboxshopcart3.Image = picboxKD14EP.Image;
                                break;
                            case "Kyrie Low 4 EP":
                                picboxshopcart3.Image = picboxkyrie7.Image;
                                break;
                            case "Nike Low By You":
                                picboxshopcart3.Image = picboxnikelowbyyou.Image;
                                break;
                            case "Men's Short Sleeve T-Shirt":
                                picboxshopcart3.Image = picboxmentshirtjordan.Image;
                                break;
                            case "Jordan Jumpman":
                                picboxshopcart3.Image = picboxmentshirtjordanjumpman.Image;
                                break;
                            case "Nike SportWear Max90":
                                picboxshopcart3.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                                break;
                            case "Nike ESC":
                                picboxshopcart3.Image = picboxmentshirtnikeesc.Image;
                                break;
                            case "Nike SportWear":
                                picboxshopcart3.Image = picboxmentshirtnikesportwear.Image;
                                break;
                            default:
                                not = 1;
                                break;
                        }
                        dem++;
                        pnlshopcartbuying3.Visible = true;
                        checkboxshopcart3.Visible = true;
                    }
                    else if (dem == 4 && dem <= sodong)
                    {
                        lbshopcartinfo4.Text = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                        /////// Change int to Vietnam Currency
                        var gia3 = Convert.ToInt32(dt.Rows[3]["Giatien"]);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        string tien3 = String.Format(info, "{0:c}", gia3);
                        //////
                        lbshopcartdongia4.Text = tien3;
                        lbshopcartthanhtien4.Text = tien3;
                        lbshopcartSIZE4.Text = Convert.ToString(dt.Rows[3]["SIZE"]);
                        string tensanpham3 = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                        switch (tensanpham3)
                        {
                            case "Air Jordan Retro 12":
                                picboxshopcart4.Image = picboxairjoranretro12.Image;
                                break;
                            case "Air Max 95 SE":
                                picboxshopcart4.Image = picboxairmax95se.Image;
                                break;
                            case "KD14EP":
                                picboxshopcart4.Image = picboxKD14EP.Image;
                                break;
                            case "Kyrie Low 4 EP":
                                picboxshopcart4.Image = picboxkyrie7.Image;
                                break;
                            case "Nike Low By You":
                                picboxshopcart4.Image = picboxnikelowbyyou.Image;
                                break;
                            case "Men's Short Sleeve T-Shirt":
                                picboxshopcart4.Image = picboxmentshirtjordan.Image;
                                break;
                            case "Jordan Jumpman":
                                picboxshopcart4.Image = picboxmentshirtjordanjumpman.Image;
                                break;
                            case "Nike SportWear Max90":
                                picboxshopcart4.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                                break;
                            case "Nike ESC":
                                picboxshopcart4.Image = picboxmentshirtnikeesc.Image;
                                break;
                            case "Nike SportWear":
                                picboxshopcart4.Image = picboxmentshirtnikesportwear.Image;
                                break;
                            default:
                                not = 1;
                                break;
                        }
                        dem++;
                        pnlshopcartbuying4.Visible = true;
                        checkboxshopcart4.Visible = true;
                    }
                    else if (dem == 5 && dem <= sodong)
                    {
                        lbshopcartinfo5.Text = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                        /////// Change int to Vietnam Currency
                        var gia4 = Convert.ToInt32(dt.Rows[4]["Giatien"]);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        string tien4 = String.Format(info, "{0:c}", gia4);
                        //////
                        lbshopcartdongia5.Text = tien4;
                        lbshopcartthanhtien5.Text = tien4;
                        lbshopcartSIZE5.Text = Convert.ToString(dt.Rows[4]["SIZE"]);
                        string tensanpham4 = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                        switch (tensanpham4)
                        {
                            case "Air Jordan Retro 12":
                                picboxshopcart5.Image = picboxairjoranretro12.Image;
                                break;
                            case "Air Max 95 SE":
                                picboxshopcart5.Image = picboxairmax95se.Image;
                                break;
                            case "KD14EP":
                                picboxshopcart5.Image = picboxKD14EP.Image;
                                break;
                            case "Kyrie Low 4 EP":
                                picboxshopcart5.Image = picboxkyrie7.Image;
                                break;
                            case "Nike Low By You":
                                picboxshopcart5.Image = picboxnikelowbyyou.Image;
                                break;
                            case "Men's Short Sleeve T-Shirt":
                                picboxshopcart5.Image = picboxmentshirtjordan.Image;
                                break;
                            case "Jordan Jumpman":
                                picboxshopcart5.Image = picboxmentshirtjordanjumpman.Image;
                                break;
                            case "Nike SportWear Max90":
                                picboxshopcart5.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                                break;
                            case "Nike ESC":
                                picboxshopcart5.Image = picboxmentshirtnikeesc.Image;
                                break;
                            case "Nike SportWear":
                                picboxshopcart5.Image = picboxmentshirtnikesportwear.Image;
                                break;
                            default:
                                not = 1;
                                break;
                        }
                        dem++;
                        pnlshopcartbuying5.Visible = true;
                        checkboxshopcart5.Visible = true;
                    }
                }
                pnlshopcart.Visible = true;
                shopcart++;
            }
            else if(shopcart %2 == 0)
            {
                pnlshopcart.Visible = false;
                shopcart++;
            }
           
        }

        private void numshopcartsoluong2_ValueChanged(object sender, EventArgs e)
        {

            dt.Rows[1]["Soluong"] = numshopcartsoluong2.Value;
            var gia11 = Convert.ToInt32(dt.Rows[1]["Giatien"]) * Convert.ToInt32(dt.Rows[1]["Soluong"]);
            var info11 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string tien11 = String.Format(info11, "{0:c}", gia11);
            dt.Rows[1]["Thanhtien"] = gia11;
            lbshopcartthanhtien2.Text = tien11;
        }

        private void numshopcartsoluong3_ValueChanged(object sender, EventArgs e)
        {
            dt.Rows[2]["Soluong"] = numshopcartsoluong3.Value;
            var gia12 = Convert.ToInt32(dt.Rows[2]["Giatien"]) * Convert.ToInt32(dt.Rows[2]["Soluong"]);
            var info12 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string tien12 = String.Format(info12, "{0:c}", gia12);
            dt.Rows[2]["Thanhtien"] = gia12;
            lbshopcartthanhtien3.Text = tien12;
        }

        private void numshopcartsoluong4_ValueChanged(object sender, EventArgs e)
        {
            dt.Rows[3]["Soluong"] = numshopcartsoluong4.Value;
            var gia13 = Convert.ToInt32(dt.Rows[3]["Giatien"]) * Convert.ToInt32(dt.Rows[3]["Soluong"]);
            var info13 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string tien13 = String.Format(info13, "{0:c}", gia13);
            dt.Rows[3]["Thanhtien"] = gia13;
            lbshopcartthanhtien4.Text = tien13;
        }

        private void numshopcartsoluong5_ValueChanged(object sender, EventArgs e)
        {
            dt.Rows[4]["Soluong"] = numshopcartsoluong5.Value;
            var gia14 = Convert.ToInt32(dt.Rows[4]["Giatien"]) * Convert.ToInt32(dt.Rows[4]["Soluong"]);
            var info14 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string tien14 = String.Format(info14, "{0:c}", gia14);
            dt.Rows[4]["Thanhtien"] = gia14;
            lbshopcartthanhtien5.Text = tien14;
        }
        int luutongcong=0;
        int checkbox1 = 1;
        int checkbox2 = 1;
        int checkbox3 = 1;
        int checkbox4 = 1;
        int checkbox5 = 1;
        int demsocheck = 0;
        int giam20;
        int giam10;
        int giam60;
        int giam50;
    

        private void checkboxshopcart1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox1 %2 !=0)
            {
                ++demsocheck;
               
                if (demsocheck == dt.Rows.Count)
                {
                    checkboxshopcartALL.Checked = true;
                }
                luutongcong = luutongcong + Convert.ToInt32(dt.Rows[0]["Thanhtien"]);
                var gia15 = luutongcong;
                var info15 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien15 = String.Format(info15, "{0:c}", gia15);
                lbshopcartTINHTIEN_tamtinh.Text = tien15;
                lbshopcartTINHTIEN_tongcong.Text = tien15;
                checkbox1++;
               
                if(giam20==1)
                {
                    int updateluutongcong1 = luutongcong * 2 / 10;
                    int tongcongsauchange1 = luutongcong * 8 / 10;
                    var giamgiachangeinfo1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange1 = String.Format(giamgiachangeinfo1, "{0:c}", updateluutongcong1);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange1;
                    /////////
                    ///
                    var giamgiachangeinfotongcong1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate1 = String.Format(giamgiachangeinfotongcong1, "{0:c}", tongcongsauchange1);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate1;
                }
                else if (giam10==1)
                {
                    int updateluutongcong2 = luutongcong * 1 / 10;
                    int tongcongsauchange2 = luutongcong * 9 / 10;
                    var giamgiachangeinfo2 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang2 = String.Format(giamgiachangeinfo2, "{0:c}", updateluutongcong2);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang2;
                    /////////
                    ///
                    var giamgiachangeinfotongcong2 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate2 = String.Format(giamgiachangeinfotongcong2, "{0:c}", tongcongsauchange2);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate2;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong3 = luutongcong * 5 / 10;
                    int tongcongsauchange3 = luutongcong * 5 / 10;
                    var giamgiachangeinfo3 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang3 = String.Format(giamgiachangeinfo3, "{0:c}", updateluutongcong3);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang3;
                    //////
                    ///
                    var giamgiachangeinfotongcong3 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate3 = String.Format(giamgiachangeinfotongcong3, "{0:c}", tongcongsauchange3);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate3;
                }
                else if(giam60==1)
                {
                    int updateluutongcong4 = luutongcong * 6 / 10;
                    int tongcongsauchange4 = luutongcong * 4 / 10;
                    var giamgiachangeinfo4 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang4 = String.Format(giamgiachangeinfo4, "{0:c}", updateluutongcong4);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang4;
                    /////////
                    ///
                    var giamgiachangeinfotongcong4 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate4 = String.Format(giamgiachangeinfotongcong4, "{0:c}", tongcongsauchange4);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate4;
                }
                numshopcartsoluong1.Enabled = false;
            }
            else if (checkbox1 %2 == 0 )
            {
                --demsocheck;
                
                numshopcartsoluong1.Enabled = true ;
                checkboxshopcartALL.Checked = false;
                luutongcong = luutongcong - Convert.ToInt32(dt.Rows[0]["Thanhtien"]);
                var gia16 = luutongcong;
                var info16 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien16 = String.Format(info16, "{0:c}", gia16);
                lbshopcartTINHTIEN_tamtinh.Text = tien16;
                lbshopcartTINHTIEN_tongcong.Text = tien16;
                checkbox1++;
              
                if (giam20 == 1)
                {
                    int updateluutongcong1 = luutongcong * 2 / 10;
                    int tongcongsauchange1 = luutongcong * 8 / 10;
                    var giamgiachangeinfo1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange1 = String.Format(giamgiachangeinfo1, "{0:c}", updateluutongcong1);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange1;
                    /////////
                    ///
                    var giamgiachangeinfotongcong1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate1 = String.Format(giamgiachangeinfotongcong1, "{0:c}", tongcongsauchange1);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate1;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong2 = luutongcong * 1 / 10;
                    int tongcongsauchange2 = luutongcong * 9 / 10;
                    var giamgiachangeinfo2 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang2 = String.Format(giamgiachangeinfo2, "{0:c}", updateluutongcong2);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang2;
                    /////////
                    ///
                    var giamgiachangeinfotongcong2 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate2 = String.Format(giamgiachangeinfotongcong2, "{0:c}", tongcongsauchange2);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate2;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong3 = luutongcong * 5 / 10;
                    int tongcongsauchange3 = luutongcong * 5 / 10;
                    var giamgiachangeinfo3 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang3 = String.Format(giamgiachangeinfo3, "{0:c}", updateluutongcong3);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang3;
                    //////
                    ///
                    var giamgiachangeinfotongcong3 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate3 = String.Format(giamgiachangeinfotongcong3, "{0:c}", tongcongsauchange3);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate3;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong4 = luutongcong * 6 / 10;
                    int tongcongsauchange4 = luutongcong * 4 / 10;
                    var giamgiachangeinfo4 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang4 = String.Format(giamgiachangeinfo4, "{0:c}", updateluutongcong4);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang4;
                    /////////
                    ///
                    var giamgiachangeinfotongcong4 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate4 = String.Format(giamgiachangeinfotongcong4, "{0:c}", tongcongsauchange4);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate4;
                }
            }
        }

        private void checkboxshopcart2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox2 % 2 != 0)
            {
                ++demsocheck;
              
                if(demsocheck==dt.Rows.Count)
                {
                    checkboxshopcartALL.Checked = true;
                }
                luutongcong = luutongcong + Convert.ToInt32(dt.Rows[1]["Thanhtien"]);
                var gia17 = luutongcong;
                var info17 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien17 = String.Format(info17, "{0:c}", gia17);
                lbshopcartTINHTIEN_tamtinh.Text = tien17;
                lbshopcartTINHTIEN_tongcong.Text = tien17;
                checkbox2++;
               
                if (giam20 == 1)
                {
                    int updateluutongcong5 = luutongcong * 2 / 10;
                    int tongcongsauchange5 = luutongcong * 8 / 10;
                    var giamgiachangeinfo5 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange5 = String.Format(giamgiachangeinfo5, "{0:c}", updateluutongcong5);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange5;
                    /////////
                    ///
                    var giamgiachangeinfotongcong5 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate5 = String.Format(giamgiachangeinfotongcong5, "{0:c}", tongcongsauchange5);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate5;
                }
                else if (giam10 == 1)
                {
                    
                    int updateluutongcong6 = luutongcong * 1 / 10;
                    int tongcongsauchange6 = luutongcong * 9 / 10;
                    var giamgiachangeinfo6 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang6 = String.Format(giamgiachangeinfo6, "{0:c}", updateluutongcong6);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang6;
                    /////////
                    ///
                    var giamgiachangeinfotongcong6 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate6 = String.Format(giamgiachangeinfotongcong6, "{0:c}", tongcongsauchange6);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate6;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong7 = luutongcong * 5 / 10;
                    int tongcongsauchange7 = luutongcong * 5 / 10;
                    var giamgiachangeinfo7 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang7 = String.Format(giamgiachangeinfo7, "{0:c}", updateluutongcong7);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang7;

                    /////////
                    ///
                    var giamgiachangeinfotongcong7 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate7 = String.Format(giamgiachangeinfotongcong7, "{0:c}", tongcongsauchange7);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate7;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong8 = luutongcong * 6 / 10;
                    int tongcongsauchange8 = luutongcong * 4 / 10;
                    var giamgiachangeinfo8 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang8 = String.Format(giamgiachangeinfo8, "{0:c}", updateluutongcong8);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang8;

                    /////////
                    ///
                    var giamgiachangeinfotongcong8 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate8 = String.Format(giamgiachangeinfotongcong8, "{0:c}", tongcongsauchange8);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate8;
                }
                numshopcartsoluong2.Enabled = false;
            }
            else if (checkbox2 % 2 == 0)
            {
                --demsocheck;
             
                numshopcartsoluong2.Enabled = true;
                checkboxshopcartALL.Checked = false;
                luutongcong = luutongcong - Convert.ToInt32(dt.Rows[1]["Thanhtien"]);
                var gia18 = luutongcong;
                var info18 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien18 = String.Format(info18, "{0:c}", gia18);
                lbshopcartTINHTIEN_tongcong.Text = tien18;
                lbshopcartTINHTIEN_tamtinh.Text = tien18;
                checkbox2++;
              
                if (giam20 == 1)
                {
                    int updateluutongcong5 = luutongcong * 2 / 10;
                    int tongcongsauchange5 = luutongcong * 8 / 10;
                    var giamgiachangeinfo5 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange5 = String.Format(giamgiachangeinfo5, "{0:c}", updateluutongcong5);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange5;
                    /////////
                    ///
                    var giamgiachangeinfotongcong5 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate5 = String.Format(giamgiachangeinfotongcong5, "{0:c}", tongcongsauchange5);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate5;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong6 = luutongcong * 1 / 10;
                    int tongcongsauchange6 = luutongcong * 9 / 10;
                    var giamgiachangeinfo6 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang6 = String.Format(giamgiachangeinfo6, "{0:c}", updateluutongcong6);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang6;
                    /////////
                    ///
                    var giamgiachangeinfotongcong6 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate6 = String.Format(giamgiachangeinfotongcong6, "{0:c}", tongcongsauchange6);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate6;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong7 = luutongcong * 5 / 10;
                    int tongcongsauchange7 = luutongcong * 5 / 10;
                    var giamgiachangeinfo7 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang7 = String.Format(giamgiachangeinfo7, "{0:c}", updateluutongcong7);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang7;

                    /////////
                    ///
                    var giamgiachangeinfotongcong7 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate7 = String.Format(giamgiachangeinfotongcong7, "{0:c}", tongcongsauchange7);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate7;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong8 = luutongcong * 6 / 10;
                    int tongcongsauchange8 = luutongcong * 4 / 10;
                    var giamgiachangeinfo8 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang8 = String.Format(giamgiachangeinfo8, "{0:c}", updateluutongcong8);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang8;

                    /////////
                    ///
                    var giamgiachangeinfotongcong8 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate8 = String.Format(giamgiachangeinfotongcong8, "{0:c}", tongcongsauchange8);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate8;
                }
            }
        }

        private void checkboxshopcart3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox3 % 2 != 0)
            {
                ++demsocheck;
               
                if (demsocheck == dt.Rows.Count)
                {
                    checkboxshopcartALL.Checked = true;
                }
                luutongcong = luutongcong + Convert.ToInt32(dt.Rows[2]["Thanhtien"]);
                var gia19 = luutongcong;
                var info19 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien19 = String.Format(info19, "{0:c}", gia19);
                lbshopcartTINHTIEN_tamtinh.Text = tien19;
                lbshopcartTINHTIEN_tongcong.Text = tien19;
                checkbox3++;
              
                if (giam20 == 1)
                {
                    int updateluutongcong9 = luutongcong * 2 / 10;
                    int tongcongsauchange9 = luutongcong * 8 / 10;
                    var giamgiachangeinfo9 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange9 = String.Format(giamgiachangeinfo9, "{0:c}", updateluutongcong9);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange9;

                    /////////
                    ///
                    var giamgiachangeinfotongcong9 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate9 = String.Format(giamgiachangeinfotongcong9, "{0:c}", tongcongsauchange9);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate9;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong10 = luutongcong * 1 / 10;
                    int tongcongsauchange10 = luutongcong * 9 / 10;
                    var giamgiachangeinfo10 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang10 = String.Format(giamgiachangeinfo10, "{0:c}", updateluutongcong10);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang10;
                    /////////
                    ///
                    var giamgiachangeinfotongcong10 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate10 = String.Format(giamgiachangeinfotongcong10, "{0:c}", tongcongsauchange10);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate10;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong11 = luutongcong * 5 / 10;
                    int tongcongsauchange11 = luutongcong * 5 / 10;
                    var giamgiachangeinfo11 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang11 = String.Format(giamgiachangeinfo11, "{0:c}", updateluutongcong11);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang11;
                    /////////
                    ///
                    var giamgiachangeinfotongcong11 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate11 = String.Format(giamgiachangeinfotongcong11, "{0:c}", tongcongsauchange11);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate11;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong12 = luutongcong * 6 / 10;
                    int tongcongsauchange12 = luutongcong * 4 / 10;
                    var giamgiachangeinfo12 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang12 = String.Format(giamgiachangeinfo12, "{0:c}", updateluutongcong12);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang12;
                    /////////
                    ///
                    var giamgiachangeinfotongcong12 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate12 = String.Format(giamgiachangeinfotongcong12, "{0:c}", tongcongsauchange12);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate12;
                }
                numshopcartsoluong3.Enabled = false;
            }
            else if (checkbox3 % 2 == 0)
            {
                --demsocheck;
               
                numshopcartsoluong3.Enabled = true;
                checkboxshopcartALL.Checked = false;
                luutongcong = luutongcong - Convert.ToInt32(dt.Rows[2]["Thanhtien"]);
                var gia20 = luutongcong;
                var info20 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien20 = String.Format(info20, "{0:c}", gia20);
                lbshopcartTINHTIEN_tamtinh.Text = tien20;
                lbshopcartTINHTIEN_tongcong.Text = tien20;
                checkbox3++;
               
                if (giam20 == 1)
                {
                    int updateluutongcong9 = luutongcong * 2 / 10;
                    int tongcongsauchange9 = luutongcong * 8 / 10;
                    var giamgiachangeinfo9 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange9 = String.Format(giamgiachangeinfo9, "{0:c}", updateluutongcong9);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange9;

                    /////////
                    ///
                    var giamgiachangeinfotongcong9 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate9 = String.Format(giamgiachangeinfotongcong9, "{0:c}", tongcongsauchange9);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate9;
                }
                else if (giam10 == 1)
                {

                    int updateluutongcong10 = luutongcong * 1 / 10;
                    int tongcongsauchange10 = luutongcong * 9 / 10;
                    var giamgiachangeinfo10 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang10 = String.Format(giamgiachangeinfo10, "{0:c}", updateluutongcong10);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang10;
                    /////////
                    ///
                    var giamgiachangeinfotongcong10 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate10 = String.Format(giamgiachangeinfotongcong10, "{0:c}", tongcongsauchange10);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate10;
                }
                else if (giam50 == 1)
                {

                    int updateluutongcong11 = luutongcong * 5 / 10;
                    int tongcongsauchange11 = luutongcong * 5 / 10;
                    var giamgiachangeinfo11 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang11 = String.Format(giamgiachangeinfo11, "{0:c}", updateluutongcong11);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang11;
                    /////////
                    ///
                    var giamgiachangeinfotongcong11 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate11 = String.Format(giamgiachangeinfotongcong11, "{0:c}", tongcongsauchange11);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate11;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong12 = luutongcong * 6 / 10;
                    int tongcongsauchange12 = luutongcong * 4 / 10;
                    var giamgiachangeinfo12 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang12 = String.Format(giamgiachangeinfo12, "{0:c}", updateluutongcong12);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang12;
                    /////////
                    ///
                    var giamgiachangeinfotongcong12 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate12 = String.Format(giamgiachangeinfotongcong12, "{0:c}", tongcongsauchange12);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate12;
                }
            }
        }

        private void checkboxshopcart4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox4 % 2 != 0)
            {
                ++demsocheck;
                if (demsocheck == dt.Rows.Count)
                {
                    checkboxshopcartALL.Checked = true;
                }
                luutongcong = luutongcong + Convert.ToInt32(dt.Rows[3]["Thanhtien"]);
                var gia21 = luutongcong;
                var info21 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien21 = String.Format(info21, "{0:c}", gia21);
                lbshopcartTINHTIEN_tamtinh.Text = tien21;
                lbshopcartTINHTIEN_tongcong.Text = tien21;
                checkbox4++;
                if (giam20 == 1)
                {
                    int updateluutongcong13 = luutongcong * 2 / 10;
                    int tongcongsauchange13 = luutongcong * 8 / 10;
                    var giamgiachangeinfo13 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange13 = String.Format(giamgiachangeinfo13, "{0:c}", updateluutongcong13);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange13;

                    /////////
                    ///
                    var giamgiachangeinfotongcong13 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate13 = String.Format(giamgiachangeinfotongcong13, "{0:c}", tongcongsauchange13);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate13;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong14 = luutongcong * 1 / 10;
                    int tongcongsauchange14 = luutongcong * 9 / 10;
                    var giamgiachangeinfo14 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang14 = String.Format(giamgiachangeinfo14, "{0:c}", updateluutongcong14);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang14;

                    /////////
                    ///
                    var giamgiachangeinfotongcong14 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate14 = String.Format(giamgiachangeinfotongcong14, "{0:c}", tongcongsauchange14);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate14;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong15 = luutongcong * 5 / 10;
                    int tongcongsauchange15 = luutongcong * 5 / 10;
                    var giamgiachangeinfo15= System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang15 = String.Format(giamgiachangeinfo15, "{0:c}", updateluutongcong15);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang15;
                    /////////
                    ///
                    var giamgiachangeinfotongcong15 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate15 = String.Format(giamgiachangeinfotongcong15, "{0:c}", tongcongsauchange15);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate15;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong16 = luutongcong * 6 / 10;
                    int tongcongsauchange16 = luutongcong * 4 / 10;
                    var giamgiachangeinfo16 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang16 = String.Format(giamgiachangeinfo16, "{0:c}", updateluutongcong16);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang16;

                    /////////
                    ///
                    var giamgiachangeinfotongcong16 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate16 = String.Format(giamgiachangeinfotongcong16, "{0:c}", tongcongsauchange16);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate16;
                }
                numshopcartsoluong4.Enabled = false;
            }
            else if (checkbox4 % 2 == 0)
            {
                --demsocheck;
                numshopcartsoluong4.Enabled = true;
                checkboxshopcartALL.Checked = false;
                luutongcong = luutongcong - Convert.ToInt32(dt.Rows[3]["Thanhtien"]);
                var gia22 = luutongcong;
                var info22 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien22 = String.Format(info22, "{0:c}", gia22);
                lbshopcartTINHTIEN_tamtinh.Text = tien22;
                lbshopcartTINHTIEN_tongcong.Text = tien22;
                checkbox4++;
                if (giam20 == 1)
                {

                    int updateluutongcong13 = luutongcong * 2 / 10;
                    int tongcongsauchange13 = luutongcong * 8 / 10;
                    var giamgiachangeinfo13 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange13 = String.Format(giamgiachangeinfo13, "{0:c}", updateluutongcong13);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange13;

                    /////////
                    ///
                    var giamgiachangeinfotongcong13 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate13 = String.Format(giamgiachangeinfotongcong13, "{0:c}", tongcongsauchange13);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate13;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong14 = luutongcong * 1 / 10;
                    int tongcongsauchange14 = luutongcong * 9 / 10;
                    var giamgiachangeinfo14 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang14 = String.Format(giamgiachangeinfo14, "{0:c}", updateluutongcong14);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang14;

                    /////////
                    ///
                    var giamgiachangeinfotongcong14 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate14 = String.Format(giamgiachangeinfotongcong14, "{0:c}", tongcongsauchange14);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate14;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong15 = luutongcong * 5 / 10;
                    int tongcongsauchange15 = luutongcong * 5 / 10;
                    var giamgiachangeinfo15 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang15 = String.Format(giamgiachangeinfo15, "{0:c}", updateluutongcong15);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang15;
                    /////////
                    ///
                    var giamgiachangeinfotongcong15 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate15 = String.Format(giamgiachangeinfotongcong15, "{0:c}", tongcongsauchange15);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate15;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong16 = luutongcong * 6 / 10;
                    int tongcongsauchange16 = luutongcong * 4 / 10;
                    var giamgiachangeinfo16 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang16 = String.Format(giamgiachangeinfo16, "{0:c}", updateluutongcong16);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang16;

                    /////////
                    ///
                    var giamgiachangeinfotongcong16 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate16 = String.Format(giamgiachangeinfotongcong16, "{0:c}", tongcongsauchange16);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate16;
                }
            }
        }

        private void checkboxshopcart5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox5 % 2 != 0)
            {
                ++demsocheck;
                if (demsocheck == dt.Rows.Count)
                {
                    checkboxshopcartALL.Checked = true;
                }
                luutongcong = luutongcong + Convert.ToInt32(dt.Rows[4]["Thanhtien"]);
                var gia23 = luutongcong;
                var info23 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien23 = String.Format(info23, "{0:c}", gia23);
                lbshopcartTINHTIEN_tamtinh.Text = tien23;
                lbshopcartTINHTIEN_tongcong.Text = tien23;
                checkbox5++;
                if (giam20 == 1)
                {
                    int updateluutongcong17 = luutongcong * 2 / 10;
                    int tongcongsauchange17 = luutongcong * 8 / 10;
                    var giamgiachangeinfo17 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange17 = String.Format(giamgiachangeinfo17, "{0:c}", updateluutongcong17);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange17;
                    /////////
                    ///
                    var giamgiachangeinfotongcong17 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate17 = String.Format(giamgiachangeinfotongcong17, "{0:c}", tongcongsauchange17);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate17;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong18 = luutongcong * 1 / 10;
                    int tongcongsauchange18 = luutongcong * 9 / 10;
                    var giamgiachangeinfo18 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang18 = String.Format(giamgiachangeinfo18, "{0:c}", updateluutongcong18);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang18;
                    /////////
                    ///
                    var giamgiachangeinfotongcong18 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate18 = String.Format(giamgiachangeinfotongcong18, "{0:c}", tongcongsauchange18);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate18;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong19 = luutongcong * 5 / 10;
                    int tongcongsauchange19 = luutongcong * 5 / 10;
                    var giamgiachangeinfo19 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang19 = String.Format(giamgiachangeinfo19, "{0:c}", updateluutongcong19);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang19;
                    /////////
                    ///
                    var giamgiachangeinfotongcong19 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate19 = String.Format(giamgiachangeinfotongcong19, "{0:c}", tongcongsauchange19);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate19;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong20 = luutongcong * 6 / 10;
                    int tongcongsauchange20 = luutongcong * 4 / 10;
                    var giamgiachangeinfo20 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang20 = String.Format(giamgiachangeinfo20, "{0:c}", updateluutongcong20);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang20;
                    /////////
                    ///
                    var giamgiachangeinfotongcong20 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate20 = String.Format(giamgiachangeinfotongcong20, "{0:c}", tongcongsauchange20);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate20;
                }
                numshopcartsoluong5.Enabled = false;
            }
            else if (checkbox5 % 2 == 0)
            {
                --demsocheck;
                numshopcartsoluong5.Enabled = true;
                checkboxshopcartALL.Checked = false;
                luutongcong = luutongcong - Convert.ToInt32(dt.Rows[4]["Thanhtien"]);
                var gia24 = luutongcong;
                var info24 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien24 = String.Format(info24, "{0:c}", gia24);
                lbshopcartTINHTIEN_tamtinh.Text = tien24;
                lbshopcartTINHTIEN_tongcong.Text = tien24;
                checkbox5++;
                if (giam20 == 1)
                {
                    int updateluutongcong17 = luutongcong * 2 / 10;
                    int tongcongsauchange17 = luutongcong * 8 / 10;
                    var giamgiachangeinfo17 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchange17 = String.Format(giamgiachangeinfo17, "{0:c}", updateluutongcong17);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchange17;
                    /////////
                    ///
                    var giamgiachangeinfotongcong17 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate17 = String.Format(giamgiachangeinfotongcong17, "{0:c}", tongcongsauchange17);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate17;
                }
                else if (giam10 == 1)
                {
                    int updateluutongcong18 = luutongcong * 1 / 10;
                    int tongcongsauchange18 = luutongcong * 9 / 10;
                    var giamgiachangeinfo18 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang18 = String.Format(giamgiachangeinfo18, "{0:c}", updateluutongcong18);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang18;
                    /////////
                    ///
                    var giamgiachangeinfotongcong18 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate18 = String.Format(giamgiachangeinfotongcong18, "{0:c}", tongcongsauchange18);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate18;
                }
                else if (giam50 == 1)
                {
                    int updateluutongcong19 = luutongcong * 5 / 10;
                    int tongcongsauchange19 = luutongcong * 5 / 10;
                    var giamgiachangeinfo19 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang19 = String.Format(giamgiachangeinfo19, "{0:c}", updateluutongcong19);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang19;
                    /////////
                    ///
                    var giamgiachangeinfotongcong19 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate19 = String.Format(giamgiachangeinfotongcong19, "{0:c}", tongcongsauchange19);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate19;
                }
                else if (giam60 == 1)
                {
                    int updateluutongcong20 = luutongcong * 6 / 10;
                    int tongcongsauchange20 = luutongcong * 4 / 10;
                    var giamgiachangeinfo20 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string giamgiasauchang20 = String.Format(giamgiachangeinfo20, "{0:c}", updateluutongcong20);
                    lbshopcartTINHTIEN_Giamgia.Text = giamgiasauchang20;
                    /////////
                    ///
                    var giamgiachangeinfotongcong20 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tongcongsauchangeupdate20 = String.Format(giamgiachangeinfotongcong20, "{0:c}", tongcongsauchange20);
                    lbshopcartTINHTIEN_tongcong.Text = tongcongsauchangeupdate20;
                }
            }
        }

        private void label64_Click(object sender, EventArgs e)
        {
            
        }
        int giam201 = 1;
        int giam101 = 1;
        int giam501 = 1;
        int giam601 = 1;
        private void btndiscount20_Click(object sender, EventArgs e)
        {
            if(giam201 %2 != 0)
            {
                int s = luutongcong * 2 / 10;
                int s1 = luutongcong * 8 / 10;
                var info25 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien1 = String.Format(info25, "{0:c}", s);
                lbshopcartTINHTIEN_Giamgia.Text = tien1;
                string tien2 = String.Format(info25, "{0:c}", s1);
                lbshopcartTINHTIEN_tongcong.Text = tien2;
                btndiscount20.BackColor = Color.Red;
                giam201++;
                giam20 = 1;
                
            }
            else if(giam201 %2 == 0)
            {
                lbshopcartTINHTIEN_Giamgia.Text = "0,00 đ";
                int s8 = luutongcong;
                var info40 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien5 = String.Format(info40, "{0:c}", s8);
                lbshopcartTINHTIEN_tongcong.Text = tien5;
                btndiscount20.BackColor = Color.Transparent;
                giam201++;
                giam20 = 0;  
            }    
        }

        private void btndiscount50_Click(object sender, EventArgs e)
        {
            if(giam501 %2 != 0 )
            {
                int s4 = luutongcong * 5 / 10;
                int s5 = luutongcong * 5 / 10;
                var info27 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien4 = String.Format(info27, "{0:c}", s4);
                lbshopcartTINHTIEN_Giamgia.Text = tien4;
                string tien5 = String.Format(info27, "{0:c}", s5);
                lbshopcartTINHTIEN_tongcong.Text = tien5;
                btndiscount50.BackColor = Color.Red;
                giam501++;
                giam50 = 1;
            }
            else if (giam501 %2 ==0)
            {
                lbshopcartTINHTIEN_Giamgia.Text = "0,00 đ";
                int s9 = luutongcong;
                var info41 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien6 = String.Format(info41, "{0:c}", s9);
                lbshopcartTINHTIEN_tongcong.Text = tien6;
                btndiscount50.BackColor = Color.Transparent;
                giam501++;
                giam50 = 0;
            }
            
        }

        private void btndiscount60_Click(object sender, EventArgs e)
        {   if (giam601 % 2 != 0)
            {
                int s2 = luutongcong * 6 / 10;
                int s3 = luutongcong * 4 / 10;
                var info26 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien2 = String.Format(info26, "{0:c}", s2);
                lbshopcartTINHTIEN_Giamgia.Text = tien2;
                string tien3 = String.Format(info26, "{0:c}", s3);
                lbshopcartTINHTIEN_tongcong.Text = tien3;
                btndiscount60.BackColor = Color.Red;
                giam601++;
                giam60 = 1;
            }
            else if (giam601 %2 == 0)
            {
                lbshopcartTINHTIEN_Giamgia.Text = "0,00 đ";
                int s10 = luutongcong;
                var info42 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien7 = String.Format(info42, "{0:c}", s10);
                lbshopcartTINHTIEN_tongcong.Text = tien7;
                btndiscount60.BackColor = Color.Transparent;
                giam601++;
                giam60 = 0;
            }

           
        }

        private void btndiscount10_Click(object sender, EventArgs e)
        {
            if(giam101 %2 != 0)
            {
                int s6 = luutongcong * 1 / 10;
                int s7 = luutongcong * 9 / 10;
                var info28 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien2 = String.Format(info28, "{0:c}", s6);
                lbshopcartTINHTIEN_Giamgia.Text = tien2;
                string tien3 = String.Format(info28, "{0:c}", s7);
                lbshopcartTINHTIEN_tongcong.Text = tien3;
                btndiscount10.BackColor = Color.Red;
                giam101++;
                giam10 = 1;
            }
            else if (giam101 %2 == 0 )
            {
                lbshopcartTINHTIEN_Giamgia.Text = "0,00 đ";
                int s11 = luutongcong;
                var info43 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string tien8 = String.Format(info43, "{0:c}", s11);
                lbshopcartTINHTIEN_tongcong.Text = tien8;
                btndiscount10.BackColor = Color.Transparent;
                giam101++;
                giam10 = 0;
            }
          
        }
        int sodongwhencheckall;
        int checkboxall = 1;
        int not1;
        private void checkboxshopcartALL_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxall %2 != 0 )
            {
                sodongwhencheckall = dt.Rows.Count;
                if(demsocheck==sodongwhencheckall)
                {

                }
                else
                {
                    if (sodongwhencheckall == 1)
                    {
                        if(checkboxshopcart1.Checked==false)
                        {
                            checkbox1 = 1;
                            checkboxshopcart1.Checked = true;
                        }
                        else if(checkboxshopcart1.Checked==true)
                        {
                            checkbox1 = 2;
                            checkboxshopcart1.Checked = true;
                        }
                        

                    }
                    
                    else if (sodongwhencheckall == 2)
                    {
                       
                        if (checkboxshopcart1.Checked == false)
                        {
                            checkbox1 = 1;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                            }
                            else if(checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;

                            }
                        }
                        else if (checkboxshopcart1.Checked == true)
                        {
                            checkbox1 = 2;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;

                            }
                        }

                    }
                    else if (sodongwhencheckall == 3)
                    {
                        
                      
                        
                        if (checkboxshopcart1.Checked == false)
                        {
                            checkbox1 = 1;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                }
                                else if(checkboxshopcart3.Checked==true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                }
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                }

                            }
                        }
                        else if (checkboxshopcart1.Checked == true)
                        {
                            checkbox1 = 2;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                }
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                }


                            }
                        }

                    }
                    else if (sodongwhencheckall == 4)
                    {
                        
                        if (checkboxshopcart1.Checked == false)
                        {
                            checkbox1 = 1;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked==true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }

                            }
                        }
                        else if (checkboxshopcart1.Checked == true)
                        {
                            checkbox1 = 2;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;

                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                    }
                                }


                            }
                        }

                    }
                    else if (sodongwhencheckall == 5)
                    {
                        if (checkboxshopcart1.Checked == false)
                        {
                            checkbox1 = 1;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if(checkboxshopcart5.Checked==true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }

                            }
                        }
                        else if (checkboxshopcart1.Checked == true)
                        {
                            checkbox1 = 2;
                            checkboxshopcart1.Checked = true;
                            if (checkboxshopcart2.Checked == false)
                            {
                                checkbox2 = 1;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }

                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }
                            }
                            else if (checkboxshopcart2.Checked == true)
                            {
                                checkbox2 = 2;
                                checkboxshopcart2.Checked = true;
                                if (checkboxshopcart3.Checked == false)
                                {
                                    checkbox3 = 1;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }
                                else if (checkboxshopcart3.Checked == true)
                                {
                                    checkbox3 = 2;
                                    checkboxshopcart3.Checked = true;
                                    if (checkboxshopcart4.Checked == false)
                                    {
                                        checkbox4 = 1;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                    else if (checkboxshopcart4.Checked == true)
                                    {
                                        checkbox4 = 2;
                                        checkboxshopcart4.Checked = true;
                                        if (checkboxshopcart5.Checked == false)
                                        {
                                            checkbox5 = 1;
                                            checkboxshopcart5.Checked = true;
                                        }
                                        else if (checkboxshopcart5.Checked == true)
                                        {
                                            checkbox5 = 2;
                                            checkboxshopcart5.Checked = true;
                                        }
                                    }
                                }


                            }
                        }

                    }
                }
               

                checkboxall++;
               

            }
            else if (checkboxall %2 == 0)
            {
                sodongwhencheckall = dt.Rows.Count;
                if(demsocheck==sodongwhencheckall)
                {
                    if(sodongwhencheckall==1)
                    {
                        checkbox1 = 2;
                        checkboxshopcart1.Checked = false;
                        demsocheck = 0;
                    }
                    else if (sodongwhencheckall==2)
                    {
                        checkbox1 = 2;
                        checkbox2 = 2;
                        checkboxshopcart1.Checked = false;
                        checkboxshopcart2.Checked = false;
                        demsocheck = 0;
                    }
                    else if(sodongwhencheckall==3)
                    {
                        checkbox1 = 2;
                        checkbox2 = 2;
                        checkbox3 = 2;
                        checkboxshopcart1.Checked = false;
                        
                        checkboxshopcart2.Checked = false;
                        
                        checkboxshopcart3.Checked = false;
                        demsocheck = 0;
                    }
                    else if(sodongwhencheckall==4)
                    {
                        checkbox1 = 2;
                        checkbox2 = 2;
                        checkbox3 = 2;
                        checkbox4 = 2;
                        checkboxshopcart1.Checked = false;
                       
                        checkboxshopcart2.Checked = false;
                        
                        checkboxshopcart3.Checked = false;
                        
                        checkboxshopcart4.Checked = false;
                        demsocheck = 0;
                    }
                    else if(sodongwhencheckall==5)
                    {
                        checkbox1 = 2;
                        checkbox2 = 2;
                        checkbox3 = 2;
                        checkbox4 = 2;
                        checkbox5 = 2;
                        checkboxshopcart1.Checked = false;
                        
                        checkboxshopcart2.Checked = false;
                        
                        checkboxshopcart3.Checked = false;
                        
                        checkboxshopcart4.Checked = false;
                        
                        checkboxshopcart5.Checked = false;
                        demsocheck = 0;
                    }
                }
                else if (demsocheck != sodongwhencheckall)
                {

                }
                checkboxall++;
               


            }


        }
        string check1 = "";
        string check2 = "";
        string check3 = "";
        string check4 = "";
        string check5 = "";
        int sodonhuy = 0;
        private void btnshopcartdelete1_Click(object sender, EventArgs e)
        {
            sodonhuy++;
            if(checkboxshopcart1.Checked==false)
            {
                check1 = "Not Check";
                if(checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if(checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if(checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            } 
            else if (checkboxshopcart1.Checked == true)
            {
                check1 = "Checked";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if(checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            int sodongtruocdelete0 = dt.Rows.Count;
            if (sodongtruocdelete0 == 1)
            {
                checkboxshopcart1.Checked = false;
                pnlshopcartbuying1.Visible = false;
                checkboxshopcart1.Visible = false;
                dataGridView1.Rows.RemoveAt(0);
            }
            else if (sodongtruocdelete0 == 2)
            {
                dt1.Rows.Add(1, "Conmem", "eu", 4774, 1, 1, "fdfdfdf");
                dt1.Rows[0]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                dataGridView1.Rows.RemoveAt(0);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                luutongcong = 0;
                if (check2=="Not Check")
                {
                    checkboxshopcart1.Checked = false;
                }
                else if(check2 =="Checked")
                {
                    checkboxshopcart1.Checked = true;
                }
            }
            else if (sodongtruocdelete0 == 3)
            {
                ////////// Move data From dt to dt1
                dt1.Rows.Add(1, "Conmem", "eu", 4774, 1, 1, "fdfdfdf");
                dt1.Rows.Add(2, "Conmem", "eu", 4774, 1, 1, "fdfdfdf");
                dt1.Rows[0]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[1]["STT"] = dt.Rows[2]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[2]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[2]["Giatien"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[2]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[2]["Thanhtien"];
                //////////////////////////////////////////
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                dataGridView1.Rows.RemoveAt(0);
                ///////////////////////////////
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                luutongcong = 0;
                if (check2 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                    }
                    else if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                    }
                }
                else if (check2 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                    }
                    else if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                    }
                }
                

            }
            else if (sodongtruocdelete0 == 4)
            {
                dt1.Rows.Add(1, "Conmem", "eu", 4774, 1, 1, "fdfdfdf");
                dt1.Rows.Add(2, "Conmem", "eu", 4774, 1, 1, "fdfdfdf");
                dt1.Rows.Add(3, "Conmem", "eu", 4774, 1, 1, "fdfdfdf");
                dt1.Rows[0]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[1]["STT"] = dt.Rows[2]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[2]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[2]["Giatien"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[2]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[2]["Thanhtien"];
                //////////////////////////////////////////
                dt1.Rows[2]["STT"]        = dt.Rows[3]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[3]["Tensanpham"];
                dt1.Rows[2]["SIZE"]       = dt.Rows[3]["SIZE"];
                dt1.Rows[2]["Giatien"]    = dt.Rows[3]["Giatien"];
                dt1.Rows[2]["Giamgia"]    = dt.Rows[3]["Giamgia"];
                dt1.Rows[2]["Thanhtien"]  = dt.Rows[3]["Thanhtien"];
              
                //////////////////////////////////////////
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                luutongcong = 0;
              
                dataGridView1.Rows.RemoveAt(0);
               
                if (check2 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if(check4=="Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }

                    }
                    else if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                    }
                }
                else if (check2 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                    }
                    else if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                    }
                }

            }
            else if (sodongtruocdelete0 == 5)
            {
                dt1.Rows.Add(1, "Conmem", "eu", 4774, 1, 7, "fdfdfdf");
                dt1.Rows.Add(2, "Conmem", "eu", 4774, 1, 7, "fdfdfdf");
                dt1.Rows.Add(3, "Conmem", "eu", 4774, 1, 7, "fdfdfdf");
                dt1.Rows.Add(4, "Conmem", "eu", 4774, 1, 7, "fdfdfdf");
                ///////////////////////////////////////////////
                dt1.Rows[0]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[1]["STT"] = dt.Rows[2]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[2]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[2]["Giatien"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[2]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[2]["Thanhtien"];
                //////////////////////////////////////////
                dt1.Rows[2]["STT"] = dt.Rows[3]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[3]["Tensanpham"];
                dt1.Rows[2]["SIZE"] = dt.Rows[3]["SIZE"];
                dt1.Rows[2]["Giatien"] = dt.Rows[3]["Giatien"];
                dt1.Rows[2]["Giamgia"] = dt.Rows[3]["Giamgia"];
                dt1.Rows[2]["Thanhtien"] = dt.Rows[3]["Thanhtien"];
                //////////////////////////////////////////
                dt1.Rows[3]["STT"]        = dt.Rows[4]["STT"];
                dt1.Rows[3]["Tensanpham"] = dt.Rows[4]["Tensanpham"];
                dt1.Rows[3]["SIZE"]       = dt.Rows[4]["SIZE"];
                dt1.Rows[3]["Giatien"]    = dt.Rows[4]["Giatien"];
                dt1.Rows[3]["Giamgia"]    = dt.Rows[4]["Giamgia"];
                dt1.Rows[3]["Thanhtien"]  = dt.Rows[4]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                dt.Rows[4]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                checkboxshopcart5.Checked = false;
                dataGridView1.Rows.RemoveAt(0);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                ////////////////////////////////
                dt.Rows[3]["STT"]        = dt1.Rows[3]["STT"];
                dt.Rows[3]["Tensanpham"] = dt1.Rows[3]["Tensanpham"];
                dt.Rows[3]["SIZE"]       = dt1.Rows[3]["SIZE"];
                dt.Rows[3]["Giatien"]    = dt1.Rows[3]["Giatien"];
                dt.Rows[3]["Soluong"]    = dt1.Rows[3]["Soluong"];
                dt.Rows[3]["Giamgia"]    = dt1.Rows[3]["Giamgia"];
                dt.Rows[3]["Thanhtien"]  = dt1.Rows[3]["Thanhtien"];
                luutongcong = 0;
                if (check2 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if(check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }

                    }
                    else if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                    }
                }
                else if (check2 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                    }
                    else if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                        else if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                            else if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                        }
                    }
                }


            }
            int sodongsaudelete0 = dt.Rows.Count;
            int dem = 1;
            for (int i = 1; i <= sodongsaudelete0; i++)
            {
                if (dem == 1)
                {

                    lbshopcartinfo1.Text = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia = Convert.ToInt32(dt.Rows[0]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien0 = String.Format(info, "{0:c}", gia);
                    //////
                    lbshopcartdongia1.Text = tien0;
                    lbshopcartthanhtien1.Text = tien0;
                    lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                   
                    string tensanpham = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    switch (tensanpham)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart1.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart1.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart1.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart1.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart1.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart1.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart1.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart1.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart1.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart1.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying1.Visible = true;
                    checkboxshopcart1.Visible = true;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 2 && dem <= sodongsaudelete0)
                {

                    lbshopcartinfo2.Text = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia1 = Convert.ToInt32(dt.Rows[1]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien1 = String.Format(info, "{0:c}", gia1);
                    //////
                    lbshopcartdongia2.Text = tien1;
                    lbshopcartthanhtien2.Text = tien1;
                    lbshopcartSIZE2.Text = Convert.ToString(dt.Rows[1]["SIZE"]);
                  
                    string tensanpham1 = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    switch (tensanpham1)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart2.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart2.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart2.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart2.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart2.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart2.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart2.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart2.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart2.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart2.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying2.Visible = true;
                    checkboxshopcart2.Visible = true;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 3 && dem <= sodongsaudelete0)
                {
                    lbshopcartinfo3.Text = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia2 = Convert.ToInt32(dt.Rows[2]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien2 = String.Format(info, "{0:c}", gia2);
                    //////
                    lbshopcartdongia3.Text = tien2;
                    lbshopcartthanhtien3.Text = tien2;
                    lbshopcartSIZE3.Text = Convert.ToString(dt.Rows[2]["SIZE"]);
                   
                    string tensanpham2 = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    switch (tensanpham2)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart3.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart3.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart3.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart3.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart3.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart3.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart3.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart3.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart3.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart3.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying3.Visible = true;
                    checkboxshopcart3.Visible = true;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;
                }
                else if (dem == 4 && dem <= sodongsaudelete0)
                {
                    lbshopcartinfo4.Text = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia3 = Convert.ToInt32(dt.Rows[3]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien3 = String.Format(info, "{0:c}", gia3);
                    //////
                    lbshopcartdongia4.Text = tien3;
                    lbshopcartthanhtien4.Text = tien3;
                    lbshopcartSIZE4.Text = Convert.ToString(dt.Rows[3]["SIZE"]);
                   
                    string tensanpham3 = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    switch (tensanpham3)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart4.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart4.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart4.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart4.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart4.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart4.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart4.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart4.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart4.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart4.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying4.Visible = true;
                    checkboxshopcart4.Visible = true;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 5 && dem <= sodongsaudelete0)
                {
                    lbshopcartinfo5.Text = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia4 = Convert.ToInt32(dt.Rows[4]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien4 = String.Format(info, "{0:c}", gia4);
                    //////
                    lbshopcartdongia5.Text = tien4;
                    lbshopcartthanhtien5.Text = tien4;
                    lbshopcartSIZE5.Text = Convert.ToString(dt.Rows[4]["SIZE"]);
                   
                    string tensanpham4 = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    switch (tensanpham4)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart5.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart5.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart5.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart5.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart5.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart5.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart5.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart5.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart5.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart5.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying5.Visible = true;
                    checkboxshopcart5.Visible = true;
                }
                dt1.Clear();
                dataGridView2.Refresh();

            }
           



        }

        private void btnshopcartdelete2_Click(object sender, EventArgs e)
        {
            sodonhuy++;
            if (checkboxshopcart1.Checked == false)
            {
                check1 = "Not Check";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            else if (checkboxshopcart1.Checked == true)
            {
                check1 = "Checked";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            int sodongtruocdelete1 = dt.Rows.Count;
            if(sodongtruocdelete1==2)
            {
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                pnlshopcartbuying2.Visible = false;
                checkboxshopcart2.Visible = false;
                dataGridView1.Rows.RemoveAt(1);
                if(check1 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                }
                
            }
            else if (sodongtruocdelete1 == 3)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                ////////////////////////////////////////////////////
                dt1.Rows[0]["STT"]        = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"]       = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"]    = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"]    = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"]    = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"]  = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"]        = dt.Rows[2]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[1]["SIZE"]       = dt.Rows[2]["SIZE"];
                dt1.Rows[1]["Giatien"]    = dt.Rows[2]["Giatien"];
                dt1.Rows[1]["Soluong"]    = dt.Rows[2]["Soluong"];
                dt1.Rows[1]["Giamgia"]    = dt.Rows[2]["Giamgia"];
                dt1.Rows[1]["Thanhtien"]  = dt.Rows[2]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                dataGridView1.Rows.RemoveAt(1);
                ///////////////////////////////////////////////////////
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"]        = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"]       = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"]    = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"]    = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"]    = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"]  = dt1.Rows[1]["Thanhtien"];
                luutongcong = 0;
                if(check1=="Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if(check3=="Checked")
                    {
                        checkboxshopcart2.Checked = true;
                    }
                    else if(check3=="Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                    }
                }
                else if (check1 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                    }
                    else if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                    }
                }


            }
            else if (sodongtruocdelete1 == 4)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(3, "dddd", "dsd", 1, 1, 1, "1");
                ////////////////////////////////////////////////////
                dt1.Rows[0]["STT"] = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"] = dt.Rows[2]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[2]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[2]["Giatien"];
                dt1.Rows[1]["Soluong"] = dt.Rows[2]["Soluong"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[2]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[2]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[2]["STT"]        = dt.Rows[3]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[3]["Tensanpham"];
                dt1.Rows[2]["SIZE"]       = dt.Rows[3]["SIZE"];
                dt1.Rows[2]["Giatien"]    = dt.Rows[3]["Giatien"];
                dt1.Rows[2]["Soluong"]    = dt.Rows[3]["Soluong"];
                dt1.Rows[2]["Giamgia"]    = dt.Rows[3]["Giamgia"];
                dt1.Rows[2]["Thanhtien"]  = dt.Rows[3]["Thanhtien"];
                /////////////////////////////////////////////
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                dataGridView1.Rows.RemoveAt(1);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[2]["STT"]        = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"]       = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"]    = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"]    = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"]    = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"]  = dt1.Rows[2]["Thanhtien"];
                luutongcong = 0;
                if(check1 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if(check4=="Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4=="Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                    else if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }

                }
                else if (check1 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                    else if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                }
            }
            else if (sodongtruocdelete1 == 5)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(3, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(4, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows[0]["STT"] = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"] = dt.Rows[2]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[2]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[2]["Giatien"];
                dt1.Rows[1]["Soluong"] = dt.Rows[2]["Soluong"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[2]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[2]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[2]["STT"] = dt.Rows[3]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[3]["Tensanpham"];
                dt1.Rows[2]["SIZE"] = dt.Rows[3]["SIZE"];
                dt1.Rows[2]["Giatien"] = dt.Rows[3]["Giatien"];
                dt1.Rows[2]["Soluong"] = dt.Rows[3]["Soluong"];
                dt1.Rows[2]["Giamgia"] = dt.Rows[3]["Giamgia"];
                dt1.Rows[2]["Thanhtien"] = dt.Rows[3]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[3]["STT"]        = dt.Rows[4]["STT"];
                dt1.Rows[3]["Tensanpham"] = dt.Rows[4]["Tensanpham"];
                dt1.Rows[3]["SIZE"]       = dt.Rows[4]["SIZE"];
                dt1.Rows[3]["Giatien"]    = dt.Rows[4]["Giatien"];
                dt1.Rows[3]["Soluong"]    = dt.Rows[4]["Soluong"];
                dt1.Rows[3]["Giamgia"]    = dt.Rows[4]["Giamgia"];
                dt1.Rows[3]["Thanhtien"]  = dt.Rows[4]["Thanhtien"];
                /////////////////////////////////////////////
                /////////////////////////////////////////////
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                dt.Rows[4]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                checkboxshopcart5.Checked = false;
                dataGridView1.Rows.RemoveAt(1);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[3]["STT"]        = dt1.Rows[3]["STT"];
                dt.Rows[3]["Tensanpham"] = dt1.Rows[3]["Tensanpham"];
                dt.Rows[3]["SIZE"]       = dt1.Rows[3]["SIZE"];
                dt.Rows[3]["Giatien"]    = dt1.Rows[3]["Giatien"];
                dt.Rows[3]["Soluong"]    = dt1.Rows[3]["Soluong"];
                dt.Rows[3]["Giamgia"]    = dt1.Rows[3]["Giamgia"];
                dt.Rows[3]["Thanhtien"]  = dt1.Rows[3]["Thanhtien"];
                luutongcong = 0;
                if (check1 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if(check5=="Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if(check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                    else if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }

                }
                else if (check1 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check3 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                    else if (check3 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                }

            }





            int sodongsaudelete1 = dt.Rows.Count;
            int dem = 1;
            for (int i = 1; i <= sodongsaudelete1; i++)
            {
                if (dem == 1)
                {

                    lbshopcartinfo1.Text = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia = Convert.ToInt32(dt.Rows[0]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien0 = String.Format(info, "{0:c}", gia);
                    //////
                    lbshopcartdongia1.Text = tien0;
                    lbshopcartthanhtien1.Text = tien0;
                    lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                   
                    string tensanpham = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    switch (tensanpham)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart1.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart1.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart1.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart1.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart1.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart1.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart1.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart1.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart1.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart1.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying1.Visible = true;
                    checkboxshopcart1.Visible = true;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 2 && dem <= sodongsaudelete1)
                {

                    lbshopcartinfo2.Text = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia1 = Convert.ToInt32(dt.Rows[1]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien1 = String.Format(info, "{0:c}", gia1);
                    //////
                    lbshopcartdongia2.Text = tien1;
                    lbshopcartthanhtien2.Text = tien1;
                    lbshopcartSIZE2.Text = Convert.ToString(dt.Rows[1]["SIZE"]);
                   
                    string tensanpham1 = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    switch (tensanpham1)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart2.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart2.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart2.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart2.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart2.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart2.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart2.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart2.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart2.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart2.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying2.Visible = true;
                    checkboxshopcart2.Visible = true;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 3 && dem <= sodongsaudelete1)
                {
                    lbshopcartinfo3.Text = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia2 = Convert.ToInt32(dt.Rows[2]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien2 = String.Format(info, "{0:c}", gia2);
                    //////
                    lbshopcartdongia3.Text = tien2;
                    lbshopcartthanhtien3.Text = tien2;
                    lbshopcartSIZE3.Text = Convert.ToString(dt.Rows[2]["SIZE"]);
                   
                    string tensanpham2 = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    switch (tensanpham2)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart3.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart3.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart3.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart3.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart3.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart3.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart3.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart3.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart3.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart3.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying3.Visible = true;
                    checkboxshopcart3.Visible = true;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;
                }
                else if (dem == 4 && dem <= sodongsaudelete1)
                {
                    lbshopcartinfo4.Text = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia3 = Convert.ToInt32(dt.Rows[3]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien3 = String.Format(info, "{0:c}", gia3);
                    //////
                    lbshopcartdongia4.Text = tien3;
                    lbshopcartthanhtien4.Text = tien3;
                    lbshopcartSIZE4.Text = Convert.ToString(dt.Rows[3]["SIZE"]);
                  
                    string tensanpham3 = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    switch (tensanpham3)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart4.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart4.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart4.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart4.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart4.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart4.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart4.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart4.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart4.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart4.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying4.Visible = true;
                    checkboxshopcart4.Visible = true;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 5 && dem <= sodongsaudelete1)
                {
                    lbshopcartinfo5.Text = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia4 = Convert.ToInt32(dt.Rows[4]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien4 = String.Format(info, "{0:c}", gia4);
                    //////
                    lbshopcartdongia5.Text = tien4;
                    lbshopcartthanhtien5.Text = tien4;
                    lbshopcartSIZE5.Text = Convert.ToString(dt.Rows[4]["SIZE"]);
                   
                    string tensanpham4 = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    switch (tensanpham4)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart5.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart5.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart5.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart5.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart5.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart5.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart5.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart5.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart5.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart5.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying5.Visible = true;
                    checkboxshopcart5.Visible = true;
                }

            }
            dt1.Clear();
            dataGridView2.Refresh();
        }

        private void btnshopcartdelete3_Click(object sender, EventArgs e)
        {
            sodonhuy++;
            if (checkboxshopcart1.Checked == false)
            {
                check1 = "Not Check";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            else if (checkboxshopcart1.Checked == true)
            {
                check1 = "Checked";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            int sodongtruocdelete2 = dt.Rows.Count;
            if (sodongtruocdelete2 == 3)
            {
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                pnlshopcartbuying3.Visible = false;
                checkboxshopcart3.Visible = false;
                dataGridView1.Rows.RemoveAt(2);
                if (check1 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if(check2=="Checked")
                    {
                        checkboxshopcart2.Checked = true;
                    }
                    else if (check2=="Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                    }
                }
                else if (check1=="Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                    }
                }

            }
            else if (sodongtruocdelete2 == 4)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(3, "dddd", "dsd", 1, 1, 1, "1");
                ////////////////////////////////////////////////////
                dt1.Rows[0]["STT"] = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"]        = dt.Rows[1]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[1]["SIZE"]       = dt.Rows[1]["SIZE"];
                dt1.Rows[1]["Giatien"]    = dt.Rows[1]["Giatien"];
                dt1.Rows[1]["Soluong"]    = dt.Rows[1]["Soluong"];
                dt1.Rows[1]["Giamgia"]    = dt.Rows[1]["Giamgia"];
                dt1.Rows[1]["Thanhtien"]  = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[2]["STT"] = dt.Rows[3]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[3]["Tensanpham"];
                dt1.Rows[2]["SIZE"] = dt.Rows[3]["SIZE"];
                dt1.Rows[2]["Giatien"] = dt.Rows[3]["Giatien"];
                dt1.Rows[2]["Soluong"] = dt.Rows[3]["Soluong"];
                dt1.Rows[2]["Giamgia"] = dt.Rows[3]["Giamgia"];
                dt1.Rows[2]["Thanhtien"] = dt.Rows[3]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
               
                dataGridView1.Rows.RemoveAt(2);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                luutongcong = 0;
                if(check1=="Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if(check2=="Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if(check4=="Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if(check4=="Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                    else if (check2=="Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }

                }
                else if (check1 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                }

            }
            else if(sodongtruocdelete2==5)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(3, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(4, "dddd", "dsd", 1, 1, 1, "1");
                ////////////////////////////////////////////////////
                dt1.Rows[0]["STT"] = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[1]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[2]["STT"] = dt.Rows[3]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[3]["Tensanpham"];
                dt1.Rows[2]["SIZE"] = dt.Rows[3]["SIZE"];
                dt1.Rows[2]["Giatien"] = dt.Rows[3]["Giatien"];
                dt1.Rows[2]["Soluong"] = dt.Rows[3]["Soluong"];
                dt1.Rows[2]["Giamgia"] = dt.Rows[3]["Giamgia"];
                dt1.Rows[2]["Thanhtien"] = dt.Rows[3]["Thanhtien"];
                //////////////////////////////////////////////
                dt1.Rows[3]["STT"]        = dt.Rows[4]["STT"];
                dt1.Rows[3]["Tensanpham"] = dt.Rows[4]["Tensanpham"];
                dt1.Rows[3]["SIZE"]       = dt.Rows[4]["SIZE"];
                dt1.Rows[3]["Giatien"]    = dt.Rows[4]["Giatien"];
                dt1.Rows[3]["Soluong"]    = dt.Rows[4]["Soluong"];
                dt1.Rows[3]["Giamgia"]    = dt.Rows[4]["Giamgia"];
                dt1.Rows[3]["Thanhtien"]  = dt.Rows[4]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                dt.Rows[4]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                checkboxshopcart5.Checked = false;
                dataGridView1.Rows.RemoveAt(2);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[3]["STT"]        = dt1.Rows[3]["STT"];
                dt.Rows[3]["Tensanpham"] = dt1.Rows[3]["Tensanpham"];
                dt.Rows[3]["SIZE"]       = dt1.Rows[3]["SIZE"];
                dt.Rows[3]["Giatien"]    = dt1.Rows[3]["Giatien"];
                dt.Rows[3]["Soluong"]    = dt1.Rows[3]["Soluong"];
                dt.Rows[3]["Giamgia"]    = dt1.Rows[3]["Giamgia"];
                dt.Rows[3]["Thanhtien"]  = dt1.Rows[3]["Thanhtien"];
                luutongcong = 0;
                if (check1 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if(check5=="Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5=="Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }

                }
                else if (check1 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check4 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check4 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                }
            }

            int sodongsaudelete2= dt.Rows.Count;
            int dem = 1;
            for (int i = 1; i <= sodongsaudelete2; i++)
            {
                if (dem == 1)
                {

                    lbshopcartinfo1.Text = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia = Convert.ToInt32(dt.Rows[0]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien0 = String.Format(info, "{0:c}", gia);
                    //////
                    lbshopcartdongia1.Text = tien0;
                    lbshopcartthanhtien1.Text = tien0;
                    lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                   
                    string tensanpham = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    switch (tensanpham)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart1.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart1.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart1.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart1.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart1.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart1.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart1.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart1.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart1.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart1.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying1.Visible = true;
                    checkboxshopcart1.Visible = true;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 2 && dem <= sodongsaudelete2)
                {

                    lbshopcartinfo2.Text = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia1 = Convert.ToInt32(dt.Rows[1]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien1 = String.Format(info, "{0:c}", gia1);
                    //////
                    lbshopcartdongia2.Text = tien1;
                    lbshopcartthanhtien2.Text = tien1;
                    lbshopcartSIZE2.Text = Convert.ToString(dt.Rows[1]["SIZE"]);
                   
                    string tensanpham1 = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    switch (tensanpham1)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart2.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart2.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart2.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart2.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart2.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart2.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart2.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart2.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart2.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart2.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying2.Visible = true;
                    checkboxshopcart2.Visible = true;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 3 && dem <= sodongsaudelete2)
                {
                    lbshopcartinfo3.Text = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia2 = Convert.ToInt32(dt.Rows[2]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien2 = String.Format(info, "{0:c}", gia2);
                    //////
                    lbshopcartdongia3.Text = tien2;
                    lbshopcartthanhtien3.Text = tien2;
                    lbshopcartSIZE3.Text = Convert.ToString(dt.Rows[2]["SIZE"]);
                   
                    string tensanpham2 = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    switch (tensanpham2)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart3.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart3.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart3.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart3.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart3.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart3.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart3.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart3.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart3.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart3.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying3.Visible = true;
                    checkboxshopcart3.Visible = true;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;
                }
                else if (dem == 4 && dem <= sodongsaudelete2)
                {
                    lbshopcartinfo4.Text = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia3 = Convert.ToInt32(dt.Rows[3]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien3 = String.Format(info, "{0:c}", gia3);
                    //////
                    lbshopcartdongia4.Text = tien3;
                    lbshopcartthanhtien4.Text = tien3;
                    lbshopcartSIZE4.Text = Convert.ToString(dt.Rows[3]["SIZE"]);
                  
                    string tensanpham3 = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    switch (tensanpham3)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart4.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart4.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart4.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart4.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart4.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart4.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart4.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart4.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart4.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart4.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying4.Visible = true;
                    checkboxshopcart4.Visible = true;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 5 && dem <= sodongsaudelete2)
                {
                    lbshopcartinfo5.Text = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia4 = Convert.ToInt32(dt.Rows[4]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien4 = String.Format(info, "{0:c}", gia4);
                    //////
                    lbshopcartdongia5.Text = tien4;
                    lbshopcartthanhtien5.Text = tien4;
                    lbshopcartSIZE5.Text = Convert.ToString(dt.Rows[4]["SIZE"]);
                   
                    string tensanpham4 = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    switch (tensanpham4)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart5.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart5.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart5.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart5.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart5.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart5.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart5.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart5.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart5.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart5.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying5.Visible = true;
                    checkboxshopcart5.Visible = true;
                }

            }
            dt1.Clear();
            dataGridView2.Refresh();
        }

        private void btnshopcartdeleteALL_Click(object sender, EventArgs e)
        {
          
            int sodongtruocdeleteALL = dt.Rows.Count;
            
            if(sodongtruocdeleteALL==1)
            {
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                dataGridView1.Rows.RemoveAt(0);
                pnlshopcartbuying1.Visible = false;
                checkboxshopcart1.Visible = false;
                sodonhuy = sodonhuy + 1;
            }
            else if (sodongtruocdeleteALL==2)
            {
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                dataGridView1.Rows.RemoveAt(1);
                dataGridView1.Rows.RemoveAt(0);
                pnlshopcartbuying1.Visible = false;
                checkboxshopcart1.Visible = false;
                pnlshopcartbuying2.Visible = false;
                checkboxshopcart2.Visible = false;
                sodonhuy = sodonhuy + 2;
            }
            else if (sodongtruocdeleteALL==3)
            {
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.Rows.RemoveAt(1);
                dataGridView1.Rows.RemoveAt(0);
                pnlshopcartbuying1.Visible = false;
                checkboxshopcart1.Visible = false;
                pnlshopcartbuying2.Visible = false;
                checkboxshopcart2.Visible = false;
                pnlshopcartbuying3.Visible = false;
                checkboxshopcart3.Visible = false;
                sodonhuy = sodonhuy + 3;
            }
            else if(sodongtruocdeleteALL==4)
            {
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                dataGridView1.Rows.RemoveAt(3);
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.Rows.RemoveAt(1);
                dataGridView1.Rows.RemoveAt(0);
                pnlshopcartbuying1.Visible = false;
                checkboxshopcart1.Visible = false;
                pnlshopcartbuying2.Visible = false;
                checkboxshopcart2.Visible = false;
                pnlshopcartbuying3.Visible = false;
                checkboxshopcart3.Visible = false;
                pnlshopcartbuying4.Visible = false;
                checkboxshopcart4.Visible = false;
                sodonhuy = sodonhuy + 4;

            }
            else if (sodongtruocdeleteALL==5)
            {
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                dt.Rows[4]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                checkboxshopcart5.Checked = false;
                dataGridView1.Rows.RemoveAt(4);
                dataGridView1.Rows.RemoveAt(3);
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.Rows.RemoveAt(1);
                dataGridView1.Rows.RemoveAt(0);
                pnlshopcartbuying1.Visible = false;
                checkboxshopcart1.Visible = false;
                pnlshopcartbuying2.Visible = false;
                checkboxshopcart2.Visible = false;
                pnlshopcartbuying3.Visible = false;
                checkboxshopcart3.Visible = false;
                pnlshopcartbuying4.Visible = false;
                checkboxshopcart4.Visible = false;
                pnlshopcartbuying5.Visible = false;
                checkboxshopcart5.Visible = false;
                sodonhuy = sodonhuy + 5;
            }
            
        }

        private void btnshopcartdelete4_Click(object sender, EventArgs e)
        {
            sodonhuy++;
            if (checkboxshopcart1.Checked == false)
            {
                check1 = "Not Check";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            else if (checkboxshopcart1.Checked == true)
            {
                check1 = "Checked";
                if (checkboxshopcart2.Checked == false)
                {
                    check2 = "Not Check";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
                else if (checkboxshopcart2.Checked == true)
                {
                    check2 = "Checked";
                    if (checkboxshopcart3.Checked == false)
                    {
                        check3 = "Not Check";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                    else if (checkboxshopcart3.Checked == true)
                    {
                        check3 = "Checked";
                        if (checkboxshopcart4.Checked == false)
                        {
                            check4 = "Not Check";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                        else if (checkboxshopcart4.Checked == true)
                        {
                            check4 = "Checked";
                            if (checkboxshopcart5.Checked == false)
                            {
                                check5 = "Not Check";
                            }
                            else if (checkboxshopcart5.Checked == true)
                            {
                                check5 = "Checked";
                            }
                        }
                    }
                }
            }
            int sodongtruocdelete3 = dt.Rows.Count;
            if(sodongtruocdelete3==4)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(3, "dddd", "dsd", 1, 1, 1, "1");
                ////////////////////////////////////////////////////
                dt1.Rows[0]["STT"] = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[1]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[2]["STT"]        = dt.Rows[2]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[2]["SIZE"]       = dt.Rows[2]["SIZE"];
                dt1.Rows[2]["Giatien"]    = dt.Rows[2]["Giatien"];
                dt1.Rows[2]["Soluong"]    = dt.Rows[2]["Soluong"];
                dt1.Rows[2]["Giamgia"]    = dt.Rows[2]["Giamgia"];
                dt1.Rows[2]["Thanhtien"]  = dt.Rows[2]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;

                dataGridView1.Rows.RemoveAt(3);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                luutongcong = 0;
                if(check1=="Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if(check3=="Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if(check3=="Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                    else if (check2=="Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                }
                else if (check1=="Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                        }
                    }
                }

            }
            else if(sodongtruocdelete3==5)
            {
                dt1.Rows.Add(1, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(2, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(3, "dddd", "dsd", 1, 1, 1, "1");
                dt1.Rows.Add(4, "dddd", "dsd", 1, 1, 1, "1");
                ////////////////////////////////////////////////////
               
                dt1.Rows[0]["STT"] = dt.Rows[0]["STT"];
                dt1.Rows[0]["Tensanpham"] = dt.Rows[0]["Tensanpham"];
                dt1.Rows[0]["SIZE"] = dt.Rows[0]["SIZE"];
                dt1.Rows[0]["Giatien"] = dt.Rows[0]["Giatien"];
                dt1.Rows[0]["Soluong"] = dt.Rows[0]["Soluong"];
                dt1.Rows[0]["Giamgia"] = dt.Rows[0]["Giamgia"];
                dt1.Rows[0]["Thanhtien"] = dt.Rows[0]["Thanhtien"];
                /////////////////////////////////////////////

                dt1.Rows[1]["STT"] = dt.Rows[1]["STT"];
                dt1.Rows[1]["Tensanpham"] = dt.Rows[1]["Tensanpham"];
                dt1.Rows[1]["SIZE"] = dt.Rows[1]["SIZE"];
                dt1.Rows[1]["Giatien"] = dt.Rows[1]["Giatien"];
                dt1.Rows[1]["Soluong"] = dt.Rows[1]["Soluong"];
                dt1.Rows[1]["Giamgia"] = dt.Rows[1]["Giamgia"];
                dt1.Rows[1]["Thanhtien"] = dt.Rows[1]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[2]["STT"] = dt.Rows[2]["STT"];
                dt1.Rows[2]["Tensanpham"] = dt.Rows[2]["Tensanpham"];
                dt1.Rows[2]["SIZE"] = dt.Rows[2]["SIZE"];
                dt1.Rows[2]["Giatien"] = dt.Rows[2]["Giatien"];
                dt1.Rows[2]["Soluong"] = dt.Rows[2]["Soluong"];
                dt1.Rows[2]["Giamgia"] = dt.Rows[2]["Giamgia"];
                dt1.Rows[2]["Thanhtien"] = dt.Rows[2]["Thanhtien"];
                /////////////////////////////////////////////
                dt1.Rows[3]["STT"]        = dt.Rows[4]["STT"];
                dt1.Rows[3]["Tensanpham"] = dt.Rows[4]["Tensanpham"];
                dt1.Rows[3]["SIZE"]       = dt.Rows[4]["SIZE"];
                dt1.Rows[3]["Giatien"]    = dt.Rows[4]["Giatien"];
                dt1.Rows[3]["Soluong"]    = dt.Rows[4]["Soluong"];
                dt1.Rows[3]["Giamgia"]    = dt.Rows[4]["Giamgia"];
                dt1.Rows[3]["Thanhtien"]  = dt.Rows[4]["Thanhtien"];
                luutongcong = 0;
                dt.Rows[0]["Thanhtien"] = 0;
                dt.Rows[1]["Thanhtien"] = 0;
                dt.Rows[2]["Thanhtien"] = 0;
                dt.Rows[3]["Thanhtien"] = 0;
                dt.Rows[4]["Thanhtien"] = 0;
                checkboxshopcart1.Checked = false;
                checkboxshopcart2.Checked = false;
                checkboxshopcart3.Checked = false;
                checkboxshopcart4.Checked = false;
                checkboxshopcart5.Checked = false;
                dataGridView1.Rows.RemoveAt(3);
                dt.Rows[0]["STT"] = dt1.Rows[0]["STT"];
                dt.Rows[0]["Tensanpham"] = dt1.Rows[0]["Tensanpham"];
                dt.Rows[0]["SIZE"] = dt1.Rows[0]["SIZE"];
                dt.Rows[0]["Giatien"] = dt1.Rows[0]["Giatien"];
                dt.Rows[0]["Soluong"] = dt1.Rows[0]["Soluong"];
                dt.Rows[0]["Giamgia"] = dt1.Rows[0]["Giamgia"];
                dt.Rows[0]["Thanhtien"] = dt1.Rows[0]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[1]["STT"] = dt1.Rows[1]["STT"];
                dt.Rows[1]["Tensanpham"] = dt1.Rows[1]["Tensanpham"];
                dt.Rows[1]["SIZE"] = dt1.Rows[1]["SIZE"];
                dt.Rows[1]["Giatien"] = dt1.Rows[1]["Giatien"];
                dt.Rows[1]["Soluong"] = dt1.Rows[1]["Soluong"];
                dt.Rows[1]["Giamgia"] = dt1.Rows[1]["Giamgia"];
                dt.Rows[1]["Thanhtien"] = dt1.Rows[1]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[2]["STT"] = dt1.Rows[2]["STT"];
                dt.Rows[2]["Tensanpham"] = dt1.Rows[2]["Tensanpham"];
                dt.Rows[2]["SIZE"] = dt1.Rows[2]["SIZE"];
                dt.Rows[2]["Giatien"] = dt1.Rows[2]["Giatien"];
                dt.Rows[2]["Soluong"] = dt1.Rows[2]["Soluong"];
                dt.Rows[2]["Giamgia"] = dt1.Rows[2]["Giamgia"];
                dt.Rows[2]["Thanhtien"] = dt1.Rows[2]["Thanhtien"];
                ///////////////////////////////////////////////////////
                dt.Rows[3]["STT"]        = dt1.Rows[3]["STT"];
                dt.Rows[3]["Tensanpham"] = dt1.Rows[3]["Tensanpham"];
                dt.Rows[3]["SIZE"]       = dt1.Rows[3]["SIZE"];
                dt.Rows[3]["Giatien"]    = dt1.Rows[3]["Giatien"];
                dt.Rows[3]["Soluong"]    = dt1.Rows[3]["Soluong"];
                dt.Rows[3]["Giamgia"]    = dt1.Rows[3]["Giamgia"];
                dt.Rows[3]["Thanhtien"]  = dt1.Rows[3]["Thanhtien"];
                luutongcong = 0;
                if (check1 == "Checked")
                {
                    checkboxshopcart1.Checked = true;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if(check5=="Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                }
                else if (check1 == "Not Check")
                {
                    checkboxshopcart1.Checked = false;
                    if (check2 == "Checked")
                    {
                        checkboxshopcart2.Checked = true;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                    else if (check2 == "Not Check")
                    {
                        checkboxshopcart2.Checked = false;
                        if (check3 == "Checked")
                        {
                            checkboxshopcart3.Checked = true;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                        else if (check3 == "Not Check")
                        {
                            checkboxshopcart3.Checked = false;
                            if (check5 == "Checked")
                            {
                                checkboxshopcart4.Checked = true;
                            }
                            else if (check5 == "Not Check")
                            {
                                checkboxshopcart4.Checked = false;
                            }
                        }
                    }
                }


            }
            int sodongsaudelete3 = dt.Rows.Count;
            int dem = 1;
            for (int i = 1; i <= sodongsaudelete3; i++)
            {
                if (dem == 1)
                {

                    lbshopcartinfo1.Text = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia = Convert.ToInt32(dt.Rows[0]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien0 = String.Format(info, "{0:c}", gia);
                    //////
                    lbshopcartdongia1.Text = tien0;
                    lbshopcartthanhtien1.Text = tien0;
                    lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                   
                    string tensanpham = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    switch (tensanpham)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart1.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart1.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart1.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart1.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart1.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart1.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart1.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart1.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart1.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart1.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying1.Visible = true;
                    checkboxshopcart1.Visible = true;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 2 && dem <= sodongsaudelete3)
                {

                    lbshopcartinfo2.Text = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia1 = Convert.ToInt32(dt.Rows[1]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien1 = String.Format(info, "{0:c}", gia1);
                    //////
                    lbshopcartdongia2.Text = tien1;
                    lbshopcartthanhtien2.Text = tien1;
                    lbshopcartSIZE2.Text = Convert.ToString(dt.Rows[1]["SIZE"]);
                   
                    string tensanpham1 = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    switch (tensanpham1)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart2.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart2.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart2.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart2.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart2.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart2.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart2.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart2.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart2.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart2.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying2.Visible = true;
                    checkboxshopcart2.Visible = true;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 3 && dem <= sodongsaudelete3)
                {
                    lbshopcartinfo3.Text = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia2 = Convert.ToInt32(dt.Rows[2]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien2 = String.Format(info, "{0:c}", gia2);
                    //////
                    lbshopcartdongia3.Text = tien2;
                    lbshopcartthanhtien3.Text = tien2;
                    lbshopcartSIZE3.Text = Convert.ToString(dt.Rows[2]["SIZE"]);
                   
                    string tensanpham2 = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    switch (tensanpham2)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart3.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart3.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart3.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart3.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart3.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart3.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart3.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart3.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart3.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart3.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying3.Visible = true;
                    checkboxshopcart3.Visible = true;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;
                }
                else if (dem == 4 && dem <= sodongsaudelete3)
                {
                    lbshopcartinfo4.Text = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia3 = Convert.ToInt32(dt.Rows[3]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien3 = String.Format(info, "{0:c}", gia3);
                    //////
                    lbshopcartdongia4.Text = tien3;
                    lbshopcartthanhtien4.Text = tien3;
                    lbshopcartSIZE4.Text = Convert.ToString(dt.Rows[3]["SIZE"]);
                   
                    string tensanpham3 = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    switch (tensanpham3)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart4.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart4.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart4.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart4.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart4.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart4.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart4.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart4.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart4.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart4.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying4.Visible = true;
                    checkboxshopcart4.Visible = true;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 5 && dem <= sodongsaudelete3)
                {
                    lbshopcartinfo5.Text = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia4 = Convert.ToInt32(dt.Rows[4]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien4 = String.Format(info, "{0:c}", gia4);
                    //////
                    lbshopcartdongia5.Text = tien4;
                    lbshopcartthanhtien5.Text = tien4;
                    lbshopcartSIZE5.Text = Convert.ToString(dt.Rows[4]["SIZE"]);
                   
                    string tensanpham4 = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    switch (tensanpham4)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart5.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart5.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart5.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart5.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart5.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart5.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart5.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart5.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart5.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart5.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying5.Visible = true;
                    checkboxshopcart5.Visible = true;
                }

            }
            dt1.Clear();
            dataGridView2.Refresh();
        }

        private void btnshopcartdelete5_Click(object sender, EventArgs e)
        {
            sodonhuy++;
            checkboxshopcart5.Checked = false;
            dataGridView1.Rows.RemoveAt(4);
            checkboxshopcart5.Visible = false;
            pnlshopcartbuying5.Visible = false;
            if(demsocheck==4)
            {
                checkboxshopcartALL.Checked = true;
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            int sodongtruocthanhtoan = dt.Rows.Count;
            if(demsocheck != sodongtruocthanhtoan)
            {
                
                if(sodongtruocthanhtoan==2)
                {
                    if (checkboxshopcart1.Checked == true)
                    {
                        dt2.ImportRow(dt.Rows[0]);
                        checkboxshopcart1.Checked = false;
                        dataGridView1.Rows.RemoveAt(0);
                    }
                    if (checkboxshopcart2.Checked==true)
                    {
                        dt2.ImportRow(dt.Rows[1]);
                        checkboxshopcart2.Checked = false;
                        dataGridView1.Rows.RemoveAt(1);

                    }
                }
                else if(sodongtruocthanhtoan==3)
                {
                    if(demsocheck==1)
                    {
                        if (checkboxshopcart1.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            checkboxshopcart1.Checked = false;
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if (checkboxshopcart2.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            checkboxshopcart2.Checked = false;
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if(checkboxshopcart3.Checked==true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                        }
                    }
                    else if (demsocheck==2)
                    {
                        if(checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);
                            
                        }
                        if(checkboxshopcart1.Checked == true && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if(checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                        }
                    }

                }
                else if (sodongtruocthanhtoan==4)
                {
                    if(demsocheck==1)
                    {
                        if (checkboxshopcart1.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            checkboxshopcart1.Checked = false;
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if (checkboxshopcart2.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            checkboxshopcart2.Checked = false;
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if (checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                        }
                        if(checkboxshopcart4.Checked==true)
                        {
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                        }
                    }
                    else if(demsocheck==2)
                    {
                        if (checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if (checkboxshopcart1.Checked == true && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if (checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                        }
                        if(checkboxshopcart1.Checked == true && checkboxshopcart4.Checked==true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if(checkboxshopcart2.Checked == true && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(1);
                        }
                        if(checkboxshopcart3.Checked == true && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                        }
                    }
                    else if(demsocheck==3)
                    {
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && checkboxshopcart3.Checked==true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if ((checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true)&& checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                        }
                        if((checkboxshopcart3.Checked == true && checkboxshopcart4.Checked == true) &&checkboxshopcart1.Checked==true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                    }
                }
                else if (sodongtruocthanhtoan==5)
                {
                    if(demsocheck==1)
                    {
                        if (checkboxshopcart1.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            checkboxshopcart1.Checked = false;
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if (checkboxshopcart2.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            checkboxshopcart2.Checked = false;
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if (checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                        }
                        if (checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                        }
                        if(checkboxshopcart5.Checked==true)
                        {
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                        }
                    }
                    else if (demsocheck == 2)
                    {
                        if (checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if (checkboxshopcart1.Checked == true && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if (checkboxshopcart1.Checked == true && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if (checkboxshopcart1.Checked == true && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if (checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if (checkboxshopcart2.Checked == true && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if (checkboxshopcart2.Checked == true && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if (checkboxshopcart3.Checked == true && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);

                        }
                        if (checkboxshopcart3.Checked == true && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(2);

                        }
                        if (checkboxshopcart4.Checked == true && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);

                        }



                    }
                    else if(demsocheck==3)
                    {
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && checkboxshopcart3.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart3.Checked == true) && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart3.Checked == true) && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart4.Checked == true) && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(0);

                        }
                        if ((checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true) && checkboxshopcart4.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if ((checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true) && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if ((checkboxshopcart2.Checked == true && checkboxshopcart4.Checked == true) && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(1);

                        }
                        if ((checkboxshopcart3.Checked == true && checkboxshopcart4.Checked == true) && checkboxshopcart5.Checked == true)
                        {
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);

                        }

                    }
                    else if (demsocheck==4)
                    {
                        if((checkboxshopcart1.Checked==true&&checkboxshopcart2.Checked==true)&&(checkboxshopcart3.Checked==true&&checkboxshopcart4.Checked==true))
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && (checkboxshopcart3.Checked == true && checkboxshopcart5.Checked == true))
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if ((checkboxshopcart2.Checked == true && checkboxshopcart3.Checked == true) && (checkboxshopcart4.Checked == true && checkboxshopcart5.Checked == true))
                        {
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(1);
                        }
                        if ((checkboxshopcart3.Checked == true && checkboxshopcart4.Checked == true) && (checkboxshopcart5.Checked == true && checkboxshopcart1.Checked == true))
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[2]);
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart3.Checked = false;
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(2);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                        if ((checkboxshopcart1.Checked == true && checkboxshopcart2.Checked == true) && (checkboxshopcart4.Checked == true && checkboxshopcart5.Checked == true))
                        {
                            dt2.ImportRow(dt.Rows[0]);
                            dt2.ImportRow(dt.Rows[1]);
                            dt2.ImportRow(dt.Rows[3]);
                            dt2.ImportRow(dt.Rows[4]);
                            checkboxshopcart1.Checked = false;
                            checkboxshopcart2.Checked = false;
                            checkboxshopcart4.Checked = false;
                            checkboxshopcart5.Checked = false;
                            dataGridView1.Rows.RemoveAt(4);
                            dataGridView1.Rows.RemoveAt(3);
                            dataGridView1.Rows.RemoveAt(1);
                            dataGridView1.Rows.RemoveAt(0);
                        }
                    }

                }
                
            }
            else if(demsocheck == sodongtruocthanhtoan)
            {
                if(sodongtruocthanhtoan==1)
                {
                    dt2.ImportRow(dt.Rows[0]);
                    checkboxshopcart1.Checked = false;
                    dataGridView1.Rows.RemoveAt(0);
                    checkboxshopcart1.Visible = false;
                    pnlshopcartbuying1.Visible = false;
                }
                else if(sodongtruocthanhtoan==2)
                {
                    dt2.ImportRow(dt.Rows[0]);
                    dt2.ImportRow(dt.Rows[1]);
                    checkboxshopcart1.Checked = false;
                    checkboxshopcart2.Checked = false;
                    dataGridView1.Rows.RemoveAt(1);
                    dataGridView1.Rows.RemoveAt(0);
                    checkboxshopcart1.Visible = false;
                    pnlshopcartbuying1.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying2.Visible = false;
                }
                else if(sodongtruocthanhtoan==3)
                {
                    dt2.ImportRow(dt.Rows[0]);
                    dt2.ImportRow(dt.Rows[1]);
                    dt2.ImportRow(dt.Rows[2]);
                    checkboxshopcart1.Checked = false;
                    checkboxshopcart2.Checked = false;
                    checkboxshopcart3.Checked = false;
                    dataGridView1.Rows.RemoveAt(2);
                    dataGridView1.Rows.RemoveAt(1);
                    dataGridView1.Rows.RemoveAt(0);
                    checkboxshopcart1.Visible = false;
                    pnlshopcartbuying1.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                }
                else if (sodongtruocthanhtoan == 4)
                {
                    dt2.ImportRow(dt.Rows[0]);
                    dt2.ImportRow(dt.Rows[1]);
                    dt2.ImportRow(dt.Rows[2]);
                    dt2.ImportRow(dt.Rows[3]);
                    checkboxshopcart1.Checked = false;
                    checkboxshopcart2.Checked = false;
                    checkboxshopcart3.Checked = false;
                    checkboxshopcart4.Checked = false;
                    dataGridView1.Rows.RemoveAt(3);
                    dataGridView1.Rows.RemoveAt(2);
                    dataGridView1.Rows.RemoveAt(1);
                    dataGridView1.Rows.RemoveAt(0);
                    checkboxshopcart1.Visible = false;
                    pnlshopcartbuying1.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                }
                else if (sodongtruocthanhtoan == 5)
                {
                    dt2.ImportRow(dt.Rows[0]);
                    dt2.ImportRow(dt.Rows[1]);
                    dt2.ImportRow(dt.Rows[2]);
                    dt2.ImportRow(dt.Rows[3]);
                    dt2.ImportRow(dt.Rows[4]);
                    checkboxshopcart1.Checked = false;
                    checkboxshopcart2.Checked = false;
                    checkboxshopcart3.Checked = false;
                    checkboxshopcart4.Checked = false;
                    checkboxshopcart5.Checked = false;
                    dataGridView1.Rows.RemoveAt(4);
                    dataGridView1.Rows.RemoveAt(3);
                    dataGridView1.Rows.RemoveAt(2);
                    dataGridView1.Rows.RemoveAt(1);
                    dataGridView1.Rows.RemoveAt(0);
                    checkboxshopcart1.Visible = false;
                    pnlshopcartbuying1.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart5.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                }
            }
            int sodongsauthanhtoan = dt.Rows.Count;
            int dem = 1;
            for (int i = 1; i <= sodongsauthanhtoan; i++)
            {
                if (dem == 1)
                {

                    lbshopcartinfo1.Text = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia = Convert.ToInt32(dt.Rows[0]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien0 = String.Format(info, "{0:c}", gia);
                    //////
                    lbshopcartdongia1.Text = tien0;
                    lbshopcartthanhtien1.Text = tien0;
                    lbshopcartSIZE1.Text = Convert.ToString(dt.Rows[0]["SIZE"]);
                    string tensanpham = Convert.ToString(dt.Rows[0]["Tensanpham"]);
                    switch (tensanpham)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart1.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart1.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart1.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart1.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart1.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart1.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart1.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart1.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart1.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart1.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying1.Visible = true;
                    checkboxshopcart1.Visible = true;
                    pnlshopcartbuying2.Visible = false;
                    checkboxshopcart2.Visible = false;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 2 && dem <= sodongsauthanhtoan)
                {

                    lbshopcartinfo2.Text = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia1 = Convert.ToInt32(dt.Rows[1]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien1 = String.Format(info, "{0:c}", gia1);
                    //////
                    lbshopcartdongia2.Text = tien1;
                    lbshopcartthanhtien2.Text = tien1;
                    lbshopcartSIZE2.Text = Convert.ToString(dt.Rows[1]["SIZE"]);
                    string tensanpham1 = Convert.ToString(dt.Rows[1]["Tensanpham"]);
                    switch (tensanpham1)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart2.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart2.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart2.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart2.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart2.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart2.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart2.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart2.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart2.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart2.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying2.Visible = true;
                    checkboxshopcart2.Visible = true;
                    pnlshopcartbuying3.Visible = false;
                    checkboxshopcart3.Visible = false;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 3 && dem <= sodongsauthanhtoan)
                {
                    lbshopcartinfo3.Text = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia2 = Convert.ToInt32(dt.Rows[2]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien2 = String.Format(info, "{0:c}", gia2);
                    //////
                    lbshopcartdongia3.Text = tien2;
                    lbshopcartthanhtien3.Text = tien2;
                    lbshopcartSIZE3.Text = Convert.ToString(dt.Rows[2]["SIZE"]);
                    string tensanpham2 = Convert.ToString(dt.Rows[2]["Tensanpham"]);
                    switch (tensanpham2)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart3.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart3.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart3.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart3.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart3.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart3.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart3.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart3.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart3.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart3.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying3.Visible = true;
                    checkboxshopcart3.Visible = true;
                    pnlshopcartbuying4.Visible = false;
                    checkboxshopcart4.Visible = false;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;
                }
                else if (dem == 4 && dem <= sodongsauthanhtoan)
                {
                    lbshopcartinfo4.Text = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia3 = Convert.ToInt32(dt.Rows[3]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien3 = String.Format(info, "{0:c}", gia3);
                    //////
                    lbshopcartdongia4.Text = tien3;
                    lbshopcartthanhtien4.Text = tien3;
                    lbshopcartSIZE4.Text = Convert.ToString(dt.Rows[3]["SIZE"]);
                    string tensanpham3 = Convert.ToString(dt.Rows[3]["Tensanpham"]);
                    switch (tensanpham3)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart4.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart4.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart4.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart4.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart4.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart4.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart4.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart4.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart4.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart4.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying4.Visible = true;
                    checkboxshopcart4.Visible = true;
                    pnlshopcartbuying5.Visible = false;
                    checkboxshopcart5.Visible = false;

                }
                else if (dem == 5 && dem <= sodongsauthanhtoan)
                {
                    lbshopcartinfo5.Text = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    /////// Change int to Vietnam Currency
                    var gia4 = Convert.ToInt32(dt.Rows[4]["Giatien"]);
                    var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string tien4 = String.Format(info, "{0:c}", gia4);
                    //////
                    lbshopcartdongia5.Text = tien4;
                    lbshopcartthanhtien5.Text = tien4;
                    lbshopcartSIZE5.Text = Convert.ToString(dt.Rows[4]["SIZE"]);
                    string tensanpham4 = Convert.ToString(dt.Rows[4]["Tensanpham"]);
                    switch (tensanpham4)
                    {
                        case "Air Jordan Retro 12":
                            picboxshopcart5.Image = picboxairjoranretro12.Image;
                            break;
                        case "Air Max 95 SE":
                            picboxshopcart5.Image = picboxairmax95se.Image;
                            break;
                        case "KD14EP":
                            picboxshopcart5.Image = picboxKD14EP.Image;
                            break;
                        case "Kyrie Low 4 EP":
                            picboxshopcart5.Image = picboxkyrie7.Image;
                            break;
                        case "Nike Low By You":
                            picboxshopcart5.Image = picboxnikelowbyyou.Image;
                            break;
                        case "Men's Short Sleeve T-Shirt":
                            picboxshopcart5.Image = picboxmentshirtjordan.Image;
                            break;
                        case "Jordan Jumpman":
                            picboxshopcart5.Image = picboxmentshirtjordanjumpman.Image;
                            break;
                        case "Nike SportWear Max90":
                            picboxshopcart5.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                            break;
                        case "Nike ESC":
                            picboxshopcart5.Image = picboxmentshirtnikeesc.Image;
                            break;
                        case "Nike SportWear":
                            picboxshopcart5.Image = picboxmentshirtnikesportwear.Image;
                            break;
                        default:
                            not = 1;
                            break;
                    }
                    dem++;
                    pnlshopcartbuying5.Visible = true;
                    checkboxshopcart5.Visible = true;
                }

            }




        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }
        string search;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            search=richTextBox_search.Text;
            if(search=="Shoe")
            {
                pnlmennewestsneaker.Visible = true;
            }
            if(search=="Shirt")
            {
                pnlmentshirt.Visible = true;
            }
            if(search=="Jordan Shoe")
            {
                pnlmennewestsneaker.Visible = true;
                picboxairmax95se.Visible = false;
                picboxKD14EP.Visible = false;
                picboxnikelowbyyou.Visible = false;
                label9.Visible = false;
                label12.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                pictureBox7.Visible = false;
                picboxairmax95se.Visible = false;
                picboxKD14EP.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                picboxkyrie7.Visible = true;
                picboxnikelowbyyou.Visible = false;
                label21.Visible = false;
                label23.Visible = false;
                label22.Visible = false;
                label24.Visible = false;


            }
            if(search=="Jordan 12")
            {
                boughtproduct = 1;
                pnlmennewestsneaker.Visible = true;
                picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-1removebg.png");
                pnlnmennewestsneakerbuying.Visible = true;
                label20.Visible = false;  ////////The one i want
                label8.Visible = false;  ////////iwant 
                label6.Visible = false;  ////// iwant
                label7.Visible = false;  /////iwant
                label9.Visible = false;
                label12.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                pictureBox7.Visible = false;
                picboxairmax95se.Visible = false;
                picboxKD14EP.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                picboxkyrie7.Visible = false;
                label5.Visible  = false;  //////wnat
                label19.Visible = false;   ///////wnat
                label18.Visible = false;///////want
                label17.Visible = false;////////want
                picboxnikelowbyyou.Visible = false;
                label21.Visible = false;
                label23.Visible = false;
                label22.Visible = false;
                label24.Visible = false;
                picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-1removebg.png");
                picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-2removebg.png");
                picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-3removebg.png");
                picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-4removebg.png");
                picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\AirJordanRetro12\jordanretro12-5removebg.png");
                btnmennewestsneakerBACK.Visible = false;
            }
            if(search=="Air Max 95")
            {
                boughtproduct = 2;
                pnlmennewestsneaker.Visible = true;
                btnmennewestsneakerBACK.Visible = false;
                pnlnmennewestsneakerbuying.Visible = true;
                picboxmennewestsneakerbuying.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-1removebg.png");
                lbnameoftheshoe.Text = "Air Max 95 SE";
                lbdescription.Text = "Taking Inspiration from Human Body and aesthetics in 90s athetics.\n the Nike Air Max 95 SE mixes unbelievable comfort and head turning style with substainable design.\n Visible Air in the heel and forefoot cushions every step.";
                picboxdetail1.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-1removebg.png");
                picboxdetail2.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-2removebg.png");
                picboxdetail3.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-3removebg.png");
                picboxdetail4.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-4removebg.png");
                picboxdetail5.Image = Image.FromFile(@"Men\NewestSneaker\AirMax95SE\airmax95se-5removebg.png");
                picboxairjoranretro12.Visible = false;
                label20.Visible = false;
                label8.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label9.Visible = false;
                label12.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                pictureBox7.Visible = false;
                picboxairmax95se.Visible = false;
                picboxKD14EP.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                picboxkyrie7.Visible = false;
                label5.Visible = false;
                label19.Visible = false;
                label18.Visible = false;
                label17.Visible = false;
                picboxnikelowbyyou.Visible = false;
                label21.Visible = false;
                label23.Visible = false;
                label22.Visible = false;
                label24.Visible = false;
            }
            if(search=="Jordan Shirt")
            {
                pnlmentshirt.Visible = true;
                picboxmentshirtnikemax90.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                picboxmentshirtnikeesc.Visible = false;
                picboxmentshirtnikesportwear.Visible = false;
                label36.Visible = false;
                label35.Visible = false;
                label37.Visible = false;
                label39.Visible = false;
                label38.Visible = false;
                label40.Visible = false;
            }
            if(search=="Nike SportWear")
            {
                boughtproduct = 10;
                pnlmentshirt.Visible = true;
                pnlmentshirtbuying.Visible = true;
                lbmentshirtname.Text = "NIKE";
                lbmentshirtname1.Text = "Nike SportWear";
                lbmentshirtdescription.Text = "The Nike Sportswear T-Shirt features our oversized Max-90 fit and heavyweight cotton jersey.\nPrinted with water-based ink, the flower Futura logo\non the chest helps you maintain a \nsunny disposition no matter what the weather.";
                picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-1sportwearremovebg.png");
                picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-1sportwearremovebg.png");
                picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-2sportwearremovebg.png");
                picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-3sportwearremovebg.png");
                picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-4sportwearremovebg.png");
                picboxdetail5mentshirt.Image = Image.FromFile(@"Men\Tshirt\Sportwear\mentshirt-5sportwearremovebg.png");
                picboxmentshirtjordan.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label28.Visible = false;
                picboxmentshirtjordanjumpman.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                picboxmentshirtnikemax90.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                picboxmentshirtnikeesc.Visible = false;
                picboxmentshirtnikesportwear.Visible = false;
                label36.Visible = false;
                label35.Visible = false;
                label37.Visible = false;
                label39.Visible = false;
                label38.Visible = false;
                label40.Visible = false;
            }
            if(search=="Jordan Sleeve")
            {
                boughtproduct = 6;
                pnlmentshirt.Visible = true;
                pnlmentshirtbuying.Visible = true;
                lbmentshirtname.Text = "Jordan";
                lbmentshirtname1.Text = "Men's Short Sleeve T-Shirt";
                lbmentshirtdescription.Text = "Add some dimension to your style with\nthis tie-dyed T-shirt from Jordan Brand.\nIt's made from structured heavyweight cotton withprinted and embroidered graphics";
                picboxdetailmainmentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-1removebg.png");
                picboxdetail1mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-1removebg.png");
                picboxdetail2mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-2removebg.png");
                picboxdetail3mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-3removebg.png");
                picboxdetail4mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-4removebg.png");
                picboxdetail5mentshirt.Image = Image.FromFile(@"Men\Tshirt\Jordan\jordantshirt-5removebg.png");
                picboxmentshirtjordan.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label28.Visible = false;
                picboxmentshirtjordanjumpman.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                picboxmentshirtnikemax90.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                picboxmentshirtnikeesc.Visible = false;
                picboxmentshirtnikesportwear.Visible = false;
                label36.Visible = false;
                label35.Visible = false;
                label37.Visible = false;
                label39.Visible = false;
                label38.Visible = false;
                label40.Visible = false;
            }
        }
        int totalcost1;
        int totalcost2;
        int totalcost3;
        int totalcost4;
        int totalcost5;
        private void btnhistory_Click(object sender, EventArgs e)
        {
            int sodongkhixemchitiet = dt2.Rows.Count;
            if(sodongkhixemchitiet==1)
            {
                btnhistorybuyingdetail1.Visible = true;
                lbhistoryinfoproduct_1.Text = Convert.ToString(dt2.Rows[0]["Tensanpham"]);
                lbhistorySIZE1.Text = Convert.ToString(dt2.Rows[0]["SIZE"]);
                totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                var infochitietall1 = totalcost1;
                var infochitiet102 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount1 = String.Format(infochitiet102, "{0:c}", infochitietall1);
                lbhistorytotalcost1.Text = notdiscount1;
                if (giam10==1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    int totalcost1_1 = totalcost1 * 1 / 10;
                    int totalcost1_9 = totalcost1 * 9 / 10;
                    var infochitiet10_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet1 =  String.Format(infochitiet10_1, "{0:c}", totalcost1_9);
                    lbhistorytotalcost1.Text = infochitiet1;
                }
                if(giam20==1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    int totalcost1_2 = totalcost1 * 2 / 10;
                    int totalcost1_8 = totalcost1 * 8 / 10;
                    var infochitiet20_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet2 = String.Format(infochitiet20_1, "{0:c}", totalcost1_8);
                    lbhistorytotalcost1.Text = infochitiet2;

                }
                if(giam50==1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    int totalcost1_5 = totalcost1 / 2;
                    var infochitiet50_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet3 = String.Format(infochitiet50_1, "{0:c}", totalcost1_5);
                    lbhistorytotalcost1.Text = infochitiet3;
                }
                if(giam60==1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    int totalcost1_4 = totalcost1 * 4 / 10;
                    int totalcost1_6 = totalcost1 * 6 / 10;
                    var infochitiet60_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet4 = String.Format(infochitiet60_1,"{0:c}", totalcost1_4);
                    lbhistorytotalcost1.Text = infochitiet4;
                }
                pnlhistorybuying1.Visible = true;

            }
            if(sodongkhixemchitiet==2)
            {
                btnhistorybuyingdetail1.Visible = true;
                btnhistorybuyingdetail2.Visible = true;
                lbhistoryinfoproduct_1.Text = Convert.ToString(dt2.Rows[0]["Tensanpham"]);
                lbhistorySIZE1.Text = Convert.ToString(dt2.Rows[0]["SIZE"]);
                totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                var infochitietall1 = totalcost1;
                var infochitiet102 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount1 = String.Format(infochitiet102, "{0:c}", infochitietall1);
                lbhistorytotalcost1.Text = notdiscount1;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_2.Text = Convert.ToString(dt2.Rows[1]["Tensanpham"]);
                lbhistorySIZE2.Text = Convert.ToString(dt2.Rows[1]["SIZE"]);
                totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                var infochitietall2 = totalcost2;
                var infochitiet103 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount2 = String.Format(infochitiet103, "{0:c}", infochitietall2);
                lbhistorytotalcost2.Text = notdiscount2;
                if (giam10 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    int totalcost1_1 = totalcost1 * 1 / 10;
                    int totalcost1_9 = totalcost1 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost2_1 = totalcost2 * 1 / 10;
                    int totalcost2_9 = totalcost2 * 9 / 10;
                    var infochitiet10_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet1 = String.Format(infochitiet10_1, "{0:c}", totalcost1_9);
                    string infochitiet1_1 = String.Format(infochitiet10_1, "{0:c}", totalcost2_9);
                    lbhistorytotalcost1.Text = infochitiet1;
                    lbhistorytotalcost2.Text = infochitiet1_1;

                }
                if (giam20 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    int totalcost1_2 = totalcost1 * 2 / 10;
                    int totalcost1_8 = totalcost1 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost2_2 = totalcost2 * 2 / 10;
                    int totalcost2_8 = totalcost2 * 8 / 10;
                    var infochitiet20_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet2 = String.Format(infochitiet20_1, "{0:c}", totalcost1_8);
                    string infochitiet2_2 = String.Format(infochitiet20_1, "{0:c}", totalcost2_8);
                    lbhistorytotalcost1.Text = infochitiet2;
                    lbhistorytotalcost2.Text = infochitiet2_2;

                }
                if (giam50 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    int totalcost1_5 = totalcost1 / 2;
                    int totalcost2_5 = totalcost2 / 2;
                    var infochitiet50_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet3 = String.Format(infochitiet50_1, "{0:c}", totalcost1_5);
                    string infochitiet3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost2_5);
                    lbhistorytotalcost1.Text = infochitiet3;
                    lbhistorytotalcost2.Text = infochitiet3_3;
                }
                if (giam60 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    int totalcost1_4 = totalcost1 * 4 / 10;
                    int totalcost1_6 = totalcost1 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost2_4 = totalcost2 * 4 / 10;
                    int totalcost2_6 = totalcost2 * 6 / 10;
                    var infochitiet60_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet4 = String.Format(infochitiet60_1, "{0:c}", totalcost1_4);
                    string infochitiet4_4 = String.Format(infochitiet60_1, "{0:c}", totalcost2_4);
                    lbhistorytotalcost1.Text = infochitiet4;
                    lbhistorytotalcost2.Text = infochitiet4_4;
                }
                pnlhistorybuying1.Visible = true;
                pnlhistorybuying2.Visible = true;
            }
            if (sodongkhixemchitiet == 3)
            {
                btnhistorybuyingdetail1.Visible = true;
                btnhistorybuyingdetail2.Visible = true;
                btnhistorybuyingdetail3.Visible = true;
                lbhistoryinfoproduct_1.Text = Convert.ToString(dt2.Rows[0]["Tensanpham"]);
                lbhistorySIZE1.Text = Convert.ToString(dt2.Rows[0]["SIZE"]);
                totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                var infochitietall1 = totalcost1;
                var infochitiet102 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount1 = String.Format(infochitiet102, "{0:c}", infochitietall1);
                lbhistorytotalcost1.Text = notdiscount1;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_2.Text = Convert.ToString(dt2.Rows[1]["Tensanpham"]);
                lbhistorySIZE2.Text = Convert.ToString(dt2.Rows[1]["SIZE"]);
                totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                var infochitietall2 = totalcost2;
                var infochitiet103 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount2 = String.Format(infochitiet103, "{0:c}", infochitietall2);
                lbhistorytotalcost2.Text = notdiscount2;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_3.Text = Convert.ToString(dt2.Rows[2]["Tensanpham"]);
                lbhistorySIZE3.Text = Convert.ToString(dt2.Rows[2]["SIZE"]);
                totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                var infochitietall3 = totalcost3;
                var infochitiet104 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount3 = String.Format(infochitiet104, "{0:c}", infochitietall3);
                lbhistorytotalcost3.Text = notdiscount3;
                if (giam10 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    int totalcost1_1 = totalcost1 * 1 / 10;
                    int totalcost1_9 = totalcost1 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost2_1 = totalcost2 * 1 / 10;
                    int totalcost2_9 = totalcost2 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost3_1 = totalcost3 * 1 / 10;
                    int totalcost3_9 = totalcost3 * 9 / 10;
                    var infochitiet10_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet1 = String.Format(infochitiet10_1, "{0:c}", totalcost1_9);
                    string infochitiet1_1 = String.Format(infochitiet10_1, "{0:c}", totalcost2_9);
                    string infochitiet1_1_3 = String.Format(infochitiet10_1, "{0:c}", totalcost3_9);
                    lbhistorytotalcost1.Text = infochitiet1;
                    lbhistorytotalcost2.Text = infochitiet1_1;
                    lbhistorytotalcost3.Text = infochitiet1_1_3;


                }
                if (giam20 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    int totalcost1_2 = totalcost1 * 2 / 10;
                    int totalcost1_8 = totalcost1 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost2_2 = totalcost2 * 2 / 10;
                    int totalcost2_8 = totalcost2 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost3_2 = totalcost3 * 2 / 10;
                    int totalcost3_8 = totalcost3 * 8 / 10;
                    var infochitiet20_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet2 = String.Format(infochitiet20_1, "{0:c}", totalcost1_8);
                    string infochitiet2_2 = String.Format(infochitiet20_1, "{0:c}", totalcost2_8);
                    string infochitiet2_2_3 = String.Format(infochitiet20_1, "{0:c}", totalcost3_8);
                    lbhistorytotalcost1.Text = infochitiet2;
                    lbhistorytotalcost2.Text = infochitiet2_2;
                    lbhistorytotalcost3.Text = infochitiet2_2_3;

                }
                if (giam50 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    int totalcost1_5 = totalcost1 / 2;
                    int totalcost2_5 = totalcost2 / 2;
                    int totalcost3_5 = totalcost3 / 2;
                    var infochitiet50_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet3 = String.Format(infochitiet50_1, "{0:c}", totalcost1_5);
                    string infochitiet3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost2_5);
                    string infochitiet3_3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost3_5);
                    lbhistorytotalcost1.Text = infochitiet3;
                    lbhistorytotalcost2.Text = infochitiet3_3;
                    lbhistorytotalcost3.Text = infochitiet3_3_3;
                }
                if (giam60 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    int totalcost1_4 = totalcost1 * 4 / 10;
                    int totalcost1_6 = totalcost1 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost2_4 = totalcost2 * 4 / 10;
                    int totalcost2_6 = totalcost2 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost3_4 = totalcost3 * 4 / 10;
                    int totalcost3_6 = totalcost3 * 6 / 10;
                    var infochitiet60_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet4 = String.Format(infochitiet60_1, "{0:c}", totalcost1_4);
                    string infochitiet4_4 = String.Format(infochitiet60_1, "{0:c}", totalcost2_4);
                    string infochitiet4_4_3 = String.Format(infochitiet60_1, "{0:c}", totalcost3_4);
                    lbhistorytotalcost1.Text = infochitiet4;
                    lbhistorytotalcost2.Text = infochitiet4_4;
                    lbhistorytotalcost3.Text = infochitiet4_4_3;
                }
                pnlhistorybuying1.Visible = true;
                pnlhistorybuying2.Visible = true;
                pnlhistorybuying3.Visible = true;
            }
            if (sodongkhixemchitiet == 4)
            {
                btnhistorybuyingdetail1.Visible = true;
                btnhistorybuyingdetail2.Visible = true;
                btnhistorybuyingdetail3.Visible = true;
                btnhistorybuyingdetail4.Visible = true;
                lbhistoryinfoproduct_1.Text = Convert.ToString(dt2.Rows[0]["Tensanpham"]);
                lbhistorySIZE1.Text = Convert.ToString(dt2.Rows[0]["SIZE"]);
                totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                var infochitietall1 = totalcost1;
                var infochitiet102 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount1 = String.Format(infochitiet102, "{0:c}", infochitietall1);
                lbhistorytotalcost1.Text = notdiscount1;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_2.Text = Convert.ToString(dt2.Rows[1]["Tensanpham"]);
                lbhistorySIZE2.Text = Convert.ToString(dt2.Rows[1]["SIZE"]);
                totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                var infochitietall2 = totalcost2;
                var infochitiet103 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount2 = String.Format(infochitiet103, "{0:c}", infochitietall2);
                lbhistorytotalcost2.Text = notdiscount2;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_3.Text = Convert.ToString(dt2.Rows[2]["Tensanpham"]);
                lbhistorySIZE3.Text = Convert.ToString(dt2.Rows[2]["SIZE"]);
                totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                var infochitietall3 = totalcost3;
                var infochitiet104 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount3 = String.Format(infochitiet104, "{0:c}", infochitietall3);
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_4.Text = Convert.ToString(dt2.Rows[3]["Tensanpham"]);
                lbhistorySIZE4.Text = Convert.ToString(dt2.Rows[3]["SIZE"]);
                totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                var infochitietall4 = totalcost4;
                var infochitiet105 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount4= String.Format(infochitiet105, "{0:c}", infochitietall4);
                lbhistorytotalcost4.Text = notdiscount4;
                if (giam10 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    int totalcost1_1 = totalcost1 * 1 / 10;
                    int totalcost1_9 = totalcost1 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost2_1 = totalcost2 * 1 / 10;
                    int totalcost2_9 = totalcost2 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost3_1 = totalcost3 * 1 / 10;
                    int totalcost3_9 = totalcost3 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost4_1 = totalcost4 * 1 / 10;
                    int totalcost4_9 = totalcost4 * 9 / 10;
                    var infochitiet10_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet1 = String.Format(infochitiet10_1, "{0:c}", totalcost1_9);
                    string infochitiet1_1 = String.Format(infochitiet10_1, "{0:c}", totalcost2_9);
                    string infochitiet1_1_3 = String.Format(infochitiet10_1, "{0:c}", totalcost3_9);
                    string infochitiet1_1_4 = String.Format(infochitiet10_1, "{0:c}", totalcost4_9);
                    lbhistorytotalcost1.Text = infochitiet1;
                    lbhistorytotalcost2.Text = infochitiet1_1;
                    lbhistorytotalcost3.Text = infochitiet1_1_3;
                    lbhistorytotalcost4.Text = infochitiet1_1_4;


                }
                if (giam20 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    int totalcost1_2 = totalcost1 * 2 / 10;
                    int totalcost1_8 = totalcost1 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost2_2 = totalcost2 * 2 / 10;
                    int totalcost2_8 = totalcost2 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost3_2 = totalcost3 * 2 / 10;
                    int totalcost3_8 = totalcost3 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost4_2 = totalcost4 * 2 / 10;
                    int totalcost4_8 = totalcost4 * 8 / 10;
                    var infochitiet20_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet2 = String.Format(infochitiet20_1, "{0:c}", totalcost1_8);
                    string infochitiet2_2 = String.Format(infochitiet20_1, "{0:c}", totalcost2_8);
                    string infochitiet2_2_3 = String.Format(infochitiet20_1, "{0:c}", totalcost3_8);
                    string infochitiet2_2_4 = String.Format(infochitiet20_1, "{0:c}", totalcost4_8);
                    lbhistorytotalcost1.Text = infochitiet2;
                    lbhistorytotalcost2.Text = infochitiet2_2;
                    lbhistorytotalcost3.Text = infochitiet2_2_3;
                    lbhistorytotalcost4.Text = infochitiet2_2_4;


                }
                if (giam50 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    int totalcost1_5 = totalcost1 / 2;
                    int totalcost2_5 = totalcost2 / 2;
                    int totalcost3_5 = totalcost3 / 2;
                    int totalcost4_5 = totalcost4 / 2;
                    var infochitiet50_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet3 = String.Format(infochitiet50_1, "{0:c}", totalcost1_5);
                    string infochitiet3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost2_5);
                    string infochitiet3_3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost3_5);
                    string infochitiet3_3_4 = String.Format(infochitiet50_1, "{0:c}", totalcost4_5);
                    lbhistorytotalcost1.Text = infochitiet3;
                    lbhistorytotalcost2.Text = infochitiet3_3;
                    lbhistorytotalcost3.Text = infochitiet3_3_3;
                    lbhistorytotalcost4.Text = infochitiet3_3_4;
                }
                if (giam60 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    int totalcost1_4 = totalcost1 * 4 / 10;
                    int totalcost1_6 = totalcost1 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost2_4 = totalcost2 * 4 / 10;
                    int totalcost2_6 = totalcost2 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost3_4 = totalcost3 * 4 / 10;
                    int totalcost3_6 = totalcost3 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost4_4 = totalcost4 * 4 / 10;
                    int totalcost4_6 = totalcost4 * 6 / 10;
                    var infochitiet60_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet4 = String.Format(infochitiet60_1, "{0:c}", totalcost1_4);
                    string infochitiet4_4 = String.Format(infochitiet60_1, "{0:c}", totalcost2_4);
                    string infochitiet4_4_3 = String.Format(infochitiet60_1, "{0:c}", totalcost3_4);
                    string infochitiet4_4_4 = String.Format(infochitiet60_1, "{0:c}", totalcost4_4);
                    lbhistorytotalcost1.Text = infochitiet4;
                    lbhistorytotalcost2.Text = infochitiet4_4;
                    lbhistorytotalcost3.Text = infochitiet4_4_3;
                    lbhistorytotalcost4.Text = infochitiet4_4_4;

                }
                pnlhistorybuying1.Visible = true;
                pnlhistorybuying2.Visible = true;
                pnlhistorybuying3.Visible = true;
                pnlhistorybuying4.Visible = true;
            }
            if (sodongkhixemchitiet == 5)
            {
                btnhistorybuyingdetail1.Visible = true;
                btnhistorybuyingdetail2.Visible = true;
                btnhistorybuyingdetail3.Visible = true;
                btnhistorybuyingdetail4.Visible = true;
                btnhistorybuyingdetail5.Visible = true;
                lbhistoryinfoproduct_1.Text = Convert.ToString(dt2.Rows[0]["Tensanpham"]);
                lbhistorySIZE1.Text = Convert.ToString(dt2.Rows[0]["SIZE"]);
                totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                var infochitietall1 = totalcost1;
                var infochitiet102 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount1 = String.Format(infochitiet102, "{0:c}", infochitietall1);
                lbhistorytotalcost1.Text = notdiscount1;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_2.Text = Convert.ToString(dt2.Rows[1]["Tensanpham"]);
                lbhistorySIZE2.Text = Convert.ToString(dt2.Rows[1]["SIZE"]);
                totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                var infochitietall2 = totalcost2;
                var infochitiet103 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount2 = String.Format(infochitiet103, "{0:c}", infochitietall2);
                lbhistorytotalcost2.Text = notdiscount2;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_3.Text = Convert.ToString(dt2.Rows[2]["Tensanpham"]);
                lbhistorySIZE3.Text = Convert.ToString(dt2.Rows[2]["SIZE"]);
                totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                var infochitietall3 = totalcost3;
                var infochitiet104 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount3 = String.Format(infochitiet104, "{0:c}", infochitietall3);
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_4.Text = Convert.ToString(dt2.Rows[3]["Tensanpham"]);
                lbhistorySIZE4.Text = Convert.ToString(dt2.Rows[3]["SIZE"]);
                totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                var infochitietall4 = totalcost4;
                var infochitiet105 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount4 = String.Format(infochitiet105, "{0:c}", infochitietall4);
                lbhistorytotalcost4.Text = notdiscount4;
                ////////////////////////////////////////////////////////////////////////////
                lbhistoryinfoproduct_5.Text = Convert.ToString(dt2.Rows[4]["Tensanpham"]);
                lbhistorySIZE5.Text = Convert.ToString(dt2.Rows[4]["SIZE"]);
                totalcost5 = Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);
                var infochitietall5 = totalcost5;
                var infochitiet106 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string notdiscount5 = String.Format(infochitiet106, "{0:c}", infochitietall5);
                lbhistorytotalcost4.Text = notdiscount5;
                if (giam10 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    totalcost5 = Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);
                    int totalcost1_1 = totalcost1 * 1 / 10;
                    int totalcost1_9 = totalcost1 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost2_1 = totalcost2 * 1 / 10;
                    int totalcost2_9 = totalcost2 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost3_1 = totalcost3 * 1 / 10;
                    int totalcost3_9 = totalcost3 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost4_1 = totalcost4 * 1 / 10;
                    int totalcost4_9 = totalcost4 * 9 / 10;
                    //////////////////////////////////////
                    int totalcost5_1 = totalcost5 * 1 / 10;
                    int totalcost5_9 = totalcost5 * 9 / 10;
                    var infochitiet10_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet1 = String.Format(infochitiet10_1, "{0:c}", totalcost1_9);
                    string infochitiet1_1 = String.Format(infochitiet10_1, "{0:c}", totalcost2_9);
                    string infochitiet1_1_3 = String.Format(infochitiet10_1, "{0:c}", totalcost3_9);
                    string infochitiet1_1_4 = String.Format(infochitiet10_1, "{0:c}", totalcost4_9);
                    string infochitiet1_1_5 = String.Format(infochitiet10_1, "{0:c}", totalcost5_9);
                    lbhistorytotalcost1.Text = infochitiet1;
                    lbhistorytotalcost2.Text = infochitiet1_1;
                    lbhistorytotalcost3.Text = infochitiet1_1_3;
                    lbhistorytotalcost4.Text = infochitiet1_1_4;
                    lbhistorytotalcost5.Text = infochitiet1_1_5;


                }
                if (giam20 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    totalcost5 = Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);
                    int totalcost1_2 = totalcost1 * 2 / 10;
                    int totalcost1_8 = totalcost1 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost2_2 = totalcost2 * 2 / 10;
                    int totalcost2_8 = totalcost2 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost3_2 = totalcost3 * 2 / 10;
                    int totalcost3_8 = totalcost3 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost4_2 = totalcost4 * 2 / 10;
                    int totalcost4_8 = totalcost4 * 8 / 10;
                    //////////////////////////////////////
                    int totalcost5_2 = totalcost5 * 2 / 10;
                    int totalcost5_8 = totalcost5 * 8 / 10;
                    var infochitiet20_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet2 = String.Format(infochitiet20_1, "{0:c}", totalcost1_8);
                    string infochitiet2_2 = String.Format(infochitiet20_1, "{0:c}", totalcost2_8);
                    string infochitiet2_2_3 = String.Format(infochitiet20_1, "{0:c}", totalcost3_8);
                    string infochitiet2_2_4 = String.Format(infochitiet20_1, "{0:c}", totalcost4_8);
                    string infochitiet2_2_5 = String.Format(infochitiet20_1, "{0:c}", totalcost5_8);
                    lbhistorytotalcost1.Text = infochitiet2;
                    lbhistorytotalcost2.Text = infochitiet2_2;
                    lbhistorytotalcost3.Text = infochitiet2_2_3;
                    lbhistorytotalcost4.Text = infochitiet2_2_4;
                    lbhistorytotalcost5.Text = infochitiet2_2_5;


                }
                if (giam50 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    totalcost5 = Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);
                    int totalcost1_5 = totalcost1 / 2;
                    int totalcost2_5 = totalcost2 / 2;
                    int totalcost3_5 = totalcost3 / 2;
                    int totalcost4_5 = totalcost4 / 2;
                    int totalcost5_5 = totalcost5 / 2;
                    var infochitiet50_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet3 = String.Format(infochitiet50_1, "{0:c}", totalcost1_5);
                    string infochitiet3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost2_5);
                    string infochitiet3_3_3 = String.Format(infochitiet50_1, "{0:c}", totalcost3_5);
                    string infochitiet3_3_4 = String.Format(infochitiet50_1, "{0:c}", totalcost4_5);
                    string infochitiet3_3_5 = String.Format(infochitiet50_1, "{0:c}", totalcost5_5);
                    lbhistorytotalcost1.Text = infochitiet3;
                    lbhistorytotalcost2.Text = infochitiet3_3;
                    lbhistorytotalcost3.Text = infochitiet3_3_3;
                    lbhistorytotalcost4.Text = infochitiet3_3_4;
                    lbhistorytotalcost5.Text = infochitiet3_3_5;

                }
                if (giam60 == 1)
                {
                    totalcost1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
                    totalcost2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
                    totalcost3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
                    totalcost4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
                    totalcost5 = Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);
                    int totalcost1_4 = totalcost1 * 4 / 10;
                    int totalcost1_6 = totalcost1 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost2_4 = totalcost2 * 4 / 10;
                    int totalcost2_6 = totalcost2 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost3_4 = totalcost3 * 4 / 10;
                    int totalcost3_6 = totalcost3 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost4_4 = totalcost4 * 4 / 10;
                    int totalcost4_6 = totalcost4 * 6 / 10;
                    /////////////////////////////////////////
                    int totalcost5_4 = totalcost5 * 4 / 10;
                    int totalcost5_6 = totalcost5 * 6 / 10;
                    var infochitiet60_1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    string infochitiet4 = String.Format(infochitiet60_1, "{0:c}", totalcost1_4);
                    string infochitiet4_4 = String.Format(infochitiet60_1, "{0:c}", totalcost2_4);
                    string infochitiet4_4_3 = String.Format(infochitiet60_1, "{0:c}", totalcost3_4);
                    string infochitiet4_4_4 = String.Format(infochitiet60_1, "{0:c}", totalcost4_4);
                    string infochitiet4_4_5 = String.Format(infochitiet60_1, "{0:c}", totalcost5_4);
                    lbhistorytotalcost1.Text = infochitiet4;
                    lbhistorytotalcost2.Text = infochitiet4_4;
                    lbhistorytotalcost3.Text = infochitiet4_4_3;
                    lbhistorytotalcost4.Text = infochitiet4_4_4;
                    lbhistorytotalcost5.Text = infochitiet4_4_5;


                }
                pnlhistorybuying1.Visible = true;
                pnlhistorybuying2.Visible = true;
                pnlhistorybuying3.Visible = true;
                pnlhistorybuying4.Visible = true;
                pnlhistorybuying5.Visible = true;
            }
            pnlhistory.Visible = true;


        }

        private void btnuseraccount_Click(object sender, EventArgs e)
        {
            pnluseraccount.Visible = true;
        }

        private void btnuseraccountBACK_Click(object sender, EventArgs e)
        {
            pnluseraccount.Visible = false;
            
            
        }

        private void btnhistoryBACK_Click(object sender, EventArgs e)
        {
            pnlhistory.Visible = false;
        }

        private void btnhistorybuyingdetail1_Click(object sender, EventArgs e)
        {
            pnldetailofboughtproduct.Visible = true;
            pnlhistory.Visible = false;
            lbcodeINDETAILOFBOUGHTPRODUCT.Text = lbproductcode1.Text;
            lbchitietdonhangNAME.Text = txtbox_shopcartGIAOTOIDAUNAME.Text;
            richchitietdonhangngnhan.Text=richTextBox_shopcartGIAOTOIDAUDETAIL.Text+ txbox_shopcartGIAOTOIDAUSDT.Text;
            string namepro = Convert.ToString(dt2.Rows[0]["Tensanpham"]);
            switch (namepro)
            {
                case "Air Jordan Retro 12":
                    picboxchitietdonhang.Image = picboxairjoranretro12.Image;
                    break;
                case "Air Max 95 SE":
                    picboxchitietdonhang.Image = picboxairmax95se.Image;
                    break;
                case "KD14EP":
                    picboxchitietdonhang.Image = picboxKD14EP.Image;
                    break;
                case "Kyrie Low 4 EP":
                    picboxchitietdonhang.Image = picboxkyrie7.Image;
                    break;
                case "Nike Low By You":
                    picboxchitietdonhang.Image = picboxnikelowbyyou.Image;
                    break;
                case "Men's Short Sleeve T-Shirt":
                    picboxchitietdonhang.Image = picboxmentshirtjordan.Image;
                    break;
                case "Jordan Jumpman":
                    picboxchitietdonhang.Image = picboxmentshirtjordanjumpman.Image;
                    break;
                case "Nike SportWear Max90":
                    picboxchitietdonhang.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                    break;
                case "Nike ESC":
                    picboxchitietdonhang.Image = picboxmentshirtnikeesc.Image;
                    break;
                case "Nike SportWear":
                    picboxchitietdonhang.Image = picboxmentshirtnikesportwear.Image;
                    break;
                default:
                    not = 1;
                    break;
            }
            int giatienpro1 = Convert.ToInt32(dt2.Rows[0]["Giatien"]);
            int tongtienpro1 = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);
            var infopro = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string dongiapro1 = String.Format(infopro, "{0:c}", giatienpro1);
            string tongtienpro1_s = String.Format(infopro, "{0:c}", tongtienpro1);
            lbchitietdondamua_dongia.Text = dongiapro1;
            lbchitietdondamua_tongcong.Text = tongtienpro1_s;
            lbchitietdondamua_dagiam1.Text = "0,00 đ";
            
            lbchitietdondamua_soluong.Text = Convert.ToString(dt2.Rows[0]["Soluong"]);
            lbchitietdondamuaSIZE.Text = Convert.ToString(dt2.Rows[0]["SIZE"]);
            
            if(giam10==1)
            {
                int giamgiapro1 = tongtienpro1 * 1 / 10;
                int tongtienpro1_chitiet = tongtienpro1 * 9 / 10;
                string giamgiapro1_chitiet = String.Format(infopro, "{0:c}", giamgiapro1);
                string tongtienpro1_chitiet_s = String.Format(infopro, "{0:c}", tongtienpro1_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro1_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro1_chitiet;
            }
            if (giam20 == 1)
            {
                int giamgiapro1 = tongtienpro1 * 2 / 10;
                int tongtienpro1_chitiet = tongtienpro1 * 8 / 10;
                string giamgiapro1_chitiet = String.Format(infopro, "{0:c}", giamgiapro1);
                string tongtienpro1_chitiet_s = String.Format(infopro, "{0:c}", tongtienpro1_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro1_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro1_chitiet;
            }
            if (giam60 == 1)
            {
                int giamgiapro1 = tongtienpro1 * 6 / 10;
                int tongtienpro1_chitiet = tongtienpro1 * 4 / 10;
                string giamgiapro1_chitiet = String.Format(infopro, "{0:c}", giamgiapro1);
                string tongtienpro1_chitiet_s = String.Format(infopro, "{0:c}", tongtienpro1_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro1_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro1_chitiet;
            }
            if (giam50 == 1)
            {
                int giamgiapro1 = tongtienpro1 * 5 / 10;
                int tongtienpro1_chitiet = tongtienpro1 * 5 / 10;
                string giamgiapro1_chitiet = String.Format(infopro, "{0:c}", giamgiapro1);
                string tongtienpro1_chitiet_s = String.Format(infopro, "{0:c}", tongtienpro1_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro1_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro1_chitiet;
            }
        }
        private void pnldetailofboughtproduct_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnhistorybuyingdetail2_Click(object sender, EventArgs e)
        {
            pnldetailofboughtproduct.Visible = true;
            pnlhistory.Visible = false;
            lbcodeINDETAILOFBOUGHTPRODUCT.Text = lbproductcode2.Text;
            lbchitietdonhangNAME.Text = txtbox_shopcartGIAOTOIDAUNAME.Text;
            richchitietdonhangngnhan.Text = richTextBox_shopcartGIAOTOIDAUDETAIL.Text + txbox_shopcartGIAOTOIDAUSDT.Text;
            string namepro1 = Convert.ToString(dt2.Rows[1]["Tensanpham"]);
            switch (namepro1)
            {
                case "Air Jordan Retro 12":
                    picboxchitietdonhang.Image = picboxairjoranretro12.Image;
                    break;
                case "Air Max 95 SE":
                    picboxchitietdonhang.Image = picboxairmax95se.Image;
                    break;
                case "KD14EP":
                    picboxchitietdonhang.Image = picboxKD14EP.Image;
                    break;
                case "Kyrie Low 4 EP":
                    picboxchitietdonhang.Image = picboxkyrie7.Image;
                    break;
                case "Nike Low By You":
                    picboxchitietdonhang.Image = picboxnikelowbyyou.Image;
                    break;
                case "Men's Short Sleeve T-Shirt":
                    picboxchitietdonhang.Image = picboxmentshirtjordan.Image;
                    break;
                case "Jordan Jumpman":
                    picboxchitietdonhang.Image = picboxmentshirtjordanjumpman.Image;
                    break;
                case "Nike SportWear Max90":
                    picboxchitietdonhang.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                    break;
                case "Nike ESC":
                    picboxchitietdonhang.Image = picboxmentshirtnikeesc.Image;
                    break;
                case "Nike SportWear":
                    picboxchitietdonhang.Image = picboxmentshirtnikesportwear.Image;
                    break;
                default:
                    not = 1;
                    break;
            }
            int giatienpro2 = Convert.ToInt32(dt2.Rows[1]["Giatien"]);
            int tongtienpro2 = Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);
            var infopro1 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string dongiapro2 = String.Format(infopro1, "{0:c}", giatienpro2);
            string tongtienpro2_s = String.Format(infopro1, "{0:c}", tongtienpro2);
            lbchitietdondamua_dongia.Text = dongiapro2;
            lbchitietdondamua_tongcong.Text = tongtienpro2_s;
            lbchitietdondamua_dagiam1.Text = "0,00 đ";

            lbchitietdondamua_soluong.Text = Convert.ToString(dt2.Rows[1]["Soluong"]);
            lbchitietdondamuaSIZE.Text = Convert.ToString(dt2.Rows[1]["SIZE"]);

            if (giam10 == 1)
            {
                int giamgiapro2 = tongtienpro2 * 1 / 10;
                int tongtienpro2_chitiet = tongtienpro2 * 9 / 10;
                string giamgiapro2_chitiet = String.Format(infopro1, "{0:c}", giamgiapro2);
                string tongtienpro2_chitiet_s = String.Format(infopro1, "{0:c}", tongtienpro2_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro2_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro2_chitiet;
            }
            if (giam20 == 1)
            {
                int giamgiapro2 = tongtienpro2 * 2 / 10;
                int tongtienpro2_chitiet = tongtienpro2 * 8 / 10;
                string giamgiapro2_chitiet = String.Format(infopro1, "{0:c}", giamgiapro2);
                string tongtienpro2_chitiet_s = String.Format(infopro1, "{0:c}", tongtienpro2_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro2_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro2_chitiet;
            }
            if (giam60 == 1)
            {
                int giamgiapro2 = tongtienpro2 * 6 / 10;
                int tongtienpro2_chitiet = tongtienpro2 * 4 / 10;
                string giamgiapro2_chitiet = String.Format(infopro1, "{0:c}", giamgiapro2);
                string tongtienpro2_chitiet_s = String.Format(infopro1, "{0:c}", tongtienpro2_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro2_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro2_chitiet;
            }
            if (giam50 == 1)
            {
                int giamgiapro2 = tongtienpro2 * 5 / 10;
                int tongtienpro2_chitiet = tongtienpro2 * 5 / 10;
                string giamgiapro2_chitiet = String.Format(infopro1, "{0:c}", giamgiapro2);
                string tongtienpro2_chitiet_s = String.Format(infopro1, "{0:c}", tongtienpro2_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro2_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro2_chitiet;
            }
        }

        private void btnhistorybuyingdetail3_Click(object sender, EventArgs e)
        {
            pnldetailofboughtproduct.Visible = true;
            pnlhistory.Visible = false;
            lbcodeINDETAILOFBOUGHTPRODUCT.Text = lbproductcode3.Text;
            lbchitietdonhangNAME.Text = txtbox_shopcartGIAOTOIDAUNAME.Text;
            richchitietdonhangngnhan.Text = richTextBox_shopcartGIAOTOIDAUDETAIL.Text+ txbox_shopcartGIAOTOIDAUSDT.Text;
            string namepro2 = Convert.ToString(dt2.Rows[2]["Tensanpham"]);
            switch (namepro2)
            {
                case "Air Jordan Retro 12":
                    picboxchitietdonhang.Image = picboxairjoranretro12.Image;
                    break;
                case "Air Max 95 SE":
                    picboxchitietdonhang.Image = picboxairmax95se.Image;
                    break;
                case "KD14EP":
                    picboxchitietdonhang.Image = picboxKD14EP.Image;
                    break;
                case "Kyrie Low 4 EP":
                    picboxchitietdonhang.Image = picboxkyrie7.Image;
                    break;
                case "Nike Low By You":
                    picboxchitietdonhang.Image = picboxnikelowbyyou.Image;
                    break;
                case "Men's Short Sleeve T-Shirt":
                    picboxchitietdonhang.Image = picboxmentshirtjordan.Image;
                    break;
                case "Jordan Jumpman":
                    picboxchitietdonhang.Image = picboxmentshirtjordanjumpman.Image;
                    break;
                case "Nike SportWear Max90":
                    picboxchitietdonhang.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                    break;
                case "Nike ESC":
                    picboxchitietdonhang.Image = picboxmentshirtnikeesc.Image;
                    break;
                case "Nike SportWear":
                    picboxchitietdonhang.Image = picboxmentshirtnikesportwear.Image;
                    break;
                default:
                    not = 1;
                    break;
            }
            int giatienpro3 = Convert.ToInt32(dt2.Rows[2]["Giatien"]);
            int tongtienpro3 = Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);
            var infopro2 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string dongiapro3 = String.Format(infopro2, "{0:c}", giatienpro3);
            string tongtienpro3_s = String.Format(infopro2, "{0:c}", tongtienpro3);
            lbchitietdondamua_dongia.Text = dongiapro3;
            lbchitietdondamua_tongcong.Text = tongtienpro3_s;
            lbchitietdondamua_dagiam1.Text = "0,00 đ";

            lbchitietdondamua_soluong.Text = Convert.ToString(dt2.Rows[2]["Soluong"]);
            lbchitietdondamuaSIZE.Text = Convert.ToString(dt2.Rows[2]["SIZE"]);

            if (giam10 == 1)
            {
                int giamgiapro3 = tongtienpro3 * 1 / 10;
                int tongtienpro3_chitiet = tongtienpro3 * 9 / 10;
                string giamgiapro3_chitiet = String.Format(infopro2, "{0:c}", giamgiapro3);
                string tongtienpro3_chitiet_s = String.Format(infopro2, "{0:c}", tongtienpro3_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro3_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro3_chitiet;
            }
            if (giam20 == 1)
            {
                int giamgiapro3 = tongtienpro3 * 2 / 10;
                int tongtienpro3_chitiet = tongtienpro3 * 8 / 10;
                string giamgiapro3_chitiet = String.Format(infopro2, "{0:c}", giamgiapro3);
                string tongtienpro3_chitiet_s = String.Format(infopro2, "{0:c}", tongtienpro3_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro3_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro3_chitiet;
            }
            if (giam60 == 1)
            {
                int giamgiapro3 = tongtienpro3 * 6 / 10;
                int tongtienpro3_chitiet = tongtienpro3 * 4 / 10;
                string giamgiapro3_chitiet = String.Format(infopro2, "{0:c}", giamgiapro3);
                string tongtienpro3_chitiet_s = String.Format(infopro2, "{0:c}", tongtienpro3_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro3_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro3_chitiet;
            }
            if (giam50 == 1)
            {
                int giamgiapro3 = tongtienpro3 * 5 / 10;
                int tongtienpro3_chitiet = tongtienpro3 * 5 / 10;
                string giamgiapro3_chitiet = String.Format(infopro2, "{0:c}", giamgiapro3);
                string tongtienpro3_chitiet_s = String.Format(infopro2, "{0:c}", tongtienpro3_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro3_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro3_chitiet;
            }
        
        }

        private void btnhistorybuyingdetail4_Click(object sender, EventArgs e)
        {
            pnldetailofboughtproduct.Visible = true;
            pnlhistory.Visible = false;
            lbcodeINDETAILOFBOUGHTPRODUCT.Text = lbproductcode4.Text;
            lbchitietdonhangNAME.Text = txtbox_shopcartGIAOTOIDAUNAME.Text+ txbox_shopcartGIAOTOIDAUSDT.Text;
            richchitietdonhangngnhan.Text = richTextBox_shopcartGIAOTOIDAUDETAIL.Text;
            string namepro3 = Convert.ToString(dt2.Rows[3]["Tensanpham"]);
            switch (namepro3)
            {
                case "Air Jordan Retro 12":
                    picboxchitietdonhang.Image = picboxairjoranretro12.Image;
                    break;
                case "Air Max 95 SE":
                    picboxchitietdonhang.Image = picboxairmax95se.Image;
                    break;
                case "KD14EP":
                    picboxchitietdonhang.Image = picboxKD14EP.Image;
                    break;
                case "Kyrie Low 4 EP":
                    picboxchitietdonhang.Image = picboxkyrie7.Image;
                    break;
                case "Nike Low By You":
                    picboxchitietdonhang.Image = picboxnikelowbyyou.Image;
                    break;
                case "Men's Short Sleeve T-Shirt":
                    picboxchitietdonhang.Image = picboxmentshirtjordan.Image;
                    break;
                case "Jordan Jumpman":
                    picboxchitietdonhang.Image = picboxmentshirtjordanjumpman.Image;
                    break;
                case "Nike SportWear Max90":
                    picboxchitietdonhang.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                    break;
                case "Nike ESC":
                    picboxchitietdonhang.Image = picboxmentshirtnikeesc.Image;
                    break;
                case "Nike SportWear":
                    picboxchitietdonhang.Image = picboxmentshirtnikesportwear.Image;
                    break;
                default:
                    not = 1;
                    break;
            }
            int giatienpro4 = Convert.ToInt32(dt2.Rows[3]["Giatien"]);
            int tongtienpro4 = Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);
            var infopro3 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string dongiapro4 = String.Format(infopro3, "{0:c}", giatienpro4);
            string tongtienpro4_s = String.Format(infopro3, "{0:c}", tongtienpro4);
            lbchitietdondamua_dongia.Text = dongiapro4;
            lbchitietdondamua_tongcong.Text = tongtienpro4_s;
            lbchitietdondamua_dagiam1.Text = "0,00 đ";

            lbchitietdondamua_soluong.Text = Convert.ToString(dt2.Rows[3]["Soluong"]);
            lbchitietdondamuaSIZE.Text = Convert.ToString(dt2.Rows[3]["SIZE"]);

            if (giam10 == 1)
            {
                int giamgiapro4 = tongtienpro4 * 1 / 10;
                int tongtienpro4_chitiet = tongtienpro4 * 9 / 10;
                string giamgiapro4_chitiet = String.Format(infopro3, "{0:c}", giamgiapro4);
                string tongtienpro4_chitiet_s = String.Format(infopro3, "{0:c}", tongtienpro4_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro4_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro4_chitiet;
            }
            if (giam20 == 1)
            {
                int giamgiapro4 = tongtienpro4 * 2 / 10;
                int tongtienpro4_chitiet = tongtienpro4 * 8 / 10;
                string giamgiapro4_chitiet = String.Format(infopro3, "{0:c}", giamgiapro4);
                string tongtienpro4_chitiet_s = String.Format(infopro3, "{0:c}", tongtienpro4_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro4_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro4_chitiet;
            }
            if (giam60 == 1)
            {
                int giamgiapro4 = tongtienpro4 * 6 / 10;
                int tongtienpro4_chitiet = tongtienpro4 * 4 / 10;
                string giamgiapro4_chitiet = String.Format(infopro3, "{0:c}", giamgiapro4);
                string tongtienpro4_chitiet_s = String.Format(infopro3, "{0:c}", tongtienpro4_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro4_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro4_chitiet;
            }
            if (giam50 == 1)
            {
                int giamgiapro4 = tongtienpro4 * 5 / 10;
                int tongtienpro4_chitiet = tongtienpro4 * 5 / 10;
                string giamgiapro4_chitiet = String.Format(infopro3, "{0:c}", giamgiapro4);
                string tongtienpro4_chitiet_s = String.Format(infopro3, "{0:c}", tongtienpro4_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro4_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro4_chitiet;
            }
        }

        private void btnhistorybuyingdetail5_Click(object sender, EventArgs e)
        {
            pnldetailofboughtproduct.Visible = true;
            pnlhistory.Visible = false;
            lbcodeINDETAILOFBOUGHTPRODUCT.Text = lbproductcode5.Text;
            lbchitietdonhangNAME.Text = txtbox_shopcartGIAOTOIDAUNAME.Text+ txbox_shopcartGIAOTOIDAUSDT.Text;
            richchitietdonhangngnhan.Text = richTextBox_shopcartGIAOTOIDAUDETAIL.Text;
            string namepro4 = Convert.ToString(dt2.Rows[4]["Tensanpham"]);
            switch (namepro4)
            {
                case "Air Jordan Retro 12":
                    picboxchitietdonhang.Image = picboxairjoranretro12.Image;
                    break;
                case "Air Max 95 SE":
                    picboxchitietdonhang.Image = picboxairmax95se.Image;
                    break;
                case "KD14EP":
                    picboxchitietdonhang.Image = picboxKD14EP.Image;
                    break;
                case "Kyrie Low 4 EP":
                    picboxchitietdonhang.Image = picboxkyrie7.Image;
                    break;
                case "Nike Low By You":
                    picboxchitietdonhang.Image = picboxnikelowbyyou.Image;
                    break;
                case "Men's Short Sleeve T-Shirt":
                    picboxchitietdonhang.Image = picboxmentshirtjordan.Image;
                    break;
                case "Jordan Jumpman":
                    picboxchitietdonhang.Image = picboxmentshirtjordanjumpman.Image;
                    break;
                case "Nike SportWear Max90":
                    picboxchitietdonhang.Image = Image.FromFile(@"Men\Tshirt\Nikemax90\mentshirt-nikemax90.png");
                    break;
                case "Nike ESC":
                    picboxchitietdonhang.Image = picboxmentshirtnikeesc.Image;
                    break;
                case "Nike SportWear":
                    picboxchitietdonhang.Image = picboxmentshirtnikesportwear.Image;
                    break;
                default:
                    not = 1;
                    break;
            }
            int giatienpro5 = Convert.ToInt32(dt2.Rows[4]["Giatien"]);
            int tongtienpro5 = Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);
            var infopro4 = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string dongiapro5 = String.Format(infopro4, "{0:c}", giatienpro5);
            string tongtienpro5_s = String.Format(infopro4, "{0:c}", tongtienpro5);
            lbchitietdondamua_dongia.Text = dongiapro5;
            lbchitietdondamua_tongcong.Text = tongtienpro5_s;
            lbchitietdondamua_dagiam1.Text = "0,00 đ";

            lbchitietdondamua_soluong.Text = Convert.ToString(dt2.Rows[4]["Soluong"]);
            lbchitietdondamuaSIZE.Text = Convert.ToString(dt2.Rows[4]["SIZE"]);

            if (giam10 == 1)
            {
                int giamgiapro5 = tongtienpro5 * 1 / 10;
                int tongtienpro5_chitiet = tongtienpro5 * 9 / 10;
                string giamgiapro5_chitiet = String.Format(infopro4, "{0:c}", giamgiapro5);
                string tongtienpro5_chitiet_s = String.Format(infopro4, "{0:c}", tongtienpro5_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro5_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro5_chitiet;
            }
            if (giam20 == 1)
            {
                int giamgiapro5 = tongtienpro5 * 2 / 10;
                int tongtienpro5_chitiet = tongtienpro5 * 8 / 10;
                string giamgiapro5_chitiet = String.Format(infopro4, "{0:c}", giamgiapro5);
                string tongtienpro5_chitiet_s = String.Format(infopro4, "{0:c}", tongtienpro5_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro5_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro5_chitiet;
            }
            if (giam60 == 1)
            {
                int giamgiapro5 = tongtienpro5 * 6 / 10;
                int tongtienpro5_chitiet = tongtienpro5 * 4 / 10;
                string giamgiapro5_chitiet = String.Format(infopro4, "{0:c}", giamgiapro5);
                string tongtienpro5_chitiet_s = String.Format(infopro4, "{0:c}", tongtienpro5_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro5_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro5_chitiet;
            }
            if (giam50 == 1)
            {
                int giamgiapro5 = tongtienpro5 * 5 / 10;
                int tongtienpro5_chitiet = tongtienpro5 * 5 / 10;
                string giamgiapro5_chitiet = String.Format(infopro4, "{0:c}", giamgiapro5);
                string tongtienpro5_chitiet_s = String.Format(infopro4, "{0:c}", tongtienpro5_chitiet);
                lbchitietdondamua_tongcong.Text = tongtienpro5_chitiet_s;
                lbchitietdondamua_dagiam1.Text = giamgiapro5_chitiet;
            }
        }
        private void btndetailofboughtproductBACK_Click(object sender, EventArgs e)
        {
            pnldetailofboughtproduct.Visible = false;
            pnlhistory.Visible = true;
        }
        int totalproductsofallorders;
        
        private void btnthongkedonhang_Click(object sender, EventArgs e)
        {
            
            int totalyoudidpay;
            int totalorders = dt2.Rows.Count;
            string totalpayed = lbshopcartTINHTIEN_tongcong.Text;
            var chuyentien = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                if (totalorders == 1)
                {
                    totalproductsofallorders = Convert.ToInt32(dt2.Rows[0]["Soluong"]);
                    totalyoudidpay = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]);


                }
                if (totalorders == 2)
                {
                    totalproductsofallorders = Convert.ToInt32(dt2.Rows[0]["Soluong"]) + Convert.ToInt32(dt2.Rows[1]["Soluong"]);
                    totalyoudidpay = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[1]["Thanhtien"]);


                }
                if (totalorders == 3)
                {
                    totalproductsofallorders = Convert.ToInt32(dt2.Rows[0]["Soluong"]) + Convert.ToInt32(dt2.Rows[1]["Soluong"]) + Convert.ToInt32(dt2.Rows[2]["Soluong"]);
                    totalyoudidpay = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[1]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[2]["Thanhtien"]);

                }
                if (totalorders == 4)
                {
                    totalproductsofallorders = Convert.ToInt32(dt2.Rows[0]["Soluong"]) + Convert.ToInt32(dt2.Rows[1]["Soluong"]) + Convert.ToInt32(dt2.Rows[2]["Soluong"]) + Convert.ToInt32(dt2.Rows[3]["Soluong"]);
                    totalyoudidpay = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[1]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[2]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[3]["Thanhtien"]);

                }
                if (totalorders == 5)
                {
                    totalproductsofallorders = Convert.ToInt32(dt2.Rows[0]["Soluong"]) + Convert.ToInt32(dt2.Rows[1]["Soluong"]) + Convert.ToInt32(dt2.Rows[2]["Soluong"]) + Convert.ToInt32(dt2.Rows[3]["Soluong"]) + Convert.ToInt32(dt2.Rows[4]["Soluong"]);
                    totalyoudidpay = Convert.ToInt32(dt2.Rows[0]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[1]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[2]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[3]["Thanhtien"]) + Convert.ToInt32(dt2.Rows[4]["Thanhtien"]);

                }
                int tongcongtatcamoidon = sodonhuy + Convert.ToInt32(dt2.Rows.Count) + Convert.ToInt32(dt.Rows.Count);
                txtbox_totalorders.Text = Convert.ToString(tongcongtatcamoidon);
                txtboxtotalproductofallorders.Text = Convert.ToString(totalproductsofallorders);
                int sodondahuy = sodonhuy;
                int sodondathanhtoan = dt2.Rows.Count;

                int sodonmoi = dt.Rows.Count;
                Decimal p1 = ((Decimal)sodondahuy / (Decimal)tongcongtatcamoidon);
                Decimal p2 = ((Decimal)sodondathanhtoan / (Decimal)tongcongtatcamoidon);

                Decimal p4 = ((Decimal)sodonmoi / (Decimal)tongcongtatcamoidon);
                string sodondahuy1 = Convert.ToString(Math.Round((p1 * 100), 1));
                string sodondathanhtoan1 = Convert.ToString(Math.Round((p2 * 100), 1));
                string sodonmoi1 = Convert.ToString(Math.Round((p4 * 100), 1));
                pnlcartstatistic.Visible = true;

                chart1.Titles.Add("Cart Statistic Report");
                chart1.Series["s1"].Points.AddXY("Đơn đang hoàn: 0 (0%)", "0");
                chart1.Series["s1"].Points.AddXY("Đơn bị hủy:" + Convert.ToString(sodondahuy) + "(" + sodondahuy1 + "%" + ")", sodondahuy1);
                chart1.Series["s1"].Points.AddXY("Đơn đã thanh toán:" + Convert.ToString(sodondathanhtoan) + "(" + sodondathanhtoan1 + "%" + ")", sodondathanhtoan1);
                chart1.Series["s1"].Points.AddXY("Đơn mới:" + Convert.ToString(sodonmoi) + "(" + sodonmoi1 + "%" + ")", sodonmoi1);
        }
        
            
        private void btnstatisticsBACK_Click(object sender, EventArgs e)
        {
            pnlcartstatistic.Visible = false;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Titles.RemoveAt(0);
        }
    }
    
}
