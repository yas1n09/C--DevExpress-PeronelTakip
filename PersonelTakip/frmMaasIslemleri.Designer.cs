namespace PersonelTakip
{
    partial class frmMaasIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaasIslemleri));
            this.lvMaaslar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvOdenenMaaslar = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHesapla = new DevExpress.XtraEditors.SimpleButton();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.txtPersonelID = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelAd = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtSabitMaas = new DevExpress.XtraEditors.TextEdit();
            this.txtFazlaMesai = new DevExpress.XtraEditors.TextEdit();
            this.txtEksikMesai = new DevExpress.XtraEditors.TextEdit();
            this.txtCalistigiGun = new DevExpress.XtraEditors.TextEdit();
            this.txtToplamMaas = new DevExpress.XtraEditors.TextEdit();
            this.txtOdenecekTutar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFazlaMesai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEksikMesai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalistigiGun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdenecekTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMaaslar
            // 
            this.lvMaaslar.BackColor = System.Drawing.Color.White;
            this.lvMaaslar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.lvMaaslar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvMaaslar.FullRowSelect = true;
            this.lvMaaslar.HideSelection = false;
            this.lvMaaslar.Location = new System.Drawing.Point(29, 38);
            this.lvMaaslar.Name = "lvMaaslar";
            this.lvMaaslar.Size = new System.Drawing.Size(662, 262);
            this.lvMaaslar.TabIndex = 141;
            this.lvMaaslar.UseCompatibleStateImageBehavior = false;
            this.lvMaaslar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PID";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dönem";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sabit Maaş";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fazla Mesai";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Eksik Mesai";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Toplam";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gün";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(34, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 150;
            this.label9.Text = "MAAŞLAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(25, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 151;
            this.label10.Text = "ÖDENMİŞ MAAŞLAR";
            // 
            // lvOdenenMaaslar
            // 
            this.lvOdenenMaaslar.BackColor = System.Drawing.Color.White;
            this.lvOdenenMaaslar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.lvOdenenMaaslar.FullRowSelect = true;
            this.lvOdenenMaaslar.HideSelection = false;
            this.lvOdenenMaaslar.Location = new System.Drawing.Point(29, 353);
            this.lvOdenenMaaslar.Name = "lvOdenenMaaslar";
            this.lvOdenenMaaslar.Size = new System.Drawing.Size(662, 256);
            this.lvOdenenMaaslar.TabIndex = 152;
            this.lvOdenenMaaslar.UseCompatibleStateImageBehavior = false;
            this.lvOdenenMaaslar.View = System.Windows.Forms.View.Details;
            this.lvOdenenMaaslar.DoubleClick += new System.EventHandler(this.lvOdenenMaaslar_DoubleClick);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Maaş ID";
            this.columnHeader16.Width = 66;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Personel ID";
            this.columnHeader17.Width = 85;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Dönem";
            this.columnHeader18.Width = 82;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Gün";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Hakedilen Maaş";
            this.columnHeader20.Width = 96;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Alacak";
            this.columnHeader21.Width = 93;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Borç";
            this.columnHeader22.Width = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(714, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 153;
            this.label11.Text = "PERSONEL LİSTESİ";
            // 
            // lvPersonel
            // 
            this.lvPersonel.BackColor = System.Drawing.Color.White;
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader15,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.HideSelection = false;
            this.lvPersonel.Location = new System.Drawing.Point(718, 38);
            this.lvPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(582, 262);
            this.lvPersonel.TabIndex = 154;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 37;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "IBAN";
            this.columnHeader15.Width = 154;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Personel Adı";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 86;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Personel Soyadı";
            this.columnHeader12.Width = 94;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Telefon";
            this.columnHeader13.Width = 93;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Adres";
            this.columnHeader14.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1149, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 155;
            this.pictureBox1.TabStop = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(753, 572);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(163, 36);
            this.btnHesapla.TabIndex = 156;
            this.btnHesapla.Text = "SİL";
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnOde
            // 
            this.btnOde.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Appearance.Options.UseFont = true;
            this.btnOde.Location = new System.Drawing.Point(945, 572);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(163, 36);
            this.btnOde.TabIndex = 157;
            this.btnOde.Text = "ÖDE";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(734, 353);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 158;
            this.labelControl1.Text = "Personal ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(734, 406);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 159;
            this.labelControl2.Text = "Personal Ad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(734, 461);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 162;
            this.labelControl3.Text = "Personel Soyad:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(942, 315);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 164;
            this.labelControl4.Text = "Dönem:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(923, 348);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 165;
            this.labelControl5.Text = "Sabit Maaş:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(871, 381);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(108, 13);
            this.labelControl6.TabIndex = 166;
            this.labelControl6.Text = "Fazladan Mesai Ücreti:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(881, 415);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 13);
            this.labelControl7.TabIndex = 167;
            this.labelControl7.Text = "Eksik Mesai Kesintisi:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(887, 448);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 13);
            this.labelControl8.TabIndex = 168;
            this.labelControl8.Text = "Çalıştığı Gün Sayısı:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(913, 480);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 13);
            this.labelControl9.TabIndex = 169;
            this.labelControl9.Text = "Toplam Maaş:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(898, 526);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 13);
            this.labelControl10.TabIndex = 170;
            this.labelControl10.Text = "Ödenecek Tutar:";
            // 
            // cbDonem
            // 
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Items.AddRange(new object[] {
            "10/2016",
            "11/2016",
            "12/2016"});
            this.cbDonem.Location = new System.Drawing.Point(1007, 312);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(101, 21);
            this.cbDonem.TabIndex = 171;
            this.cbDonem.SelectedIndexChanged += new System.EventHandler(this.cbDonem_SelectedIndexChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(734, 372);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelID.TabIndex = 172;
            this.txtPersonelID.EditValueChanged += new System.EventHandler(this.txtPersonelID_EditValueChanged);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(734, 425);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAd.TabIndex = 173;
            this.txtPersonelAd.EditValueChanged += new System.EventHandler(this.txtPersonelAd_EditValueChanged);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(734, 480);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelSoyad.TabIndex = 174;
            this.txtPersonelSoyad.EditValueChanged += new System.EventHandler(this.txtPersonelSoyad_EditValueChanged);
            // 
            // txtSabitMaas
            // 
            this.txtSabitMaas.Location = new System.Drawing.Point(1007, 350);
            this.txtSabitMaas.Name = "txtSabitMaas";
            this.txtSabitMaas.Size = new System.Drawing.Size(100, 20);
            this.txtSabitMaas.TabIndex = 175;
            // 
            // txtFazlaMesai
            // 
            this.txtFazlaMesai.Location = new System.Drawing.Point(1007, 378);
            this.txtFazlaMesai.Name = "txtFazlaMesai";
            this.txtFazlaMesai.Size = new System.Drawing.Size(100, 20);
            this.txtFazlaMesai.TabIndex = 176;
            // 
            // txtEksikMesai
            // 
            this.txtEksikMesai.Location = new System.Drawing.Point(1007, 412);
            this.txtEksikMesai.Name = "txtEksikMesai";
            this.txtEksikMesai.Size = new System.Drawing.Size(100, 20);
            this.txtEksikMesai.TabIndex = 177;
            // 
            // txtCalistigiGun
            // 
            this.txtCalistigiGun.Location = new System.Drawing.Point(1007, 445);
            this.txtCalistigiGun.Name = "txtCalistigiGun";
            this.txtCalistigiGun.Size = new System.Drawing.Size(100, 20);
            this.txtCalistigiGun.TabIndex = 178;
            // 
            // txtToplamMaas
            // 
            this.txtToplamMaas.Location = new System.Drawing.Point(1007, 477);
            this.txtToplamMaas.Name = "txtToplamMaas";
            this.txtToplamMaas.Size = new System.Drawing.Size(100, 20);
            this.txtToplamMaas.TabIndex = 179;
            // 
            // txtOdenecekTutar
            // 
            this.txtOdenecekTutar.Location = new System.Drawing.Point(1007, 523);
            this.txtOdenecekTutar.Name = "txtOdenecekTutar";
            this.txtOdenecekTutar.Size = new System.Drawing.Size(100, 20);
            this.txtOdenecekTutar.TabIndex = 180;
            // 
            // frmMaasIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 655);
            this.Controls.Add(this.txtOdenecekTutar);
            this.Controls.Add(this.txtToplamMaas);
            this.Controls.Add(this.txtCalistigiGun);
            this.Controls.Add(this.txtEksikMesai);
            this.Controls.Add(this.txtFazlaMesai);
            this.Controls.Add(this.txtSabitMaas);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.cbDonem);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lvOdenenMaaslar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvMaaslar);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMaasIslemleri.IconOptions.SvgImage")));
            this.Name = "frmMaasIslemleri";
            this.Text = "Maaş İşlemleri";
            this.Load += new System.EventHandler(this.frmMaasIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFazlaMesai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEksikMesai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalistigiGun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdenecekTutar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMaaslar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvOdenenMaaslar;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnHesapla;
        private DevExpress.XtraEditors.SimpleButton btnOde;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox cbDonem;
        private DevExpress.XtraEditors.TextEdit txtPersonelID;
        private DevExpress.XtraEditors.TextEdit txtPersonelAd;
        private DevExpress.XtraEditors.TextEdit txtPersonelSoyad;
        private DevExpress.XtraEditors.TextEdit txtSabitMaas;
        private DevExpress.XtraEditors.TextEdit txtFazlaMesai;
        private DevExpress.XtraEditors.TextEdit txtEksikMesai;
        private DevExpress.XtraEditors.TextEdit txtCalistigiGun;
        private DevExpress.XtraEditors.TextEdit txtToplamMaas;
        private DevExpress.XtraEditors.TextEdit txtOdenecekTutar;
    }
}