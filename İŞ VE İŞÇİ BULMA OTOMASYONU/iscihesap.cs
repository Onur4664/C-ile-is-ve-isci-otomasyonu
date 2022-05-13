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
    public partial class iscihesap : Form
    {
        public iscihesap()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();


        private void iscihesap_Load(object sender, EventArgs e)
        {
            kullanıcıadı.Focus();
            if (con.State == ConnectionState.Closed) con.Open();
            verileri_cek();
            textBox1.DataBindings.Add("Text", bs, "arayan_id");
            kullanıcıadı.DataBindings.Add("Text", bs, "kullanici_adi");
            adı.DataBindings.Add("Text", bs, "ad");
            soyadı.DataBindings.Add("Text", bs, "soyad");
            mail.DataBindings.Add("Text", bs, "mail");
            sifresi.DataBindings.Add("Text", bs, "sifre");
        }
        void verileri_cek()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            ds.Clear();
            string seckomutu = "select * from arayanhesap";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "arayanhesap");
            bs.DataSource = ds.Tables["arayanhesap"];
            dataGridView1.DataSource = bs;
            con.Close();
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
                cmd.CommandText = "delete from arayanhesap where arayan_id=@arayan_id";
                cmd.Parameters.AddWithValue("arayan_id", deger);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kaydınız başarıyla silindi");
                verileri_cek();
            }
        }

        private void güncelleme_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select kullanici_adi from arayanhesap where ayaran_id='" + textBox1.Text + "'";
            cmd.CommandText = "update arayanhesap set kullanici_adi=@kullanici_adi,ad=@ad,soyad=@soyad,mail=@mail,sifre=@sifre where kullanici_adi=@kullanici_adi";
            cmd.Parameters.AddWithValue("@kullanici_adi", kullanıcıadı.Text);
            cmd.Parameters.AddWithValue("@ad", adı.Text);
            cmd.Parameters.AddWithValue("@soyad", soyadı.Text);
            cmd.Parameters.AddWithValue("@mail", mail.Text);
            cmd.Parameters.AddWithValue("@sifre", sifresi.Text);
            MessageBox.Show("İşleminiz Tamalanmıştır");
            cmd.ExecuteNonQuery();
            verileri_cek();
        }
    }
}
