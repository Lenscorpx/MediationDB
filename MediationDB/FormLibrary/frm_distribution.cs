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
    }
}
