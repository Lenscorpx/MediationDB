using System;
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
    public partial class frm_organisation_atelier : Form
    {
        public frm_organisation_atelier()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(txt_num_participation.Text=="")
            {
                MessageBox.Show("Veuillez choisir l'atelier pour lequel vous voulez consulter ou ajouter des participants");
            }
            else
            {

            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (txt_num_participation.Text == "")
            {
                MessageBox.Show("Veuillez choisir l'atelier pour lequel vous voulez consulter ou ajouter des observations");
            }
            else
            {

            }
        }
    }
}
