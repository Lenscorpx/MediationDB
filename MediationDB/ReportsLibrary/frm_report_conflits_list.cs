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
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace MediationDB.ReportsLibrary
{
    public partial class frm_report_conflits_list : Form
    {
        Data_Repository rps= new Data_Repository();   
       
        public frm_report_conflits_list()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.liste_conflits_par_groupements(documentViewer1);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
