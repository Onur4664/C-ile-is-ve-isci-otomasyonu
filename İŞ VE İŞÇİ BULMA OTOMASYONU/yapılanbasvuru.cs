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
    public partial class yapılanbasvuru : Form
    {

        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        public yapılanbasvuru()
        {
            InitializeComponent();
        }
        void verileri_cek()
        {

            ds.Clear();
            string seckomutu = "select * from ilan_ver where basvuru_durumu='Başvuruldu'";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, con);
            da.Fill(ds, "ilan_ver");
            bs.DataSource = ds.Tables["ilan_ver"];
            dataGridView1.DataSource = bs;
            con.Close();
        }

        private void yapılanbasvuru_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verileri_cek();
            textBox1.DataBindings.Add("Text", bs, "isveren_id");
            verileri_cek();
        }

        private void basvuruiptal_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "update ilan_ver set basvuru_durumu=@basvuru_durumu where isveren_id=" + textBox1.Text + "";
            cmdd.Connection = con;
            cmdd.Parameters.AddWithValue("@basvuru_durumu", "Başvurulmadı");
            DialogResult c = MessageBox.Show("işlem tamamlandı", " tamamlandı", MessageBoxButtons.OK);
            if (c == DialogResult.OK)
            {
                cmdd.ExecuteNonQuery();
                verileri_cek();

            }
        }
    }
}
