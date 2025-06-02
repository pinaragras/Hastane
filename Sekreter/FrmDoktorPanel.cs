using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmDoktorPanel : Form
    {
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DoktorTableAdapter dsd = new DataSet1TableAdapters.DoktorTableAdapter();
        SqlConnect msql = new SqlConnect();
        private class BransItem
        {
            public int BransId { get; set; }
            public string BransAdi { get; set; }
        }

        private void FrmDoktorPanel_Load(object sender, EventArgs e)
        {
            btnDSil.Enabled = false;
            btnDGuncelle.Enabled = false;

            //Doktorları getirme
            dataGridView1.DataSource = dsd.doktorlar();

            //Bransları getirme
            var bransList = new List<BransItem>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Brans", msql.connect());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bransList.Add(new BransItem
                {
                    BransId = dr.GetInt32(0),
                    BransAdi = dr.GetString(1)
                });
            }
            dr.Close();
            msql.connect().Close();

            cmbBrans.DataSource = bransList;
            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "BransId";
        }

        private void btnDEkle_Click(object sender, EventArgs e)
        {
            dsd.doktorEkle(long.Parse(mskDoktorTC.Text), txtUnvan.Text, txtDoktorAd.Text, txtDoktorSoyad.Text, cmbCinsiyet.Text,
                ((BransItem)cmbBrans.SelectedItem).BransId, txtDoktorSifre.Text);
            dataGridView1.DataSource = dsd.doktorlar();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDSil_Click(object sender, EventArgs e)
        {
            dsd.doktorSil(long.Parse(mskDoktorTC.Text));
            dataGridView1.DataSource = dsd.doktorlar();
            MessageBox.Show("Doktor Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDGuncelle_Click(object sender, EventArgs e)
        {
            dsd.doktorGuncelle(txtDoktorAd.Text, txtDoktorSoyad.Text, cmbCinsiyet.Text, ((BransItem)cmbBrans.SelectedItem).BransId,
                txtDoktorSifre.Text, long.Parse(mskDoktorTC.Text));
            dataGridView1.DataSource = dsd.doktorlar();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int bransId;
            int rw = dataGridView1.SelectedCells[0].RowIndex;
            if (dataGridView1.Rows[rw].Cells[5].Value == null || dataGridView1.Rows[rw].Cells[5].Value is DBNull)
            {
                bransId = -1;
            }
            else
            {
                bransId = Convert.ToInt32(dataGridView1.Rows[rw].Cells[5].Value);
            }

            txtUnvan.Text = dataGridView1.Rows[rw].Cells[1].Value.ToString();
            txtDoktorAd.Text = dataGridView1.Rows[rw].Cells[2].Value.ToString();
            txtDoktorSoyad.Text = dataGridView1.Rows[rw].Cells[3].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[rw].Cells[4].Value.ToString();
            mskDoktorTC.Text = dataGridView1.Rows[rw].Cells[0].Value.ToString();
            cmbBrans.SelectedValue = bransId;
            txtDoktorSifre.Text = dataGridView1.Rows[rw].Cells[6].Value.ToString();

            if (mskDoktorTC.Text == "")
            {
                mskDoktorTC.Enabled = true;
                btnDEkle.Enabled = true;
                btnDSil.Enabled = false;
                btnDGuncelle.Enabled = false;
            }
            else
            {
                mskDoktorTC.Enabled = false;
                btnDEkle.Enabled = false;
                btnDSil.Enabled = true;
                btnDGuncelle.Enabled = true;
            }
        }
    }
}
