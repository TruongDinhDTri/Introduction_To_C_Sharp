
namespace ductrishopnew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmen = new System.Windows.Forms.Button();
            this.pnlmen = new System.Windows.Forms.Panel();
            this.btnmennewestsneaker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlmen.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnmen
            // 
            this.btnmen.BackColor = System.Drawing.Color.Transparent;
            this.btnmen.FlatAppearance.BorderSize = 0;
            this.btnmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnmen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmen.Location = new System.Drawing.Point(635, 12);
            this.btnmen.Name = "btnmen";
            this.btnmen.Size = new System.Drawing.Size(75, 39);
            this.btnmen.TabIndex = 1;
            this.btnmen.Text = "MEN";
            this.btnmen.UseVisualStyleBackColor = false;
            this.btnmen.Click += new System.EventHandler(this.btnmen_Click);
            // 
            // pnlmen
            // 
            this.pnlmen.Controls.Add(this.btnmennewestsneaker);
            this.pnlmen.Location = new System.Drawing.Point(543, 50);
            this.pnlmen.Name = "pnlmen";
            this.pnlmen.Size = new System.Drawing.Size(281, 74);
            this.pnlmen.TabIndex = 2;
            this.pnlmen.Visible = false;
            // 
            // btnmennewestsneaker
            // 
            this.btnmennewestsneaker.Location = new System.Drawing.Point(22, 7);
            this.btnmennewestsneaker.Name = "btnmennewestsneaker";
            this.btnmennewestsneaker.Size = new System.Drawing.Size(106, 23);
            this.btnmennewestsneaker.TabIndex = 0;
            this.btnmennewestsneaker.Text = "Newest Sneaker";
            this.btnmennewestsneaker.UseVisualStyleBackColor = true;
            this.btnmennewestsneaker.Click += new System.EventHandler(this.btnmennewestsneaker_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-2, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 560);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 293);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 553);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1211, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlmen);
            this.Controls.Add(this.btnmen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlmen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmen;
        private System.Windows.Forms.Panel pnlmen;
        private System.Windows.Forms.Button btnmennewestsneaker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

