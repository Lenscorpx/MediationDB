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
    public partial class frm_help : Form
    {
        public frm_help()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_help_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            frm_help_MouseClick(sender, e);
        }
    }
}
