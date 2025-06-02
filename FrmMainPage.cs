using System;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        private void btnHastaGir_Click(object sender, EventArgs e)
        {
            FrmHastaPage fr = new FrmHastaPage();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGir_Click(object sender, EventArgs e)
        {
            FrmDoktorPage fr = new FrmDoktorPage();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGir_Click(object sender, EventArgs e)
        {
            FrmSekreterPage fr = new FrmSekreterPage();
            fr.Show();
            this.Hide();
        }
    }
}
