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
    public partial class frm_vulnerabilite : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_vulnerabilite()
        {
            InitializeComponent();
            refresh();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh()
        {
            txt_description.ResetText();
            txt_id_vulnerabilite.ResetText();
            rps.afficher_vulnerabilite(bunifuCustomDataGrid2);
        }

        private void txt_id_vulnerabilite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_vulnerabilite(bunifuCustomDataGrid2, txt_id_vulnerabilite.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_vulnerabilite.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_vulnerabilite.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_vulnerabilite(txt_id_vulnerabilite.Text, txt_description.Text);
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_vulnerabilite.Text == "")
            {
                MessageBox.Show("Selectionnez l'element a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_vulnerabilite(txt_id_vulnerabilite.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuCustomDataGrid1_CellContentClick(sender, e);
        }

        private void btn_enregistrer_Click_1(object sender, EventArgs e)
        {
            btn_enregistrer_Click(sender, e);
        }

        private void btn_supprimer_Click_1(object sender, EventArgs e)
        {
            btn_supprimer_Click(sender, e);
        }
    }
}
