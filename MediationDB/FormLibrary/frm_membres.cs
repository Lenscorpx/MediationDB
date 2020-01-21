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
    public partial class frm_membres : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_membres()
        {
            InitializeComponent();
            refresh();
        }
        public void refresh()
        {
            rps.afficher_membres(bunifuCustomDataGrid2);
            rps.recuperer_vulnerabilite(cbx_vulnerabilite);
            txt_adresse.ResetText();
            txt_code_membre.ResetText();
            txt_id_menage.ResetText();
            txt_noms_membre.ResetText();
            txt_profession.ResetText();
            txt_provenance.ResetText();
            txt_telephone.ResetText();            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_code_membre.Text == "")
            {
                if (txt_id_menage.Text ==""||txt_noms_membre.Text==""||cbx_sexe.Text==""||cbx_etat_civil.Text==""||cbx_vulnerabilite.Text=="")
                {
                    MessageBox.Show("Veuillez completer les champs importants!");
                }
                else
                {
                    if(rd_btn_yes.Checked==true)
                    {
                        rps.inserer_membre(txt_code_membre.Text, txt_noms_membre.Text, Convert.ToDateTime(dt_date_naissance.Text),
                                       cbx_sexe.Text, cbx_etat_civil.Text, cbx_vulnerabilite.Text, txt_provenance.Text, 
                                       txt_adresse.Text, txt_telephone.Text, "Yes", txt_profession.Text, txt_id_menage.Text, DateTime.Now);
                    }
                    else
                    {
                        rps.inserer_membre(txt_code_membre.Text, txt_noms_membre.Text, Convert.ToDateTime(dt_date_naissance.Text),
                                       cbx_sexe.Text, cbx_etat_civil.Text, cbx_vulnerabilite.Text, txt_provenance.Text,
                                       txt_adresse.Text, txt_telephone.Text, "No", txt_profession.Text, txt_id_menage.Text, DateTime.Now);
                    }
                    
                }
            }
            else
            {
                if (txt_id_menage.Text == "" || txt_noms_membre.Text == "" || cbx_sexe.Text == "" || cbx_etat_civil.Text == "" || cbx_vulnerabilite.Text == "")
                {
                    MessageBox.Show("Veuillez completer les champs importants!");
                }
                else
                {
                    if (rd_btn_yes.Checked == true)
                    {
                        rps.modifier_membre(txt_code_membre.Text, txt_noms_membre.Text, Convert.ToDateTime(dt_date_naissance.Text),
                                       cbx_sexe.Text, cbx_etat_civil.Text, cbx_vulnerabilite.Text, txt_provenance.Text,
                                       txt_adresse.Text, txt_telephone.Text, "Yes", txt_profession.Text, txt_id_menage.Text, DateTime.Now);
                    }
                    else
                    {
                        rps.modifier_membre(txt_code_membre.Text, txt_noms_membre.Text, Convert.ToDateTime(dt_date_naissance.Text),
                                       cbx_sexe.Text, cbx_etat_civil.Text, cbx_vulnerabilite.Text, txt_provenance.Text,
                                       txt_adresse.Text, txt_telephone.Text, "No", txt_profession.Text, txt_id_menage.Text, DateTime.Now);
                    }

                }
            }
        }

        private void frm_membres_Load(object sender, EventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(txt_code_membre.Text=="")
            {
                MessageBox.Show("Veuillez choisir le membre a supprimer!");
            }
            else
            { 
                DialogResult rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cet élément?", "Confirmation de suppression", 
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(rs==DialogResult.Yes)
                {
                    rps.supprimer_membre(txt_code_membre.Text);

                }
            }
        }

        private void txt_id_menage_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_membres_parID(bunifuCustomDataGrid2, txt_id_menage.Text);
        }

        private void txt_noms_membre_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_membres_parNoms(bunifuCustomDataGrid2, txt_noms_membre.Text);
        }
    }
}
