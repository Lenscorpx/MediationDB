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
    public partial class frm_type_conflit : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_type_conflit()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_type_conflit(bunifuCustomDataGrid1);
            txt_description.ResetText();
            txt_id_typeconflit.ResetText();
        }

        private void txt_id_typeconflit_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_type_conflit(bunifuCustomDataGrid1, txt_id_typeconflit.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_typeconflit.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_type_conflit(txt_id_typeconflit.Text, txt_description.Text);
                refresh();
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_typeconflit.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_typeconflit.Text == "")
            {
                MessageBox.Show("Completez le code du mediateur a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_type_conflit(txt_id_typeconflit.Text);
                    refresh();
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
