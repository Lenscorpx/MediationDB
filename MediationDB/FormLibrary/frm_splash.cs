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
    public partial class frm_splash : Form
    {
        int count = 0, buffer = 0;
        public frm_splash()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.05;
                pictureBox4.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox1.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            if (buffer == 15)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox4.Hide();
            if (buffer == 15)
            {
                timer4.Start();
                timer3.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                var m = new frm_menu();
                m.Show();
                timer4.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.05;
                pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox4.Hide();
                pictureBox3.Hide();
            }
        }
    }
}
