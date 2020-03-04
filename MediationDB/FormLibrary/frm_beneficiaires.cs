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
    public partial class frm_beneficiaires : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_beneficiaires()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            rps.afficher_beneficiaires(bunifuCustomDataGrid2);
            rps.recuperer_vulnerabilite(cbx_vulnerabilite);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
