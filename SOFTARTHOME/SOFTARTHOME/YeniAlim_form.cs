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
    public partial class YeniAlim_form : Form
    {
        public YeniAlim_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");
       
        int urun_id;
        byte[] resim = null;
        int eskistok;

        private void YeniAlim_form_Load(object sender, EventArgs e)
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
            alimadet_numeric.Enabled = true;
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
                stokadet_tbox.Text  =read["Urun_Stok_Adet"].ToString();
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

        private void alimadet_numeric_ValueChanged(object sender, EventArgs e)
        {
            if (alimadet_numeric.Value == 0)
            {
                kaydetbtn.Visible = false;               
            }
            else
            {
                kaydetbtn.Visible = true;
            }
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Alimlar(Urun_ID,Alim_Tarih,Alim_Adet,Alim_Not,Alim_Tutar) values(@Urun_ID,@Alim_Tarih,@Alim_Adet,@Alim_Not,@Alim_Tutar)", baglanti);

            komut.Parameters.AddWithValue("@Urun_ID", urun_id);
            komut.Parameters.AddWithValue("@Alim_Adet", alimadet_numeric.Value);
            komut.Parameters.AddWithValue("@Alim_Tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Alim_Not", alimnotu_tbox.Text);
            komut.Parameters.AddWithValue("@Alim_Tutar", alimtutari_tbox.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            int yenistok = eskistok + Convert.ToInt32(alimadet_numeric.Value);
            SqlCommand komut2 = new SqlCommand("update Urunler set Urun_Stok_Adet=@Urun_Stok_Adet where Urun_ID=@Urun_ID", baglanti);
            komut2.Parameters.AddWithValue("@Urun_ID", urun_id);
            komut2.Parameters.AddWithValue("@Urun_Stok_Adet", yenistok);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("" + alimadet_numeric.Value + " adet " + tamad_tbox.Text + " alım kaydı oluşturuldu ");

            textleri_temizle();
        }

        public void textleri_temizle()
        {
            pictureBox1.Image = null;
            tamad_tbox.Clear();
            renk_tbox.Clear();
            boyut_tbox.Clear();
            stokadet_tbox.Clear();
            alimadet_numeric.Value = 0;
            alimtutari_tbox.Clear();
            alimnotu_tbox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            alimadet_numeric.Enabled = false;
            kaydetbtn.Visible = false;
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniAlim_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            urun_id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            alimadet_numeric.Enabled = true;
            urunu_cek();
        }
    }
}
