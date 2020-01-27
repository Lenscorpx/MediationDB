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
using MediationDB.FormLibrary;

namespace MediationDB.FormLibrary
{
    public partial class frm_sensibilisation : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_sensibilisation()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_sensibilisation(bunifuCustomDataGrid2);
            rps.recuperer_localite(listBox1);
            txt_id_localite.ResetText();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_localite.Text = listBox1.SelectedItem.ToString();
        }

        private void txt_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_sensibilisation(bunifuCustomDataGrid2, txt_localite.Text);
        }

        private void txt_code_sensibilisation_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_sensibilisation_bycode_sensibilisation(bunifuCustomDataGrid2, txt_code_sensibilisation.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_code_sensibilisation.Text=="")
            {
                MessageBox.Show("Completez le code de sensibilisation!");
            }
            else
            {
                if(txt_localite.Text=="")
                {
                    MessageBox.Show("Completez la localite ou se passe la sensibilisation!");
                }
                else
                {
                    rps.inserer_sensibilisation(txt_code_sensibilisation.Text, dt_debut_sensibilisations.Value, dt_fin_sensibilisation.Value, txt_localite.Text);
                    refresh();
                    var fr = new frm_atelier_masse();
                    fr.txt_code_sensibilisation.Text = txt_code_sensibilisation.Text;
                    fr.ShowDialog();                    
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(txt_code_sensibilisation.Text=="")
            {
                MessageBox.Show("Selectionnez le code de sensibilisation!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Etes vous sure de l'operation que vous voulez faire? (Suppression)");
                if(rs==DialogResult.Yes)
                {
                    rps.supprimer_sensibilisation(txt_code_sensibilisation.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_sensibilisation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            dt_debut_sensibilisations.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            dt_fin_sensibilisation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_localite.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_code_sensibilisation.Text == "")
            {
                MessageBox.Show("Selectionnez le code de sensibilisation!");
            }
            else
            {
                var fr = new frm_atelier_masse();
                fr.txt_code_sensibilisation.Text = txt_code_sensibilisation.Text;
                fr.ShowDialog();
            }
        }
    }
}