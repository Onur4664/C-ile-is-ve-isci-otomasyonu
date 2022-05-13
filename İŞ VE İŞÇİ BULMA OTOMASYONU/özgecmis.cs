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
    public partial class özgecmis : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();  
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        public özgecmis()
        {
            InitializeComponent();
        }
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

        private void özgecmis_Load(object sender, EventArgs e)
        {
            egitim();
            if (con.State == ConnectionState.Closed) con.Open();            
            verileri_cek();         
            adı.DataBindings.Add("Text", bs, "ad");
            tel.DataBindings.Add("Text", bs, "tel");
            soyadı.DataBindings.Add("Text", bs, "soyad");
            acıklama.DataBindings.Add("Text", bs, "acıklama");
            hobi.DataBindings.Add("Text", bs, "hobi");
            deneyim.DataBindings.Add("Text", bs, "deneyim");
            adres.DataBindings.Add("Text", bs, "adres");
            cbegitim.DataBindings.Add("Text", bs, "egitim_durumu");
            tel.Focus();
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            yeniegitimd egitim = new yeniegitimd();
            egitim.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult c = MessageBox.Show("Silmek istediğinize emin misiniz ?", "uyarı", MessageBoxButtons.OKCancel);
            if (c == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.CommandText = "delete from özgecmiş1 where ozgecmis_id=@ozgecmis_id";
                cmd.Parameters.AddWithValue("ozgecmis_id", deger);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kaydınız başarıyla silindi");
                verileri_cek();
            }

        }
        void verileri_cek()
        {
           
            ds.Clear();
            string seckomutu = "select * from özgecmiş1";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "özgecmiş1");
            bs.DataSource = ds.Tables["özgecmiş1"];
            dataGridView1.DataSource = bs;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            if (adı.Text == "" & soyadı.Text == "" & tel.Text == "" & adres.Text == "" & cbegitim.Text == "" & deneyim.Text == "" & hobi.Text == "" & acıklama.Text == "")
            {
                MessageBox.Show("lütfen tüm verileri giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into özgecmiş1(ad,soyad,egitim_durumu,tel,acıklama,deneyim,adres,hobi) Values(@ad,@soyad,@egitim_durumu,@tel,@acıklama,@deneyim,@adres,@hobi)";
                cmd.Parameters.AddWithValue("@ad", adı.Text);
                cmd.Parameters.AddWithValue("@soyad", soyadı.Text);
                cmd.Parameters.AddWithValue("@egitim_durumu", cbegitim.Text);
                cmd.Parameters.AddWithValue("@tel", tel.Text);
                cmd.Parameters.AddWithValue("@acıklama", acıklama.Text);
                cmd.Parameters.AddWithValue("@deneyim", deneyim.Text);
                cmd.Parameters.AddWithValue("@adres", adres.Text);
                cmd.Parameters.AddWithValue("@hobi", hobi.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Ögrenci Eklendi");
                verileri_cek();
            }
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select ad from özgecmiş1 where ozgecmis_id='" + textBox2.Text + "'";
            cmd.CommandText = "update özgecmiş1 set ad=@ad,soyad=@soyad,egitim_durumu=@egitim_durumu,tel=@tel,acıklama=@acıklama,deneyim=@deneyim,adres=@adres,hobi=@hobi where ad=@ad";
            cmd.Parameters.AddWithValue("@ad", adı.Text);
            cmd.Parameters.AddWithValue("@soyad", soyadı.Text);
            cmd.Parameters.AddWithValue("@egitim_durumu", cbegitim.Text);
            cmd.Parameters.AddWithValue("@tel", tel.Text);
            cmd.Parameters.AddWithValue("@acıklama", acıklama.Text);
            cmd.Parameters.AddWithValue("@deneyim", deneyim.Text);
            cmd.Parameters.AddWithValue("@adres", adres.Text);
            cmd.Parameters.AddWithValue("@hobi", hobi.Text);
            cmd.Parameters.AddWithValue("@ozgecmis_id", textBox2.Text);
            MessageBox.Show("İşleminiz Tamalanmıştır");
            cmd.ExecuteNonQuery();
            verileri_cek();
        }
    }
}
