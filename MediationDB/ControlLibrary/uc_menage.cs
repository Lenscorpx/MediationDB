using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.FormLibrary;
using MediationDB.DataLibrary;

namespace MediationDB.ControlLibrary
{
    public partial class uc_menage : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_menage()
        {
            InitializeComponent();
            refreshData();
        }

        private void refreshData()
        {
            rps.afficher_menages(bunifuCustomDataGrid1);
            txt_id_menage.ResetText();
            cbx_situation.Text = "";
        }
        private void btn_membres_Click(object sender, EventArgs e)
        {
            if(txt_id_menage.Text=="")
            {
                MessageBox.Show("Veuillez selectionner le menage auquel vous voulez ajouter un membre!");
            }
            else
            {
                var fr = new frm_membres();
                fr.txt_id_menage.Text = txt_id_menage.Text;
                fr.ShowDialog();
            }
        }
    }
}
