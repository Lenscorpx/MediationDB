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
    public partial class frm_objet_conflit : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_objet_conflit()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_objet_conflit(bunifuCustomDataGrid2);
            txt_description.ResetText();
            txt_id_objet_conflit.ResetText();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_objet_conflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_objet_conflit(bunifuCustomDataGrid2, txt_id_objet_conflit.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_objet_conflit.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_objet_conflit(txt_id_objet_conflit.Text, txt_description.Text);
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_objet_conflit.Text == "")
            {
                MessageBox.Show("Completez l'objet de conflit a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_objet_conflit(txt_id_objet_conflit.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_objet_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
