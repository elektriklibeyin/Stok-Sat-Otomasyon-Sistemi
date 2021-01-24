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
    public partial class YeniSatis_form : Form
    {
        public YeniSatis_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        int urun_id;

        byte[] resim = null;

        string satiskanali;

        int eskistok;
     

        private void YeniSatis_form_Load(object sender, EventArgs e)
        {
            urunlerilistele();
        }

        private void urunlerilistele()
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
            satisadet_numeric.Enabled = true;
            urunu_cek();
        }

        private void urunu_cek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Urunler where Urun_ID like '" + urun_id + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tamad_tbox.Text = read["Urun_Tam_Ad"].ToString();               
                renk_tbox.Text = read["Urun_Renk"].ToString();
                boyut_tbox.Text = read["Urun_Boyut"].ToString();
                stokadet_tbox.Text = read["Urun_Stok_Adet"].ToString();
                fiyatsatis_tbox.Text = read["Urun_Satis_Fiyat"].ToString();
                fiyattrend_tbox.Text = read["Urun_Trendyol_Fiyat"].ToString();
                fiyattoptan_tbox.Text = read["Urun_Toptan_Fiyat"].ToString();
               
                eskistok = int.Parse(read["Urun_Stok_Adet"].ToString());               
               
                if (read["Urun_Resim"] == DBNull.Value)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    resim = (byte[])read["Urun_Resim"];
                    MemoryStream mis = new MemoryStream();
                    mis.Write(resim, 0, resim.Length);
                    pictureBox1.Image = Image.FromStream(mis);
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

        private void satiskanali_cbox_TextChanged(object sender, EventArgs e)
        {
            if (satiskanali_cbox.Text == "SOFTARTHOME")
            {
                satisfiyati_tbox.Text = (int.Parse(fiyatsatis_tbox.Text) * satisadet_numeric.Value).ToString();
                odemeyontemi_cbox.Text = "KAPIDA ÖDEME";
            }

            else if (satiskanali_cbox.Text == "TOPTAN")
            {
                satisfiyati_tbox.Text = (int.Parse(fiyattoptan_tbox.Text) * satisadet_numeric.Value).ToString();               
            }

            else
            {
                satisfiyati_tbox.Text = (int.Parse(fiyattrend_tbox.Text) * satisadet_numeric.Value).ToString();
                odemeyontemi_cbox.Text = "DİĞER";                
            }
        }

        private void satisadet_numeric_ValueChanged(object sender, EventArgs e)
        {
            if (satiskanali_cbox.Text == "SOFTARTHOME")
            {
                satisfiyati_tbox.Text = (int.Parse(fiyatsatis_tbox.Text) * satisadet_numeric.Value).ToString();
            }

            else if (satiskanali_cbox.Text == "TOPTAN")
            {
                satisfiyati_tbox.Text = (int.Parse(fiyattoptan_tbox.Text) * satisadet_numeric.Value).ToString();
            }

            else
            {
                satisfiyati_tbox.Text = (int.Parse(fiyattrend_tbox.Text) * satisadet_numeric.Value).ToString();
            }
            // 
            if (satisadet_numeric.Value == 0)
            {
                kaydetbtn.Visible = false;
                groupBox1.Enabled = false;
            }
            else
            {
                kaydetbtn.Visible = true;
                groupBox1.Enabled = true;
            }
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Satimlar(Urun_ID,Satim_Adet,Satim_Tarih,Satim_Not,Satim_Kanal,Alici_Ad,Alici_Adres,Alici_Telefon,Odeme_Yontem,Satim_Fiyat,kagit_cikti) values(@Urun_ID,@Satim_Adet,@Satim_Tarih,@Satim_Not,@Satim_Kanal,@Alici_Ad,@Alici_Adres,@Alici_Telefon,@Odeme_Yontem,@Satim_Fiyat,@kagit_cikti)", baglanti);

            komut.Parameters.AddWithValue("@Urun_ID", urun_id);
            komut.Parameters.AddWithValue("@Satim_Adet", satisadet_numeric.Value);
            komut.Parameters.AddWithValue("@Satim_Tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Satim_Not", satisnot_tbox.Text);
            if (satiskanali_cbox.SelectedItem == null)
            {
                komut.Parameters.AddWithValue("@Satim_Kanal", "bilinmiyor");
            }
            else
            {
               komut.Parameters.AddWithValue("@Satim_Kanal", satiskanali_cbox.SelectedItem);
            }
            if(odemeyontemi_cbox.SelectedItem == null)
            {
                komut.Parameters.AddWithValue("@Odeme_Yontem", "bilinmiyor");
            }
            else
            {
               komut.Parameters.AddWithValue("@Odeme_Yontem", odemeyontemi_cbox.SelectedItem);
            }
            komut.Parameters.AddWithValue("@Alici_Ad", aliciad_tbox.Text);
            komut.Parameters.AddWithValue("@Alici_Telefon", alicitel_tbox.Text);
            komut.Parameters.AddWithValue("@Alici_Adres", aliciadres_tbox.Text);
            komut.Parameters.AddWithValue("@Satim_Fiyat", satisfiyati_tbox.Text);
            komut.Parameters.AddWithValue("@kagit_cikti", false);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            int yenistok = eskistok - Convert.ToInt32(satisadet_numeric.Value);
            SqlCommand komut2 = new SqlCommand("update Urunler set Urun_Stok_Adet=@Urun_Stok_Adet where Urun_ID=@Urun_ID", baglanti);
            komut2.Parameters.AddWithValue("@Urun_ID", urun_id);
            komut2.Parameters.AddWithValue("@Urun_Stok_Adet", yenistok);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("" + satisadet_numeric.Value + " adet " + tamad_tbox.Text + " satış kaydı oluşturuldu ");

            textleri_temizle();
        }

        public void textleri_temizle()
        {
            tamad_tbox.Clear();
            pictureBox1.Image = null;
            fiyatsatis_tbox.Text = "0";
            fiyattrend_tbox.Text = "0";
            fiyattoptan_tbox.Text = "0";
            renk_tbox.Clear();
            boyut_tbox.Clear();
            stokadet_tbox.Clear();
            satisadet_numeric.Value = 0;
            satiskanali_cbox.SelectedItem = null;
            satisfiyati_tbox.Clear();
            odemeyontemi_cbox.SelectedItem = null;
            satisnot_tbox.Clear();
            aliciad_tbox.Clear();
            alicitel_tbox.Clear();
            aliciadres_tbox.Clear();
            satisadet_numeric.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
            kaydetbtn.Visible = false;
        }

            

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            urun_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            satisadet_numeric.Enabled = true;
            urunu_cek();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            urun_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            satisadet_numeric.Enabled = true;
            urunu_cek();
        } 
        


        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniSatis_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }

       
    }
}
