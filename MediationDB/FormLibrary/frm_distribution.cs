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
    public partial class frm_distribution : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_distribution()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.recuperer_projet(cbx_projet);
            rps.recuperer_executants(cbx_executant);
            rps.recuperer_localite(listBox1);
            rps.recuperer_agr(cbx_agr);
            rps.afficher_distribution(bunifuCustomDataGrid2);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
           if(cbx_projet.Text==""||cbx_executant.Text==""||cbx_agr.Text==""||txt_qte_recue.Text==""||txt_valeur.Text=="")
            {
                MessageBox.Show("Veuillez completer les informations manquantes!");
            }
           else
            {
                rps.enregistrer_distribution(txt_num_distribution.Text, dt_date_distribution.Value, txt_id_localite.Text, cbx_projet.Text, cbx_agr.Text, Convert.ToDecimal(txt_qte_recue.Text), Convert.ToDecimal(txt_valeur.Text), cbx_executant.Text, txt_observation.Text);
                refresh();
            }
        }

        private void txt_search_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_search_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_id_localite.Text = listBox1.SelectedItem.ToString();
        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_distrtibution_parlocalite(bunifuCustomDataGrid2, txt_id_localite.Text);
        }

        private void txt_num_distribution_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_distribution_parcode(bunifuCustomDataGrid2, txt_num_distribution.Text);
        }

        private void cbx_projet_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.rechercher_distrtibution_parprojet(bunifuCustomDataGrid2, cbx_projet.Text);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_distribution.Text == "")
            {
                MessageBox.Show("Veuillez selectionner l'element a supprimer!");
            }
            else
            {
                rps.supprimer_distribution(txt_num_distribution.Text);
                refresh();
            }
        }

        private void dt_date_distribution_ValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_distribution_pardate(bunifuCustomDataGrid2, dt_date_distribution.Value);
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_num_distribution.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
                //dt_date_distribution.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
                txt_id_localite.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
                cbx_projet.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
                cbx_agr.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
                txt_qte_recue.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[5].Value.ToString();
                txt_valeur.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[6].Value.ToString();
                cbx_executant.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[7].Value.ToString();
                txt_observation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }
    }
}
