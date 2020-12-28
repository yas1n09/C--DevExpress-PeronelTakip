namespace PersonelTakip
{
    partial class frmMesaiIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaiIslemleri));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMesaiID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelID = new DevExpress.XtraEditors.TextEdit();
            this.cbDonemAy = new System.Windows.Forms.ComboBox();
            this.cbDonemYil = new System.Windows.Forms.ComboBox();
            this.txtDonem = new DevExpress.XtraEditors.TextEdit();
            this.txtMesaiTarih = new System.Windows.Forms.TextBox();
            this.dtpMesaiTarih = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lvMesai = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCikisDakika = new System.Windows.Forms.ComboBox();
            this.cbCikisSaat = new System.Windows.Forms.ComboBox();
            this.cbGirisDakika = new System.Windows.Forms.ComboBox();
            this.cbGirisSaat = new System.Windows.Forms.ComboBox();
            this.txtCikis = new System.Windows.Forms.TextBox();
            this.txtGiris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaiID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mesai Günü:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Dönem:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Personel ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Adı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Soyadı:";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Enabled = false;
            this.txtMesaiID.Location = new System.Drawing.Point(12, 178);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(19, 20);
            this.txtMesaiID.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Giriş Saati:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 232);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Çıkış Saati:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(83, 124);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 14;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(83, 155);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 15;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Location = new System.Drawing.Point(83, 94);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(58, 20);
            this.txtPersonelID.TabIndex = 16;
            // 
            // cbDonemAy
            // 
            this.cbDonemAy.FormattingEnabled = true;
            this.cbDonemAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbDonemAy.Location = new System.Drawing.Point(83, 67);
            this.cbDonemAy.Name = "cbDonemAy";
            this.cbDonemAy.Size = new System.Drawing.Size(38, 21);
            this.cbDonemAy.TabIndex = 55;
            this.cbDonemAy.SelectedIndexChanged += new System.EventHandler(this.cbDonemAy_SelectedIndexChanged);
            // 
            // cbDonemYil
            // 
            this.cbDonemYil.FormattingEnabled = true;
            this.cbDonemYil.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbDonemYil.Location = new System.Drawing.Point(127, 67);
            this.cbDonemYil.Name = "cbDonemYil";
            this.cbDonemYil.Size = new System.Drawing.Size(56, 21);
            this.cbDonemYil.TabIndex = 56;
            this.cbDonemYil.SelectedIndexChanged += new System.EventHandler(this.cbDonemYil_SelectedIndexChanged);
            // 
            // txtDonem
            // 
            this.txtDonem.Enabled = false;
            this.txtDonem.Location = new System.Drawing.Point(83, 36);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(58, 20);
            this.txtDonem.TabIndex = 57;
            this.txtDonem.TextChanged += new System.EventHandler(this.txtDonem_TextChanged);
            // 
            // txtMesaiTarih
            // 
            this.txtMesaiTarih.Location = new System.Drawing.Point(83, -1);
            this.txtMesaiTarih.Name = "txtMesaiTarih";
            this.txtMesaiTarih.ReadOnly = true;
            this.txtMesaiTarih.Size = new System.Drawing.Size(86, 21);
            this.txtMesaiTarih.TabIndex = 58;
            this.txtMesaiTarih.TextChanged += new System.EventHandler(this.txtMesaiTarih_TextChanged);
            // 
            // dtpMesaiTarih
            // 
            this.dtpMesaiTarih.Location = new System.Drawing.Point(164, -1);
            this.dtpMesaiTarih.Name = "dtpMesaiTarih";
            this.dtpMesaiTarih.Size = new System.Drawing.Size(19, 21);
            this.dtpMesaiTarih.TabIndex = 59;
            this.dtpMesaiTarih.ValueChanged += new System.EventHandler(this.dtpMesaiTarih_ValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(248, -1);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "PERSONEL LİSTESİ";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(474, -1);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(330, 13);
            this.labelControl9.TabIndex = 60;
            this.labelControl9.Text = "*Lütfen mesai eklemek istediğiniz personeli listeden tıklayarak seçiniz.";
            // 
            // lvPersonel
            // 
            this.lvPersonel.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvPersonel.BackColor = System.Drawing.Color.White;
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.HideSelection = false;
            this.lvPersonel.Location = new System.Drawing.Point(248, 34);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(580, 183);
            this.lvPersonel.TabIndex = 61;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyadı";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 63;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adres";
            this.columnHeader6.Width = 78;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(1, 312);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(208, 23);
            this.btnGetir.TabIndex = 62;
            this.btnGetir.Text = "Personelin Tüm Mesailerini Getir";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(1, 342);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(101, 36);
            this.btnYeni.TabIndex = 63;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(108, 342);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(101, 36);
            this.btnDegistir.TabIndex = 64;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1, 384);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 36);
            this.btnKaydet.TabIndex = 65;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(108, 384);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 36);
            this.btnSil.TabIndex = 66;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(248, 279);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 13);
            this.labelControl10.TabIndex = 67;
            this.labelControl10.Text = "PERSONEL LİSTESİ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(610, 279);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(194, 13);
            this.labelControl11.TabIndex = 68;
            this.labelControl11.Text = "*Silme işlemi için listeden personel seçiniz";
            // 
            // lvMesai
            // 
            this.lvMesai.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvMesai.BackColor = System.Drawing.Color.White;
            this.lvMesai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvMesai.FullRowSelect = true;
            this.lvMesai.HideSelection = false;
            this.lvMesai.Location = new System.Drawing.Point(248, 312);
            this.lvMesai.Name = "lvMesai";
            this.lvMesai.Size = new System.Drawing.Size(580, 144);
            this.lvMesai.TabIndex = 69;
            this.lvMesai.UseCompatibleStateImageBehavior = false;
            this.lvMesai.View = System.Windows.Forms.View.Details;
            this.lvMesai.DoubleClick += new System.EventHandler(this.lvMesai_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MesaiID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mesai Tarih";
            this.columnHeader10.Width = 113;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ad";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Soyad";
            this.columnHeader12.Width = 69;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Giriş Saat";
            this.columnHeader13.Width = 76;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Çıkış Saat";
            this.columnHeader14.Width = 84;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Dönem";
            this.columnHeader15.Width = 183;
            // 
            // cbCikisDakika
            // 
            this.cbCikisDakika.FormattingEnabled = true;
            this.cbCikisDakika.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbCikisDakika.Location = new System.Drawing.Point(164, 228);
            this.cbCikisDakika.Name = "cbCikisDakika";
            this.cbCikisDakika.Size = new System.Drawing.Size(38, 21);
            this.cbCikisDakika.TabIndex = 73;
            this.cbCikisDakika.SelectedIndexChanged += new System.EventHandler(this.cbCikisDakika_SelectedIndexChanged);
            // 
            // cbCikisSaat
            // 
            this.cbCikisSaat.FormattingEnabled = true;
            this.cbCikisSaat.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbCikisSaat.Location = new System.Drawing.Point(120, 228);
            this.cbCikisSaat.Name = "cbCikisSaat";
            this.cbCikisSaat.Size = new System.Drawing.Size(38, 21);
            this.cbCikisSaat.TabIndex = 72;
            this.cbCikisSaat.SelectedIndexChanged += new System.EventHandler(this.cbCikisSaat_SelectedIndexChanged);
            // 
            // cbGirisDakika
            // 
            this.cbGirisDakika.FormattingEnabled = true;
            this.cbGirisDakika.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbGirisDakika.Location = new System.Drawing.Point(164, 201);
            this.cbGirisDakika.Name = "cbGirisDakika";
            this.cbGirisDakika.Size = new System.Drawing.Size(38, 21);
            this.cbGirisDakika.TabIndex = 71;
            this.cbGirisDakika.SelectedIndexChanged += new System.EventHandler(this.cbGirisDakika_SelectedIndexChanged);
            // 
            // cbGirisSaat
            // 
            this.cbGirisSaat.FormattingEnabled = true;
            this.cbGirisSaat.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbGirisSaat.Location = new System.Drawing.Point(120, 201);
            this.cbGirisSaat.Name = "cbGirisSaat";
            this.cbGirisSaat.Size = new System.Drawing.Size(38, 21);
            this.cbGirisSaat.TabIndex = 70;
            this.cbGirisSaat.SelectedIndexChanged += new System.EventHandler(this.cbGirisSaat_SelectedIndexChanged);
            // 
            // txtCikis
            // 
            this.txtCikis.BackColor = System.Drawing.Color.White;
            this.txtCikis.Location = new System.Drawing.Point(69, 228);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(45, 21);
            this.txtCikis.TabIndex = 75;
            // 
            // txtGiris
            // 
            this.txtGiris.BackColor = System.Drawing.Color.White;
            this.txtGiris.Location = new System.Drawing.Point(69, 202);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(45, 21);
            this.txtGiris.TabIndex = 74;
            // 
            // frmMesaiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 512);
            this.Controls.Add(this.txtCikis);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.cbCikisDakika);
            this.Controls.Add(this.cbCikisSaat);
            this.Controls.Add(this.cbGirisDakika);
            this.Controls.Add(this.cbGirisSaat);
            this.Controls.Add(this.lvMesai);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dtpMesaiTarih);
            this.Controls.Add(this.txtMesaiTarih);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.cbDonemYil);
            this.Controls.Add(this.cbDonemAy);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMesaiIslemleri.IconOptions.SvgImage")));
            this.Name = "frmMesaiIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai İşlemleri";
            this.Load += new System.EventHandler(this.frmMesaiIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaiID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMesaiID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtPersonelID;
        private System.Windows.Forms.ComboBox cbDonemAy;
        private System.Windows.Forms.ComboBox cbDonemYil;
        private DevExpress.XtraEditors.TextEdit txtDonem;
        private System.Windows.Forms.TextBox txtMesaiTarih;
        private System.Windows.Forms.DateTimePicker dtpMesaiTarih;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.ListView lvMesai;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ComboBox cbCikisDakika;
        private System.Windows.Forms.ComboBox cbCikisSaat;
        private System.Windows.Forms.ComboBox cbGirisDakika;
        private System.Windows.Forms.ComboBox cbGirisSaat;
        private System.Windows.Forms.TextBox txtCikis;
        private System.Windows.Forms.TextBox txtGiris;
    }
}