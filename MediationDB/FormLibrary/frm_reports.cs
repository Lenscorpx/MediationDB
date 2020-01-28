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
    public partial class frm_reports : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_reports()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_rapport_conflit(bunifuCustomDataGrid2);
            rps.recuperer_localite(listBox1);
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
            rps.search_rapport_conflit_by_localite(bunifuCustomDataGrid2, txt_localite.Text);
        }

        private void txt_code_conflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_rapport_conflit_by_conflit(bunifuCustomDataGrid2, txt_code_conflit.Text);
        }

        private void txt_typesconflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_rapport_conflit_by_typeconflit(bunifuCustomDataGrid2, txt_typesconflit.Text);
        }

        private void txt_nature_conflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_rapport_conflit_by_natureconflit(bunifuCustomDataGrid2, txt_nature_conflit.Text);
        }

        private void txt_groupement_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_rapport_conflit_by_groupement(bunifuCustomDataGrid2, txt_groupement.Text);
        }

        private void txt_etat_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_rapport_conflit_by_etat(bunifuCustomDataGrid2, txt_etat.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            rps.search_rapporsearch_rapport_conflit_by_date_conflit(bunifuCustomDataGrid2, dt_conf_1.Value, dt_conf_2.Value);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            rps.search_rapport_conflit_by_date_resolution(bunifuCustomDataGrid2, dt_resol_1.Value, dt_resol_2.Value);
        }
    }
}
