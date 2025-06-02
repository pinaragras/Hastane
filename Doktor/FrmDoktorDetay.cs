using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlConnect msql = new SqlConnect();
        public string doktorTC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblDoktorTC.Text = doktorTC;

            //Doktor Ad, Soyad getirme kodları
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Doktor WHERE D_KimlikId=@p1", msql.connect());
            cmd1.Parameters.AddWithValue("@p1", doktorTC);

            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                lblDAdSoyad.Text = dr[2] + " " + dr[3];
            }
            msql.connect().Close();

            //Randevuları getirme kodları
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
            col3.HeaderText = "Şikayet";
            col3.DataPropertyName = "Sikayet";
            dataGridView1.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Hasta";
            col4.DataPropertyName = "Hasta";
            dataGridView1.Columns.Add(col4);

            DataSet1TableAdapters.RandevuTableAdapter dsrnd = new DataSet1TableAdapters.RandevuTableAdapter();
            dataGridView1.DataSource = dsrnd.doktorRndGetir(Convert.ToInt64(doktorTC));
        }

        private void lnkBilgiDuzelt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoktorBilgi frm = new FrmDoktorBilgi();
            frm.doktorTC = doktorTC;
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmDoktorPage frm = new FrmDoktorPage();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rwi = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayeti.Text = dataGridView1.Rows[rwi].Cells[2].Value?.ToString();
        }
    }
}
