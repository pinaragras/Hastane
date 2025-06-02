using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmDoktorPage : Form
    {
        public FrmDoktorPage()
        {
            InitializeComponent();
        }

        SqlConnect msql = new SqlConnect();
        private void btnDGir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Doktor WHERE D_KimlikId=@p1 AND Sifre=@p2", msql.connect());
            cmd2.Parameters.AddWithValue("@p1", mskDTC.Text);
            cmd2.Parameters.AddWithValue("@p2", txtDSifre.Text);

            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                FrmDoktorDetay frd = new FrmDoktorDetay();
                frd.doktorTC = mskDTC.Text;
                frd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Doktor Kaydı Bulunamadı. Lütfen Girdiğiniz Bilgileri Kontrol Ediniz...", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            msql.connect().Close();
        }

        private void btnDGeri_Click(object sender, EventArgs e)
        {
            FrmMainPage frmMain = new FrmMainPage();
            frmMain.Show();
            this.Close();
        }
    }
}
