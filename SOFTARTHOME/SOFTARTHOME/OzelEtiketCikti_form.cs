using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTARTHOME
{
    public partial class OzelEtiketCikti_form : Form
    {
        public OzelEtiketCikti_form()
        {
            InitializeComponent();
        }
    

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Open(@"C:\Users\mwidg\source\repos\SOFTARTHOME\sablon2.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

            Microsoft.Office.Interop.Excel.Range Range1 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, 2];
            Range1.Value2 = textBox1.Text;
            Microsoft.Office.Interop.Excel.Range Range2 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[2, 2];
            Range2.Value2 = textBox2.Text;
            Microsoft.Office.Interop.Excel.Range Range3 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[3, 2];
            Range3.Value2 = textBox3.Text;
            Microsoft.Office.Interop.Excel.Range Range4 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[8, 2];
            Range4.Value2 = textBox4.Text;
            Microsoft.Office.Interop.Excel.Range Range5 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[9, 1];
            Range5.Value2 = textBox5.Text;
        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OzelEtiketCikti_form.ActiveForm.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
