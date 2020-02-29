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
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
