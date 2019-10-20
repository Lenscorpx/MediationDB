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
    public partial class frm_mediateur : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_mediateur()
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
            rps.afficher_mediateur(bunifuCustomDataGrid1);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_mediateur.Text=bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text= bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
    
}
