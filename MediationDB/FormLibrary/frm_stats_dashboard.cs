using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediationDB.FormLibrary
{
    public partial class frm_stats_dashboard : Form
    {
        public frm_stats_dashboard()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conflits_Click(object sender, EventArgs e)
        {
            var fr = new frm_stats_conflits();
            fr.Show();
        }

        private void btn_sensibilisations_Click(object sender, EventArgs e)
        {
            var fr = new frm_evolution();
            fr.Show();
        }

        private void btn_membres_Click(object sender, EventArgs e)
        {
            var fr = new frm_reports();
            fr.Show();
        }
    }
}
