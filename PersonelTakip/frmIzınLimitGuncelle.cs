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
using PersonelTakip.Classes;

namespace PersonelTakip
{
    public partial class frmIzınLimitGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmIzınLimitGuncelle()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            txtLimit.EditValue=null;
            txtYeniLimit.EditValue = null;
            cbIzinTipi.Text = "";

        }
       
    
        private void frmIzınLimitGuncelle_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Izin iz = new Izin();
            int a;
            if (Int32.TryParse(txtYeniLimit.Text, out a) && cbIzinTipi.SelectedItem.ToString() != "")
            {
                if (iz.IzinLimitGuncelle(cbIzinTipi.SelectedItem.ToString(), Convert.ToInt32(txtYeniLimit.Text)))
                {
                    XtraMessageBox.Show("Limit Güncellendi.");
                    Temizle();
                }
            }
            else { XtraMessageBox.Show("Lütfen İzin Tipini Seçiniz veya Sayısal Bir Değer Giriniz."); }
        }

        private void cbIzinTipi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Izin iz = new Izin();
            txtLimit.Text = iz.IzinLimitGetir(cbIzinTipi.SelectedItem.ToString()).ToString();
        }
    }
}