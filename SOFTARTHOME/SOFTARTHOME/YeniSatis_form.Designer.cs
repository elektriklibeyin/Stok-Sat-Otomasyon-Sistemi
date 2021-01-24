namespace SOFTARTHOME
{
    partial class YeniSatis_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniSatis_form));
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
            this.satisnot_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.satisadet_numeric = new System.Windows.Forms.NumericUpDown();
            this.odemeyontemi_cbox = new System.Windows.Forms.ComboBox();
            this.satiskanali_cbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.aliciad_tbox = new System.Windows.Forms.TextBox();
            this.aliciadres_tbox = new System.Windows.Forms.TextBox();
            this.alicitel_tbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.satisfiyati_tbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fiyatsatis_tbox = new System.Windows.Forms.TextBox();
            this.fiyattrend_tbox = new System.Windows.Forms.TextBox();
            this.fiyattoptan_tbox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.satisadet_numeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arama_tbox
            // 
            this.arama_tbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arama_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_tbox.Location = new System.Drawing.Point(41, 64);
            this.arama_tbox.Name = "arama_tbox";
            this.arama_tbox.Size = new System.Drawing.Size(440, 24);
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
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 120);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "ÜrünID";
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
            this.ürün_tam_ad.Width = 250;
            // 
            // stokadet_tbox
            // 
            this.stokadet_tbox.Enabled = false;
            this.stokadet_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokadet_tbox.Location = new System.Drawing.Point(958, 405);
            this.stokadet_tbox.Name = "stokadet_tbox";
            this.stokadet_tbox.Size = new System.Drawing.Size(120, 22);
            this.stokadet_tbox.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(955, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 109;
            this.label8.Text = "Stokta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(954, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 108;
            this.label7.Text = "Boyut:";
            // 
            // boyut_tbox
            // 
            this.boyut_tbox.Enabled = false;
            this.boyut_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boyut_tbox.Location = new System.Drawing.Point(958, 355);
            this.boyut_tbox.Name = "boyut_tbox";
            this.boyut_tbox.Size = new System.Drawing.Size(120, 22);
            this.boyut_tbox.TabIndex = 107;
            // 
            // renk_tbox
            // 
            this.renk_tbox.Enabled = false;
            this.renk_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renk_tbox.Location = new System.Drawing.Point(958, 306);
            this.renk_tbox.Name = "renk_tbox";
            this.renk_tbox.Size = new System.Drawing.Size(120, 22);
            this.renk_tbox.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(954, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 105;
            this.label1.Text = "Renk:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(958, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // tamad_tbox
            // 
            this.tamad_tbox.Enabled = false;
            this.tamad_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamad_tbox.Location = new System.Drawing.Point(181, 239);
            this.tamad_tbox.Name = "tamad_tbox";
            this.tamad_tbox.Size = new System.Drawing.Size(300, 26);
            this.tamad_tbox.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(956, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Satışı Yapılacak Ürünün Özellikleri;";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(629, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(512, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Satış Tarihi:";
            // 
            // satisnot_tbox
            // 
            this.satisnot_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisnot_tbox.Location = new System.Drawing.Point(629, 192);
            this.satisnot_tbox.Multiline = true;
            this.satisnot_tbox.Name = "satisnot_tbox";
            this.satisnot_tbox.Size = new System.Drawing.Size(250, 40);
            this.satisnot_tbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(66, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Satış Adeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(518, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Satış Notu:";
            // 
            // satisadet_numeric
            // 
            this.satisadet_numeric.Enabled = false;
            this.satisadet_numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisadet_numeric.Location = new System.Drawing.Point(181, 279);
            this.satisadet_numeric.Name = "satisadet_numeric";
            this.satisadet_numeric.Size = new System.Drawing.Size(80, 26);
            this.satisadet_numeric.TabIndex = 3;
            this.satisadet_numeric.ValueChanged += new System.EventHandler(this.satisadet_numeric_ValueChanged);
            // 
            // odemeyontemi_cbox
            // 
            this.odemeyontemi_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeyontemi_cbox.FormattingEnabled = true;
            this.odemeyontemi_cbox.Items.AddRange(new object[] {
            "KAPIDA ÖDEME",
            "EFT-HAVALE",
            "KREDİ KARTI",
            "DİĞER"});
            this.odemeyontemi_cbox.Location = new System.Drawing.Point(180, 399);
            this.odemeyontemi_cbox.Name = "odemeyontemi_cbox";
            this.odemeyontemi_cbox.Size = new System.Drawing.Size(180, 24);
            this.odemeyontemi_cbox.TabIndex = 6;
            // 
            // satiskanali_cbox
            // 
            this.satiskanali_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satiskanali_cbox.FormattingEnabled = true;
            this.satiskanali_cbox.Items.AddRange(new object[] {
            "SOFTARTHOME",
            "VİVENSE\t",
            "HEPSİBURADA",
            "TRENDYOL",
            "N11",
            "EPTTAVM",
            "ÇİÇEKSEPETİ",
            "AMAZON.COM",
            "AMAZON.DE",
            "AMAZON.CO.UK",
            "TOPTAN"});
            this.satiskanali_cbox.Location = new System.Drawing.Point(181, 319);
            this.satiskanali_cbox.Name = "satiskanali_cbox";
            this.satiskanali_cbox.Size = new System.Drawing.Size(180, 24);
            this.satiskanali_cbox.TabIndex = 4;
            this.satiskanali_cbox.TextChanged += new System.EventHandler(this.satiskanali_cbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(59, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 119;
            this.label6.Text = "Satış Kanalı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(26, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 120;
            this.label9.Text = "Ödeme Yöntemi:";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kaydetbtn.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kaydetbtn.Location = new System.Drawing.Point(499, 534);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(600, 50);
            this.kaydetbtn.TabIndex = 11;
            this.kaydetbtn.Text = "Satışı Gerçekleştir.";
            this.kaydetbtn.UseVisualStyleBackColor = false;
            this.kaydetbtn.Visible = false;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // aliciad_tbox
            // 
            this.aliciad_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciad_tbox.Location = new System.Drawing.Point(90, 28);
            this.aliciad_tbox.Name = "aliciad_tbox";
            this.aliciad_tbox.Size = new System.Drawing.Size(281, 24);
            this.aliciad_tbox.TabIndex = 8;
            // 
            // aliciadres_tbox
            // 
            this.aliciadres_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciadres_tbox.Location = new System.Drawing.Point(91, 97);
            this.aliciadres_tbox.Multiline = true;
            this.aliciadres_tbox.Name = "aliciadres_tbox";
            this.aliciadres_tbox.Size = new System.Drawing.Size(280, 65);
            this.aliciadres_tbox.TabIndex = 10;
            // 
            // alicitel_tbox
            // 
            this.alicitel_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alicitel_tbox.Location = new System.Drawing.Point(90, 63);
            this.alicitel_tbox.Name = "alicitel_tbox";
            this.alicitel_tbox.Size = new System.Drawing.Size(281, 24);
            this.alicitel_tbox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(48, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 125;
            this.label10.Text = "Ad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(23, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 126;
            this.label11.Text = "Adres:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(46, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 127;
            this.label12.Text = "Tel:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aliciad_tbox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.aliciadres_tbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.alicitel_tbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(41, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcının";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(63, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 129;
            this.label13.Text = "Satış Fiyatı:";
            // 
            // satisfiyati_tbox
            // 
            this.satisfiyati_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisfiyati_tbox.Location = new System.Drawing.Point(180, 359);
            this.satisfiyati_tbox.Name = "satisfiyati_tbox";
            this.satisfiyati_tbox.Size = new System.Drawing.Size(100, 24);
            this.satisfiyati_tbox.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(1134, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 18);
            this.label14.TabIndex = 131;
            this.label14.Text = "Satış Fiyatı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(1134, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 18);
            this.label15.TabIndex = 132;
            this.label15.Text = "Trendyol Fiyatı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(1134, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
            this.label16.TabIndex = 133;
            this.label16.Text = "Toptan Fiyatı:";
            // 
            // fiyatsatis_tbox
            // 
            this.fiyatsatis_tbox.Enabled = false;
            this.fiyatsatis_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatsatis_tbox.Location = new System.Drawing.Point(1137, 306);
            this.fiyatsatis_tbox.Name = "fiyatsatis_tbox";
            this.fiyatsatis_tbox.Size = new System.Drawing.Size(120, 22);
            this.fiyatsatis_tbox.TabIndex = 134;
            this.fiyatsatis_tbox.Text = "0";
            // 
            // fiyattrend_tbox
            // 
            this.fiyattrend_tbox.Enabled = false;
            this.fiyattrend_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyattrend_tbox.Location = new System.Drawing.Point(1137, 355);
            this.fiyattrend_tbox.Name = "fiyattrend_tbox";
            this.fiyattrend_tbox.Size = new System.Drawing.Size(120, 22);
            this.fiyattrend_tbox.TabIndex = 135;
            this.fiyattrend_tbox.Text = "0";
            // 
            // fiyattoptan_tbox
            // 
            this.fiyattoptan_tbox.Enabled = false;
            this.fiyattoptan_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyattoptan_tbox.Location = new System.Drawing.Point(1137, 405);
            this.fiyattoptan_tbox.Name = "fiyattoptan_tbox";
            this.fiyattoptan_tbox.Size = new System.Drawing.Size(120, 22);
            this.fiyattoptan_tbox.TabIndex = 136;
            this.fiyattoptan_tbox.Text = "0";
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
            this.menuStrip1.TabIndex = 137;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(54, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 20);
            this.label17.TabIndex = 138;
            this.label17.Text = "Satılan Ürün:";
            // 
            // YeniSatis_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fiyattoptan_tbox);
            this.Controls.Add(this.fiyattrend_tbox);
            this.Controls.Add(this.fiyatsatis_tbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.satisfiyati_tbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.satiskanali_cbox);
            this.Controls.Add(this.odemeyontemi_cbox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.satisnot_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.satisadet_numeric);
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
            this.Name = "YeniSatis_form";
            this.Text = "SoftArtHome - Ürün Satış";
            this.Load += new System.EventHandler(this.YeniSatis_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisadet_numeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox satisnot_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown satisadet_numeric;
        private System.Windows.Forms.ComboBox odemeyontemi_cbox;
        private System.Windows.Forms.ComboBox satiskanali_cbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.TextBox aliciad_tbox;
        private System.Windows.Forms.TextBox aliciadres_tbox;
        private System.Windows.Forms.TextBox alicitel_tbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox satisfiyati_tbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox fiyatsatis_tbox;
        private System.Windows.Forms.TextBox fiyattrend_tbox;
        private System.Windows.Forms.TextBox fiyattoptan_tbox;
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