using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.ControlLibrary;

namespace MediationDB.FormLibrary
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            charger_splash();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            
        }
        private void charger_splash()
        {
            var fr = new uc_splash()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new uc_conflit()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs = MessageBox.Show(this, "Etes vous sur de vouloir quitter l'application?", "Confirmation pour quitter l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Stop,MessageBoxDefaultButton.Button2);
            if (rs==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            var fr = new uc_parametres()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new uc_menage()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }
    }
}
