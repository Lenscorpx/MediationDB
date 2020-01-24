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
    }
}
