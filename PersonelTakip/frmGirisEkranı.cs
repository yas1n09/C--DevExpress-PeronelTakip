using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PersonelTakip.Classes;
using DevExpress.XtraEditors;

namespace PersonelTakip
{
    public partial class frmGirisEkranı : DevExpress.XtraEditors.XtraForm
    {

        public frmGirisEkranı()
        {
            InitializeComponent();
        }

        public static bool Sonuc = false;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G3T65MN;Initial Catalog=PersonelTakip;Integrated Security=True");
        private object PersonelTakip;

        private void btnGiris_Click(object sender, EventArgs e)
        {

            SqlCommand comm = new SqlCommand("Select KullaniciAdi, Parola from Admin", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            bool Adi = false;


            while (dr.Read())
            {
                if (txtKullaniciAdi.Text.Trim() == dr["KullaniciAdi"].ToString() && txtParola.Text.Trim() == dr["Parola"].ToString())
                {
                    Sonuc = true;

                    //MessageBox.Show("Girdiğiniz kullanıcı adı mevcut değil! ");
                    //txtKullaniciAdi.Focus();
                }
                else if (txtKullaniciAdi.Text.Trim() == dr["KullaniciAdi"].ToString() && txtParola.Text.Trim() != dr["Parola"].ToString())
                {
                    Adi = true;
                }
            }
            dr.Close();
            conn.Close();

            if (Sonuc)
            {
                //MessageBox.Show("Giriş Başarılı");
                frmAnasayfa fr = new frmAnasayfa();
                fr.Show();
                this.Hide();
                
                
                

            }
            else if (Adi == true && Sonuc == false)
            {
                XtraMessageBox.Show("Girdiğiniz Parola Yanlış!");
                txtParola.Focus();
            }

            else
            {
                XtraMessageBox.Show("Girdiğiniz kullanıcı adı mevcut değil! ");
                txtKullaniciAdi.Focus();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
