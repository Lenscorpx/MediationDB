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
    public partial class frm_dash_agr : Form
    {
        public frm_dash_agr()
        {
            InitializeComponent();
        }

        private void btn_distribution_agr_Click(object sender, EventArgs e)
        {
            var fr = new frm_distribution();
            fr.Show();
        }

        private void btn_beneficiaires_Click(object sender, EventArgs e)
        {
            var fr = new frm_beneficiaires();
            fr.Show();
        }
    }
}
