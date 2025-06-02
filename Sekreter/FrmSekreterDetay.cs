using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.BransTableAdapter dsb = new DataSet1TableAdapters.BransTableAdapter();
        DataSet1TableAdapters.RandevuTableAdapter dsrnd = new DataSet1TableAdapters.RandevuTableAdapter();
        SqlConnect msql = new SqlConnect();
        public string sekreterTC, sekreterAdSoyad, doktor, randevuID;
        private class BransItem
        {
            public int BransId { get; set; }
            public string BransAdi { get; set; }
        }
        private class DoktorItem
        {
            public long D_KimlikId { get; set; }
            public string DoktorAdSoyad { get; set; }
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblSekreterTC.Text = sekreterTC;
            lblSAdSoyad.Text = sekreterAdSoyad;

            //Bransları datagrid'e getirme kodları
            dataGridView1.DataSource = dsb.branslar();

            //Doktorları datagrid'e getirme kodları
            DataTable dt2 = new DataTable();
            SqlDataAdapter dta2 = new SqlDataAdapter($@"SELECT (d.Unvan + ' ' + d.D_Ad + ' ' + d.D_Soyad) AS 'Doktor', b.BransAdi FROM Doktor d
            INNER JOIN Brans b ON d.BransId = b.BransId", msql.connect());
            dta2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bransları combobox'a getirme kodları
            var bransList = new List<BransItem>();
            SqlCommand cmd3 = new SqlCommand("SELECT BransId, BransAdi FROM Brans", msql.connect());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                bransList.Add(new BransItem
                {
                    BransId = dr3.GetInt32(0),
                    BransAdi = dr3.GetString(1)
                });
            }
            dr3.Close();
            msql.connect().Close();

            cmbBrans.DataSource = bransList;
            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "BransId";

            if (randevuID != null)
            {
                lblSekreterTC.Text = sekreterTC;
                lblSAdSoyad.Text = sekreterAdSoyad;
                txtID.Text = randevuID;

                SqlCommand cmd4 = new SqlCommand($@"SELECT r.Tarih, r.Saat, b.*, d.D_KimlikId, d.Unvan, d.D_Ad, d.D_Soyad, r.Durum, r.H_KimlikId
FROM Randevu r
                INNER JOIN Doktor d ON r.D_KimlikId = d.D_KimlikId
                INNER JOIN Brans b ON d.BransId = b.BransId
                WHERE RandevuId=@p1", msql.connect());
                cmd4.Parameters.AddWithValue("@p1", txtID.Text);

                var doktorList = new List<DoktorItem>();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    mskTarih.Text = dr4.GetDateTime(0).ToString("dd/MM/yyyy");
                    mskSaat.Text = dr4[1].ToString();
                    ((BransItem)cmbBrans.SelectedItem).BransId = dr4.GetInt32(2);

                    doktorList.Add(new DoktorItem
                    {
                        D_KimlikId = dr4.GetInt64(4),
                        DoktorAdSoyad = dr4.GetString(5) + " " + dr4.GetString(6) + " " + dr4.GetString(7)
                    });

                    chcDurum.Checked = dr4.GetBoolean(8);
                    mskTC.Text = dr4[9].ToString();

                    if(!string.IsNullOrEmpty(txtID.Text))
                    {
                        mskTC.Enabled = true;
                        chcDurum.Enabled = true;
                        btnRdvSil.Enabled = true;
                        btnRdvGuncelle.Enabled = true;
                    }
                    else
                    {
                        mskTC.Enabled = false;
                        chcDurum.Enabled = false;
                        btnRdvSil.Enabled = false;
                        btnRdvGuncelle.Enabled = false;
                    }

                    cmbDoktor.DataSource = doktorList;
                    cmbDoktor.DisplayMember = "DoktorAdSoyad";
                    cmbDoktor.ValueMember = "D_KimlikId";
                }
                dr4.Close();
                msql.connect().Close();
            }
        }

        private void btnRdvKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbBrans.Text) || !string.IsNullOrEmpty(cmbDoktor.Text))
            {
                dsrnd.randevuEkle(mskTarih.Text, mskSaat.Text, ((DoktorItem)cmbDoktor.SelectedItem).D_KimlikId);
                MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Girilen Bilgileri Kontrol Ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRdvSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                dsrnd.randevuSil(int.Parse(txtID.Text));
                MessageBox.Show("Randevu İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Lütfen Randevu Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRdvGuncelle_Click(object sender, EventArgs e)
        {
            string tc = "\0";

            if (mskTC.Text.Length == 11)
            {
                tc = mskTC.Text;
            }

            dsrnd.randevuGuncelle(mskTarih.Text, mskSaat.Text, chcDurum.Checked, ((DoktorItem)cmbDoktor.SelectedItem).D_KimlikId,
                string.IsNullOrEmpty(tc) ? long.Parse(tc) : (long?)null, int.Parse(txtID.Text));

            MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            mskTC.Clear();
            cmbDoktor.Enabled = false;
            mskTC.Enabled = false;

            btnRdvGuncelle.Enabled = false;
            btnRdvSil.Enabled = false;

            SqlCommand cmd = new SqlCommand("SELECT D_KimlikId, Unvan, D_Ad, D_Soyad FROM Doktor WHERE BransId=@p1", msql.connect());
            cmd.Parameters.AddWithValue("@p1", ((BransItem)cmbBrans.SelectedItem).BransId);

            var doktorList = new List<DoktorItem>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                doktorList.Add(new DoktorItem
                {
                    D_KimlikId = dr.GetInt64(0),
                    DoktorAdSoyad = dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3)
                });

                if (doktorList.Count > 0)
                {
                    cmbDoktor.Enabled = true;
                }
            }
            dr.Close();
            msql.connect().Close();

            cmbDoktor.DataSource = doktorList;
            cmbDoktor.DisplayMember = "DoktorAdSoyad";
            cmbDoktor.ValueMember = "D_KimlikId";
        }

        private void btnDrPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPanel frd = new FrmDoktorPanel();
            frd.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBransPanel frb = new FrmBransPanel();
            frb.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmSekreterPage frm = new FrmSekreterPage();
            frm.Show();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frr = new FrmRandevuListesi();
            frr.skrTC = lblSekreterTC.Text;
            frr.skrAdSoyad = lblSAdSoyad.Text;
            frr.doktorTC = ((DoktorItem)cmbDoktor.SelectedItem)?.D_KimlikId.ToString();
            frr.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbBrans.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (cmbDoktor.Items.Count > 0)
            {
                cmbDoktor.Enabled = true;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rwd = dataGridView2.SelectedCells[0].RowIndex;
            cmbDoktor.Text = dataGridView2.Rows[rwd].Cells[0].Value.ToString();
            cmbBrans.Text = dataGridView2.Rows[rwd].Cells[1].Value.ToString();
        }
    }
}
