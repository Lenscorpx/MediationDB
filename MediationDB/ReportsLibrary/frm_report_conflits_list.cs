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

namespace MediationDB.ReportsLibrary
{
    public partial class frm_report_conflits_list : Form
    {
        Data_Repository rps= new Data_Repository();   
        rpt_conflits rpt = new rpt_conflits();
        public frm_report_conflits_list()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {            
            rpt.DataSource = rps.liste_conflits_par_groupements();
            //rpt.SetDataSource(dt.Tables["rechercher_pay_bill"]);                    
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
            documentViewer1.Refresh();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
