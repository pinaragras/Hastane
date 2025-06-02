using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmHastaBilgi : Form
    {
        public FrmHastaBilgi()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.HastaTableAdapter dsh = new DataSet1TableAdapters.HastaTableAdapter();
        SqlConnect msql = new SqlConnect();
        public string hastaTC;
        private void FrmHastaBilgi_Load(object sender, EventArgs e)
        {
            mskHastaTC.Text = hastaTC;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Hasta WHERE H_KimlikId=@p6", msql.connect());
            cmd.Parameters.AddWithValue("@p6", hastaTC);
            
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtHastaAd.Text = dr[1].ToString();
                txtHastaSoyad.Text = dr[2].ToString();
                cmbHastaCinsiyet.Text = dr[3].ToString();
                txtHastaSifre.Text = dr[4].ToString();
            }
            dr.Close();
            msql.connect().Close();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            dsh.hastaGuncelle(txtHastaAd.Text, txtHastaSoyad.Text, cmbHastaCinsiyet.Text,
                txtHastaSifre.Text, long.Parse(mskHastaTC.Text));

            MessageBox.Show("Hasta Bilgileri Güncellendi..!", "Bilgileri Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
