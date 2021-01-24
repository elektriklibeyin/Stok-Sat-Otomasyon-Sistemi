namespace SOFTARTHOME
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anamenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YeniSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparişDefteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÖzelEtiketYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÜrünleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÜrünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÜrünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YeniAlımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlımHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RaporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışRakamlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlımRakamlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.siparişGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anamenuToolStripMenuItem,
            this.SatışlarToolStripMenuItem,
            this.ÜrünlerToolStripMenuItem,
            this.AlımlarToolStripMenuItem,
            this.RaporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anamenuToolStripMenuItem
            // 
            this.anamenuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anamenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.anamenuToolStripMenuItem.Name = "anamenuToolStripMenuItem";
            this.anamenuToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.anamenuToolStripMenuItem.Text = "ANA SAYFA";
            // 
            // SatışlarToolStripMenuItem
            // 
            this.SatışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniSatışToolStripMenuItem,
            this.SiparişDefteriToolStripMenuItem,
            this.SatışHareketleriToolStripMenuItem,
            this.ÖzelEtiketYazToolStripMenuItem,
            this.SatışSilToolStripMenuItem,
            this.siparişGüncelleToolStripMenuItem});
            this.SatışlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SatışlarToolStripMenuItem.Name = "SatışlarToolStripMenuItem";
            this.SatışlarToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.SatışlarToolStripMenuItem.Text = "SATIŞLAR";
            // 
            // YeniSatışToolStripMenuItem
            // 
            this.YeniSatışToolStripMenuItem.Name = "YeniSatışToolStripMenuItem";
            this.YeniSatışToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.YeniSatışToolStripMenuItem.Text = "Yeni Satış";
            this.YeniSatışToolStripMenuItem.Click += new System.EventHandler(this.YeniSatışToolStripMenuItem_Click);
            // 
            // SiparişDefteriToolStripMenuItem
            // 
            this.SiparişDefteriToolStripMenuItem.Name = "SiparişDefteriToolStripMenuItem";
            this.SiparişDefteriToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.SiparişDefteriToolStripMenuItem.Text = "Sipariş Defteri";
            this.SiparişDefteriToolStripMenuItem.Click += new System.EventHandler(this.SiparişDefteriToolStripMenuItem_Click);
            // 
            // SatışHareketleriToolStripMenuItem
            // 
            this.SatışHareketleriToolStripMenuItem.Name = "SatışHareketleriToolStripMenuItem";
            this.SatışHareketleriToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.SatışHareketleriToolStripMenuItem.Text = "Satış Hareketleri";
            this.SatışHareketleriToolStripMenuItem.Click += new System.EventHandler(this.SatışHareketleriToolStripMenuItem_Click);
            // 
            // ÖzelEtiketYazToolStripMenuItem
            // 
            this.ÖzelEtiketYazToolStripMenuItem.Name = "ÖzelEtiketYazToolStripMenuItem";
            this.ÖzelEtiketYazToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ÖzelEtiketYazToolStripMenuItem.Text = "Özel Etiket Yaz";
            this.ÖzelEtiketYazToolStripMenuItem.Click += new System.EventHandler(this.ÖzelEtiketYazToolStripMenuItem_Click);
            // 
            // SatışSilToolStripMenuItem
            // 
            this.SatışSilToolStripMenuItem.Name = "SatışSilToolStripMenuItem";
            this.SatışSilToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.SatışSilToolStripMenuItem.Text = "İade / Satış Sil";
            this.SatışSilToolStripMenuItem.Click += new System.EventHandler(this.SatışSilToolStripMenuItem_Click);
            // 
            // ÜrünlerToolStripMenuItem
            // 
            this.ÜrünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniÜrünEkleToolStripMenuItem,
            this.ÜrünleriListeleToolStripMenuItem,
            this.ÜrünGüncelleToolStripMenuItem,
            this.ÜrünSilToolStripMenuItem});
            this.ÜrünlerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ÜrünlerToolStripMenuItem.Name = "ÜrünlerToolStripMenuItem";
            this.ÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.ÜrünlerToolStripMenuItem.Text = "ÜRÜNLER";
            // 
            // YeniÜrünEkleToolStripMenuItem
            // 
            this.YeniÜrünEkleToolStripMenuItem.Name = "YeniÜrünEkleToolStripMenuItem";
            this.YeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.YeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            this.YeniÜrünEkleToolStripMenuItem.Click += new System.EventHandler(this.YeniÜrünEkleToolStripMenuItem_Click);
            // 
            // ÜrünleriListeleToolStripMenuItem
            // 
            this.ÜrünleriListeleToolStripMenuItem.Name = "ÜrünleriListeleToolStripMenuItem";
            this.ÜrünleriListeleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.ÜrünleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            this.ÜrünleriListeleToolStripMenuItem.Click += new System.EventHandler(this.ÜrünleriListeleToolStripMenuItem_Click);
            // 
            // ÜrünGüncelleToolStripMenuItem
            // 
            this.ÜrünGüncelleToolStripMenuItem.Name = "ÜrünGüncelleToolStripMenuItem";
            this.ÜrünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.ÜrünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            this.ÜrünGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ÜrünGüncelleToolStripMenuItem_Click);
            // 
            // ÜrünSilToolStripMenuItem
            // 
            this.ÜrünSilToolStripMenuItem.Name = "ÜrünSilToolStripMenuItem";
            this.ÜrünSilToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.ÜrünSilToolStripMenuItem.Text = "Ürün Sil";
            this.ÜrünSilToolStripMenuItem.Click += new System.EventHandler(this.ÜrünSilToolStripMenuItem_Click);
            // 
            // AlımlarToolStripMenuItem
            // 
            this.AlımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniAlımToolStripMenuItem,
            this.AlımHareketleriToolStripMenuItem});
            this.AlımlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.AlımlarToolStripMenuItem.Name = "AlımlarToolStripMenuItem";
            this.AlımlarToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.AlımlarToolStripMenuItem.Text = "ALIMLAR";
            // 
            // YeniAlımToolStripMenuItem
            // 
            this.YeniAlımToolStripMenuItem.Name = "YeniAlımToolStripMenuItem";
            this.YeniAlımToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.YeniAlımToolStripMenuItem.Text = "Yeni Alım ";
            this.YeniAlımToolStripMenuItem.Click += new System.EventHandler(this.YeniAlımToolStripMenuItem_Click);
            // 
            // AlımHareketleriToolStripMenuItem
            // 
            this.AlımHareketleriToolStripMenuItem.Name = "AlımHareketleriToolStripMenuItem";
            this.AlımHareketleriToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.AlımHareketleriToolStripMenuItem.Text = "Alım Hareketleri";
            this.AlımHareketleriToolStripMenuItem.Click += new System.EventHandler(this.AlımHareketleriToolStripMenuItem_Click);
            // 
            // RaporlarToolStripMenuItem
            // 
            this.RaporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SatışRakamlarıToolStripMenuItem,
            this.AlımRakamlarıToolStripMenuItem});
            this.RaporlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem";
            this.RaporlarToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.RaporlarToolStripMenuItem.Text = "RAPORLAR";
            // 
            // SatışRakamlarıToolStripMenuItem
            // 
            this.SatışRakamlarıToolStripMenuItem.Name = "SatışRakamlarıToolStripMenuItem";
            this.SatışRakamlarıToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.SatışRakamlarıToolStripMenuItem.Text = "Satış Rakamları";
            // 
            // AlımRakamlarıToolStripMenuItem
            // 
            this.AlımRakamlarıToolStripMenuItem.Name = "AlımRakamlarıToolStripMenuItem";
            this.AlımRakamlarıToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.AlımRakamlarıToolStripMenuItem.Text = "Alım Rakamları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(1103, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bugünkü Satış Sayısı:";
            // 
            // siparişGüncelleToolStripMenuItem
            // 
            this.siparişGüncelleToolStripMenuItem.Name = "siparişGüncelleToolStripMenuItem";
            this.siparişGüncelleToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.siparişGüncelleToolStripMenuItem.Text = "Sipariş Güncelle";
            this.siparişGüncelleToolStripMenuItem.Click += new System.EventHandler(this.siparişGüncelleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SoftArtHome - Anasayfa";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anamenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SatışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YeniSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SiparişDefteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SatışHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÖzelEtiketYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YeniÜrünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÜrünleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÜrünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÜrünSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YeniAlımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlımHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RaporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SatışRakamlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlımRakamlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SatışSilToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem siparişGüncelleToolStripMenuItem;
    }
}

