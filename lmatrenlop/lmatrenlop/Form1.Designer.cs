
namespace lmatrenlop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnloadanhnen = new System.Windows.Forms.Button();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxoasach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmauve = new System.Windows.Forms.Button();
            this.radioButton_elipse = new System.Windows.Forms.RadioButton();
            this.radioButton_hinhchunhat = new System.Windows.Forms.RadioButton();
            this.radioButton_duongthang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picboxprofileinside = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxprofileinside)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnxoasach);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(860, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnloadanhnen);
            this.groupBox2.Controls.Add(this.textBox_y);
            this.groupBox2.Controls.Add(this.textBox_x);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh ";
            // 
            // btnloadanhnen
            // 
            this.btnloadanhnen.Location = new System.Drawing.Point(44, 164);
            this.btnloadanhnen.Name = "btnloadanhnen";
            this.btnloadanhnen.Size = new System.Drawing.Size(178, 23);
            this.btnloadanhnen.TabIndex = 3;
            this.btnloadanhnen.Text = "Chọn ảnh nền ";
            this.btnloadanhnen.UseVisualStyleBackColor = true;
            this.btnloadanhnen.Click += new System.EventHandler(this.btnloadanhnen_Click);
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(122, 86);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(123, 24);
            this.textBox_y.TabIndex = 2;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(122, 41);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(123, 24);
            this.textBox_x.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vị trí ảnh X,Y";
            // 
            // btnxoasach
            // 
            this.btnxoasach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnxoasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoasach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoasach.Location = new System.Drawing.Point(31, 234);
            this.btnxoasach.Name = "btnxoasach";
            this.btnxoasach.Size = new System.Drawing.Size(221, 49);
            this.btnxoasach.TabIndex = 1;
            this.btnxoasach.Text = "Xóa sạch";
            this.btnxoasach.UseVisualStyleBackColor = false;
            this.btnxoasach.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnmauve);
            this.panel1.Controls.Add(this.radioButton_elipse);
            this.panel1.Controls.Add(this.radioButton_hinhchunhat);
            this.panel1.Controls.Add(this.radioButton_duongthang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 209);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnmauve
            // 
            this.btnmauve.BackColor = System.Drawing.Color.Black;
            this.btnmauve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmauve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnmauve.Location = new System.Drawing.Point(52, 150);
            this.btnmauve.Name = "btnmauve";
            this.btnmauve.Size = new System.Drawing.Size(170, 47);
            this.btnmauve.TabIndex = 4;
            this.btnmauve.Text = "Màu vẽ ";
            this.btnmauve.UseVisualStyleBackColor = false;
            this.btnmauve.Click += new System.EventHandler(this.btnmauve_Click);
            // 
            // radioButton_elipse
            // 
            this.radioButton_elipse.AutoSize = true;
            this.radioButton_elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radioButton_elipse.Location = new System.Drawing.Point(6, 106);
            this.radioButton_elipse.Name = "radioButton_elipse";
            this.radioButton_elipse.Size = new System.Drawing.Size(121, 22);
            this.radioButton_elipse.TabIndex = 3;
            this.radioButton_elipse.TabStop = true;
            this.radioButton_elipse.Text = "Vẽ Hình Elipse";
            this.radioButton_elipse.UseVisualStyleBackColor = true;
            // 
            // radioButton_hinhchunhat
            // 
            this.radioButton_hinhchunhat.AutoSize = true;
            this.radioButton_hinhchunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radioButton_hinhchunhat.Location = new System.Drawing.Point(6, 68);
            this.radioButton_hinhchunhat.Name = "radioButton_hinhchunhat";
            this.radioButton_hinhchunhat.Size = new System.Drawing.Size(138, 22);
            this.radioButton_hinhchunhat.TabIndex = 2;
            this.radioButton_hinhchunhat.TabStop = true;
            this.radioButton_hinhchunhat.Text = "Vẽ hình chữ nhật ";
            this.radioButton_hinhchunhat.UseVisualStyleBackColor = true;
            // 
            // radioButton_duongthang
            // 
            this.radioButton_duongthang.AutoSize = true;
            this.radioButton_duongthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radioButton_duongthang.Location = new System.Drawing.Point(6, 30);
            this.radioButton_duongthang.Name = "radioButton_duongthang";
            this.radioButton_duongthang.Size = new System.Drawing.Size(132, 22);
            this.radioButton_duongthang.TabIndex = 1;
            this.radioButton_duongthang.TabStop = true;
            this.radioButton_duongthang.Text = "Vẽ đường thẳng ";
            this.radioButton_duongthang.UseVisualStyleBackColor = true;
            this.radioButton_duongthang.CheckedChanged += new System.EventHandler(this.radioButton_duongthang_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình vẽ ";
            // 
            // picboxprofileinside
            // 
            this.picboxprofileinside.BackColor = System.Drawing.SystemColors.Control;
            this.picboxprofileinside.Location = new System.Drawing.Point(12, 57);
            this.picboxprofileinside.Name = "picboxprofileinside";
            this.picboxprofileinside.Size = new System.Drawing.Size(209, 195);
            this.picboxprofileinside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxprofileinside.TabIndex = 1;
            this.picboxprofileinside.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 533);
            this.Controls.Add(this.picboxprofileinside);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxprofileinside)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmauve;
        private System.Windows.Forms.RadioButton radioButton_elipse;
        private System.Windows.Forms.RadioButton radioButton_hinhchunhat;
        private System.Windows.Forms.RadioButton radioButton_duongthang;
        private System.Windows.Forms.Button btnxoasach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnloadanhnen;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picboxprofileinside;
    }
}

