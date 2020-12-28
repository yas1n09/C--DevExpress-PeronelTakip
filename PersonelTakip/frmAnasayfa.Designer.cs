namespace PersonelTakip
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.btnPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.btnMesaiIslemleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaasIslemleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrimler = new DevExpress.XtraEditors.SimpleButton();
            this.btnIzınIslemleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonel.ImageOptions.SvgImage")));
            this.btnPersonel.Location = new System.Drawing.Point(12, 12);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPersonel.Size = new System.Drawing.Size(288, 194);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel İşlemleri";
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnMesaiIslemleri
            // 
            this.btnMesaiIslemleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMesaiIslemleri.ImageOptions.SvgImage")));
            this.btnMesaiIslemleri.Location = new System.Drawing.Point(344, 12);
            this.btnMesaiIslemleri.Name = "btnMesaiIslemleri";
            this.btnMesaiIslemleri.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMesaiIslemleri.Size = new System.Drawing.Size(278, 194);
            this.btnMesaiIslemleri.TabIndex = 1;
            this.btnMesaiIslemleri.Text = "Mesai İşlemleri";
            this.btnMesaiIslemleri.Click += new System.EventHandler(this.btnMesaiIslemleri_Click);
            // 
            // btnMaasIslemleri
            // 
            this.btnMaasIslemleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMaasIslemleri.ImageOptions.SvgImage")));
            this.btnMaasIslemleri.Location = new System.Drawing.Point(12, 243);
            this.btnMaasIslemleri.Name = "btnMaasIslemleri";
            this.btnMaasIslemleri.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMaasIslemleri.Size = new System.Drawing.Size(288, 191);
            this.btnMaasIslemleri.TabIndex = 3;
            this.btnMaasIslemleri.Text = "Maaş İşlemleri";
            this.btnMaasIslemleri.Click += new System.EventHandler(this.btnMaasIslemleri_Click);
            // 
            // btnPrimler
            // 
            this.btnPrimler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrimler.ImageOptions.SvgImage")));
            this.btnPrimler.Location = new System.Drawing.Point(372, 243);
            this.btnPrimler.Name = "btnPrimler";
            this.btnPrimler.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrimler.Size = new System.Drawing.Size(278, 191);
            this.btnPrimler.TabIndex = 4;
            this.btnPrimler.Text = "Primleri";
            this.btnPrimler.Click += new System.EventHandler(this.btnPrimler_Click);
            // 
            // btnIzınIslemleri
            // 
            this.btnIzınIslemleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIzınIslemleri.ImageOptions.SvgImage")));
            this.btnIzınIslemleri.Location = new System.Drawing.Point(656, 12);
            this.btnIzınIslemleri.Name = "btnIzınIslemleri";
            this.btnIzınIslemleri.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIzınIslemleri.Size = new System.Drawing.Size(280, 194);
            this.btnIzınIslemleri.TabIndex = 2;
            this.btnIzınIslemleri.Text = "İzin İşlemleri";
            this.btnIzınIslemleri.Click += new System.EventHandler(this.btnIzınIslemleri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCikis.ImageOptions.SvgImage")));
            this.btnCikis.Location = new System.Drawing.Point(656, 243);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCikis.Size = new System.Drawing.Size(280, 191);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(997, 485);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnIzınIslemleri);
            this.Controls.Add(this.btnPrimler);
            this.Controls.Add(this.btnMaasIslemleri);
            this.Controls.Add(this.btnMesaiIslemleri);
            this.Controls.Add(this.btnPersonel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmAnasayfa.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmAnasayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPersonel;
        private DevExpress.XtraEditors.SimpleButton btnMesaiIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnMaasIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnPrimler;
        private DevExpress.XtraEditors.SimpleButton btnIzınIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}