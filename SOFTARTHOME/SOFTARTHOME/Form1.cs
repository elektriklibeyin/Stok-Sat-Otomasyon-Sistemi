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
using System.Data.Sql;
using System.Data.SqlTypes;
using System.IO;

namespace SOFTARTHOME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        private void YeniSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            YeniSatis_form a = new YeniSatis_form();
            a.Show();          
        }

        private void SiparişDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            SiparisDefteri_form a = new SiparisDefteri_form();
            a.Show();
        }

        private void SatışHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            SatisHareketleri_form a = new SatisHareketleri_form();
            a.Show();
        }

        private void ÖzelEtiketYazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();           
            OzelEtiketCikti_form a = new OzelEtiketCikti_form();
            a.Show();
        }

        private void YeniÜrünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            YeniUrunEkle_form a = new YeniUrunEkle_form();
            a.Show();
        }

        private void ÜrünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            UrunleriListele_form a = new UrunleriListele_form();
            a.Show();
        }

        private void ÜrünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            UrunGuncelleme_form a = new UrunGuncelleme_form();
            a.Show();
        }

        private void ÜrünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            ÜrünSil_form a = new ÜrünSil_form();
            a.Show();
        }

        private void YeniAlımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            YeniAlim_form a = new YeniAlim_form();
            a.Show();
        }

        private void AlımHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            AlimHareketleri_form a = new AlimHareketleri_form();
            a.Show();
        }

        private void SatışSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            SatisSil_form a = new SatisSil_form();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select COUNT(*) from Satimlar where Satim_Tarih between @trh1 and @trh2", baglanti);          
            komut.Parameters.AddWithValue("@trh1", DateTime.Today);
            komut.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read()){
               label1.Text ="Bugünkü Satış Sayısı : "+ read[0].ToString() + " ";
            }
            
            baglanti.Close();
           
        }

        private void siparişGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            SiparisGuncelle_form a = new SiparisGuncelle_form();
            a.Show();
        }
    }   
}
