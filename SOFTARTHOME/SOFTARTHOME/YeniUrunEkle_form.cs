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
    public partial class YeniUrunEkle_form : Form
    {
        public YeniUrunEkle_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");
        byte[] resim;
        string resimpath;
        DateTime dt = DateTime.Today;

        private void satisdurumu_check_CheckedChanged(object sender, EventArgs e)
        {
            if (satisdurumu_check.Checked)
            {
                satisdurumu_check.Text = ("✓");
            }
            else if (!satisdurumu_check.Checked)
            {
                satisdurumu_check.Text = ("");
            }
        }

        private void resimsecbtn_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Yüklemek İstediğiniz Resmi Seçin";
            openFileDialog1.Filter = "jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimpath = openFileDialog1.FileName.ToString();
                FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                resim = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            } 
        }

        private void resimsilbtn_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            resim = null;
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler(Urun_Ad,Urun_Tam_Ad,Urun_Renk,Urun_Boyut,Urun_Stok_Adet,Urun_Satis_Durum,Urun_Stok_Kod,Urun_Barkod,Urun_Kayit_Tarih,Urun_Satis_Fiyat,Urun_Toptan_Fiyat,Urun_Trendyol_Fiyat,Urun_Maliyet,Urun_Kesim_Maliyet,Urun_Not,Urun_Resim,softarthome_sk,trendyol_sk,n11_sk,hepsiburada_sk,epttavm_sk,vivense_sk,ciceksepeti_sk,amazoncom_sk,amazonde_sk,amazoncouk_sk) values(@Urun_Ad,@Urun_Tam_Ad,@Urun_Renk,@Urun_Boyut,@Urun_Stok_Adet,@Urun_Satis_Durum,@Urun_Stok_Kod,@Urun_Barkod,@Urun_Kayit_Tarih,@Urun_Satis_Fiyat,@Urun_Toptan_Fiyat,@Urun_Trendyol_Fiyat,@Urun_Maliyet,@Urun_Kesim_Maliyet,@Urun_Not,@Urun_Resim,@softarthome_sk,@trendyol_sk,@n11_sk,@hepsiburada_sk,@epttavm_sk,@vivense_sk,@ciceksepeti_sk,@amazoncom_sk,@amazonde_sk,@amazoncouk_sk)", baglanti);

            komut.Parameters.AddWithValue("@Urun_Ad", ad_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Tam_Ad", tamad_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Renk", renk_cbox.SelectedItem);
            komut.Parameters.AddWithValue("@Urun_Boyut", boyut_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Stok_Adet", stokadet_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Satis_Durum", satisdurumu_check.Checked);
            komut.Parameters.AddWithValue("@Urun_Stok_Kod", stokkod_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Barkod", barkod_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Kayit_Tarih", dt);
            komut.Parameters.AddWithValue("@Urun_Satis_Fiyat", satisfiyati_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Toptan_Fiyat", toptanfiyat_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Trendyol_Fiyat", trendyolfiyati_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Maliyet", maligider_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Kesim_Maliyet", kesimgider_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Not", not_tbox.Text);
            // SATIŞ KANALLARI
            komut.Parameters.AddWithValue("@softarthome_sk", softarthome_c.Checked);
            komut.Parameters.AddWithValue("@trendyol_sk", trendyol_c.Checked);
            komut.Parameters.AddWithValue("@n11_sk", n11_c.Checked);
            komut.Parameters.AddWithValue("@hepsiburada_sk", hepsiburada_c.Checked);
            komut.Parameters.AddWithValue("@epttavm_sk", epttavm_c.Checked);
            komut.Parameters.AddWithValue("@vivense_sk", vivense_c.Checked);
            komut.Parameters.AddWithValue("@ciceksepeti_sk", ciceksepeti_c.Checked);
            komut.Parameters.AddWithValue("@amazoncom_sk", amazoncom_c.Checked);
            komut.Parameters.AddWithValue("@amazonde_sk", amazonde_c.Checked);
            komut.Parameters.AddWithValue("@amazoncouk_sk", amazoncouk_c.Checked);
            //SATIŞ KANALLARI

            if (pictureBox1.Image == null)
            {
                // komut.Parameters.AddWithValue("@ürün_resim",SqlDbType.Image).Value = imgtype; //
                SqlParameter imageparameter = new SqlParameter("@Urun_Resim", SqlDbType.Image);
                imageparameter.Value = DBNull.Value;
                komut.Parameters.Add(imageparameter);
            }
            else
            {
                komut.Parameters.Add("@Urun_Resim", SqlDbType.Image, resim.Length).Value = resim;
            }

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oluşturulan " + tamad_tbox.Text + " isimli yeni ürününüz kaydedilmiştir.");

            textleri_temizle();
        }

        private void textleri_temizle()
        {
            ad_tbox.Clear();
            tamad_tbox.Clear();
            renk_cbox.SelectedItem = null;
            boyut_tbox.Clear();
            stokadet_tbox.Clear();
            stokkod_tbox.Clear();
            barkod_tbox.Clear();
            kesimgider_tbox.Clear();
            maligider_tbox.Clear();
            satisfiyati_tbox.Clear();
            toptanfiyat_tbox.Clear(); 
            trendyolfiyati_tbox.Clear();
            satisdurumu_check.Checked = false;       
            pictureBox1.Image = null;
            resim = null;
            not_tbox.Clear();
            softarthome_c.Checked = false;
            trendyol_c.Checked = false;
            n11_c.Checked = false;
            hepsiburada_c.Checked = false;
            epttavm_c.Checked = false;
            vivense_c.Checked = false;
            ciceksepeti_c.Checked = false;
            amazoncom_c.Checked = false;
            amazonde_c.Checked = false;
            amazoncouk_c.Checked = false;
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniUrunEkle_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
