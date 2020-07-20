using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.ReportsLibrary;

namespace MediationDB.FormLibrary
{
    public partial class frm_dash_reports : Form
    {
        public frm_dash_reports()
        {
            InitializeComponent();
        }

        private void btn_conflits_Click(object sender, EventArgs e)
        {
            var fr = new frm_report_conflits_list();
            fr.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sensibilisations_Click(object sender, EventArgs e)
        {
            var fr = new frm_sensibilises();
            fr.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            var
        }
    }
}
