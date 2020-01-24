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
    public partial class frm_details_objets_conflits : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_details_objets_conflits()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.recuperer_objet_conflit(cbx_objet_conflit);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
