using System;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmBransPanel : Form
    {
        public FrmBransPanel()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.BransTableAdapter dsb = new DataSet1TableAdapters.BransTableAdapter();

        private void FrmBransPanel_Load(object sender, EventArgs e)
        {
            btnBSil.Enabled = false;
            btnBGuncelle.Enabled = false;

            dataGridView1.DataSource = dsb.branslar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rw = dataGridView1.SelectedCells[0].RowIndex;
            txtBransID.Text = dataGridView1.Rows[rw].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[rw].Cells[1].Value.ToString();

            if (txtBransID.Text == "")
            {
                btnBEkle.Enabled = true;
                btnBSil.Enabled = false;
                btnBGuncelle.Enabled = false;
            }
            else
            {
                btnBEkle.Enabled = false;
                btnBSil.Enabled = true;
                btnBGuncelle.Enabled = true;
            }
        }

        private void btnBEkle_Click(object sender, EventArgs e)
        {
            dsb.bransEkle(txtBransAd.Text);
            dataGridView1.DataSource = dsb.branslar();
            MessageBox.Show("Brans Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBSil_Click(object sender, EventArgs e)
        {
            dsb.bransSil(int.Parse(txtBransID.Text));
            dataGridView1.DataSource = dsb.branslar();
            MessageBox.Show("Brans Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBGuncelle_Click(object sender, EventArgs e)
        {
            dsb.bransGuncelle(txtBransAd.Text, int.Parse(txtBransID.Text));
            dataGridView1.DataSource = dsb.branslar();
            MessageBox.Show("Brans Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
