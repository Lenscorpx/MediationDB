﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediationDB.FormLibrary
{
    public partial class frm_accueil : Form
    {
        public frm_accueil()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs = MessageBox.Show(this, "Voulez vous quitter?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_fonciers_Click(object sender, EventArgs e)
        {

        }
    }
}