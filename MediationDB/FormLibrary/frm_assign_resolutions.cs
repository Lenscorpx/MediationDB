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
    public partial class frm_assign_resolutions : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_assign_resolutions()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_assign_resolutions(bunifuCustomDataGrid2);
            rps.recuperer_resolutions(cbx_resolutions);
            rtxt_descr.Clear();            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_num_details.Text=="")
            {
                if(txt_num_conflit.Text==""||cbx_resolutions.Text=="")
                {
                    MessageBox.Show("Completez les champs vides!");
                }
                else
                {
                    rps.inserer_assign_resolutions(cbx_resolutions.Text, txt_num_conflit.Text, Convert.ToDateTime(dt_date_resolution.Text), rtxt_descr.Text);
                    refresh();
                }
            }
            else
            {
                if (txt_num_conflit.Text == "" || cbx_resolutions.Text == "")
                {
                    MessageBox.Show("Completez les champs vides!");
                }
                else
                {
                    rps.modifier_assign_resolutions(Convert.ToInt32(txt_num_details.Text), cbx_resolutions.Text, txt_num_conflit.Text, Convert.ToDateTime(dt_date_resolution.Text), rtxt_descr.Text);
                    refresh();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_details.Text == "")
            {
                MessageBox.Show("Completez le code de resolutions a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_assign_resolutions(Convert.ToInt32(txt_num_details.Text));
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_details.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_num_conflit.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            cbx_resolutions.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            dt_date_resolution.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            rtxt_descr.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
