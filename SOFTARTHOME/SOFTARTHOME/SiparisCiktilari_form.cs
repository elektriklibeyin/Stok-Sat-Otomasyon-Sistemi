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
/*
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;*/


namespace SOFTARTHOME
{
    public partial class SiparisCiktilari_form : Form
    {
        public SiparisCiktilari_form()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");

        DataSet dtst = new DataSet();

        private void SiparisCiktilari_form_Load(object sender, EventArgs e)
        {
            verileri_görüntüle();
        }

        private void verileri_görüntüle()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Urunler.Urun_Tam_Ad,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Satimlar.Satim_Tarih from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Kanal='SOFTARTHOME' AND Satimlar.kagit_cikti='false' ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
            da.Fill(dtst);
            
            dataGridView1.DataSource = dtst.Tables[0];
       
            if(dataGridView1[0,0].Value == null){
                pictureBox1.Visible = false;
            }

            baglanti.Close();

        }

        
        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisCiktilari_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Satimlar SET kagit_cikti='true' WHERE Satim_Kanal='SOFTARTHOME' AND kagit_cikti='false'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Open(@"C:\Users\mwidg\source\repos\SOFTARTHOME\sablon.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];


            for (int i = 0; i < 100; i += 2)
            {

                if (dataGridView1[0, i].Value == null) break;
                Microsoft.Office.Interop.Excel.Range Range1 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1 + ((i / 2) * 11), 2];
                Range1.Value2 = dataGridView1[0, i].Value;
                Microsoft.Office.Interop.Excel.Range Range2 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[2 + ((i / 2) * 11), 2];
                Range2.Value2 = dataGridView1[1, i].Value;
                Microsoft.Office.Interop.Excel.Range Range3 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[3 + ((i / 2) * 11), 2];
                Range3.Value2 = dataGridView1[2, i].Value;
                Microsoft.Office.Interop.Excel.Range Range4 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[8 + ((i / 2) * 11), 2];
                Range4.Value2 = dataGridView1[3, i].Value;

                if (dataGridView1[4, i].Value != null)
                {
                    if (dataGridView1[4, i].Value.ToString() == "KAPIDA ÖDEME")
                    {
                        var fyt = dataGridView1[5, i].Value;
                        var odemeyontem = dataGridView1[4, i].Value;
                        Microsoft.Office.Interop.Excel.Range Range5 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[9 + ((i / 2) * 11), 1];
                        Range5.Value2 = "" + fyt + " TL.  " + odemeyontem + "";
                        fyt = null;
                        odemeyontem = null;
                    }
                }

                if (dataGridView1[0, i + 1].Value == null) break;
                Microsoft.Office.Interop.Excel.Range Range6 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1 + ((i / 2) * 11), 5];
                Range6.Value2 = dataGridView1[0, i + 1].Value;
                Microsoft.Office.Interop.Excel.Range Range7 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[2 + ((i / 2) * 11), 5];
                Range7.Value2 = dataGridView1[1, i + 1].Value;
                Microsoft.Office.Interop.Excel.Range Range8 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[3 + ((i / 2) * 11), 5];
                Range8.Value2 = dataGridView1[2, i + 1].Value;
                Microsoft.Office.Interop.Excel.Range Range9 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[8 + ((i / 2) * 11), 5];
                Range9.Value2 = dataGridView1[3, i + 1].Value;

                if (dataGridView1[4, i + 1].Value != null)
                {
                    if (dataGridView1[4, i + 1].Value.ToString() == "KAPIDA ÖDEME")
                    {
                        var fyt = dataGridView1[5, i + 1].Value;
                        var odemeyontem = dataGridView1[4, i + 1].Value;
                        Microsoft.Office.Interop.Excel.Range Range10 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[9 + ((i / 2) * 11), 4];
                        Range10.Value2 = "" + fyt + " TL.  " + odemeyontem + "";
                        fyt = null;
                        odemeyontem = null;
                    }
                }
            }
        }

        private void gün_cbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Urunler.Urun_Tam_Ad,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Satimlar.Satim_Tarih from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Kanal='SOFTARTHOME' AND Satimlar.Satim_Tarih between @trh1 and @trh2 ORDER BY Satimlar.Satim_Tarih DESC", baglanti);

            if (gün_cbox.Text == "YARIN")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(+1));
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+2));
            }
            else if (gün_cbox.Text == "BUGÜN")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today);
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            }
            else if (gün_cbox.Text == "DÜN")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(-1));
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today);
            }
            else if( gün_cbox.Text =="2 GÜNLÜK")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(-2));
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            }
            else if(gün_cbox.Text =="3 GÜNLÜK")
            {
                da.SelectCommand.Parameters.AddWithValue("@trh1", DateTime.Today.AddDays(-3));
                da.SelectCommand.Parameters.AddWithValue("@trh2", DateTime.Today.AddDays(+1));
            }


            dtst.Clear();
            da.Fill(dtst);

            if (dataGridView1[0, 0].Value == null)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }

            dataGridView1.DataSource = dtst.Tables[0];
            //  dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending); //tarih olarak azalan sıralamada 
            baglanti.Close();
        }

        private void YeniEtiketler_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Urunler.Urun_Tam_Ad,Satimlar.Alici_Ad,Satimlar.Alici_Adres,Satimlar.Alici_Telefon,Satimlar.Odeme_Yontem,Satimlar.Satim_Fiyat,Satimlar.Satim_Tarih from Satimlar INNER JOIN Urunler ON Satimlar.Urun_ID=Urunler.Urun_ID AND Satimlar.Satim_Kanal='SOFTARTHOME' AND Satimlar.kagit_cikti='false' ORDER BY Satimlar.Satim_Tarih DESC", baglanti);
            dtst.Clear();
            da.Fill(dtst);
           
            dataGridView1.DataSource = dtst.Tables[0];

            if (dataGridView1[0, 0].Value == null)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }

            baglanti.Close();
        }
    }
}
