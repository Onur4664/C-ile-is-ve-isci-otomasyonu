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
    public partial class yeniisci : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        Boolean yenikayitmi;
        SqlDataReader oku;
        int tutindex;


        public yeniisci()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into arayanhesap(ad,soyad,kullanici_adi,sifre,mail) Values(@ad,@soyad,@kullanıcı_ad,@sifre,@mail)";
            cmd.Parameters.AddWithValue("ad", adı.Text);
            cmd.Parameters.AddWithValue("soyad", soyadı.Text);
            cmd.Parameters.AddWithValue("kullanıcı_ad", kullanıcıadı.Text);
            cmd.Parameters.AddWithValue("sifre", sifresi.Text);
            cmd.Parameters.AddWithValue("mail", mail.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yeni Kayıt Eklendi");
            iscigiris giris = new iscigiris();
            this.Hide();
            giris.Show();
            verileri_cek();
            
        }
        void verileri_cek()
        {
            ds.Clear();
            string seckomutu = "select * from arayanhesap";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "arayanhesap");
        }
    }
}
