﻿using System;
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
    public partial class frm_stats_conflits : Form
    {
        Data_Repository rps = new Data_Repository();
        public frm_stats_conflits()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            rps.recuperer_localite(listBox1);
            try
            {
                txt_conflits_classes.ResetText();
                txt_conflits_encours.ResetText();
                txt_conflits_referes.ResetText();
                txt_conflit_resolus.ResetText();
                txt_femmes_classes.ResetText();
                txt_femmes_conflits.ResetText();
                txt_femmes_encours.ResetText();
                txt_femmes_referes.ResetText();
                txt_femmes_resolus.ResetText();
                txt_filles_classes.ResetText();
                txt_filles_conflits.ResetText();
                txt_filles_encours.ResetText();
                txt_filles_referes.ResetText();
                txt_filles_resolus.ResetText();
                txt_garcons.ResetText();
                txt_garcons_classes.ResetText();
                txt_garcons_encours.ResetText();
                txt_garcons_referes.ResetText();
                txt_garcons_resolus.ResetText();
                txt_hommes_classes.ResetText();
                txt_hommes_conflits.ResetText();
                txt_hommes_encours.ResetText();
                txt_hommes_referes.ResetText();
                txt_hommes_resolus.ResetText();
                txt_nombre_conflit.ResetText();
                txt_total_classes.ResetText();
                txt_total_encours.ResetText();
                txt_total_femmes.ResetText();
                txt_total_filles.ResetText();
                txt_total_garcons.ResetText();
                txt_total_general.ResetText();
                txt_total_hommes.ResetText();
                txt_total_menages.ResetText();
                txt_total_referes.ResetText();
                txt_total_resolus.ResetText();
                
            }
            catch
            {

            }
            //rps.recuperer_resolutions(cbx_resolutions);
        }
        private void lbl_nbre_conflits_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_localite_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_localite(listBox1, txt_id_localite.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_localite.Text = listBox1.SelectedItem.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_period_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_conflit_resolus_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_conflit_resolus.Text == "")
                {
                    chart_resolus.Value = 0;
                }
                else
                {
                    chart_resolus.Value = (Convert.ToInt32(txt_conflit_resolus.Text) * 100) / Convert.ToInt32(txt_nombre_conflit.Text);
                }

            }
            catch
            {

            }
        }

        private void txt_conflits_encours_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_conflits_encours.Text == "")
                {
                    chart_encours.Value = 0;
                }
                else
                {
                    chart_encours.Value = (Convert.ToInt32(txt_conflits_encours.Text) * 100) / Convert.ToInt32(txt_nombre_conflit.Text);
                }
            }
            catch
            {

            }
        }

        private void txt_conflits_referes_OnValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (txt_conflits_referes.Text == "")
                {
                    chart_referes.Value = 0;
                }
                else
                {
                    chart_referes.Value = (Convert.ToInt32(txt_conflits_referes.Text) * 100) / Convert.ToInt32(txt_nombre_conflit.Text);
                }
            }
            catch
            {

            }
        }

        private void txt_conflits_classes_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_conflits_classes.Text == "")
                {
                    chart_classes.Value = 0;
                }
                else
                {
                    chart_classes.Value = (Convert.ToInt32(txt_conflits_classes.Text) * 100) / Convert.ToInt32(txt_nombre_conflit.Text);
                }
            }
            catch
            {

            }
        }

        private void txt_nombre_conflit_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            rps.stats_total_conflit_parperiode(txt_nombre_conflit, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_conflit_resolu_parperiode(txt_conflit_resolus, "Résolu", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_conflit_resolu_parperiode(txt_conflits_referes, "Referé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_conflit_resolu_parperiode(txt_conflits_classes, "Classé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_conflit_resolu_parperiode(txt_conflits_encours, "En cours", dt_resol_1.Value, dt_resol_2.Value);


            rps.stats_total_menages_conflit_parperiode(txt_total_menages, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_total_menages_conflit_parperiode(txt_total_general, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_menages_conflit_resolus_parperiode(txt_total_resolus, "Résolu", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_menages_conflit_resolus_parperiode(txt_total_referes, "Referé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_menages_conflit_resolus_parperiode(txt_total_classes, "Classé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_menages_conflit_resolus_parperiode(txt_total_encours, "En cours", dt_resol_1.Value, dt_resol_2.Value);


            rps.stats_total_hommes_conflit_parperiode(txt_hommes_conflits, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_total_hommes_conflit_parperiode(txt_total_hommes, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_hommes_conflit_resolu_parperiode(txt_hommes_resolus, "Résolu", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_hommes_conflit_resolu_parperiode(txt_hommes_referes, "Referé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_hommes_conflit_resolu_parperiode(txt_hommes_classes, "Classé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_hommes_conflit_resolu_parperiode(txt_hommes_encours, "En cours", dt_resol_1.Value, dt_resol_2.Value);


            rps.stats_total_femmes_conflit_parperiode(txt_femmes_conflits, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_total_femmes_conflit_parperiode(txt_total_femmes, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_femmes_conflit_resolus_parperiode(txt_femmes_resolus, "Résolu", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_femmes_conflit_resolus_parperiode(txt_femmes_referes, "Referé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_femmes_conflit_resolus_parperiode(txt_femmes_classes, "Classé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_femmes_conflit_resolus_parperiode(txt_femmes_encours, "En cours", dt_resol_1.Value, dt_resol_2.Value);


            rps.stats_total_filles_conflit_parperiode(txt_filles_conflits, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_total_filles_conflit_parperiode(txt_total_filles, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_filles_conflit_resolus_parperiode(txt_filles_resolus, "Résolu", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_filles_conflit_resolus_parperiode(txt_filles_referes, "Referé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_filles_conflit_resolus_parperiode(txt_filles_classes, "Classé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_filles_conflit_resolus_parperiode(txt_filles_encours, "En cours", dt_resol_1.Value, dt_resol_2.Value);

            rps.stats_total_garcons_conflit_parperiode(txt_garcons, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_total_garcons_conflit_parperiode(txt_total_garcons, dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_garcons_conflit_resolus_parperiode(txt_garcons_resolus, "Résolu", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_garcons_conflit_resolus_parperiode(txt_garcons_referes, "Referé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_garcons_conflit_resolus_parperiode(txt_garcons_classes, "Classé", dt_resol_1.Value, dt_resol_2.Value);
            rps.stats_garcons_conflit_resolus_parperiode(txt_garcons_encours, "En cours", dt_resol_1.Value, dt_resol_2.Value);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
