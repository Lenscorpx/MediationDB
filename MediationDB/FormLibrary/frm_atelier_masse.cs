using MediationDB.DataLibrary;
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
    public partial class frm_atelier_masse : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_atelier_masse()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_atelier_masse(bunifuCustomDataGrid2);
            txt_autorite_femme.ResetText();
            txt_autorite_homme.ResetText();
            txt_code_sensibilisation.ResetText();
            txt_commentaires.ResetText();
            txt_femmes.ResetText();
            txt_filles.ResetText();
            txt_garcons.ResetText();
            txt_hommes.ResetText();
            txt_menages_depl.ResetText();
            txt_menages_locaux.ResetText();
            txt_menages_rap.ResetText();
            txt_menages_retournes.ResetText();
            txt_noms_sensibilisateurs.ResetText();
            txt_num_atelier.ResetText();
            txt_observation.ResetText();
            txt_telephone.ResetText();
            txt_themes.ResetText();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_code_sensibilisation.Text=="")
            {
                MessageBox.Show("Veuillez saisir le code de sensibilisation");
            }
            else
            {
                rps.inserer_atelier_masse(txt_code_sensibilisation.Text, dt_debut_sensibilisations.Value, Convert.ToInt32(txt_hommes.Text), Convert.ToInt32(txt_femmes.Text),
                    Convert.ToInt32(txt_filles.Text), Convert.ToInt32(txt_garcons.Text), Convert.ToInt32(txt_autorite_femme.Text), Convert.ToInt32(txt_autorite_homme.Text),
                    Convert.ToInt32(txt_menages_depl.Text), Convert.ToInt32(txt_menages_retournes.Text), Convert.ToInt32(txt_menages_locaux.Text),
                    Convert.ToInt32(txt_menages_rap.Text), txt_themes.Text, txt_observation.Text, txt_noms_sensibilisateurs.Text, txt_commentaires.Text, txt_telephone.Text);
                refresh();
            }
        }

        private void txt_code_sensibilisation_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_atelier_masse_bysensibilisation(bunifuCustomDataGrid2, txt_code_sensibilisation.Text);
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_atelier.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            dt_debut_sensibilisations.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            txt_code_sensibilisation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_hommes.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            txt_femmes.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
            txt_filles.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[5].Value.ToString();
            txt_garcons.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[6].Value.ToString();
            txt_autorite_femme.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[7].Value.ToString();
            txt_autorite_homme.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[8].Value.ToString();
            txt_menages_depl.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[9].Value.ToString();
            txt_menages_retournes.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[10].Value.ToString();
            txt_menages_locaux.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[11].Value.ToString();
            txt_menages_rap.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[12].Value.ToString();
            txt_themes.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[13].Value.ToString();
            txt_observation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[14].Value.ToString();
            txt_noms_sensibilisateurs.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[15].Value.ToString();
            txt_commentaires.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[16].Value.ToString();
            txt_telephone.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[17].Value.ToString();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_atelier.Text == "")
            {
                MessageBox.Show("Selectionnez le code de l'ateliers!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Etes vous sure de l'operation que vous voulez faire? (Suppression)");
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_atelier_masse(Convert.ToInt32(txt_num_atelier.Text));
                    refresh();
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
