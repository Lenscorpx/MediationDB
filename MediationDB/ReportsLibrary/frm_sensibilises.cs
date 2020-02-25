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
    public partial class frm_sensibilises : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_sensibilises()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.Liste_sensibilisationa(documentViewer1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
