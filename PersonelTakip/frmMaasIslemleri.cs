using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PersonelTakip.Classes;

namespace PersonelTakip
{
    public partial class frmMaasIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmMaasIslemleri()
        {
            InitializeComponent();
        }

        Maas m = new Maas();
        Personel p = new Personel();

        private void frmMaasIslemleri_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
            btnHesapla.Enabled = false;
            m.PersonelleriMaaslaGetir(lvPersonel);
            m.OdenenMaaslariGetir(lvOdenenMaaslar);
            cbDonem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonem.SelectedIndex = 0;
        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            if (cbDonem.Text == "" || cbDonem.Text == null)
            {
                XtraMessageBox.Show("Lütfen Dönem Seçiniz. ");
            }
            else
            {
                m.MaaslariGetir(lvMaaslar, cbDonem, lvPersonel.SelectedItems[0].SubItems[0].Text);
                txtPersonelID.Text = lvMaaslar.Items[0].SubItems[0].Text;
                txtPersonelAd.Text = lvMaaslar.Items[0].SubItems[1].Text;
                txtPersonelSoyad.Text = lvMaaslar.Items[0].SubItems[2].Text;
                txtSabitMaas.Text = lvMaaslar.Items[0].SubItems[4].Text;
                txtFazlaMesai.Text = (Convert.ToInt32(lvMaaslar.Items[0].SubItems[5].Text) * 20).ToString();
                txtEksikMesai.Text = (Convert.ToInt32(lvMaaslar.Items[0].SubItems[6].Text) * 10).ToString();
                txtCalistigiGun.Text = lvMaaslar.Items[0].SubItems[8].Text;
                txtToplamMaas.Text = lvMaaslar.Items[0].SubItems[7].Text;
            }
        }

        private void cbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPersonel.Items[0].Selected = true;
            lvPersonel.Select();
            m.MaaslariGetir(lvMaaslar, cbDonem, lvPersonel.SelectedItems[0].SubItems[0].Text);

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool Sonuc = Convert.ToBoolean(m.MaasSil(lvOdenenMaaslar));
                if (Sonuc)
                {
                    XtraMessageBox.Show("Seçilen maaş bilgileri silindi.");
                    Temizle();
                    btnHesapla.Enabled = false;
                    m.OdenenMaaslariGetir(lvOdenenMaaslar);
                }
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            double a;
            if (m.MaasKontrol(txtPersonelID.Text, cbDonem.SelectedItem.ToString()))
            {
                XtraMessageBox.Show("Bu personelin seçili dönem ödemesi zaten yapılmış! ");
                Temizle();
            }
            else
            {

                if (Double.TryParse(txtOdenecekTutar.Text, out a))
                {
                    double alacak, borc;
                    if ((Convert.ToDouble(txtOdenecekTutar.Text)) < (Convert.ToDouble(txtToplamMaas.Text)))
                    {
                        alacak = (Convert.ToDouble(txtToplamMaas.Text)) - (Convert.ToDouble(txtOdenecekTutar.Text));
                        borc = 0;
                    }
                    else if ((Convert.ToDouble(txtToplamMaas.Text)) < (Convert.ToDouble(txtOdenecekTutar.Text)))
                    {
                        borc = (Convert.ToDouble(txtOdenecekTutar.Text) - (Convert.ToDouble(txtToplamMaas.Text)));
                        alacak = 0;
                    }
                    else
                    {
                        borc = 0;
                        alacak = 0;
                    }

                    m.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    m.Donem = cbDonem.SelectedItem.ToString();
                    m.CalistigiGun = Convert.ToDouble(txtCalistigiGun.Text);
                    m.Hakedis = Convert.ToDouble(txtToplamMaas.Text);
                    m.Alacak = alacak;
                    m.Borc = borc;
                    m.MaasOde(m);
                    m.ToplamAlacakBorcGuncelle(txtPersonelID.Text, alacak, borc);
                    Temizle();
                }
                else
                    XtraMessageBox.Show("Lütfen Sayısal Bir Değer Giriniz.");
            }
        }

        private void Temizle()
        {
            txtPersonelID.EditValue = null;
            txtPersonelAd.EditValue = null;
            txtPersonelSoyad.EditValue = null;
            txtSabitMaas.EditValue = null;
            txtFazlaMesai.EditValue = null;
            txtEksikMesai.EditValue = null;
            txtCalistigiGun.EditValue = null;
            txtToplamMaas.EditValue = null;
            txtOdenecekTutar.EditValue = null;
            txtPersonelID.Focus();
        }

        private void txtPersonelID_EditValueChanged(object sender, EventArgs e)
        {
            m.PersonelleriGetirByArama(txtPersonelID.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, lvPersonel);
            m.MaaslariGetirByArama(txtPersonelID.Text, lvOdenenMaaslar);
        }

        private void txtPersonelAd_EditValueChanged(object sender, EventArgs e)
        {
            m.PersonelleriGetirByArama(txtPersonelID.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, lvPersonel);

        }

        private void txtPersonelSoyad_EditValueChanged(object sender, EventArgs e)
        {
            m.PersonelleriGetirByArama(txtPersonelID.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, lvPersonel);

        }
        private void lvOdenenMaaslar_DoubleClick(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true;

        }
    }
}