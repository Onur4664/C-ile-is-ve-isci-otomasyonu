using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İŞ_VE_İŞÇİ_BULMA_OTOMASYONU
{
    public partial class iscisayfa : Form
    {
        public iscisayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(" Çıkmak istedğinize emin misiniz ? ", "ÇIKIŞ", MessageBoxButtons.OKCancel);
            if (cevap == DialogResult.OK)
            {
                iscigiris giris = new iscigiris();
                this.Hide();
                giris.ShowDialog();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            iscihesap hesap = new iscihesap();
            this.Hide();
            hesap.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            isara isara = new isara();
            this.Hide();
            isara.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            yapılanbasvuru basvurular = new yapılanbasvuru();
            this.Hide();
            basvurular.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            özgecmis özgecmis = new özgecmis();
            this.Hide();
            özgecmis.ShowDialog();
            this.Show();
        }
    }
}
