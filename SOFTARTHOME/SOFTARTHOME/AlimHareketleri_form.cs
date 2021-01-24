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
    public partial class AlimHareketleri_form : Form
    {
        public AlimHareketleri_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        DataSet dtst = new DataSet();

        private void verileri_görüntüle()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Alimlar.Alim_ID, Alimlar.Urun_ID, Alimlar.Alim_Tarih, Alimlar.Alim_Adet, Alimlar.Alim_Not, Alimlar.Alim_Tutar, Urunler.Urun_Renk, Urunler.Urun_Boyut, Urunler.Urun_Tam_Ad from Alimlar INNER JOIN Urunler ON Alimlar.Urun_ID=Urunler.Urun_ID ORDER BY Alimlar.Alim_Tarih DESC", baglanti);
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();

        }

        private void AlimHareketleri_form_Load(object sender, EventArgs e)
        {
            verileri_görüntüle();
        }

        private void arama_tbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Alimlar.Alim_ID, Alimlar.Urun_ID, Alimlar.Alim_Tarih, Alimlar.Alim_Adet, Alimlar.Alim_Not, Alimlar.Alim_Tutar, Urunler.Urun_Renk, Urunler.Urun_Boyut, Urunler.Urun_Tam_Ad from Alimlar INNER JOIN Urunler ON Alimlar.Urun_ID=Urunler.Urun_ID AND Urunler.Urun_Ad like '%" + arama_tbox.Text + "%'", baglanti);
            dtst.Clear();
            da.Fill(dtst);

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();

        }

        private void TarihFiltreButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Alimlar.Alim_ID, Alimlar.Urun_ID, Alimlar.Alim_Tarih, Alimlar.Alim_Adet, Alimlar.Alim_Not, Alimlar.Alim_Tutar, Urunler.Urun_Renk, Urunler.Urun_Boyut, Urunler.Urun_Tam_Ad from Alimlar INNER JOIN Urunler ON Alimlar.Urun_ID=Urunler.Urun_ID AND Alimlar.Alim_Tarih between @trh1 and @trh2", baglanti);
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
            AlimHareketleri_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
