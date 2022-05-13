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
    public partial class GİRİŞ : Form
    {
        public GİRİŞ()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            iscigiris iscigiris = new iscigiris();
            this.Hide();
            iscigiris.Show();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isverengiris isverengiris = new isverengiris();
            this.Hide();
            isverengiris.Show();
            

        }
    }
}
