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
    }
}
