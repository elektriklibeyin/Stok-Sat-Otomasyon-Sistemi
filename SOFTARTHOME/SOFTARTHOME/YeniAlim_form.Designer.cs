namespace SOFTARTHOME
{
    partial class YeniAlim_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniAlim_form));
            this.arama_tbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ürün_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ürün_tam_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokadet_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boyut_tbox = new System.Windows.Forms.TextBox();
            this.renk_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tamad_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.alimnotu_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alimadet_numeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.alimtutari_tbox = new System.Windows.Forms.TextBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
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
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimadet_numeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arama_tbox
            // 
            this.arama_tbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arama_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_tbox.Location = new System.Drawing.Point(47, 58);
            this.arama_tbox.Name = "arama_tbox";
            this.arama_tbox.Size = new System.Drawing.Size(430, 24);
            this.arama_tbox.TabIndex = 1;
            this.arama_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arama_tbox.TextChanged += new System.EventHandler(this.arama_tbox_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ürün_ad,
            this.ürün_tam_ad});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 150);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "Ürün ID";
            this.id.Width = 65;
            // 
            // ürün_ad
            // 
            this.ürün_ad.Text = "Ürün Adı:";
            this.ürün_ad.Width = 120;
            // 
            // ürün_tam_ad
            // 
            this.ürün_tam_ad.Text = "Ürün Tam Adı:";
            this.ürün_tam_ad.Width = 240;
            // 
            // stokadet_tbox
            // 
            this.stokadet_tbox.Enabled = false;
            this.stokadet_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokadet_tbox.Location = new System.Drawing.Point(1138, 258);
            this.stokadet_tbox.Name = "stokadet_tbox";
            this.stokadet_tbox.Size = new System.Drawing.Size(120, 22);
            this.stokadet_tbox.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(1135, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 118;
            this.label8.Text = "Stokta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1134, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 117;
            this.label7.Text = "Boyut:";
            // 
            // boyut_tbox
            // 
            this.boyut_tbox.Enabled = false;
            this.boyut_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boyut_tbox.Location = new System.Drawing.Point(1138, 208);
            this.boyut_tbox.Name = "boyut_tbox";
            this.boyut_tbox.Size = new System.Drawing.Size(120, 22);
            this.boyut_tbox.TabIndex = 116;
            // 
            // renk_tbox
            // 
            this.renk_tbox.Enabled = false;
            this.renk_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renk_tbox.Location = new System.Drawing.Point(1138, 159);
            this.renk_tbox.Name = "renk_tbox";
            this.renk_tbox.Size = new System.Drawing.Size(120, 22);
            this.renk_tbox.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1134, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 114;
            this.label1.Text = "Renk:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(811, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // tamad_tbox
            // 
            this.tamad_tbox.Enabled = false;
            this.tamad_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamad_tbox.Location = new System.Drawing.Point(177, 274);
            this.tamad_tbox.Name = "tamad_tbox";
            this.tamad_tbox.Size = new System.Drawing.Size(300, 26);
            this.tamad_tbox.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(807, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Alımı Yapılacak Ürünün Özellikleri;";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 424);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 24);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(56, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 124;
            this.label5.Text = "Alım Tarihi:";
            // 
            // alimnotu_tbox
            // 
            this.alimnotu_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alimnotu_tbox.Location = new System.Drawing.Point(177, 474);
            this.alimnotu_tbox.Multiline = true;
            this.alimnotu_tbox.Name = "alimnotu_tbox";
            this.alimnotu_tbox.Size = new System.Drawing.Size(300, 45);
            this.alimnotu_tbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(58, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 122;
            this.label4.Text = "Alım Adeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(62, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 121;
            this.label3.Text = "Alım Notu:";
            // 
            // alimadet_numeric
            // 
            this.alimadet_numeric.Enabled = false;
            this.alimadet_numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alimadet_numeric.Location = new System.Drawing.Point(177, 324);
            this.alimadet_numeric.Name = "alimadet_numeric";
            this.alimadet_numeric.Size = new System.Drawing.Size(80, 26);
            this.alimadet_numeric.TabIndex = 3;
            this.alimadet_numeric.ValueChanged += new System.EventHandler(this.alimadet_numeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(54, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 126;
            this.label6.Text = "Alım Tutarı:";
            // 
            // alimtutari_tbox
            // 
            this.alimtutari_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alimtutari_tbox.Location = new System.Drawing.Point(177, 374);
            this.alimtutari_tbox.Name = "alimtutari_tbox";
            this.alimtutari_tbox.Size = new System.Drawing.Size(100, 26);
            this.alimtutari_tbox.TabIndex = 4;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kaydetbtn.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbtn.Location = new System.Drawing.Point(60, 577);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(700, 50);
            this.kaydetbtn.TabIndex = 7;
            this.kaydetbtn.Text = "Alımı Gerçekleştir.";
            this.kaydetbtn.UseVisualStyleBackColor = false;
            this.kaydetbtn.Visible = false;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
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
            this.menuStrip1.TabIndex = 127;
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
            this.YeniAlımToolStripMenuItem.Text = "Yeni Alım ";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(45, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 20);
            this.label17.TabIndex = 139;
            this.label17.Text = "Alınan Ürün:";
            // 
            // YeniAlim_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.alimtutari_tbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alimnotu_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alimadet_numeric);
            this.Controls.Add(this.stokadet_tbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boyut_tbox);
            this.Controls.Add(this.renk_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tamad_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arama_tbox);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YeniAlim_form";
            this.Text = "SoftArtHome - Yeni Ürün Alımı";
            this.Load += new System.EventHandler(this.YeniAlim_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimadet_numeric)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arama_tbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader ürün_ad;
        private System.Windows.Forms.ColumnHeader ürün_tam_ad;
        private System.Windows.Forms.TextBox stokadet_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boyut_tbox;
        private System.Windows.Forms.TextBox renk_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tamad_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alimnotu_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown alimadet_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alimtutari_tbox;
        private System.Windows.Forms.Button kaydetbtn;
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
        private System.Windows.Forms.ToolStripMenuItem iadeSatışSilToolStripMenuItem;
        private System.Windows.Forms.Label label17;
    }
}