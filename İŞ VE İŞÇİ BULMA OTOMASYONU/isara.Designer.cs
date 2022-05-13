namespace İŞ_VE_İŞÇİ_BULMA_OTOMASYONU
{
    partial class isara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isara));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.basvur = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbcalısma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbpozisyon = new System.Windows.Forms.ComboBox();
            this.cbsektör = new System.Windows.Forms.ComboBox();
            this.cbegitim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.istanım = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // basvur
            // 
            this.basvur.Location = new System.Drawing.Point(460, 161);
            this.basvur.Name = "basvur";
            this.basvur.Size = new System.Drawing.Size(122, 36);
            this.basvur.TabIndex = 2;
            this.basvur.Text = "BAŞVUR";
            this.basvur.UseVisualStyleBackColor = true;
            this.basvur.Click += new System.EventHandler(this.basvur_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Location = new System.Drawing.Point(579, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // cbcalısma
            // 
            this.cbcalısma.FormattingEnabled = true;
            this.cbcalısma.Location = new System.Drawing.Point(185, 170);
            this.cbcalısma.Name = "cbcalısma";
            this.cbcalısma.Size = new System.Drawing.Size(100, 21);
            this.cbcalısma.TabIndex = 113;
            this.cbcalısma.SelectedIndexChanged += new System.EventHandler(this.cbcalısma_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 112;
            this.label3.Text = "ÇALIŞMA ŞEKLİ";
            // 
            // cbpozisyon
            // 
            this.cbpozisyon.FormattingEnabled = true;
            this.cbpozisyon.Location = new System.Drawing.Point(185, 143);
            this.cbpozisyon.Name = "cbpozisyon";
            this.cbpozisyon.Size = new System.Drawing.Size(100, 21);
            this.cbpozisyon.TabIndex = 109;
            this.cbpozisyon.SelectedIndexChanged += new System.EventHandler(this.cbpozisyon_SelectedIndexChanged);
            // 
            // cbsektör
            // 
            this.cbsektör.FormattingEnabled = true;
            this.cbsektör.Location = new System.Drawing.Point(185, 107);
            this.cbsektör.Name = "cbsektör";
            this.cbsektör.Size = new System.Drawing.Size(100, 21);
            this.cbsektör.TabIndex = 106;
            this.cbsektör.SelectedIndexChanged += new System.EventHandler(this.cbsektör_SelectedIndexChanged);
            // 
            // cbegitim
            // 
            this.cbegitim.FormattingEnabled = true;
            this.cbegitim.Location = new System.Drawing.Point(185, 68);
            this.cbegitim.Name = "cbegitim";
            this.cbegitim.Size = new System.Drawing.Size(100, 21);
            this.cbegitim.TabIndex = 100;
            this.cbegitim.SelectedIndexChanged += new System.EventHandler(this.cbegitim_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 102;
            this.label7.Text = "EĞİTİM DURUMU:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 14);
            this.label9.TabIndex = 103;
            this.label9.Text = "POZİSYON:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 101;
            this.label8.Text = "SEKTÖR:";
            // 
            // istanım
            // 
            this.istanım.Location = new System.Drawing.Point(185, 32);
            this.istanım.Name = "istanım";
            this.istanım.Size = new System.Drawing.Size(100, 20);
            this.istanım.TabIndex = 114;
            this.istanım.TextChanged += new System.EventHandler(this.istanım_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 115;
            this.label10.Text = "İŞ TANIIMI:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(522, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 116;
            this.textBox1.Visible = false;
            // 
            // isara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 452);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.istanım);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbcalısma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbpozisyon);
            this.Controls.Add(this.cbsektör);
            this.Controls.Add(this.cbegitim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.basvur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "isara";
            this.Text = "isara";
            this.Load += new System.EventHandler(this.isara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button basvur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbcalısma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbpozisyon;
        private System.Windows.Forms.ComboBox cbsektör;
        private System.Windows.Forms.ComboBox cbegitim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox istanım;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}