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
    public partial class frm_pays : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_pays()
        {
            InitializeComponent();
            refresh();
        }
        public void refresh()
        {
            rps.afficher_pays(bunifuCustomDataGrid2);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_code_pays.Text=="")
            {
                if(txt_capitale.Text==""||txt_noms_pays_fr.Text==""||txt_nom_pays_eng.Text=="")
                {
                    MessageBox.Show("Veuillez completer les cases manquantes!");
                }
                else
                {
                    rps.ajouter_pays(txt)
                }
            }
        }
    }
}
