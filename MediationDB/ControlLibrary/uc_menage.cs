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
        }

        private void refreshData()
        {            
            rps.recuperer_situation_menage(cbx_situation);
            txt_id_menage.ResetText();
            cbx_situation.Text = "";
            rps.afficher_menages(bunifuCustomDataGrid1);
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

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_id_menage.Text==""||cbx_situation.Text=="")
                {
                    MessageBox.Show("Veuillez completez les éléments manquants!");
                }
            else
                {
                    rps.enregistrer_menage(txt_id_menage.Text, cbx_situation.Text);
                refreshData();
                }            
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_menage.Text == "")
            {
                MessageBox.Show("Completez le code de menage a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_menage(txt_id_menage.Text);
                    refreshData();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void uc_menage_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_menage.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            dt_date_enregistrement.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            cbx_situation.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
