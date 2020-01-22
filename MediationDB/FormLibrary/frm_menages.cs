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
    public partial class frm_menages : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_menages()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_menages(bunifuCustomDataGrid2);
            rps.recuperer_situation_menage(cbx_situation_menage);
            txt_code_menage.ResetText();
            txt_femmes.ResetText();
            txt_filles.ResetText();
            txt_garcons.ResetText();
            txt_hommes.ResetText();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_code_menage.Text == "")
            {
                MessageBox.Show("Veuillez selectionner le menage auquel vous voulez ajouter un membre!");
            }
            else
            {
                var fr = new frm_membres();
                fr.txt_id_menage.Text = txt_code_menage.Text;
                fr.ShowDialog();
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_code_menage.Text == "" || cbx_situation_menage.Text == ""||txt_femmes.Text==""||txt_filles.Text==""||txt_garcons.Text==""||txt_hommes.Text=="")
            {
                MessageBox.Show("Veuillez completez les éléments manquants!");
            }
            else
            {
                rps.enregistrer_menage(txt_code_menage.Text, cbx_situation_menage.Text, Convert.ToInt32(txt_hommes.Text), Convert.ToInt32(txt_femmes.Text), Convert.ToInt32(txt_garcons.Text), Convert.ToInt32(txt_filles.Text));
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_code_menage.Text == "")
            {
                MessageBox.Show("Completez le code de menage a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_menage(txt_code_menage.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_menage.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            dt_debut_mediation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            cbx_situation_menage.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_hommes.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            txt_femmes.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
            txt_garcons.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[5].Value.ToString();
            txt_filles.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txt_code_menage_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_menage(bunifuCustomDataGrid2, txt_code_menage.Text);
        }
    }
}
