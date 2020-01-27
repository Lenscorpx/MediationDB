using MediationDB.DataLibrary;
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
    public partial class frm_atelier_masse : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_atelier_masse()
        {
            InitializeComponent();
        }
    }
}
