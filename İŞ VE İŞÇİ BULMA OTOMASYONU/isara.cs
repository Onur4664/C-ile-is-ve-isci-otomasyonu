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
    public partial class isara : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        public isara()
        {
            InitializeComponent();
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
        private void ara_Click(object sender, EventArgs e)
        {

        }

        private void isara_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verileri_cek();
            textBox1.DataBindings.Add("Text", bs, "isveren_id");
            verileri_cek();
            egitim();
            sektor();
            calışma();
            pozisyon();
        }

        private void istanım_TextChanged(object sender, EventArgs e)
        {
            string sec = "select*from ilan_ver where istanım like '" + istanım.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ilan_ver");
            if ( istanım.Text.Count()==0)
            {
                cbegitim.Enabled = cbpozisyon.Enabled = cbsektör.Enabled = cbcalısma.Enabled = true;
            }
            else
            {
                cbegitim.Enabled = cbpozisyon.Enabled = cbsektör.Enabled = cbcalısma.Enabled = true;
            }
        }

        private void cbegitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = "select*from ilan_ver where egitim_durumu like '" + cbegitim.Text+ "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ilan_ver");
            if (istanım.Text.Count() == 0)
            {
                istanım.Enabled = cbpozisyon.Enabled = cbsektör.Enabled = cbcalısma.Enabled = true;
            }
            else
            {
                istanım.Enabled = cbpozisyon.Enabled = cbsektör.Enabled = cbcalısma.Enabled = true;
            }
        }

        private void cbsektör_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = "select*from ilan_ver where sektor_ad like '" + cbsektör.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ilan_ver");
            if (istanım.Text.Count() == 0)
            {
                istanım.Enabled = cbpozisyon.Enabled = cbegitim.Enabled = cbcalısma.Enabled = true;
            }
            else
            {
                istanım.Enabled = cbpozisyon.Enabled = cbegitim.Enabled = cbcalısma.Enabled = true;
            }
        }

        private void cbpozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = "select*from ilan_ver where pozisyon_sekli like '" + cbpozisyon.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ilan_ver");
            if (istanım.Text.Count() == 0)
            {
                istanım.Enabled = cbsektör.Enabled = cbegitim.Enabled = cbcalısma.Enabled = true;
            }
            else
            {
                istanım.Enabled = cbsektör.Enabled = cbegitim.Enabled = cbcalısma.Enabled = true;
            }
        }

        private void cbcalısma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = "select*from ilan_ver where calısma_sekli like '" + cbcalısma.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ilan_ver");
            if (istanım.Text.Count() == 0)
            {
                istanım.Enabled = cbpozisyon.Enabled = cbegitim.Enabled = cbsektör.Enabled = true;
            }
            else
            {
                istanım.Enabled = cbpozisyon.Enabled = cbegitim.Enabled = cbsektör.Enabled = true;
            }
        }

        private void basvur_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "update ilan_ver set basvuru_durumu=@basvuru_durumu where isveren_id='" + textBox1.Text + "'";
            cmdd.Connection = con;
            cmdd.Parameters.AddWithValue("@basvuru_durumu", "Başvuruldu");
            DialogResult c = MessageBox.Show("işlem tamamlandı", " tamamlandı", MessageBoxButtons.OK);
            if ( c== DialogResult.OK)
            {
                cmdd.ExecuteNonQuery();
                verileri_cek();
           
            }

           
        }
    }
}
