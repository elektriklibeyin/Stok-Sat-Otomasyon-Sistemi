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
    public partial class UrunGuncelleme_form : Form
    {
        public UrunGuncelleme_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        int urun_id = 0;

        string resimpath = null;
        byte[] resimyeni = null;
        byte[] resimeski = null;

        string checkbox_control;

        private void UrunGuncelleme_form_Load(object sender, EventArgs e)
        {
            urunleri_listele();
        }

        private void urunleri_listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Urunler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Urun_ID"].ToString();
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            urun_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            urunu_cek();
            kaydetbtn.Visible = true;
        }

        private void urunu_cek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Urunler where Urun_ID like '" + urun_id + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                id_tbox.Text = read["Urun_ID"].ToString();
                ad_tbox.Text = read["Urun_Ad"].ToString();
                tamad_tbox.Text = read["Urun_Tam_Ad"].ToString();
                renk_cbox.Text = read["Urun_Renk"].ToString();
                boyut_tbox.Text = read["Urun_Boyut"].ToString();
                stokadet_tbox.Text = read["Urun_Stok_Adet"].ToString();

                checkbox_control = read["Urun_Satis_Durum"].ToString();
                if (checkbox_control == "True")
                {
                    satisdurumu_check.Checked = true;
                }
                else
                {
                    satisdurumu_check.Checked = false;
                }

                stokkod_tbox.Text = read["Urun_Stok_Kod"].ToString();
                barkod_tbox.Text = read["Urun_Barkod"].ToString();
                toptanfiyat_tbox.Text = read["Urun_Toptan_Fiyat"].ToString();
                satisfiyati_tbox.Text = read["Urun_Satis_Fiyat"].ToString();
                trendyolfiyati_tbox.Text = read["Urun_Trendyol_Fiyat"].ToString();
                not_tbox.Text = read["Urun_Not"].ToString();
                maligider_tbox.Text = read["Urun_Maliyet"].ToString();
                kesimgider_tbox.Text = read["Urun_Kesim_Maliyet"].ToString();
                dateTimePicker1.Text = read["Urun_Kayit_Tarih"].ToString();

                // SATIŞ KANALLARI//
                checkbox_control = read["softarthome_sk"].ToString();
                if (checkbox_control == "True")         
                    softarthome_c.Checked = true;               
                else               
                   softarthome_c.Checked = false;

                checkbox_control = read["trendyol_sk"].ToString();
                if (checkbox_control == "True")
                    trendyol_c.Checked = true;
                else
                    trendyol_c.Checked = false;

                checkbox_control = read["n11_sk"].ToString();
                if (checkbox_control == "True")
                    n11_c.Checked = true;
                else
                    n11_c.Checked = false;

                checkbox_control = read["hepsiburada_sk"].ToString();
                if (checkbox_control == "True")
                    hepsiburada_c.Checked = true;
                else
                    hepsiburada_c.Checked = false;

                checkbox_control = read["epttavm_sk"].ToString();
                if (checkbox_control == "True")
                    epttavm_c.Checked = true;
                else
                    epttavm_c.Checked = false;

                checkbox_control = read["vivense_sk"].ToString();
                if (checkbox_control == "True")
                    vivense_c.Checked = true;
                else
                    vivense_c.Checked = false;

                checkbox_control = read["ciceksepeti_sk"].ToString();
                if (checkbox_control == "True")
                    ciceksepeti_c.Checked = true;
                else
                    ciceksepeti_c.Checked = false;

                checkbox_control = read["amazoncom_sk"].ToString();
                if (checkbox_control == "True")
                    amazoncom_c.Checked = true;
                else
                    amazoncom_c.Checked = false;

                checkbox_control = read["amazonde_sk"].ToString();
                if (checkbox_control == "True")
                    amazonde_c.Checked = true;
                else
                    amazonde_c.Checked = false;

                checkbox_control = read["amazoncouk_sk"].ToString();
                if (checkbox_control == "True")
                    amazoncouk_c.Checked = true;
                else
                    amazoncouk_c.Checked = false;
                //SATIŞ KANALLARI//

                if (read["Urun_Resim"] == DBNull.Value)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    resimeski = (byte[])read["Urun_Resim"];
                    MemoryStream mis = new MemoryStream();
                    mis.Write(resimeski, 0, resimeski.Length);
                    pictureBox1.Image = Image.FromStream(mis);
                    resimeski = (byte[])read["Urun_Resim"];
                }
            }
            baglanti.Close();
        }

        private void arama_tbox_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from Urunler where Urun_Ad like '%" + arama_tbox.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Urun_ID"].ToString();
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void resimsilbtn_Click(object sender, EventArgs e)
        {          
                pictureBox1.Image = null;          
        }

        private void resimsecbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Yüklemek İstediğiniz Resmi Seçin";
            openFileDialog1.Filter = "jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimpath = openFileDialog1.FileName.ToString();
                FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                resimyeni = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }         
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Urunler set Urun_Ad=@Urun_Ad,Urun_Tam_Ad=@Urun_Tam_Ad,Urun_Renk=@Urun_Renk,Urun_Boyut=@Urun_Boyut,Urun_Stok_Adet=@Urun_Stok_Adet,Urun_Satis_Durum=@Urun_Satis_Durum,Urun_Stok_Kod=@Urun_Stok_Kod,Urun_Barkod=@Urun_Barkod,Urun_Kayit_Tarih=@Urun_Kayit_Tarih,Urun_Satis_Fiyat=@Urun_Satis_Fiyat,Urun_Toptan_Fiyat=@Urun_Toptan_Fiyat,Urun_Trendyol_Fiyat=@Urun_Trendyol_Fiyat,Urun_Maliyet=@Urun_Maliyet,Urun_Kesim_Maliyet=@Urun_Kesim_Maliyet,Urun_Not=@Urun_Not,Urun_Resim=@Urun_Resim,softarthome_sk=@Softarthome_sk,trendyol_sk=@trendyol_sk,n11_sk=@n11_sk,hepsiburada_sk=@hepsiburada_sk,epttavm_sk=@epttavm_sk,vivense_sk=@vivense_sk,ciceksepeti_sk=@ciceksepeti_sk,amazoncom_sk=@amazoncom_sk,amazonde_sk=@amazonde_sk,amazoncouk_sk=@amazoncouk_sk where Urun_ID=@Urun_ID", baglanti);

            komut.Parameters.AddWithValue("@Urun_ID", id_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Ad", ad_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Tam_Ad", tamad_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Renk", renk_cbox.SelectedItem);
            komut.Parameters.AddWithValue("@Urun_Boyut", boyut_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Stok_Adet", stokadet_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Satis_Durum", satisdurumu_check.Checked);
            komut.Parameters.AddWithValue("@Urun_Stok_Kod", stokkod_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Barkod", barkod_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_Kayit_Tarih", dateTimePicker1.Value);
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
                SqlParameter imageparameter = new SqlParameter("@Urun_Resim", SqlDbType.Image);
                imageparameter.Value = DBNull.Value;
                komut.Parameters.Add(imageparameter);
            }
            else
            {
                if (resimpath == null)
                {
                    komut.Parameters.Add("@Urun_Resim", SqlDbType.Image, resimeski.Length).Value = resimeski;
                }
                else
                {
                    komut.Parameters.Add("@Urun_Resim", SqlDbType.Image, resimyeni.Length).Value = resimyeni;
                }
            }

            komut.ExecuteNonQuery();
            baglanti.Close();    

            MessageBox.Show("ID numarası: " + id_tbox.Text + " olan üründe yapılan değişiklikler başarı ile kaydedilmiştir.");
            textleri_temizle();
        }

        private void textleri_temizle()
        {
            id_tbox.Clear();
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
            resimeski = null;
            resimyeni = null;
            resimpath = null;
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
            dateTimePicker1.Value = DateTime.Today;
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelleme_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
