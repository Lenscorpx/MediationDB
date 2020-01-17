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
    public partial class frm_conflit : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_conflit()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.recuperer_localite(listBox1);
            rps.recuperer_type_conflit(cbx_type_conflit);
            rps.recuperer_nature_conflit(cbx_nature_conflit);
            rps.afficher_conflit(bunifuCustomDataGrid2);
            txt_id_localite.ResetText();
            txt_localite.ResetText();
            txt_num_conflit.ResetText();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            metroDateTime1.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            cbx_type_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            cbx_nature_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
            txt_localite.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_localite.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_num_conflit.Text == "")
            {
                if (cbx_nature_conflit.Text == "" || cbx_type_conflit.Text == "" || txt_localite.Text == "")
                {
                    MessageBox.Show("Completez les informations manquantes!");
                }
                else
                {
                    rps.inserer_conflit(metroDateTime1.Value, cbx_type_conflit.Text, cbx_nature_conflit.Text, txt_localite.Text);
                    refresh();
                }
            }
            else
            {
                if (cbx_nature_conflit.Text == "" || cbx_type_conflit.Text == "" || txt_localite.Text == "")
                {
                    MessageBox.Show("Completez les informations manquantes!");
                }
                else
                {
                    rps.modifier_conflit(Convert.ToInt32(txt_num_conflit.Text), metroDateTime1.Value, cbx_type_conflit.Text, cbx_nature_conflit.Text, txt_localite.Text);
                    refresh();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_conflit.Text == "")
            {
                MessageBox.Show("Completez le code du conflit a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_conflit(Convert.ToInt32(txt_num_conflit.Text));
                    refresh();
                }
            }
        }

        private void btn_mediation_Click(object sender, EventArgs e)
        {
            if (txt_num_conflit.Text == "")
            {
                MessageBox.Show("Choisissez le conflit auquel vous voulez ajouter une mediation!");
            }
            else
            {
                var fr = new frm_mediation();
                fr.txt_num_conflit.Text = txt_num_conflit.Text;
                fr.ShowDialog();
            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            if (txt_num_conflit.Text == "")
            {
                MessageBox.Show("Choisissez le conflit auquel vous voulez ajouter des details!");
            }
            else
            {
                var fr = new frm_details_conflit();
                fr.txt_num_conflit.Text = txt_num_conflit.Text;
                fr.ShowDialog();
            }
        }

        private void btn_causes_Click(object sender, EventArgs e)
        {
            var fr = new frm_details_causes();
            fr.ShowDialog();
        }

        private void btn_objets_Click(object sender, EventArgs e)
        {
            var fr = new frm_details_objets_conflits();
            fr.ShowDialog();
        }
    }
}
