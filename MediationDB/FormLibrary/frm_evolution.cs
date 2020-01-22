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
    public partial class frm_evolution : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_evolution()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_evolution_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rps.chart_nombre_membre(lbl_nombre_membre);
                rps.chart_nombre_menage(lbl_nombre_menages);
                lbl_date.Text = Convert.ToString(DateTime.Now);
            }
            catch
            {

            }
            
        }
    }
}
