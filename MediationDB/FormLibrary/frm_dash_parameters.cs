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
    public partial class frm_dash_parameters : Form
    {
        public frm_dash_parameters()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_params_causes_Click(object sender, EventArgs e)
        {
            var fr = new frm_causes_conflit();
            fr.ShowDialog();
        }

        private void btn_objets_Click(object sender, EventArgs e)
        {
            var fr = new frm_objet_conflit();
            fr.ShowDialog();
        }

        private void btn_resolutions_Click(object sender, EventArgs e)
        {
            var fr = new frm_resolutions();
            fr.ShowDialog();
        }

        private void btn_types_parties_Click(object sender, EventArgs e)
        {
            var fr = new frm_types_partie();
            fr.ShowDialog();
        }

        private void btn_vulnerabilites_Click(object sender, EventArgs e)
        {
            var fr = new frm_vulnerabilite();
            fr.ShowDialog();
        }

        private void btn_typep_conflit_Click(object sender, EventArgs e)
        {
            var fr = new frm_type_conflit();
            fr.ShowDialog();
        }
    }
}
