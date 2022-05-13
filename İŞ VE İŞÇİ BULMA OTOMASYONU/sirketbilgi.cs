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
    public partial class sirketbilgi : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        void verileri_cek()
        {

            ds.Clear();
            string seckomutu = "select * from şirket_bilgi";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "şirket_bilgi");
            bs.DataSource = ds.Tables["şirket_bilgi"];
            dataGridView1.DataSource = bs;
            con.Close();
        }
        public sirketbilgi()
        {
            InitializeComponent();
        }
        void sektor()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from sektor";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sektor_ad"]);
            }
            con.Close();
        }
        private void güncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void sirketbilgi_Load(object sender, EventArgs e)
        {
            sektor();
            if (con.State == ConnectionState.Closed) con.Open();
            verileri_cek();
            textBox1.DataBindings.Add("Text", bs, "sirket_id");
            kullanıcıadı.DataBindings.Add("Text", bs, "kullanıcı_ad");
            adı.DataBindings.Add("Text", bs, "sirket_adı");
            tel.DataBindings.Add("Text", bs, "tel");
            adres.DataBindings.Add("Text", bs, "adres");
            comboBox1.DataBindings.Add("Text", bs, "sektor_ad");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult c = MessageBox.Show("Silmek istediğinize emin misiniz ?", "uyarı", MessageBoxButtons.OKCancel);
            if (c == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.CommandText = "delete from şirket_bilgi where sirket_id=@sirket_id";
                cmd.Parameters.AddWithValue("sirket_id", deger);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kaydınız başarıyla silindi");
                verileri_cek();             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            if (kullanıcıadı.Text == "" & adı.Text == "" & tel.Text == "" & adres.Text == "" & comboBox1.Text == "" )
            {
                MessageBox.Show("lütfen tüm verileri giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into şirket_bilgi(kullanıcı_ad,sirket_adı,tel,adres,sektor_ad) Values(@kullanıcı_ad,@sirket_adı,@tel,@adres,@sektor_ad)";
                cmd.Parameters.AddWithValue("@kullanıcı_ad", kullanıcıadı.Text);
                cmd.Parameters.AddWithValue("@sirket_adı", adı.Text);
                cmd.Parameters.AddWithValue("@tel", tel.Text);
                cmd.Parameters.AddWithValue("@adres", adres.Text);
                cmd.Parameters.AddWithValue("@sektor_ad", comboBox1.Text);
                MessageBox.Show("İşleminiz Tamalanmıştır");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Şirket Bilgisi Eklendi");
                verileri_cek();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from şirket_bilgi where sirket_id=" + textBox1.Text + "";
            cmd.CommandText = "update şirket_bilgi set kullanıcı_ad=@kullanıcı_ad,sirket_adı=@sirket_adı,tel=@tel,adres=@adres,sektor_ad=@sektor_ad where sirket_id="+textBox1.Text+"";        
            cmd.Parameters.AddWithValue("@kullanıcı_ad", kullanıcıadı.Text);
            cmd.Parameters.AddWithValue("@sirket_adı", adı.Text);
            cmd.Parameters.AddWithValue("@tel", tel.Text);
            cmd.Parameters.AddWithValue("@adres", adres.Text);
            cmd.Parameters.AddWithValue("@sektor_ad", comboBox1.Text);
            MessageBox.Show("İşleminiz Tamalanmıştır");
            cmd.ExecuteNonQuery();
            verileri_cek();
        }
    }
}
