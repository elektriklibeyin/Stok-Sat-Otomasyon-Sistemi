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
    public partial class ÜrünSil_form : Form
    {
        public ÜrünSil_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");
        int urun_id = 0;
        string tam_Ad;

        private void ÜrünSil_form_Load(object sender, EventArgs e)
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            urun_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            urunu_cek();
        }

        private void urunu_cek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Urunler where Urun_ID like '" + urun_id + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label1.Text = "Seçilen Ürünün Temel Bilgileri;";
                label2.Text = "Ad : " + read["Urun_Ad"].ToString() + "";
                label3.Text = "Tam Ad : " + read["Urun_Tam_Ad"].ToString() + "";            
                label4.Text = "Renk : " + read["Urun_Renk"].ToString() + "";
                label5.Text = "Boyutlar : " + read["Urun_Boyut"].ToString() + "";
                label6.Text = "Stok-Kod : " + read["Urun_Stok_Kod"].ToString() + "";
                label7.Text = "Barkod : " + read["Urun_Barkod"].ToString() + "";
                label8.Text = "Satış Durumu : " + read["Urun_Satis_Durum"].ToString() + "";
                label9.Text = "Stok Adet : " + read["Urun_Stok_Adet"].ToString() + "";
                label10.Text = "Kayıt Tarihi : " + read["Urun_Kayit_Tarih"].ToString() + "";
                label11.Text = "Ürün Notu : " + read["Urun_Not"].ToString() + "";
                tam_Ad = read["Urun_Tam_Ad"].ToString();

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

        private void silbtn_Click(object sender, EventArgs e)
        {

            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("" + tam_Ad + " isimli ürünü silmek istediğinize emin misiniz? ( Silme işlemi geri alınamamaktadır! )", "Silme İşlemi Doğrulama", MessageBoxButtons.YesNo);

            if (Secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Urunler where Urun_ID=(" + urun_id + ")", baglanti);
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
                urunleri_listele();
            }
            if (Secim == DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir.");

            }


        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünSil_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
