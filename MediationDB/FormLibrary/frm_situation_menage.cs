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
    public partial class frm_situation_menage : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_situation_menage()
        {
            InitializeComponent();
            refresh();            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh()
        {            
            txt_description.ResetText();
            txt_id_situation.ResetText();
            panel1.Focus();
            rps.afficher_situation_menage(bunifuCustomDataGrid2);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_situation.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Veuillez completer les champs necessaires!");
            }
            else
            {
                rps.enregistrer_situation_menage(txt_id_situation.Text, txt_description.Text);
                refresh();
            }
        }

        private void txt_id_situation_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_situation(bunifuCustomDataGrid2, txt_id_situation.Text);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_situation.Text == "")
            {
                MessageBox.Show("Completez la situation de menage a supprimer");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous vraiment supprimer cette information?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_situation_menage(txt_id_situation.Text);
                    refresh();
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txt_id_situation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
                txt_description.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }