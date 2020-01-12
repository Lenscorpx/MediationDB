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
    public partial class frm_search_ateliers : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_search_ateliers()
        {
            InitializeComponent();
            refreshData();
        }

        private void refreshData()
        {
            rps.afficher_ateliers_sensibilises(bunifuCustomDataGrid2);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            rps.rechercher_ateliers_sensibilises_par_dates(bunifuCustomDataGrid2, dt_debut.Value, dt_fin.Value);
        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_ateliers_sensibilises_par_localite(bunifuCustomDataGrid2, txt_id_localite.Text);
        }

        private void txt_theme_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_ateliers_sensibilises_par_themes(bunifuCustomDataGrid2, txt_theme.Text);
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
