using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmDoktorBilgi : Form
    {
        public FrmDoktorBilgi()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DoktorTableAdapter dsd = new DataSet1TableAdapters.DoktorTableAdapter();
        SqlConnect msql = new SqlConnect();
        public string doktorTC;
        private class BransItem
        {
            public int BransId { get; set; }
            public string BransAdi { get; set; }
        }

        private void FrmDoktorBilgi_Load(object sender, EventArgs e)
        {
            mskDrTC.Text = doktorTC;

            //Doktor Bilgilerini getirme kodları
            SqlCommand cmd1 = new SqlCommand($@"SELECT * FROM Doktor d
            INNER JOIN Brans b ON d.BransId = b.BransId WHERE D_KimlikId=@p6", msql.connect());
            cmd1.Parameters.AddWithValue("@p6", doktorTC);

            int doktorBransId = -1;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtDrAd.Text = dr1[2].ToString();
                txtDrSoyad.Text = dr1[3].ToString();
                cmbDrCinsiyet.Text = dr1[4].ToString();
                txtDrSifre.Text = dr1[6].ToString();
                doktorBransId = Convert.ToInt32(dr1[7]);
            }
            dr1.Close();
            msql.connect().Close();

            var bransList = new List<BransItem>();
            //Bransları combobox'a getirme kodları
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Brans", msql.connect());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                bransList.Add(new BransItem
                {
                    BransId = dr2.GetInt32(0),
                    BransAdi = dr2.GetString(1)
                });
            }
            dr2.Close();
            msql.connect().Close();

            cmbDrBrans.DataSource = bransList;
            cmbDrBrans.DisplayMember = "BransAdi";
            cmbDrBrans.ValueMember = "BransId";

            if (doktorBransId != -1)
                cmbDrBrans.SelectedValue = doktorBransId;
        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            dsd.doktorGuncelle(txtDrAd.Text, txtDrSoyad.Text, cmbDrCinsiyet.Text, Convert.ToInt32(cmbDrBrans.SelectedValue), txtDrSifre.Text,
                Convert.ToInt64(mskDrTC.Text));
            MessageBox.Show("Doktor Bilgileri Güncellendi..!", "Bilgileri Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
