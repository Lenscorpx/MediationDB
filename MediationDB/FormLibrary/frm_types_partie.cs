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
    public partial class frm_types_partie : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_types_partie()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_type_partie(bunifuCustomDataGrid2);
            txt_description.ResetText();
            txt_type_partie.ResetText();
        }

        private void txt_type_partie_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_type_partie(bunifuCustomDataGrid2, txt_type_partie.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_type_partie.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_type_parties(txt_type_partie.Text, txt_description.Text);
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_type_partie.Text == "")
            {
                MessageBox.Show("Completez la nature de conflit a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_type_partie(txt_type_partie.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_type_partie.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
