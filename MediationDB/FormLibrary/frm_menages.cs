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
    public partial class frm_menages : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_menages()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_menages(bunifuCustomDataGrid2);
            txt_code_menage.ResetText();
            txt_num_conflit.ResetText();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_membres();
            fr.Show();
        }
    }
}
