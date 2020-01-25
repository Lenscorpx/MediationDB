using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.DataLibrary;

namespace MediationDB.FormLibrary
{
    public partial class frm_details_parties_conflits : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_details_parties_conflits()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            rps.charger_membres(listBox1);
            rps.recuperer_type_partie(cbx_type_partie);
            rps.afficher_partie(bunifuCustomDataGrid2);
            txt_num_partie.ResetText();
            txt_code_menage.ResetText();
            txt_id_membre.ResetText();
            //txt_num_conflit.ResetText();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_chef_menage_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_nom_membre(listBox1, txt_recherche.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_noms.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void txt_noms_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_membres_parNoms(txt_id_membre, txt_code_menage, txt_noms.Text);
        }

        private void txt_code_menage_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_partie_byMenage(bunifuCustomDataGrid2, txt_code_menage.Text);
        }

        private void txt_num_conflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_partie_byConflit(bunifuCustomDataGrid2, txt_num_conflit.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_num_partie.Text=="")
            {
                if(txt_num_conflit.Text==""||cbx_type_partie.Text==""||txt_code_menage.Text=="")
                {
                    MessageBox.Show("Remplissez les informations manquantes!");
                }
                else
                {
                    rps.inserer_partie(cbx_type_partie.Text, txt_code_menage.Text, txt_num_conflit.Text);                                  
                }
            }
            else
            {
                if (txt_num_conflit.Text == "" || cbx_type_partie.Text == "" || txt_code_menage.Text == "")
                {
                    MessageBox.Show("Remplissez les informations manquantes!");
                }
                else
                {
                    rps.modifier_partie(Convert.ToInt32(txt_num_partie.Text),cbx_type_partie.Text, txt_code_menage.Text, txt_num_conflit.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_partie.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            dt_debut_mediation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            cbx_type_partie.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_code_menage.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            txt_num_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_partie.Text == "")
            {                
                    MessageBox.Show("Remplissez les informations manquantes!");               
            }
            else
            {                
                    rps.supprimer_partie(Convert.ToInt32(txt_num_partie.Text));
                    refresh();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var fr = new frm_details_conflit();
            fr.txt_num_conflit.Text = txt_num_conflit.Text;
            fr.ShowDialog();
            refresh();
        }
    }
}
