using System;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.HastaTableAdapter dsh = new DataSet1TableAdapters.HastaTableAdapter();

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            dsh.hastaEkle(Convert.ToInt64(mskHastaTC.Text), txtHastaAd.Text, txtHastaSoyad.Text,
                cmbHastaCinsiyet.Text, txtHastaSifre.Text);

            MessageBox.Show("Üyelik Kaydınız Oluşturulmuştur!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
