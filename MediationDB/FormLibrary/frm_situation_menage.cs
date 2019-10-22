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
        }
    }
}
