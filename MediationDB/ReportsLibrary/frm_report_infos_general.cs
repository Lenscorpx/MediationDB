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
    public partial class frm_report_infos_general : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_report_infos_general()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            rps.liste_conflits_par_groupements(documentViewer1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
