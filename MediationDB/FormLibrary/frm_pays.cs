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
            if(txt_code_pays.Text==""|| txt_capitale.Text == "" || txt_noms_pays_fr.Text == "" || txt_nom_pays_eng.Text == "")
            {
                MessageBox.Show(this,"Veuillez completer les cases manquantes!", "Elements manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                rps.ajouter_pays(txt_code_pays.Text, txt_nom_pays_eng.Text, txt_noms_pays_fr.Text, txt_capitale.Text);
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(txt_code_pays.Text=="")
            {
                MessageBox.Show(this,"Completez le code du pays a supprimer!", "Elements manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Etes vous sur de vouloir supprimer cette information?", "Confirmation de suppression", 
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(rs==DialogResult.Yes)
                {
                    rps.supprimer_pays(txt_code_pays.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_pays.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_nom_pays_eng.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            txt_noms_pays_fr.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_capitale.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
