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
    public partial class SatisSil_form : Form
    {
        public SatisSil_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");
        int satis_id = 0;
        string tam_ad;

        private void SatisSil_form_Load(object sender, EventArgs e)
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            satis_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            pictureBox1.Visible = true;
            urunu_cek();
        }

        private void urunu_cek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Satimlar.Satim_ID, Urunler.Urun_ID,Urunler.Urun_Tam_Ad,Satimlar.Satim_Adet,Satimlar.Satim_Tarih,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Satim_Kanal,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Urunler.Urun_Renk,Urunler.Urun_Boyut,Satimlar.Satim_Not from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satim_ID like '" + satis_id + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
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
                tam_ad = read["Urun_Tam_Ad"].ToString();

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

        private void satiskanali_cbox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("" + tam_ad + " isimli ürünün Satışını silmek istediğinize emin misiniz? ( Silme işlemi geri alınamamaktadır! )", "Silme İşlemi Doğrulama", MessageBoxButtons.YesNo);

            if (Secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Satimlar where Satim_ID=(" + satis_id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listView1.Items.Clear();
                label1.Text = "------";
                label2.Text = "------";
                label3.Text = "------";
                label4.Text = "------";
                label5.Text = "------";
                label6.Text = "------";
                label7.Text = "------";
                label8.Text = "------";
                label9.Text = "------";
                label10.Text = "------";
                label11.Text = "------";
                label12.Text = "------";
                label13.Text = "------";
                label14.Text = "------";
                pictureBox1.Visible = false;
                urunleri_listele();
            }
            if (Secim == DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir.");

            }
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisSil_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            satis_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            pictureBox1.Visible = true;
            urunu_cek();
        }
    }
}
