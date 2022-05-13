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
    public partial class isverengiris : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader oku;
        Boolean yenikayitmi;
        public isverengiris()
        {
            InitializeComponent();
        }

        private void yeni_Click(object sender, EventArgs e)
        {
            yeniisveren isveren = new yeniisveren();
            this.Hide();
            isveren.Show();
           
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (ka.Text == "" && sf.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Ve Şifre Girin");
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from hesapbilgi where kullanıcı_ad='" + ka.Text + "'and sifre='" + sf.Text + "'";
                oku = cmd.ExecuteReader();
                if (oku.Read())
                {
                    isverensayfası isf = new isverensayfası();                  
                    this.Hide();
                    isf.Show();
                    
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Ve Şifre");
                }
                con.Close();
            }
            
        }
    }
}
