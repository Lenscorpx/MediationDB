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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            //charger_splash();
            //MessageBox.Show("Bienvenu(e) " + lbl_nom_user.Text +
            //    "\nMerci encore pour l'utilisation de ce logiciel de gestion d'informations sur les médiations foncières" +
            //    " sur le bas du formulaire veuillez trouver les boutons qui vous permettront de consulter les différents" +
            //    " formulaires sur les médiations foncières ainsi que les sensibilisations");
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            
        }
        

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //var fr = new uc_conflit()
            //{
            //    Size = panel1.Size
            //};
            //panel1.Controls.Clear();
            //panel1.Controls.Add(fr);
            //fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            //fr.Visible = true;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs = MessageBox.Show(this, "Etes vous sur de vouloir quitter l'application?", "Confirmation pour quitter l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Stop,MessageBoxDefaultButton.Button2);
            if (rs==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            //var fr = new uc_parametres()
            //{
            //    Size = panel1.Size
            //};
            //panel1.Controls.Clear();
            //panel1.Controls.Add(fr);
            //fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            //fr.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //var fr = new uc_menage()
            //{
            //    Size = panel1.Size
            //};
            //panel1.Controls.Clear();
            //panel1.Controls.Add(fr);
            //fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            //fr.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            bunifuFlatButton1_Click(sender, e);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            bunifuFlatButton2_Click(sender, e);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs = MessageBox.Show(this, "Voulez vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_conflits_Click(object sender, EventArgs e)
        {
            var fr = new frm_conflit();
            fr.ShowDialog();
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

        private void btn_nature_conflit_Click(object sender, EventArgs e)
        {
            var fr = new frm_nature_conflit();
            fr.ShowDialog();
        }

        private void btn_situation_Click(object sender, EventArgs e)
        {
            var fr = new frm_situation_menage();
            fr.ShowDialog();
        }

        private void btn_typep_conflit_Click(object sender, EventArgs e)
        {
            var fr = new frm_type_conflit();
            fr.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            var fr = new frm_help();
            fr.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_mediateurs_Click(object sender, EventArgs e)
        {
            var fr = new frm_mediateur();
            fr.ShowDialog();
        }

        private void btn_sensibilisations_Click(object sender, EventArgs e)
        {
            var fr = new frm_sensibilisation();
            fr.ShowDialog();
        }

        private void btn_ateliers_Click(object sender, EventArgs e)
        {
            var fr = new frm_search_ateliers();
            fr.ShowDialog();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btn_menages_Click(object sender, EventArgs e)
        {
            var fr = new frm_menages();
            fr.Show();
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

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_types_atelier();
            fr.ShowDialog();
        }

        private void btn_etat_part_Click(object sender, EventArgs e)
        {
            var fr = new frm_etat_participant();
            fr.ShowDialog();
        }

        private void btn_organisations_Click(object sender, EventArgs e)
        {
            var fr = new frm_membres();
            fr.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_parties_Click(object sender, EventArgs e)
        {
            var fr = new frm_stats_dashboard();
            fr.Show();
        }

        private void btn_rapports_Click(object sender, EventArgs e)
        {
            var fr = new frm_report_conflits_list();
            fr.ShowDialog();
        }
    }
}
