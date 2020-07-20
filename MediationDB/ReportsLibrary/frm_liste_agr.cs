using MediationDB.DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediationDB.ReportsLibrary
{
    public partial class frm_liste_agr : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_liste_agr()
        {
            InitializeComponent();
            refresh();
            //rps.liste_beneficiaires(documentViewer1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh()
        {
            rps.liste_beneficiaires(documentViewer1);
        }
    }
}
