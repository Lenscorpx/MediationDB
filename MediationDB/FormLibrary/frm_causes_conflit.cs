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
    public partial class frm_causes_conflit : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_causes_conflit()
        {
            InitializeComponent();
            refresh();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_cause_conflit.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void refresh()
        {
            rps.afficher_causes_conflit(bunifuCustomDataGrid1);
            txt_description.ResetText();
            txt_id_cause_conflit.ResetText();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

            if (txt_id_cause_conflit.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_causes_conflit(txt_id_cause_conflit.Text, txt_description.Text);
                refresh();
            }
        }

        private void txt_id_cause_conflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_cause_conflit(bunifuCustomDataGrid1, txt_id_cause_conflit.Text);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_cause_conflit.Text == "")
            {
                MessageBox.Show("Completez la cause de conflit a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_cause_conflit(txt_id_cause_conflit.Text);
                    refresh();
                }
            }
        }
    }
}
