namespace SOFTARTHOME
{
    partial class ÜrünSil_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünSil_form));
            this.arama_tbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ürün_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ürün_tam_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ürün_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.silbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anamenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YeniSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparişDefteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÖzelEtiketYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iadeSatışSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arama_tbox
            // 
            this.arama_tbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arama_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_tbox.Location = new System.Drawing.Point(861, 52);
            this.arama_tbox.Name = "arama_tbox";
            this.arama_tbox.Size = new System.Drawing.Size(400, 24);
            this.arama_tbox.TabIndex = 26;
            this.arama_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arama_tbox.TextChanged += new System.EventHandler(this.arama_tbox_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ürün_id,
            this.Ürün_Ad,
            this.ürün_tam_ad});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(861, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 550);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // ürün_id
            // 
            this.ürün_id.Text = "ÜrünID";
            // 
            // ürün_tam_ad
            // 
            this.ürün_tam_ad.Text = "Ürün Tam Adı:";
            this.ürün_tam_ad.Width = 200;
            // 
            // Ürün_Ad
            // 
            this.Ürün_Ad.Text = "Ürün Ad:";
            this.Ürün_Ad.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(58, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(58, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(58, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(58, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(58, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(58, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(58, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(58, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(58, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "------";
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silbtn.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbtn.Location = new System.Drawing.Point(62, 570);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(400, 40);
            this.silbtn.TabIndex = 46;
            this.silbtn.Text = "Seçili Ürünü Sil";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
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
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anamenuToolStripMenuItem
            // 
            this.anamenuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anamenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.anamenuToolStripMenuItem.Name = "anamenuToolStripMenuItem";
            this.anamenuToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.anamenuToolStripMenuItem.Text = "ANA SAYFA";
            this.anamenuToolStripMenuItem.Click += new System.EventHandler(this.anamenuToolStripMenuItem_Click);
            // 
            // SatışlarToolStripMenuItem
            // 
            this.SatışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniSatışToolStripMenuItem,
            this.SiparişDefteriToolStripMenuItem,
            this.SatışHareketleriToolStripMenuItem,
            this.ÖzelEtiketYazToolStripMenuItem,
            this.iadeSatışSilToolStripMenuItem});
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
            // 
            // SiparişDefteriToolStripMenuItem
            // 
            this.SiparişDefteriToolStripMenuItem.Name = "SiparişDefteriToolStripMenuItem";
            this.SiparişDefteriToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.SiparişDefteriToolStripMenuItem.Text = "Sipariş Defteri";
            // 
            // SatışHareketleriToolStripMenuItem
            // 
            this.SatışHareketleriToolStripMenuItem.Name = "SatışHareketleriToolStripMenuItem";
            this.SatışHareketleriToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.SatışHareketleriToolStripMenuItem.Text = "Satış Hareketleri";
            // 
            // ÖzelEtiketYazToolStripMenuItem
            // 
            this.ÖzelEtiketYazToolStripMenuItem.Name = "ÖzelEtiketYazToolStripMenuItem";
            this.ÖzelEtiketYazToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ÖzelEtiketYazToolStripMenuItem.Text = "Özel Etiket Yaz";
            // 
            // iadeSatışSilToolStripMenuItem
            // 
            this.iadeSatışSilToolStripMenuItem.Name = "iadeSatışSilToolStripMenuItem";
            this.iadeSatışSilToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.iadeSatışSilToolStripMenuItem.Text = "İade / Satış Sil";
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
            // 
            // ÜrünleriListeleToolStripMenuItem
            // 
            this.ÜrünleriListeleToolStripMenuItem.Name = "ÜrünleriListeleToolStripMenuItem";
            this.ÜrünleriListeleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.ÜrünleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            // 
            // ÜrünGüncelleToolStripMenuItem
            // 
            this.ÜrünGüncelleToolStripMenuItem.Name = "ÜrünGüncelleToolStripMenuItem";
            this.ÜrünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.ÜrünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            // 
            // ÜrünSilToolStripMenuItem
            // 
            this.ÜrünSilToolStripMenuItem.Name = "ÜrünSilToolStripMenuItem";
            this.ÜrünSilToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.ÜrünSilToolStripMenuItem.Text = "Ürün Sil";
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
            this.YeniAlımToolStripMenuItem.Text = "Yeni Alım";
            // 
            // AlımHareketleriToolStripMenuItem
            // 
            this.AlımHareketleriToolStripMenuItem.Name = "AlımHareketleriToolStripMenuItem";
            this.AlımHareketleriToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.AlımHareketleriToolStripMenuItem.Text = "Alım Hareketleri";
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
            // ÜrünSil_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arama_tbox);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÜrünSil_form";
            this.Text = "SoftArtHome - !! Ürün Silme !!";
            this.Load += new System.EventHandler(this.ÜrünSil_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox arama_tbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ürün_id;
        private System.Windows.Forms.ColumnHeader ürün_tam_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button silbtn;
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
        private System.Windows.Forms.ColumnHeader Ürün_Ad;
        private System.Windows.Forms.ToolStripMenuItem iadeSatışSilToolStripMenuItem;
    }
}