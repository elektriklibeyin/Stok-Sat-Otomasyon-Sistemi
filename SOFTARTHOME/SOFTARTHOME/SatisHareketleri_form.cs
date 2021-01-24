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
    public partial class SatisHareketleri_form : Form
    {
        public SatisHareketleri_form()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        DataSet dtst = new DataSet();
      

        private void SatisHareketleri_form_Load(object sender, EventArgs e)
        {
            verileri_görüntüle();
        }

        private void verileri_görüntüle()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();

        }

        private void arama_tbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Urunler.Urun_Ad like '%" + arama_tbox.Text + "%'", baglanti);
            dtst.Clear();
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();


        }

        private void satiskanali_cbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            dtst.Clear();
            if (satiskanali_cbox.Text == "ALL")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
                da.Fill(dtst);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Kanal = '" + satiskanali_cbox.Text + "'", baglanti);
                da.Fill(dtst);        
            }            

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();
        }

        private void odemeyontemi_cbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            dtst.Clear();
            if (odemeyontemi_cbox.Text == "ALL")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
                da.Fill(dtst);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Odeme_Yontem = '" + odemeyontemi_cbox.Text + "'", baglanti);
                da.Fill(dtst);
            }

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();
        }

        private void TarihFiltreButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Satimlar.Satim_ID,Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Tarih between @trh1 and @trh2", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@trh1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@trh2", dateTimePicker2.Value);
            dtst.Clear();
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisHareketleri_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
