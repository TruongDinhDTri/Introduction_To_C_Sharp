using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTASKEESIMULATOR
{
    public partial class pnlfinishedactivity : Form
    {
        public pnlfinishedactivity()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void label4_Click(object sender, EventArgs e)
        {

        }
        int num = 0;
        int lc = 0;
        string so_phong_A = "";
        string so_phong_B = "";
        string so_phong_C = "";
        int num23 = 0;
        int thanhtoan = 0;
        int indexx = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            picbox_time.Image = imageList1.Images[num];
            num++;
            if(num==5)
            {
                num = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
        int chuyen = 1;
        int pnlchosen;
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            if(chuyen==1)
            {
                pnlgrocery1.Visible = true;
                ++chuyen;
                pnlchosen = 1;
            }
            else
            {
                if(chuyen==2)
                {
                    pnllaundry1.Visible = true;
                    pnlgrocery1.Visible = false;
                    ++chuyen;
                    pnlchosen = 2;
                }
                else
                {
                    if(chuyen==3)
                    {
                        pnldeepclean1.Visible = true;
                        pnllaundry1.Visible = false;
                        ++chuyen;
                        pnlchosen = 3;
                    }  
                    else
                    {
                        if(chuyen==4)
                        {
                            pnlkhukhuan1.Visible = true;
                            pnldeepclean1.Visible = false;
                            chuyen++;
                            pnlchosen = 4;
                        }
                        else
                        {
                            if(chuyen==5)
                            {
                                chuyen = 1;
                            }
                        }
                    }
                }
            }
                
        }
        string s = " ";
        private void btnwant_Click(object sender, EventArgs e)
        {
            if (pnlchosen == 1)
            {
                pnlgrocerychosen.Visible = true;
                pnlgrocery1.Visible = false;
                s = "GroceryAssis";
            }
            else
            {
                if(pnlchosen == 2)
                {
                    pnllaundrychosen.Visible = true;
                    pnllaundry1.Visible = false;
                     s = "Laundry";
                }
                else
                {
                    if(pnlchosen == 3)
                    {
                        pnldeepcleanchosen.Visible = true;
                        pnldeepclean1.Visible = false;
                         s = "DeepClean";
                    } 
                    else
                    {
                        if(pnlchosen == 4)
                        {
                            pnlkhukhuanchosen.Visible = true;
                            pnlkhukhuan1.Visible = false;
                            s = "Disinfiction";
                        }
                    }
                }
            }
        }
        private void btngroceryback_Click(object sender, EventArgs e)
        {
            pnlgrocerychosen.Visible = false;
            chuyen = 1;
        }

        private void btnkhukhuanback_Click(object sender, EventArgs e)
        {
            pnlkhukhuanchosen.Visible = false;
            pnlkhukhuan1.Visible = true;
            chuyen = 1;
        }

        private void btnlaudryback_Click(object sender, EventArgs e)
        {
            pnllaundrychosen.Visible = false;
            chuyen = 1;
        }

        private void btndeepcleanback_Click(object sender, EventArgs e)
        {
            pnldeepcleanchosen.Visible = false;
            chuyen = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Sothutu", typeof(Int32));
            dt.Columns.Add("Loaidichvu", typeof(string));
            dt.Columns.Add("Diachi", typeof(string));
            dt.Columns.Add("Sdt", typeof(Int32));
            dt.Columns.Add("Sogio", typeof(Int32));
            dt.Columns.Add("Dientich", typeof(Int32));
            dt.Columns.Add("Kg", typeof(Int32));
            dt.Columns.Add("Ghichu", typeof(string));
            dt.Columns.Add("Sotien", typeof(Int32));
            dt.Columns.Add("Ngaylam", typeof(string));
            dt.Columns.Add("Thanhtoan", typeof(Int32));
            dataGridView1.DataSource = dt;
            
        }
        
        string AutoIDRoom(string TypeRoom)
        {
            string IDRoom = "";
            if (TypeRoom == "GroceryAssis")
            {
                IDRoom += "GroceryAssis";

                IDRoom += Convert.ToString(so_phong_A);
            }
            else if (TypeRoom == "Laundry")
            {
                IDRoom += "Laundry";

                IDRoom += Convert.ToString(so_phong_B);
            }
            else if (TypeRoom == "DeepClean")
            {
                IDRoom += "DeepClean";

                IDRoom += Convert.ToString(so_phong_C);
            }
            else if (TypeRoom == "Disinfiction")
            {
                IDRoom += "Disinfiction";

                IDRoom += Convert.ToString(so_phong_C);
            }

            return IDRoom;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pnldeepcleanchosen_Paint(object sender, PaintEventArgs e)
        {
            label13.Parent = picbox_deepclean;
            label13.BackColor = Color.Transparent;

            label14.Parent = picbox_deepclean;
            label14.BackColor = Color.Transparent;

            label15.Parent = picbox_deepclean;
            label15.BackColor = Color.Transparent;

            label16.Parent = picbox_deepclean;
            label16.BackColor = Color.Transparent;

            label17.Parent = picbox_deepclean;
            label17.BackColor = Color.Transparent;


        }

        private void pnllaundrychosen_Paint(object sender, PaintEventArgs e)
        {
            label24.Parent = picbox_laundry;
            label24.BackColor = Color.Transparent;

            label25.Parent = picbox_laundry;
            label25.BackColor = Color.Transparent;

            label26.Parent = picbox_laundry;
            label26.BackColor = Color.Transparent;

            label27.Parent = picbox_laundry;
            label27.BackColor = Color.Transparent;
        }

        private void dateTimePicker_ngaylamlaundry_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlgrocerychosen_Paint(object sender, PaintEventArgs e)
        {
            label40.Parent = picbox_grocery;
            label40.BackColor = Color.Transparent;

            label41.Parent = picbox_grocery;
            label41.BackColor = Color.Transparent;

            label42.Parent = picbox_grocery;
            label42.BackColor = Color.Transparent;
        }

        private void pnlkhukhuanchosen_Paint(object sender, PaintEventArgs e)
        {
            label43.Parent = picboxkhukhuan;
            label43.BackColor = Color.Transparent;

            label44.Parent = picboxkhukhuan;
            label44.BackColor = Color.Transparent;

            label45.Parent = picboxkhukhuan;
            label45.BackColor = Color.Transparent;


        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            pnlmain.Visible = true;
            pnlaccount.Visible = false;
            pnlchat.Visible = false;
            pnlactivity.Visible = false;
        }

        private void btnactivity_Click(object sender, EventArgs e)
        {
            pnlactivity.Visible = true;
            pnlmain.Visible = false;
            pnlchat.Visible = false;
            pnlaccount.Visible = false;
        }

        private void btnchat_Click(object sender, EventArgs e)
        {
            pnlchat.Visible = true;
            pnlmain.Visible = false;
            pnlactivity.Visible = false;
            pnlaccount.Visible = false;
        }
  
        private void btnaccount_Click(object sender, EventArgs e)
        {
            pnlaccount.Visible = true;
            pnlmain.Visible = false;
            pnlactivity.Visible = false;
            pnlchat.Visible = false;
           

        }


        private void btnpending_acitivity_Click(object sender, EventArgs e)
        {
            pnlpendingactivity.Visible = true;
            pnlfinished.Visible = false;
            pnlview.Visible = false ;


        }

      
        private void View_Click(object sender, EventArgs e)
        {
            pnlview.Visible = true;
            pnlpendingactivity.Visible = false;
            pnlfinished.Visible = false;

        }

        private void btnprofilesback_Click(object sender, EventArgs e)
        {
            pnlprofiles.Visible = false;


        }

        private void btnsettingback_Click(object sender, EventArgs e)
        {
            pnlsetting.Visible = false;
        }

        private void btndiscountnewsback_Click(object sender, EventArgs e)
        {
            pnldiscountnews.Visible = false;
        }

        private void btnhelpback_Click(object sender, EventArgs e)
        {
            pnlhelp.Visible = false;
        }

        private void pnlhelp_Paint(object sender, PaintEventArgs e)
        {
            label48.Parent = pictureBox_help;
            label48.BackColor = Color.Transparent;

            label49.Parent = pictureBox_help;
            label49.BackColor = Color.Transparent;
        }

        private void btnnguoiyeuthichback_Click(object sender, EventArgs e)
        {
            pnlnguoiyeuthich.Visible = false;
        }

        private void btnseeprofiles_Click(object sender, EventArgs e)
        {
            pnlprofiles.Visible = true;
        }

        private void btnfavorite_Click(object sender, EventArgs e)
        {
            pnlnguoiyeuthich.Visible = true;
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            pnlhelp.Visible = true;
        }

        private void btndiscountnews_Click(object sender, EventArgs e)
        {
            pnldiscountnews.Visible = true;
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            pnlsetting.Visible = true;
        }

        private void btndeepcleanxacnhan_Click(object sender, EventArgs e)
        {
            string id_room = AutoIDRoom(s);
            listView_pendingactivity.LargeImageList = imageList1;
            listView_pendingactivity.Items.Add(id_room, 5);
            dt.Rows.Add(num23, id_room, Convert.ToString(richTextBox_diachideepclean.Text), Convert.ToString(richTextBox_sdtdeepclean.Text), Convert.ToInt32(numericUpDown_sogiodeepclean.Value), Convert.ToInt32(richTextBox_dientichdeepclean.Text), 1, Convert.ToString(richTextBox_ghichudeepclean.Text),200000, Convert.ToString(dateTimePicker_ngaylamdeepclean.Value),thanhtoan);
            ++num23;
        }

        private void btnlaundryxacnhan_Click(object sender, EventArgs e)
        {
            string id_room = AutoIDRoom(s);
            listView_pendingactivity.LargeImageList = imageList1;
            listView_pendingactivity.Items.Add(id_room, 6);
            dt.Rows.Add(num23, id_room, Convert.ToString(richTextBox_diachilaundry.Text), Convert.ToString(richTextBox_sdtlaundry.Text), Convert.ToInt32(numericUpDown_sogiolaundry.Value), 1, Convert.ToInt32(richTextBox_sokglaundry.Text), Convert.ToString(richTextBox_ghichulaundry.Text), 150000, Convert.ToString(dateTimePicker_ngaylamlaundry.Value), thanhtoan);
            ++num23;
        }

        private void btngroceryxacnhan_Click(object sender, EventArgs e)
        {
            string id_room = AutoIDRoom(s);
            listView_pendingactivity.LargeImageList = imageList1;
            listView_pendingactivity.Items.Add(id_room, 8);
            dt.Rows.Add(num23, id_room, Convert.ToString(richTextBox_diachigrocery.Text), Convert.ToString(richTextBox_sdtgrocery.Text), Convert.ToInt32(numericUpDown_sogiogrocery.Value), 1, Convert.ToInt32(richTextBox_sokggrocery.Text), Convert.ToString(richTextBox_ghichugrocery.Text), 300000 , Convert.ToString(dateTimePicker_ngaylamgrocery.Value), thanhtoan);

            ++num23;
        }

        private void btnkhukhuanxacnhan_Click(object sender, EventArgs e)
        {
            string id_room = AutoIDRoom(s);
            listView_pendingactivity.LargeImageList = imageList1;
            listView_pendingactivity.Items.Add(id_room, 7 );
            dt.Rows.Add(num23, id_room, Convert.ToString(richTextBox_diachikhukhuan.Text), Convert.ToString(richTextBox_sdtkhukhuan.Text), Convert.ToInt32(numericUpDown_sogiokhukhuan.Value), Convert.ToInt32(richTextBox_dientichkhukhuan.Text), 1 , Convert.ToString(richTextBox_ghichukhukhuan.Text), 350000, Convert.ToString(dateTimePicker_ngaylamkhukhuan.Value), thanhtoan);
            ++num23;
        }
        int a, b, c, d;
        private void listView_pendingactivity_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            indexx = e.ItemIndex;   //items Index chinh la index khi bam vao items cua listview1
            if(dt.Rows.Count > 0)
            {
                a = Convert.ToInt32(dt.Rows[indexx]["Sotien"]);
                b = Convert.ToInt32(dt.Rows[indexx]["Sogio"]);
                c = Convert.ToInt32(dt.Rows[indexx]["Kg"]);
                d = Convert.ToInt32(dt.Rows[indexx]["Dientich"]);

                if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "GroceryAssis")
                {
                    dt.Rows[indexx]["Thanhtoan"] = a * b * c;
                    richTextBox_loaidichvuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                    richTextBox_diachithanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                    richTextBox_sdtthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                    richTextBox_sogiothanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                    richTextBox_dientichthanhtoan.Text = "1";
                    richTextBox_sokgthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Kg"]);
                    richTextBox_ghichuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                    richTextBox_ngaylamthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                    richTextBox_canthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);
                }
                else if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "Laundry")
                {
                    dt.Rows[indexx]["Thanhtoan"] = a * b * c;
                    richTextBox_loaidichvuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                    richTextBox_diachithanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                    richTextBox_sdtthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                    richTextBox_sogiothanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                    richTextBox_dientichthanhtoan.Text = "1";
                    richTextBox_sokgthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Kg"]);
                    richTextBox_ghichuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                    richTextBox_ngaylamthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                    richTextBox_canthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);
                }
                else if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "DeepClean")
                {
                    dt.Rows[indexx]["Thanhtoan"] = a * b * d;
                    richTextBox_loaidichvuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                    richTextBox_diachithanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                    richTextBox_sdtthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                    richTextBox_sogiothanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                    richTextBox_dientichthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Dientich"]);
                    richTextBox_sokgthanhtoan.Text = "1";
                    richTextBox_ghichuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                    richTextBox_ngaylamthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                    richTextBox_canthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);
                }
                else if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "Disinfiction")
                {
                    dt.Rows[indexx]["Thanhtoan"] = a * b * d;
                    richTextBox_loaidichvuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                    richTextBox_diachithanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                    richTextBox_sdtthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                    richTextBox_sogiothanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                    richTextBox_dientichthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Dientich"]);
                    richTextBox_sokgthanhtoan.Text = "1";
                    richTextBox_ghichuthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                    richTextBox_ngaylamthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                    richTextBox_canthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);
                }

                pnlthanhtoan.Visible = true;
            }
            else
            {
                lc = 12;
            }    


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView_finished_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pnlhistory.Visible = true;
        }
        int uudai = 1;
        private void btnuudai_Click(object sender, EventArgs e)
        {
            if(uudai%2 !=0)
            {
                pnluudai.Visible = true;
                uudai++;
            }
            else if(uudai%2 ==0)
            {
                pnluudai.Visible = false ;
                uudai++;
            }
            
        }
        private void btndiscount20_Click(object sender, EventArgs e)
        {
            dt.Rows[indexx]["Thanhtoan"] = Convert.ToInt32(dt.Rows[indexx]["Thanhtoan"]) - 20000;
            richTextBox_canthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"])+"(Da giam 20000)";
        }
        private void btndiscount50_Click(object sender, EventArgs e)
        {
            dt.Rows[indexx]["Thanhtoan"] = Convert.ToInt32(dt.Rows[indexx]["Thanhtoan"]) / 2;
            richTextBox_canthanhtoan.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]) + "(Da giam 50%)";
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "GroceryAssis")
            {
                listView_finished.LargeImageList = imageList1;
                listView_finished.Items.Add(listView_pendingactivity.Items[indexx].Text + "Da thanh toan", 8);
                richTextBox_loaidichvuhistory.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                richTextBox_diachihistory.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                richTextBox_sdthistory.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                richTextBox_sogiohistory.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                richTextBox_dientichhistory.Text = Convert.ToString(dt.Rows[indexx]["Dientich"]);
                richTextBox_sokghistory.Text = "1";
                richTextBox_ghichuhistory.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                richTextBox_ngaylamhistory.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                richTextBox_dathanhtoanhistory.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);


            }
            else if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "Laundry")
            {
                listView_finished.LargeImageList = imageList1;
                listView_finished.Items.Add(listView_pendingactivity.Items[indexx].Text + "Da thanh toan", 6);
                richTextBox_loaidichvuhistory.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                richTextBox_diachihistory.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                richTextBox_sdthistory.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                richTextBox_sogiohistory.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                richTextBox_dientichhistory.Text = Convert.ToString(dt.Rows[indexx]["Dientich"]);
                richTextBox_sokghistory.Text = "1";
                richTextBox_ghichuhistory.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                richTextBox_ngaylamhistory.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                richTextBox_dathanhtoanhistory.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);





            }
            else if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "DeepClean")
            {
                listView_finished.LargeImageList = imageList1;
                listView_finished.Items.Add(listView_pendingactivity.Items[indexx].Text + "Da thanh toan", 5);
                richTextBox_loaidichvuhistory.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                richTextBox_diachihistory.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                richTextBox_sdthistory.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                richTextBox_sogiohistory.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                richTextBox_dientichhistory.Text = Convert.ToString(dt.Rows[indexx]["Dientich"]);
                richTextBox_sokghistory.Text = "1";
                richTextBox_ghichuhistory.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                richTextBox_ngaylamhistory.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                richTextBox_dathanhtoanhistory.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);



            }
            else if (Convert.ToString(dt.Rows[indexx]["Loaidichvu"]) == "Disinfiction")
            {
                listView_finished.LargeImageList = imageList1;
                listView_finished.Items.Add(listView_pendingactivity.Items[indexx].Text + "Da thanh toan", 7);
                richTextBox_loaidichvuhistory.Text = Convert.ToString(dt.Rows[indexx]["Loaidichvu"]);
                richTextBox_diachihistory.Text = Convert.ToString(dt.Rows[indexx]["Diachi"]);
                richTextBox_sdthistory.Text = Convert.ToString(dt.Rows[indexx]["Sdt"]);
                richTextBox_sogiohistory.Text = Convert.ToString(dt.Rows[indexx]["Sogio"]);
                richTextBox_dientichhistory.Text = Convert.ToString(dt.Rows[indexx]["Dientich"]);
                richTextBox_sokghistory.Text = "1";
                richTextBox_ghichuhistory.Text = Convert.ToString(dt.Rows[indexx]["Ghichu"]);
                richTextBox_ngaylamhistory.Text = Convert.ToString(dt.Rows[indexx]["Ngaylam"]);
                richTextBox_dathanhtoanhistory.Text = Convert.ToString(dt.Rows[indexx]["Thanhtoan"]);

               




            }
                MessageBox.Show("So tien da thanh toan la : " + Convert.ToString(dt.Rows[indexx]["Thanhtoan"]),"Tien Thanh Toan ",MessageBoxButtons.OK);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_english_CheckedChanged(object sender, EventArgs e)
        {
            label73.Text = "History of Services";
            label72.Text = "Typeservice";
            label71.Text = "Address";
            label69.Text = "Phone.num";
            label70.Text = "HireTime(hour)";
            label68.Text = "Square";
            label67.Text = "Kg";
            label66.Text = "Note";
            label65.Text = "Date/ Time";
            label58.Text = "Already Payed";
            button4.Text = "Go back";
            ///////////////////////////////////////////////////////////////
            ///
            label56.Text = "TypeService";
            label57.Text = "Address";
            Sdt.Text = "Phone.num";
            label59.Text = "HireTime(hour)";
            label60.Text = "Square";
            label61.Text = "Kg";

            label62.Text = "Notes";
            label63.Text = "Date/ Times";
            label64.Text = "Need.T.Pay";
            btnthanhtoan.Text = "Pay";
            btnuudai.Text = "Favour";
            btndiscount20.Text = "Discount20";
            btndiscount50.Text = "Discount50";
            btnfinished_activity.Text = "Finished";
            View.Text = "View";
            btnpending_acitivity.Text = "Pending";
            btnpnlthanhtoanback.Text = "Go Back";
            btnthanhtoan.Text = "Pay";
            ////////////////////////////////////////////////////////////////
            ///
            label6.Text = "Address";
            label8.Text = "Phone.num";
            label9.Text = "HireTime(Hour)";
            label10.Text = "Square";
            label11.Text = "Note";
            label12.Text = "Date/Time";
            btndeepcleanxacnhan.Text = "Confirm";
            btndeepcleanback.Text = "Go Back";



            label13.Text = "we will remove the deep dirt and grime";
            label14.Text = "in your home";
            label15.Text = "Hard-to-reach ledges";
            label16.Text = "windows";
            label17.Text = "light fixtures and above cabinets";


            label18.Text = "Address";
            label19.Text = "Phone.num";
            label20.Text = "HireTime(Hour)";
            label21.Text = "Kg";
            label22.Text = "Note";
            label23.Text = "Date/Time";

            btnlaundryxacnhan.Text = "Confirm";
            btnlaudryback.Text = "Go Back";


            label24.Text = "We will collecting soiled linens or clothing";
            label25.Text ="sorting laundry by color and fabric type";
            label26.Text = "performing stain treatments";
            label27.Text ="and operating laundry machines";


            label28.Text = "Address";
            label29.Text = "Phone.num";
            label30.Text = "HireTime(Hour)";
            label31.Text = "Kg";
            label32.Text = "Note";
            label33.Text = "Date/ Time";

            btngroceryback.Text = "Go Back";
            btngroceryxacnhan.Text = "Confirm";


            label40.Text = "Ability to work fast";

            label41.Text = "but in an efficient and controlled manner";
            label42.Text="Ability to operate as a team member";


            label39.Text = "Address";
            label38.Text = "Phone.num";
            label37.Text = "HireTime(hour)";
            label36.Text = "Square";
            label35.Text = "Note";
            label34.Text = "Date/Time";



            btnkhukhuanback.Text = "Go Back";
            btnkhukhuanxacnhan.Text = "Confirm";

            label43.Text = "Disinfection Services for Covid - 19";
            label44.Text = "keep your friends and family safe";
            label45.Text = "Electrostatic sprayer, pump or battery sprayer";


            btnwant.Text = "Want";
            label3.Text = "Coming so soon...";
            label4.Text = "car wash";
            label5.Text = "Garden";
            label7.Text = "Pet care";
            label2.Text = "Have a nice day,Tri";
            label46.Text = "No message yet";

            label52.Text = "Name";
            label53.Text = "Phone.num";
            label54.Text = "Address";
            label47.Text = "Favorites";
            label51.Text = "Theme";

            btnprofilesback.Text = "Go Back";
            btnsetting.Text = "Setting";
            label50.Text = "Languages";
            btnsettingback.Text = "Go Back";
            radioButton_english.Text = "English";
            radioButton_tiengviet.Text = "Vietnamese";
            btndiscountnews.Text = "Discount News";
            btndiscountnewsback.Text = "Go Back";
            btnhelp.Text = "Help";
            btnhelpback.Text = "Go Back";
            btnnguoiyeuthichback.Text = "Go Back";
            btnseeprofiles.Text = "See Profiles";
            btnprofilesback.Text = "Go Back";
            






        }

        private void radioButton_tiengviet_CheckedChanged(object sender, EventArgs e)
        {

            label73.Text = "Lịch sử dịch vụ";
            label72.Text = "Loại dịch vụ ";
            label71.Text = "Địa chỉ";
            label69.Text = "Sdt";
            label70.Text = "Số giờ";
            label68.Text = "Diện tích";
            label67.Text = "Kg";
            label66.Text = "Ghi chú";
            label65.Text = "Ngày làm ";
            label58.Text = "Đã trả";
            button4.Text = "Quay về";
            ///////////////////////////////////////////////////////////////
            ///
            label56.Text = "Loại dịch vụ";
            label57.Text = "Địa chỉ";
            Sdt.Text = "Sdt";
            label59.Text = "Số giờ";
            label60.Text = "Diện tích";
            label61.Text = "Kg";

            label62.Text = "Ghi chú";
            label63.Text = "Ngày làm";
            label64.Text = "Cần trả";
            btnthanhtoan.Text = "Thanh toán";
            btnuudai.Text = "Ưu đãi";
            btndiscount20.Text = "Giảm 20";
            btndiscount50.Text = "Giảm 50";
            btnfinished_activity.Text = "Đã xong";
            View.Text = "Chi tiết";
            btnpending_acitivity.Text = "Đang làm";
            btnpnlthanhtoanback.Text = "Quay về";
            btnthanhtoan.Text = "Thanh toán";
            ////////////////////////////////////////////////////////////////
            ///
            label6.Text = "Địa chỉ";
            label8.Text = "Sdt";
            label9.Text = "Số giờ ";
            label10.Text = "Diện tích";
            label11.Text = "Ghi chú";
            label12.Text = "Ngày làm";
            btndeepcleanxacnhan.Text = "Xác nhận";
            btndeepcleanback.Text = "Quay về";



            label13.Text = "Chúng tôi sẽ loại bỏ bụi bẩn sâu";
            label14.Text = "trong ngôi nhà bạn";
            label15.Text = "Những nơi khó với tới";
            label16.Text = "Cửa sổ";
            label17.Text = "Công tắc đèn và trên kệ tủ";


            label18.Text = "Địa chỉ";
            label19.Text = "Sdt";
            label20.Text = "Số giờ";
            label21.Text = "Kg";
            label22.Text = "Ghi chú";
            label23.Text = "Ngày làm";

            btnlaundryxacnhan.Text = "Xác nhận";
            btnlaudryback.Text = "Quay về";


            label24.Text = "Chúng tôi sẽ lấy quần áo bẩn";
            label25.Text = "xếp chúng theo màu và loại vải";
            label26.Text = "xếp đồ ngăn nắp";
            label27.Text = "sử dụng thành thạo máy giặt";


            label28.Text = "Địa chỉ";
            label29.Text = "Sdt";
            label30.Text = "Số giờ";
            label31.Text = "Kg";
            label32.Text = "Ghi chú";
            label33.Text = "Ngày làm";

            btngroceryback.Text = "Quay về";
            btngroceryxacnhan.Text = "Xác nhận";


            label40.Text = "Khả năng làm việc nhanh nhẹn ";

            label41.Text = "Nhưng hiệu quả và có kiểm soát";
            label42.Text = "Có khả năng làm việc nhóm tốt";


            label39.Text = "Địa chỉ";
            label38.Text = "Sdt";
            label37.Text = "Số giờ";
            label36.Text = "Diện tích";
            label35.Text = "Ghi chú";
            label34.Text = "Ngày làm";



            btnkhukhuanback.Text = "Quay về";
            btnkhukhuanxacnhan.Text = "Xác nhận";

            label43.Text = "Khử khuẩn cho mùa Covid-19";
            label44.Text = "giữ gia đình và bạn bè bạn an toàn";
            label45.Text = "Phun điện tử và vòi phun công nghê";


            btnwant.Text = "Sử dụng";
            label3.Text = "Sắp ra mắt...";
            label4.Text = "Rửa xe";
            label5.Text = "Làm vườn";
            label7.Text = "Thú cưng";
            label2.Text = "1 ngày tốt lành,Trí";
            label46.Text = "Chưa có tin nhắn nào ";

            label52.Text = "Họ Tên";
            label53.Text = "Sdt";
            label54.Text = "Địa chỉ";
            label47.Text = "Yêu thích";
            label51.Text = "Màu sắc";

            btnprofilesback.Text = "Quay về";
            btnsetting.Text = "Cài đặt";
            label50.Text = "Ngôn ngữ";
            btnsettingback.Text = "Quay về";
            radioButton_english.Text = "Tiếng Anh";
            radioButton_tiengviet.Text = "Tiếng Việt";
            btndiscountnews.Text = "Tin Tức Khuyến mãi";
            btndiscountnewsback.Text = "Quay về";
            btnhelp.Text = "Trợ giúp";
            btnhelpback.Text = "Quay về";
            btnnguoiyeuthichback.Text = "Quay về";
            btnseeprofiles.Text = "Xem hồ sơ";
            btnprofilesback.Text = "Quay về";
            btnfavorite.Text = "Yêu thích";







        }

        private void picboxprofileinside_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog odl = new OpenFileDialog();
            if(odl.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(odl.FileName);
                picboxprofileinside.Image = image;
                picboxprofileoutside.Image = image;
                picboxprofileinside.SizeMode = PictureBoxSizeMode.Zoom;
                picboxprofileoutside.SizeMode = PictureBoxSizeMode.Zoom;
            }    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnaccount_Click(null, null);
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            btnaccount_Click(null, null);
        }

        private void btnthemexanh_Click(object sender, EventArgs e)
        {
            btntotoro.BackColor = Color.FromArgb(196, 217, 251);
            button1    .BackColor = Color.FromArgb(196,217,251);
            label2     .BackColor = Color.FromArgb(196,217,251);
            btnchuyen  .BackColor = Color.FromArgb(196,217,251);
            btnwant    .BackColor = Color.FromArgb(196,217,251);
            button5    .BackColor = Color.FromArgb(196,217,251);
            button3    .BackColor = Color.FromArgb(196,217,251);
            button2    .BackColor = Color.FromArgb(196,217,251);
            label4     .BackColor = Color.FromArgb(196,217,251);
            pictureBox4.BackColor = Color.FromArgb(196,217,251);
            label5     .BackColor = Color.FromArgb(196,217,251);
            pictureBox5.BackColor = Color.FromArgb(196,217,251);
            label7     .BackColor = Color.FromArgb(196,217,251);
            pictureBox6.BackColor = Color.FromArgb(196,217,251);
            pnlmain    .BackColor = Color.FromArgb(196,217,251);
            pnlactivity.BackColor = Color.FromArgb(196,217,251);
            pnlchat    .BackColor = Color.FromArgb(196,217,251);
            label46    .BackColor = Color.FromArgb(196,217,251);
            picbox_chat.BackColor = Color.FromArgb(196,217,251);
            pnlprofiles.BackColor = Color.LightCyan;
            picboxprofileinside.BackColor = Color.FromArgb(196, 217, 251);
            picboxprofileoutside.BackColor = Color.FromArgb(196, 217, 251);
            label52.BackColor = Color.LightCyan;
            label53.BackColor = Color.LightCyan;
            label54.BackColor = Color.LightCyan;
            label55.BackColor = Color.LightCyan;
            pnlsetting.BackColor = Color.Aqua;
            radioButton_english.BackColor = Color.Aqua;
            radioButton_tiengviet.BackColor = Color.Aqua;
            btnthemexanh.BackColor = Color.Aqua;
            label51.BackColor = Color.Aqua;
            pnldiscountnews.BackColor = Color.FromArgb(192, 255, 255);
            pnlhelp.BackColor = Color.FromArgb(255, 192, 192);
            pictureBox_help.BackColor = Color.FromArgb(255, 192, 192);
            richTextBox_help.BackColor = Color.FromArgb(255, 192, 192);
            pnlnguoiyeuthich.BackColor = Color.FromArgb(255, 224, 192);
            pnlaccount .BackColor = Color.FromArgb(196,217,251);
            pictureBox8   .BackColor = Color.FromArgb(196,217,251);
            pictureBox9  .BackColor = Color.FromArgb(196,217,251);
            picbox_chat.BackColor = Color.Khaki;
            listView_nguoiyeuthich.BackColor = Color.Orange;
            btnhome.BackColor=Color.FromArgb(196, 217, 251);
            btnactivity.BackColor = Color.FromArgb(196, 217, 251);
            btnchat.BackColor = Color.FromArgb(196, 217, 251);
            btnaccount.BackColor = Color.FromArgb(196, 217, 251);
            picbox_chat.BackColor=Color.FromArgb(196, 217, 251);

            label1.BackColor =     Color.FromArgb(196, 217, 251);
            pictureBox1.BackColor =Color.FromArgb(196, 217, 251);
            pictureBox2.BackColor =Color.FromArgb(196, 217, 251);
            pictureBox3.BackColor =Color.FromArgb(196, 217, 251);
            pictureBox7.BackColor =Color.FromArgb(196, 217, 251);
            label74.BackColor = Color.FromArgb(196, 217, 251);
        }

        private void btnthemevang_Click(object sender, EventArgs e)
        {
            btntotoro.BackColor = Color.Khaki;
            button1.BackColor = Color.Khaki;
            label2.BackColor = Color.Khaki;
            btnchuyen.BackColor = Color.Khaki;
            btnwant.BackColor = Color.Khaki;
            button5.BackColor = Color.Khaki;
            button3.BackColor = Color.Khaki;
            button2.BackColor = Color.Khaki;
            label4.BackColor = Color.Khaki;
            pictureBox4.BackColor = Color.Khaki;
            label5.BackColor = Color.Khaki;
            pictureBox5.BackColor = Color.Khaki;
            label7.BackColor = Color.Khaki;
            pictureBox6.BackColor = Color.Khaki;
            pnlmain.BackColor = Color.Khaki;
            pnlactivity.BackColor = Color.Khaki;
            pnlchat.BackColor = Color.Khaki;
            label46.BackColor = Color.Khaki;
            picbox_chat.BackColor = Color.Khaki;
            pnlprofiles.BackColor = Color.Khaki;
            picboxprofileinside.BackColor = Color.Khaki;
            picboxprofileoutside.BackColor = Color.Khaki;
            label52.BackColor = Color.Khaki;
            label53.BackColor = Color.Khaki;
            label54.BackColor = Color.Khaki;
            label55.BackColor = Color.Khaki;
            pnlsetting.BackColor = Color.Khaki;
            radioButton_english.BackColor = Color.Khaki;
            radioButton_tiengviet.BackColor = Color.Khaki;
            btnthemexanh.BackColor = Color.Khaki;
            label51.BackColor = Color.Khaki;
            pnldiscountnews.BackColor = Color.Khaki;
            pnlhelp.BackColor = Color.Khaki;
            pictureBox_help.BackColor = Color.Khaki;
            richTextBox_help.BackColor = Color.Khaki;
            pnlnguoiyeuthich.BackColor = Color.Khaki;
            pnlaccount.BackColor = Color.Khaki;
            pictureBox8.BackColor = Color.Khaki;
            pictureBox9.BackColor = Color.Khaki;
            picbox_chat.BackColor = Color.Khaki;
            listView_nguoiyeuthich.BackColor = Color.Khaki;
            btnhome.BackColor = Color.Khaki;
            btnactivity.BackColor = Color.Khaki;
            btnchat.BackColor = Color.Khaki;
            btnaccount.BackColor = Color.Khaki;

            label1.BackColor =       Color.Khaki;
            pictureBox1.BackColor =  Color.Khaki;
            pictureBox2.BackColor =  Color.Khaki;
            pictureBox3.BackColor =  Color.Khaki;
            pictureBox7.BackColor =  Color.Khaki;
            label74.BackColor =      Color.Khaki;
        }

        private void btnthemexanhla_Click(object sender, EventArgs e)
        {
            btntotoro.BackColor = Color.MediumSpringGreen;
            button1.BackColor = Color.MediumSpringGreen;
            label2.BackColor = Color.MediumSpringGreen;
            btnchuyen.BackColor = Color.MediumSpringGreen;
            btnwant.BackColor =  Color.MediumSpringGreen;
            button5.BackColor =  Color.MediumSpringGreen;
            button3.BackColor =  Color.MediumSpringGreen;
            button2.BackColor = Color.MediumSpringGreen;
            label4.BackColor = Color.MediumSpringGreen;
            pictureBox4.BackColor = Color.MediumSpringGreen;
            label5.BackColor = Color.MediumSpringGreen;
            pictureBox5.BackColor = Color.MediumSpringGreen;
            label7.BackColor = Color.MediumSpringGreen;
            pictureBox6.BackColor = Color.MediumSpringGreen;
            pnlmain.BackColor = Color.MediumSpringGreen;
            pnlactivity.BackColor = Color.MediumSpringGreen;
            pnlchat.BackColor = Color.MediumSpringGreen;
            label46.BackColor = Color.MediumSpringGreen;
            picbox_chat.BackColor =  Color.MediumSpringGreen;
            pnlprofiles.BackColor = Color.MediumSpringGreen;
            picboxprofileinside.BackColor = Color.MediumSpringGreen;
            picboxprofileoutside.BackColor =Color.MediumSpringGreen;
            label52.BackColor = Color.MediumSpringGreen;
            label53.BackColor = Color.MediumSpringGreen;
            label54.BackColor = Color.MediumSpringGreen;
            label55.BackColor = Color.MediumSpringGreen;
            pnlsetting.BackColor = Color.MediumSpringGreen;
            radioButton_english.BackColor = Color.MediumSpringGreen;
            radioButton_tiengviet.BackColor = Color.MediumSpringGreen;
            btnthemexanh.BackColor = Color.MediumSpringGreen;
            label51.BackColor = Color.MediumSpringGreen;
            pnldiscountnews.BackColor = Color.MediumSpringGreen;
            pnlhelp.BackColor = Color.MediumSpringGreen;
            pictureBox_help.BackColor =  Color.MediumSpringGreen;
            richTextBox_help.BackColor = Color.MediumSpringGreen;
            pnlnguoiyeuthich.BackColor = Color.MediumSpringGreen;
            pnlaccount.BackColor =   Color.MediumSpringGreen;
            pictureBox8.BackColor =  Color.MediumSpringGreen;
            pictureBox9.BackColor =  Color.MediumSpringGreen;
            picbox_chat.BackColor = Color.MediumSpringGreen;
            listView_nguoiyeuthich.BackColor = Color.MediumSpringGreen;
            btnhome.BackColor = Color.MediumSpringGreen;
            btnactivity.BackColor = Color.MediumSpringGreen;
            btnchat.BackColor = Color.MediumSpringGreen;
            btnaccount.BackColor = Color.MediumSpringGreen;
            label1.BackColor =     Color.MediumSpringGreen;
            pictureBox1.BackColor =Color.MediumSpringGreen;
            pictureBox2.BackColor =Color.MediumSpringGreen;
            pictureBox3.BackColor =Color.MediumSpringGreen;
            pictureBox7.BackColor =Color.MediumSpringGreen;
            label74.BackColor = Color.MediumSpringGreen;
        }

        private void btnthemehong_Click(object sender, EventArgs e)
        {
            btntotoro.BackColor = Color.LightPink;
            button1.BackColor =   Color.LightPink;
            btnchuyen.BackColor = Color.LightPink;
            btnwant.BackColor =   Color.LightPink;
            button5.BackColor =   Color.LightPink;
            button3.BackColor =   Color.LightPink;
            button2.BackColor =   Color.LightPink;
            label4.BackColor = Color.LightPink;
            pictureBox4.BackColor = Color.LightPink;
            label5.BackColor = Color.LightPink;
            pictureBox5.BackColor = Color.LightPink;
            label7.BackColor = Color.LightPink;
            pictureBox6.BackColor = Color.LightPink;
            pnlmain.BackColor = Color.LightPink;
            pnlactivity.BackColor = Color.LightPink;
            pnlchat.BackColor = Color.LightPink;
            label46.BackColor = Color.LightPink;
            picbox_chat.BackColor = Color.LightPink;
            pnlprofiles.BackColor = Color.LightPink;
            picboxprofileinside.BackColor = Color.LightPink;
            picboxprofileoutside.BackColor = Color.LightPink;
            label52.BackColor =Color.LightPink;
            label53.BackColor =Color.LightPink;
            label54.BackColor =Color.LightPink;
            label55.BackColor = Color.LightPink;
            pnlsetting.BackColor = Color.LightPink;
            radioButton_english.BackColor = Color.LightPink;
            radioButton_tiengviet.BackColor = Color.LightPink;
            btnthemexanh.BackColor = Color.LightPink;
            label51.BackColor = Color.LightPink;
            pnldiscountnews.BackColor = Color.LightPink;
            pnlhelp.BackColor = Color.LightPink;
            pictureBox_help.BackColor = Color.LightPink;
            richTextBox_help.BackColor =Color.LightPink;
            pnlnguoiyeuthich.BackColor = Color.LightPink;
            pnlaccount.BackColor = Color.LightPink;
            pictureBox8.BackColor =Color.LightPink;
            pictureBox9.BackColor =Color.LightPink;
            picbox_chat.BackColor = Color.LightPink;
            listView_nguoiyeuthich.BackColor = Color.LightPink;
            btnhome.BackColor = Color.LightPink;
            btnactivity.BackColor = Color.LightPink;
            btnchat.BackColor = Color.LightPink;
            btnaccount.BackColor = Color.LightPink;
            label2.BackColor=Color.LightPink;
            label1.BackColor = Color.LightPink;
            pictureBox1.BackColor = Color.LightPink;
            pictureBox2.BackColor = Color.LightPink;
            pictureBox3.BackColor = Color.LightPink;
            pictureBox7.BackColor = Color.LightPink;
            label74.BackColor = Color.LightPink;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            

            dataGridView1.Rows.RemoveAt(indexx);
            listView_pendingactivity.Items[indexx].Remove();
            pnlhistory.Visible = false;
            pnlthanhtoan.Visible = false;


        }

        private void btnfinished_activity_Click(object sender, EventArgs e)
        {
            pnlfinished.Visible = true;
            pnlpendingactivity.Visible = false;
            pnlview.Visible = false;
          

        }
        private void btnpnlthanhtoanback_Click(object sender, EventArgs e)
        {
            pnlthanhtoan.Visible = false;
          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pnlhistory.Visible = false;
            pnlthanhtoan.Visible = false;
            dataGridView1.Rows.RemoveAt(indexx);
            listView_pendingactivity.Items[indexx].Remove();
            
          

        }


    }
}
