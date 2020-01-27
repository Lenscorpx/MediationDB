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
    public partial class frm_mediation : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_mediation()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh()
        {
            rps.afficher_mediation_all(bunifuCustomDataGrid2);
            rps.recuperer_localite(listBox1);
            rps.recuperer_mediateur(cbx_mediateur);
        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_num_mediation.Text == "")
            {
                if (cbx_mediateur.Text == "" || txt_appreciation.Text == "" || txt_localite.Text == ""|| txt_noms_mediateur.Text=="")
                {
                    MessageBox.Show("Completez les informations manquantes!");
                }
                else
                {
                    rps.inserer_mediation(dt_debut_mediation.Value, txt_num_conflit.Text, cbx_mediateur.Text, txt_noms_mediateur.Text, txt_localite.Text, txt_appreciation.Text, dt_fin_mediation.Value);
                    refresh();
                }
            }
            else
            {
                if (cbx_mediateur.Text == "" || txt_appreciation.Text == "" || txt_localite.Text == "" || txt_noms_mediateur.Text == "")
                {
                    MessageBox.Show("Completez les informations manquantes!");
                }
                else
                {
                    rps.modifier_mediation(Convert.ToInt32(txt_num_mediation),dt_debut_mediation.Value, txt_num_conflit.Text, cbx_mediateur.Text, txt_noms_mediateur.Text, txt_localite.Text, txt_appreciation.Text, dt_fin_mediation.Value);
                    refresh();
                }
            }
        }

        private void frm_mediation_Load(object sender, EventArgs e)
        {
            refresh();
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

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_mediation.Text == "")
            {
                MessageBox.Show("Completez le code du conflit a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_mediation(Convert.ToInt32(txt_num_mediation.Text));
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_mediation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            dt_debut_mediation.Text = Convert.ToString(bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString());
            txt_num_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            cbx_mediateur.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            txt_noms_mediateur.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
            txt_localite.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[5].Value.ToString();
            txt_appreciation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[6].Value.ToString();
            dt_fin_mediation.Text = Convert.ToString(bunifuCustomDataGrid2.SelectedRows[0].Cells[7].Value.ToString());
        }

        private void btn_enregistrer_Click_1(object sender, EventArgs e)
        {
            btn_enregistrer_Click(sender, e);
        }

        private void btn_supprimer_Click_1(object sender, EventArgs e)
        {
            btn_supprimer_Click(sender, e);
        }

        private void btn_resolutions_Click(object sender, EventArgs e)
        {
            var fr = new frm_assign_resolutions();
            fr.txt_num_conflit.Text = txt_num_conflit.Text;
            fr.ShowDialog();
        }

        private void txt_num_conflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.afficher_mediation(bunifuCustomDataGrid2, txt_num_conflit.Text);
        }
    }
}
