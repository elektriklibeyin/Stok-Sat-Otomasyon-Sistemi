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
    public partial class SiparisGuncelle_form : Form
    {
        public SiparisGuncelle_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");
        int satis_id = 0;
        int urun_id = 0;
      

        private void SiparisGuncelle_form_Load(object sender, EventArgs e)
        {
            urunleri_listele();
        }

        private void urunleri_listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID, Urunler.Urun_Tam_Ad, Satimlar.Alici_Ad, Satimlar.Satim_Tarih, Satimlar.Satim_Kanal from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID ORDER BY Satimlar.Satim_Tarih DESC", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Satim_ID"].ToString();
                ekle.SubItems.Add(oku["Urun_ID"].ToString());
                ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());
                ekle.SubItems.Add(oku["Alici_Ad"].ToString());
                ekle.SubItems.Add(oku["Satim_Tarih"].ToString());
                ekle.SubItems.Add(oku["Satim_Kanal"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        
        private void satiskanali_cbox_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            if (satiskanali_cbox.Text == "ALL")
            {
                SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID, Urunler.Urun_Tam_Ad, Satimlar.Alici_Ad, Satimlar.Satim_Tarih, Satimlar.Satim_Kanal from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID ORDER BY Satimlar.Satim_Tarih DESC ", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Satim_ID"].ToString();
                    ekle.SubItems.Add(oku["Urun_ID"].ToString());
                    ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());
                    ekle.SubItems.Add(oku["Alici_Ad"].ToString());
                    ekle.SubItems.Add(oku["Satim_Tarih"].ToString());
                    ekle.SubItems.Add(oku["Satim_Kanal"].ToString());
                    listView1.Items.Add(ekle);
                }
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID, Urunler.Urun_Tam_Ad, Satimlar.Alici_Ad, Satimlar.Satim_Tarih, Satimlar.Satim_Kanal from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Kanal = '" + satiskanali_cbox.Text + "' ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Satim_ID"].ToString();
                    ekle.SubItems.Add(oku["Urun_ID"].ToString());
                    ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());
                    ekle.SubItems.Add(oku["Alici_Ad"].ToString());
                    ekle.SubItems.Add(oku["Satim_Tarih"].ToString());
                    ekle.SubItems.Add(oku["Satim_Kanal"].ToString());
                    listView1.Items.Add(ekle);
                }
            }
            baglanti.Close();
        }

        private void arama_tbox_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID, Urunler.Urun_Tam_Ad, Satimlar.Alici_Ad, Satimlar.Satim_Tarih, Satimlar.Satim_Kanal from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Urunler.Urun_Ad like '%" + arama_tbox.Text + "%' ORDER BY Satimlar.Satim_Tarih DESC", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Satim_ID"].ToString();
                ekle.SubItems.Add(oku["Urun_ID"].ToString());
                ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());
                ekle.SubItems.Add(oku["Alici_Ad"].ToString());
                ekle.SubItems.Add(oku["Satim_Tarih"].ToString());
                ekle.SubItems.Add(oku["Satim_Kanal"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            satis_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            pictureBox1.Visible = true;
            satisi_cek();
        }

        private void satisi_cek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satim_ID like '" + satis_id + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                id_tbox.Text = read["Satim_ID"].ToString();
                urun_id_tbox.Text = read["Urun_ID"].ToString();
                tamad_tbox.Text = read["Urun_Tam_Ad"].ToString();
                satis_Adet_tbox.Text = read["Satim_Adet"].ToString();          
                comboBox1.Text = read["Satim_Kanal"].ToString();
                satisfiyati_tbox.Text = read["Satim_Fiyat"].ToString();
                odemeyontemi_cbox.Text = read["Odeme_Yontem"].ToString();
                dateTimePicker3.Text = read["Satim_Tarih"].ToString();
                satisnot_tbox.Text = read["Satim_Not"].ToString();
                aliciad_tbox.Text = read["Alici_Ad"].ToString();
                alicitel_tbox.Text = read["Alici_Telefon"].ToString();
                aliciadres_tbox.Text = read["Alici_Adres"].ToString();

                
                /*
                label1.Text = "Seçilen Satışın Bilgileri;";
                label2.Text = "Satış ID : " + read["Satim_ID"].ToString() + "";
                label3.Text = "Urun ID : " + read["Urun_ID"].ToString() + "";
                label4.Text = "Urun Tam Ad : " + read["Urun_Tam_Ad"].ToString() + "";
                label5.Text = "Alıcı Adı : " + read["Alici_Ad"].ToString() + "";
                label6.Text = "Alıcı Telefon : " + read["Alici_Telefon"].ToString() + "";
                label7.Text = "Alıcı Adres  : " + read["Alici_Adres"].ToString() + "";
                label8.Text = "Satış Kanalı : " + read["Satim_Kanal"].ToString() + "";
                label9.Text = "Satış Tarihi : " + read["Satim_Tarih"].ToString() + "";
                label10.Text = "Satış Fiyatı : " + read["Satim_Fiyat"].ToString() + "";
                label11.Text = "Ödeme Yöntemi : " + read["Odeme_Yontem"].ToString() + "";
                label12.Text = "Urun Boyut : " + read["Urun_Boyut"].ToString() + "";
                label13.Text = "Urun Renk : " + read["Urun_Renk"].ToString() + "";
                label14.Text = "Satış Notu : " + read["Satim_Not"].ToString() + "";
                tam_ad = read["Urun_Tam_Ad"].ToString(); */

            }
            baglanti.Close();
        }

        private void arama_tbox2_TextChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from Urunler where Urun_Ad like '%" + arama_tbox2.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Urun_ID"].ToString();
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());

                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            urun_id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);        
            urunudegistir();
        }

        private void urunudegistir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Urunler where Urun_ID like '" + urun_id + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                urun_id_tbox.Text = read["Urun_ID"].ToString();
                tamad_tbox.Text = read["Urun_Tam_Ad"].ToString();
            }
            baglanti.Close();
        }

        private void TarihFiltreButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID, Urunler.Urun_Tam_Ad, Satimlar.Alici_Ad, Satimlar.Satim_Tarih, Satimlar.Satim_Kanal from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Tarih between @trh1 and @trh2 ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
            komut.Parameters.AddWithValue("@trh1", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@trh2", dateTimePicker2.Value);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Satim_ID"].ToString();
                ekle.SubItems.Add(oku["Urun_ID"].ToString());
                ekle.SubItems.Add(oku["Urun_Tam_Ad"].ToString());
                ekle.SubItems.Add(oku["Alici_Ad"].ToString());
                ekle.SubItems.Add(oku["Satim_Tarih"].ToString());
                ekle.SubItems.Add(oku["Satim_Kanal"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Satimlar Set Urun_ID=@Urun_ID, Satim_Adet=@Satim_Adet, Satim_Tarih=@Satim_Tarih, Satim_Not=@Satim_Not, Satim_Kanal=@Satim_Kanal, Alici_Ad=@Alici_Ad, Alici_Adres=@Alici_Adres, Alici_Telefon=@Alici_Telefon, Odeme_Yontem=@Odeme_Yontem, Satim_Fiyat=@Satim_Fiyat where Satim_ID=@Satim_ID", baglanti);

            komut.Parameters.AddWithValue("@Satim_ID", id_tbox.Text);
            komut.Parameters.AddWithValue("@Urun_ID", urun_id_tbox.Text);
            komut.Parameters.AddWithValue("@Satim_Adet", satis_Adet_tbox.Text);
            komut.Parameters.AddWithValue("@Satim_Tarih", dateTimePicker3.Value);
            komut.Parameters.AddWithValue("@Satim_Not", satisnot_tbox.Text);
            komut.Parameters.AddWithValue("@Satim_Kanal", comboBox1.Text);
            komut.Parameters.AddWithValue("@Alici_Ad", aliciad_tbox.Text);
            komut.Parameters.AddWithValue("@Alici_Adres", aliciadres_tbox.Text);
            komut.Parameters.AddWithValue("@Alici_Telefon", alicitel_tbox.Text);
            komut.Parameters.AddWithValue("@Odeme_Yontem", odemeyontemi_cbox.Text);
            komut.Parameters.AddWithValue("@Satim_Fiyat", satisfiyati_tbox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("ID numarası: " + id_tbox.Text + " olan Satışta yapılan değişiklikler başarı ile kaydedilmiştir.");
            textleri_temizle();
        }

        private void textleri_temizle()
        {
            listView2.Items.Clear();
            arama_tbox2.Clear();
            id_tbox.Clear();
            urun_id_tbox.Clear();
            tamad_tbox.Clear();
            aliciad_tbox.Clear();
            satisfiyati_tbox.Clear();
            aliciadres_tbox.Clear();
            alicitel_tbox.Clear();
            satis_Adet_tbox.Clear();
            comboBox1.SelectedItem = null;
            satis_Adet_tbox.Clear();
            odemeyontemi_cbox.SelectedItem = null;
            dateTimePicker3.Value = DateTime.Today;
            satisnot_tbox.Clear();
            pictureBox1.Visible = false;

        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisGuncelle_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
