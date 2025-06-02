using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.RandevuTableAdapter dsrnd = new DataSet1TableAdapters.RandevuTableAdapter();
        SqlConnect msql = new SqlConnect();
        public string hastaTC;
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

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblHastaTC.Text = hastaTC;

            //Hasta Ad, Soyad getirme kodları
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Hasta WHERE H_KimlikId=@p1", msql.connect());
            cmd1.Parameters.AddWithValue("@p1", hastaTC);

            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                lblHAdSoyad.Text = dr[1] + " " + dr[2];
            }
            dr.Close();
            msql.connect().Close();

            //Hasta Randevu Gecmisi getirme kodları
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Tarih";
            col1.DataPropertyName = "Tarih";
            dataGridView1.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Saat";
            col2.DataPropertyName = "Saat";
            dataGridView1.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Doktor";
            col3.DataPropertyName = "Doktor";
            dataGridView1.Columns.Add(col3);

            dataGridView1.DataSource = dsrnd.hastaRndGetir(Convert.ToInt64(hastaTC));

            var bransList = new List<BransItem>();

            //Brans getirme kodları
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

            cmbBrans.DataSource = bransList;
            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "BransId";
        }

        private void lnkBilgiDuzelt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgi frm = new FrmHastaBilgi();
            frm.hastaTC = hastaTC;
            frm.Show();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Enabled = false;
            rchSikayet.Enabled = false;

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
            }
            dr.Close();
            msql.connect().Close();

            cmbDoktor.DataSource = doktorList;
            cmbDoktor.DisplayMember = "DoktorAdSoyad";
            cmbDoktor.ValueMember = "D_KimlikId";

            if (doktorList.Count > 0)
            {
                cmbDoktor.Enabled = true;
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchSikayet.Clear();
            rchSikayet.Enabled = true;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();

            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Id";
            col1.DataPropertyName = "RandevuId";
            dataGridView2.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Tarih";
            col2.DataPropertyName = "Tarih";
            dataGridView2.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Saat";
            col3.DataPropertyName = "Saat";
            dataGridView2.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Branş";
            col4.DataPropertyName = "BransAdi";
            dataGridView2.Columns.Add(col4);

            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Doktor";
            col5.DataPropertyName = "Doktor";
            dataGridView2.Columns.Add(col5);

            dataGridView2.DataSource = dsrnd.hastaDrRndGetir(((BransItem)cmbBrans.SelectedItem).BransId,
                ((DoktorItem)cmbDoktor.SelectedItem).D_KimlikId);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rdw = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[rdw].Cells[0].Value.ToString();

            btnRandevuAl.Enabled = true;
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            string sikayet = "\0";

            if (rchSikayet.Text.Length > 0)
            {
                sikayet = rchSikayet.Text;
            }

            dsrnd.hastaRndAl(long.Parse(lblHastaTC.Text), sikayet, int.Parse(txtID.Text));
            dataGridView1.DataSource = dsrnd.hastaRndGetir(long.Parse(hastaTC));
            dataGridView2.DataSource = dsrnd.hastaDrRndGetir(((BransItem)cmbBrans.SelectedItem).BransId,
                ((DoktorItem)cmbDoktor.SelectedItem).D_KimlikId);

            MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmHastaPage frm = new FrmHastaPage();
            frm.Show();
            this.Close();
        }
    }
}
