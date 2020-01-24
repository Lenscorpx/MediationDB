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
    public partial class frm_details_objets_conflits : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_details_objets_conflits()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.recuperer_objet_conflit(cbx_objet_conflit);
            rps.afficher_assign_objets(bunifuCustomDataGrid2);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_num_details.Text=="")
            {
                if (txt_num_conflit.Text == "")
                {
                    MessageBox.Show("Completez les informations manquantes!");
                }
                else
                {
                    rps.inserer_assign_objet_conflit(cbx_objet_conflit.Text, txt_num_conflit.Text, txt_observation.Text);
                }
            }
            else
            {
                if (txt_num_conflit.Text == "")
                {
                    MessageBox.Show("Completez les informations manquantes!");
                }
                else
                {
                    rps.modifier_assign_objet_conflit(Convert.ToInt32(txt_num_details.Text),cbx_objet_conflit.Text, txt_num_conflit.Text, txt_observation.Text);
                }
            }
            
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(txt_num_details.Text=="")
            {
                MessageBox.Show("Veuillez completer les champs manquants");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Confirmez vous cette suppression?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(rs==DialogResult.Yes)
                {
                    rps.supprimer_assign_objet_conflit(txt_num_details.Text);
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_details.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            cbx_objet_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_num_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            txt_observation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
