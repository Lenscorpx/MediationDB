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
    public partial class frm_assign_resolutions : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_assign_resolutions()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            rps.afficher_a
        }
    }
}
