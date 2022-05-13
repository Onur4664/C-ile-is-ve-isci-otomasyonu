namespace İŞ_VE_İŞÇİ_BULMA_OTOMASYONU
{
    partial class isverengiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isverengiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sf = new System.Windows.Forms.TextBox();
            this.ka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yeni = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // sf
            // 
            this.sf.Location = new System.Drawing.Point(162, 146);
            this.sf.Name = "sf";
            this.sf.Size = new System.Drawing.Size(134, 20);
            this.sf.TabIndex = 8;
            this.sf.UseSystemPasswordChar = true;
            // 
            // ka
            // 
            this.ka.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ka.Location = new System.Drawing.Point(162, 100);
            this.ka.Name = "ka";
            this.ka.Size = new System.Drawing.Size(134, 20);
            this.ka.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // yeni
            // 
            this.yeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yeni.BackgroundImage")));
            this.yeni.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeni.ForeColor = System.Drawing.Color.DarkRed;
            this.yeni.Location = new System.Drawing.Point(254, 225);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(75, 34);
            this.yeni.TabIndex = 4;
            this.yeni.Text = "Kayıt";
            this.yeni.UseVisualStyleBackColor = true;
            this.yeni.Click += new System.EventHandler(this.yeni_Click);
            // 
            // giris
            // 
            this.giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giris.BackgroundImage")));
            this.giris.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris.ForeColor = System.Drawing.Color.DarkRed;
            this.giris.Location = new System.Drawing.Point(184, 187);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(145, 32);
            this.giris.TabIndex = 5;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // isverengiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sf);
            this.Controls.Add(this.ka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yeni);
            this.Controls.Add(this.giris);
            this.Name = "isverengiris";
            this.Text = "isverengiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yeni;
        private System.Windows.Forms.Button giris;
        public System.Windows.Forms.TextBox ka;
    }
}