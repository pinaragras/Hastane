using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmHastaPage : Form
    {
        public FrmHastaPage()
        {
            InitializeComponent();
        }

        SqlConnect msql = new SqlConnect();

        private void lnkHKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void btnHGir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Hasta WHERE H_KimlikId=@p1 AND Sifre=@p2", msql.connect());

            cmd1.Parameters.AddWithValue("@p1", mskHTC.Text);
            cmd1.Parameters.AddWithValue("@p2", txtHSifre.Text);

            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                FrmHastaDetay frh = new FrmHastaDetay();
                frh.hastaTC = mskHTC.Text;
                frh.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hasta Kaydı Bulunamadı. Lütfen Girdiğiniz Bilgileri Kontrol Ediniz...", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            msql.connect().Close();
        }

        private void btnHGeri_Click(object sender, EventArgs e)
        {
            FrmMainPage frmMain = new FrmMainPage();
            frmMain.Show();
            this.Close();
        }
    }
}
