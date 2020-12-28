namespace PersonelTakip
{
    partial class frmIzınLimitGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzınLimitGuncelle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLimit = new DevExpress.XtraEditors.TextEdit();
            this.txtYeniLimit = new DevExpress.XtraEditors.TextEdit();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.cbIzinTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniLimit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İZİN TİPİ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(162, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "İZİN LİMİTİ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "YENİ LİMİT";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(162, 31);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Properties.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 4;
            // 
            // txtYeniLimit
            // 
            this.txtYeniLimit.Location = new System.Drawing.Point(34, 100);
            this.txtYeniLimit.Name = "txtYeniLimit";
            this.txtYeniLimit.Size = new System.Drawing.Size(100, 20);
            this.txtYeniLimit.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(162, 103);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 53);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbIzinTipi
            // 
            this.cbIzinTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbIzinTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzinTipi.FormattingEnabled = true;
            this.cbIzinTipi.Items.AddRange(new object[] {
            "Raporlu",
            "Ücretli",
            "Ücretsiz"});
            this.cbIzinTipi.Location = new System.Drawing.Point(34, 31);
            this.cbIzinTipi.Name = "cbIzinTipi";
            this.cbIzinTipi.Size = new System.Drawing.Size(100, 21);
            this.cbIzinTipi.TabIndex = 9;
            this.cbIzinTipi.SelectedIndexChanged += new System.EventHandler(this.cbIzinTipi_SelectedIndexChanged_1);
            // 
            // frmIzınLimitGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 177);
            this.Controls.Add(this.cbIzinTipi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYeniLimit);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmIzınLimitGuncelle.IconOptions.SvgImage")));
            this.Name = "frmIzınLimitGuncelle";
            this.Text = "İZİN LİMİTLERİ";
            this.Load += new System.EventHandler(this.frmIzınLimitGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniLimit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtLimit;
        private DevExpress.XtraEditors.TextEdit txtYeniLimit;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.ComboBox cbIzinTipi;
    }
}