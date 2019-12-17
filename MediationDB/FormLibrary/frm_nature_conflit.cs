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
    public partial class frm_nature_conflit : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_nature_conflit()
        {
            InitializeComponent();
            refresh();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh()
        {
            rps.afficher_nature_conflit(bunifuCustomDataGrid2);
            txt_description.ResetText();
            txt_id_nature_conflit.ResetText();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_nature_conflit.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_nature_conflit(txt_id_nature_conflit.Text, txt_description.Text);
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_nature_conflit.Text == "")
            {
                MessageBox.Show("Completez la nature de conflit a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_nature_conflit(txt_id_nature_conflit.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_nature_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
