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
    public partial class basvurular : Form
    {
        public basvurular()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-PFH0K5T\\SQLEXPRESS;Initial Catalog=is_ve_isci_bulma;Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
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

        private void basvurular_Load(object sender, EventArgs e)
        {
            verileri_cek();
        }
    }
}
