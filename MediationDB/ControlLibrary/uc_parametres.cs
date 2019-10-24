using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.FormLibrary;

namespace MediationDB.ControlLibrary
{
    public partial class uc_parametres : UserControl
    {
        public uc_parametres()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var fr = new frm_objet_conflit();
            fr.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var fr = new frm_nature_conflit();
            fr.ShowDialog();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            var fr = new frm_mediateur();
            fr.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_type_conflit();
            fr.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new frm_causes_conflit();
            fr.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            var fr = new frm_types_partie();
            fr.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            var fr = new frm_situation_menage();
            fr.ShowDialog();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            var fr = new frm_vulnerabilite();
            fr.ShowDialog();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            var fr = new frm_resolutions();
            fr.ShowDialog();
        }
    }
}
