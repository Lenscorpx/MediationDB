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
    public partial class frm_sensibilisation : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_sensibilisation()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.afficher_sensibilisation(bunifuCustomDataGrid2);
            rps.recuperer_localite(listBox1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_localite.Text = listBox1.SelectedItem.ToString();
        }
    }
}