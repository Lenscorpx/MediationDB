﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.DataLibrary;

namespace MediationDB.ControlLibrary
{
    public partial class uc_conflit : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_conflit()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            rps.recuperer_localite(listBox1);
            rps.recuperer_type_conflit(cbx_type_conflit);
            rps.recuperer_nature_conflit(cbx_nature_conflit);
            rps.afficher_conflit(bunifuCustomDataGrid1);
            txt_id_localite.ResetText();
            txt_localite.ResetText();
            txt_num_conflit.ResetText();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_localite.Text = listBox1.SelectedItem.ToString();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
