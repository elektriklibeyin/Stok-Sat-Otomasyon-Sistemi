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
    public partial class UrunleriListele_form : Form
    {
        public UrunleriListele_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LOL4MBT\SQLEXPRESS;Initial Catalog=SoftArtStockOtomation;Integrated Security=True");
        DataSet dtst = new DataSet();

        private void UrunleriListele_form_Load(object sender, EventArgs e)
        {
            urunleri_listele();
        }

        private void urunleri_listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Urunler", baglanti);
            adtr.Fill(dtst, "Urunler");
            dataGridView1.DataSource = dtst.Tables[0];
            baglanti.Close();
        }

        private void arama_tbox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Urunler where Urun_Ad like '%" + arama_tbox.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook UrunStok = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)UrunStok.Sheets[1];
          
            for(int i =0; i<dataGridView1.Columns.Count; i++)
            {
                
                
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridView1.Columns[i].HeaderText;
            }
          
            for (int i=0;i<dataGridView1.Columns.Count; i++)
            {
                if (i == 16) continue;
                for (int j=0; j<dataGridView1.Rows.Count; j++)
                {
                    try
                    { 
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    range.Value2 = dataGridView1[i, j].Value;
                    }
                    catch
                    {

                    }                
                }
            }
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunleriListele_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
