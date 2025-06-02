using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmSekreterPage : Form
    {
        public FrmSekreterPage()
        {
            InitializeComponent();
        }

        SqlConnect msql = new SqlConnect();

        private void btnSGir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Sekreter WHERE S_KimlikId=@p1 AND Sifre=@p2", msql.connect());

            cmd3.Parameters.AddWithValue("@p1", mskSTC.Text);
            cmd3.Parameters.AddWithValue("@p2", txtSSifre.Text);

            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.sekreterAdSoyad = dr3[1] + " " + dr3[2];
                frs.sekreterTC = mskSTC.Text;

                frs.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sekreter Kaydı Bulunamadı. Lütfen Girdiğiniz Bilgileri Kontrol Ediniz...", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            msql.connect().Close();
        }

        private void btnSGeri_Click(object sender, EventArgs e)
        {
            FrmMainPage frmMain = new FrmMainPage();
            frmMain.Show();
            this.Close();
        }
    }
}
