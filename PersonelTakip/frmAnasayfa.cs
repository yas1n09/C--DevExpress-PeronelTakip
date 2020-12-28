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

namespace PersonelTakip
{
    public partial class frmAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            
            frmPersonelIslemleri frm = new frmPersonelIslemleri();
            frm.ShowDialog();
            
            //XtraDialog.Show(frmPersonelIslemleri);
            
        }

        private void btnMesaiIslemleri_Click(object sender, EventArgs e)
        {
            frmMesaiIslemleri frm = new frmMesaiIslemleri();
            frm.ShowDialog();
        }

        private void btnIzınIslemleri_Click(object sender, EventArgs e)
        {
            frmIzinIslemleri frm = new frmIzinIslemleri();
            frm.ShowDialog();
        }

        private void btnMaasIslemleri_Click(object sender, EventArgs e)
        {
            frmMaasIslemleri frm = new frmMaasIslemleri();
            frm.ShowDialog();
        }

        private void btnPrimler_Click(object sender, EventArgs e)
        {
            frmPrimIslemleri frm = new frmPrimIslemleri();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}