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
    public partial class frm_details_conflit : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_details_conflit()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            //MessageBox.Show(txt_num_conflit.Text);
            rps.afficher_details_conflits(bunifuCustomDataGrid1, Convert.ToInt32(txt_num_conflit.Text));
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_num_details.Text == "")
            {
                if (rtxt_descr.Text=="")
                {
                    MessageBox.Show("Descrivez le detail sur le conflit au lieu prevu!");
                }
                else
                {
                    rps.inserer_details(rtxt_descr.Text, Convert.ToInt32(txt_num_conflit.Text));
                    refresh();
                }
            }
            else
            {
                if (rtxt_descr.Text == "")
                {
                    MessageBox.Show("Descrivez le detail sur le conflit au lieu prevu!");
                }
                else
                {
                    rps.modifier_details(Convert.ToInt32(txt_num_details.Text),rtxt_descr.Text, Convert.ToInt32(txt_num_conflit.Text));
                    refresh();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_details.Text == "")
            {
                MessageBox.Show("Veuillezz selectionner le detail a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_details_conflits(Convert.ToInt32(txt_num_details.Text));
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_details.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_num_conflit .Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            rtxt_descr.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void frm_details_conflit_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
