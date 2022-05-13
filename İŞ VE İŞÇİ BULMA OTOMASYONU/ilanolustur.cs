using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İŞ_VE_İŞÇİ_BULMA_OTOMASYONU
{
    public partial class ilanolustur : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        void egitim()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from egitim";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbegitim.Items.Add(dr["egitim_durumu"]);
            }
            con.Close();
        }
        void sektor()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from sektor";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbsektör.Items.Add(dr["sektor_ad"]);
            }
            con.Close();
        }
        void pozisyon()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from pozisyon";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbpozisyon.Items.Add(dr["pozisyon_ad"]);
            }
            con.Close();
        }
        void calışma()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from calısma";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbcalısma.Items.Add(dr["calısma_sekli"]);
            }
            con.Close();
        }
        void verileri_cek()
        {

            ds.Clear();
            string seckomutu = "select * from ilan_ver";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "ilan_ver");
            bs.DataSource = ds.Tables["ilan_ver"];
            dataGridView1.DataSource = bs;
            con.Close();
        }
        public ilanolustur()
        {
            InitializeComponent();

        }

        private void ilanolustur_Load(object sender, EventArgs e)
        {
            egitim();
            sektor();
            calışma();
            pozisyon();
            if (con.State == ConnectionState.Closed) con.Open();
            verileri_cek();
            textBox1.DataBindings.Add("Text", bs, "isveren_id");
            adı.DataBindings.Add("Text", bs, "sirket_ad");
            istanım.DataBindings.Add("Text", bs, "istanım");
            cbsektör.DataBindings.Add("Text", bs, "sektor_ad");
            cbpozisyon.DataBindings.Add("Text", bs, "pozisyon_sekli");
            cbcalısma.DataBindings.Add("Text", bs, "calısma_sekli");
            
        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult c = MessageBox.Show("Silmek istediğinize emin misiniz ?", "uyarı", MessageBoxButtons.OKCancel);
            if (c == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.CommandText = "delete from ilan_ver where isveren_id=@isveren_id";
                cmd.Parameters.AddWithValue("isveren_id", deger);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kaydınız başarıyla silindi");
                verileri_cek();
                cbegitim.Text = "";
            }

        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandText = "select * from ilan_ver where isveren_id=" + textBox1.Text + "";
             cmd.CommandText = "update ilan_ver set sirket_ad=@sirket_ad,istanım=@istanım,egitim_durumu=@egitim_durumu,sektor_ad=@sektor_ad,calısma_sekli=@calısma_sekli,pozisyon_sekli=@pozisyon_sekli,basvuru_durumu=@basvuru_durumu where isveren_id="+textBox1.Text+"";
             cmd.Parameters.AddWithValue("@sirket_ad", adı.Text);
             cmd.Parameters.AddWithValue("@istanım", istanım.Text);
             cmd.Parameters.AddWithValue("@egitim_durumu", cbegitim.Text);
             cmd.Parameters.AddWithValue("@sektor_ad", cbsektör.Text);
             cmd.Parameters.AddWithValue("@calısma_sekli", cbcalısma.Text);
             cmd.Parameters.AddWithValue("@pozisyon_sekli", cbpozisyon.Text);
             cmd.Parameters.AddWithValue("@basvuru_durumu", textBox2.Text);
             MessageBox.Show("İşleminiz Tamalanmıştır");
             cmd.ExecuteNonQuery();
             verileri_cek();

         
        }

        private void ilanver_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            if (adı.Text == "" & istanım.Text == "" & cbpozisyon.Text == "" & cbsektör.Text == "" & cbegitim.Text == "" & cbcalısma.Text == "" )
            {
                MessageBox.Show("lütfen tüm verileri giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into ilan_ver(sirket_ad,istanım,egitim_durumu,sektor_ad,calısma_sekli,pozisyon_sekli,basvuru_durumu) Values(@sirket_ad,@istanım,@egitim_durumu,@sektor_ad,@calısma_sekli,@pozisyon_sekli,@basvuru_durumu)";
                cmd.Parameters.AddWithValue("@sirket_ad", adı.Text);
                cmd.Parameters.AddWithValue("@istanım", istanım.Text);
                cmd.Parameters.AddWithValue("@egitim_durumu", cbegitim.Text);
                cmd.Parameters.AddWithValue("@sektor_ad", cbsektör.Text);
                cmd.Parameters.AddWithValue("@calısma_sekli", cbcalısma.Text);
                cmd.Parameters.AddWithValue("@pozisyon_sekli", cbpozisyon.Text);
                cmd.Parameters.AddWithValue("@basvuru_durumu", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni İlan Eklendi");
                verileri_cek();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
