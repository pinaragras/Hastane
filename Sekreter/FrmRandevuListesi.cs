using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        SqlConnect msql = new SqlConnect();

        public string doktorTC, rndID, skrTC, skrAdSoyad;

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            string drcondition;

            if (doktorTC == "" || doktorTC == null)
            {
                drcondition = "";
            }
            else
            {
                drcondition = " WHERE d.D_KimlikId = " + long.Parse(doktorTC);
            }

            DataTable dt = new DataTable();

            var query = $@"SELECT
                r.RandevuId,
                r.Tarih,
                r.Saat,
                (d.Unvan + ' ' + d.D_Ad + ' ' + d.D_Soyad) AS Doktor,
                (h.H_Ad + ' ' + h.H_Soyad) AS Hasta,
                r.Sikayet
            FROM Randevu r
            INNER JOIN Doktor d ON r.D_KimlikId = d.D_KimlikId
            LEFT JOIN Hasta h ON r.H_KimlikId = h.H_KimlikId";

            SqlDataAdapter dta = new SqlDataAdapter(query + drcondition, msql.connect());
            dta.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rw = dataGridView1.SelectedCells[0].RowIndex;
            rndID = dataGridView1.Rows[rw].Cells[0].Value.ToString();

            FrmSekreterDetay frs = new FrmSekreterDetay();
            frs.sekreterTC = skrTC;
            frs.sekreterAdSoyad = skrAdSoyad;
            frs.randevuID = rndID;

            frs.Show();
            this.Close();
        }
    }
}
