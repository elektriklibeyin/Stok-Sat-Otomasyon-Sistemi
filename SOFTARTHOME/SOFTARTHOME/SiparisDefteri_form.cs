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
    public partial class SiparisDefteri_form : Form
    {
        public SiparisDefteri_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        DataSet dtst = new DataSet();
        
       

        private void verileri_görüntüle()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Tarih between @trh1 and @trh2 ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today);
            da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            dtst.Clear();
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];      
            baglanti.Close();

        }

        private void SiparisDefteri_form_Load_1(object sender, EventArgs e)
        {
            verileri_görüntüle();
        }
     

        private void satisadet_numeric_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(gun_numeric.Value);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Tarih between @trh1 and @trh2 ORDER BY Satimlar.Satim_Tarih DESC ", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(-(x-1)));
            da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            dtst.Clear();
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            baglanti.Close();
        }

      

        private void SatisCiktilari_Button_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            SiparisCiktilari_form a = new SiparisCiktilari_form();
            a.Show();
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisDefteri_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void gün_cbox_TextChanged(object sender, EventArgs e)
        {   baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Tarih between @trh1 and @trh2 ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
          
            if (gün_cbox.Text == "YARIN")
            {
            da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(+1));
            da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+2));
            }
            else if(gün_cbox.Text == "BUGÜN")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today);
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            }
            else if(gün_cbox.Text == "DÜN")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(-1));
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today);
            }
            
              
            dtst.Clear();
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            baglanti.Close();
        }
    }
}
