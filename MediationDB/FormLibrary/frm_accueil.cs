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
    public partial class frm_accueil : Form
    {
        public frm_accueil()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs = MessageBox.Show(this, "Voulez vous quitter?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_fonciers_Click(object sender, EventArgs e)
        {
            this.Close();
            var fr = new frm_menu();
            fr.Show();
        }

        private void btn_executants_Click(object sender, EventArgs e)
        {
            var fr = new frm_dash_agr();
            fr.Show();
        }

        private void btn_beneficiaires_Click(object sender, EventArgs e)
        {
            var fr = new frm_dash_parameters();
            fr.Show();
        }
    }
}
