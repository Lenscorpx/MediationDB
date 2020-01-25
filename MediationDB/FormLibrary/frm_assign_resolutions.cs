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
    }
}
