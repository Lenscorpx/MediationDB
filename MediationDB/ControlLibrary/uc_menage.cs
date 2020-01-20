using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.FormLibrary;
using MediationDB.DataLibrary;

namespace MediationDB.ControlLibrary
{
    public partial class uc_menage : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_menage()
        {
            InitializeComponent();            
        }

        private void refreshData()
        {            
            rps.recuperer_situation_menage(cbx_situation);
            txt_id_menage.ResetText();
            cbx_situation.Text = "";
            rps.afficher_menages(bunifuCustomDataGrid1);
        }
        private void btn_membres_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
                     
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void uc_menage_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
