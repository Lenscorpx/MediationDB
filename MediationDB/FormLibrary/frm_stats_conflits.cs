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
    public partial class frm_stats_conflits : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_stats_conflits()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.recuperer_localite(listBox1);
            //rps.recuperer_resolutions(cbx_resolutions);
        }
        private void lbl_nbre_conflits_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_localite.Text = listBox1.SelectedItem.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
