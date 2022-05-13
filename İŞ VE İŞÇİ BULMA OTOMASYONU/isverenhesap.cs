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
    public partial class isverenhesap : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        Boolean yenikayitmi;
        SqlDataReader oku;
        public isverenhesap()
        {
            InitializeComponent();
        }

        private void güncelleme_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select kullanıcı_ad from hesapbilgi where hesapid='" + textBox1.Text + "'";
            cmd.CommandText = "update hesapbilgi set kullanıcı_ad=@kullanıcı_ad,ad=@ad,soyad=@soyad,mail=@mail,sifre=@sifre where hesapid="+textBox1.Text+"";
            cmd.Parameters.AddWithValue("@kullanıcı_ad", kullanıcıadı.Text);
            cmd.Parameters.AddWithValue("@ad", adı.Text);
            cmd.Parameters.AddWithValue("@soyad", soyadı.Text);
            cmd.Parameters.AddWithValue("@mail", mail.Text);
            cmd.Parameters.AddWithValue("@sifre", sifresi.Text);
            MessageBox.Show("İşleminiz Tamalanmıştır");
            cmd.ExecuteNonQuery();
            verileri_cek();
        }
        void verileri_cek()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            ds.Clear();
            string seckomutu = "select * from hesapbilgi";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "hesapbilgi");
            bs.DataSource = ds.Tables["hesapbilgi"];
            dataGridView1.DataSource = bs;
            con.Close();
        }

        private void isverenhesap_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verileri_cek();
            textBox1.DataBindings.Add("Text", bs, "hesapid");
            kullanıcıadı.DataBindings.Add("Text", bs, "kullanıcı_ad");
            adı.DataBindings.Add("Text", bs, "ad");
            soyadı.DataBindings.Add("Text", bs, "soyad");
            mail.DataBindings.Add("Text", bs, "mail");
            sifresi.DataBindings.Add("Text", bs, "sifre");
            yenikayitmi = false;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult c = MessageBox.Show("Silmek istediğinize emin misiniz ?", "uyarı", MessageBoxButtons.OKCancel);
            if ( c == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.CommandText = "delete from hesapbilgi where hesapid=@hesapid";
                cmd.Parameters.AddWithValue("hesapid", deger);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kaydınız başarıyla silindi");
                verileri_cek();
            }
        }
        
    }
}
