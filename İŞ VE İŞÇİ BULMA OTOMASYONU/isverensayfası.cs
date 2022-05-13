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
    public partial class isverensayfası : Form
    {
        public isverensayfası()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(" Çıkmak istedğinize emin misiniz ? ", "ÇIKIŞ", MessageBoxButtons.OKCancel);
            if (cevap == DialogResult.OK)
            {
                isverengiris giris = new isverengiris();
                this.Hide();
                giris.ShowDialog();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sirketbilgi sirket = new sirketbilgi();
            this.Hide();
            sirket.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            basvurular basvuru = new basvurular();
            this.Hide();
            basvuru.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ilanolustur ilan = new ilanolustur();
            this.Hide();
            ilan.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            isverenhesap hesap = new isverenhesap();
            this.Hide();
            hesap.ShowDialog();
            this.Show();
        }
    }
}
