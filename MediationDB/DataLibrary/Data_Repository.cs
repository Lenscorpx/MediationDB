using Bunifu.Framework.UI;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediationDB.FormLibrary;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports;
using MediationDB.ReportsLibrary;

namespace MediationDB.DataLibrary
{
    public class Data_Repository
    {
        static SqlConnection cnx;
        Params prms = new Params();
        public Data_Repository()
        {
            prms.Serveur = "unhserver.database.windows.net";
            prms.Base_de_donnees = "db_foncier";
            prms.Nom_user = "Lens";
            prms.Mot_de_passe = "unhabitat@@2020";
            //prms.Serveur = "DESKTOP-PO0I2OH";
            //prms.Base_de_donnees = "db_foncier";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "Windy@2019.com?";
            //prms.Serveur = "DESKTOP-VIA78VL";
            //prms.Base_de_donnees = "db_foncier";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "Windy@2020.com?";
            //prms.Serveur = "DESKTOP-LSH2J11\\UNHABITAT_SERVER";
            //prms.Base_de_donnees = "db_foncier";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "UNH@PKA2020";
            //prms.Serveur = "DESKTOP-NFR9KTI";
            //prms.Base_de_donnees = "db_foncier";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "123456789";

        }
        public void afficher_mediateur(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_mediateur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_mediateur(string id_mediateur, string descr_mediateur)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_mediateur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_mediateur", SqlDbType.NVarChar)).Value = id_mediateur;
                cmd.Parameters.Add(new SqlParameter("descr_mediateur", SqlDbType.NVarChar)).Value = descr_mediateur;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_mediateur(string id_mediateur)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_mediateur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_mediateur", SqlDbType.NVarChar)).Value = id_mediateur;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_mediateur(DataGridView dtg, string id_mediateur)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_mediateur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_mediateur", SqlDbType.NVarChar)).Value = id_mediateur;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_type_conflit(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_type_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_type_conflit(string id_type_conflit, string descr_type_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_type_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_type_conflit", SqlDbType.NVarChar)).Value = id_type_conflit;
                cmd.Parameters.Add(new SqlParameter("descr_type_conflit", SqlDbType.NVarChar)).Value = descr_type_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_type_conflit(string id_type_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_type_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_type_conflit", SqlDbType.NVarChar)).Value = id_type_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_type_conflit(DataGridView dtg, string id_type_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_type_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_type_conflit", SqlDbType.NVarChar)).Value = id_type_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_causes_conflit(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_causes_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_causes_conflit(string id_cause_conflit, string descr_causes)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_causes_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_cause_conflit", SqlDbType.NVarChar)).Value = id_cause_conflit;
                cmd.Parameters.Add(new SqlParameter("descr_causes", SqlDbType.NVarChar)).Value = descr_causes;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_cause_conflit(string id_cause_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_cause_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_cause_conflit", SqlDbType.NVarChar)).Value = id_cause_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_cause_conflit(DataGridView dtg, string id_cause_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_cause_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_cause_conflit", SqlDbType.NVarChar)).Value = id_cause_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_objet_conflit(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_objet_conflit(string id_objets_conflits, string descr_objet_conflits)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_objets_conflits", SqlDbType.NVarChar)).Value = id_objets_conflits;
                cmd.Parameters.Add(new SqlParameter("descr_objet_conflits", SqlDbType.NVarChar)).Value = descr_objet_conflits;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_objet_conflit(string id_objets_conflits)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_objets_conflits", SqlDbType.NVarChar)).Value = id_objets_conflits;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_objet_conflit(DataGridView dtg, string id_objets_conflits)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_objets_conflits", SqlDbType.NVarChar)).Value = id_objets_conflits;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_nature_conflit(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_nature_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_nature_conflit(string id_nature_conflit, string descr_nature_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_nature_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_nature_conflit", SqlDbType.NVarChar)).Value = id_nature_conflit;
                cmd.Parameters.Add(new SqlParameter("descr_nature_conflit", SqlDbType.NVarChar)).Value = descr_nature_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_nature_conflit(string id_nature_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_nature_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_nature_conflit", SqlDbType.NVarChar)).Value = id_nature_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_nature_conflit(DataGridView dtg, string id_nature_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_nature_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_nature_conflit", SqlDbType.NVarChar)).Value = id_nature_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_type_partie(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_type_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_type_parties(string id_typ_partie, string descr_typ_partie)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_type_parties", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_typ_partie", SqlDbType.NVarChar)).Value = id_typ_partie;
                cmd.Parameters.Add(new SqlParameter("descr_typ_partie", SqlDbType.NVarChar)).Value = descr_typ_partie;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_type_partie(string id_typ_partie)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_type_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_typ_partie", SqlDbType.NVarChar)).Value = id_typ_partie;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_type_partie(DataGridView dtg, string id_typ_partie)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_type_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_typ_partie", SqlDbType.NVarChar)).Value = id_typ_partie;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_situation_menage(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_situation_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_situation_menage(string id_situation, string descr_situation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_situation_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_situation", SqlDbType.NVarChar)).Value = id_situation;
                cmd.Parameters.Add(new SqlParameter("descr_situation", SqlDbType.NVarChar)).Value = descr_situation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_situation_menage(string id_situation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_situation_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_situation", SqlDbType.NVarChar)).Value = id_situation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_situation(DataGridView dtg, string id_situation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_situation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_situation", SqlDbType.NVarChar)).Value = id_situation;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_vulnerabilite (DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_vulnerabilite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_vulnerabilite(string id_vulnerabilite, string descr_vulnerabilite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_vulnerabilite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_vulnerabilite", SqlDbType.NVarChar)).Value = id_vulnerabilite;
                cmd.Parameters.Add(new SqlParameter("descr_vulnerabilite", SqlDbType.NVarChar)).Value = descr_vulnerabilite;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_vulnerabilite(string id_vulnerabilite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_vulnerabilite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_vulnerabilite", SqlDbType.NVarChar)).Value = id_vulnerabilite;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_vulnerabilite(DataGridView dtg, string id_vulnerabilite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_vulnerabilite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_vulnerabilite", SqlDbType.NVarChar)).Value = id_vulnerabilite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_vulnerabilite(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_vulnerabilite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_resolution(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_resolution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_resolution(string id_resolution, string descr_resolution)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_resolution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.Parameters.Add(new SqlParameter("descr_resolution", SqlDbType.NVarChar)).Value = descr_resolution;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_resolution(string id_resolution)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_resolution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_resolution(DataGridView dtg, string id_resolution)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_resolution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_localite(ListBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_localite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_type_conflit(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_type_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_nature_conflit(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_nature_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_localite(ListBox cbx, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_localite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_conflit(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_conflit(DataGridView dtg, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_conflit(string num_conflit,DateTime date_debut_conflit, string id_type_conflit, string id_nature_conflit, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("date_debut_conflit", SqlDbType.Date)).Value = date_debut_conflit;
                cmd.Parameters.Add(new SqlParameter("id_type_conflit", SqlDbType.NVarChar)).Value = id_type_conflit;
                cmd.Parameters.Add(new SqlParameter("id_nature_conflit", SqlDbType.NVarChar)).Value = id_nature_conflit;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_conflit(string num_conflit, DateTime date_debut_conflit, string id_type_conflit, string id_nature_conflit, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("date_debut_conflit", SqlDbType.Date)).Value = date_debut_conflit;
                cmd.Parameters.Add(new SqlParameter("id_type_conflit", SqlDbType.NVarChar)).Value = id_type_conflit;
                cmd.Parameters.Add(new SqlParameter("id_nature_conflit", SqlDbType.NVarChar)).Value = id_nature_conflit;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_conflit(string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_details_conflits(DataGridView dtg, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_details_conflits", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_details(string descript_conflit, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_details", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("descript_conflit", SqlDbType.NVarChar)).Value = descript_conflit;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_details(int num_details_conflits, string descript_conflit, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_details", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details_conflits", SqlDbType.Int)).Value = num_details_conflits;
                cmd.Parameters.Add(new SqlParameter("descript_conflit", SqlDbType.NVarChar)).Value = descript_conflit;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_details_conflits(int num_details_conflits)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_details_conflits", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details_conflits", SqlDbType.Int)).Value = num_details_conflits;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_mediation(DataGridView dtg, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_mediation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_mediation_all(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_mediation_all", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_mediation(DateTime date_debut_mediation, string num_conflit, string id_mediateur, string noms_mediateur, string lieu, string appreciation, DateTime date_fin_mediation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_mediation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_debut_mediation", SqlDbType.Date)).Value = date_debut_mediation;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("id_mediateur", SqlDbType.NVarChar)).Value = id_mediateur;
                cmd.Parameters.Add(new SqlParameter("noms_mediateur", SqlDbType.NVarChar)).Value = noms_mediateur;
                cmd.Parameters.Add(new SqlParameter("lieu", SqlDbType.NVarChar)).Value = lieu;
                cmd.Parameters.Add(new SqlParameter("appreciation", SqlDbType.NVarChar)).Value = appreciation;
                cmd.Parameters.Add(new SqlParameter("date_fin_mediation", SqlDbType.Date)).Value = date_fin_mediation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_mediation(int num_mediation, DateTime date_debut_mediation, string num_conflit, string id_mediateur, string noms_mediateur, string lieu, string appreciation, DateTime date_fin_mediation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_mediation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_mediation", SqlDbType.Int)).Value = num_mediation;
                cmd.Parameters.Add(new SqlParameter("date_debut_mediation", SqlDbType.Date)).Value = date_debut_mediation;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("id_mediateur", SqlDbType.NVarChar)).Value = id_mediateur;
                cmd.Parameters.Add(new SqlParameter("noms_mediateur", SqlDbType.NVarChar)).Value = noms_mediateur;
                cmd.Parameters.Add(new SqlParameter("lieu", SqlDbType.NVarChar)).Value = lieu;
                cmd.Parameters.Add(new SqlParameter("appreciation", SqlDbType.NVarChar)).Value = appreciation;
                cmd.Parameters.Add(new SqlParameter("date_fin_mediation", SqlDbType.Date)).Value = date_fin_mediation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_mediation(int num_mediation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_mediation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_mediation", SqlDbType.Int)).Value = num_mediation;
                
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_mediateur(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_mediateur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_menages(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_menages", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_menage(string id_menage, string id_situation, int hommes, int femmes, int garcons, int filles)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.Parameters.Add(new SqlParameter("id_situation", SqlDbType.NVarChar)).Value = id_situation;
                cmd.Parameters.Add(new SqlParameter("hommes", SqlDbType.Int)).Value = hommes;
                cmd.Parameters.Add(new SqlParameter("femmes", SqlDbType.Int)).Value = femmes;
                cmd.Parameters.Add(new SqlParameter("garcons", SqlDbType.Int)).Value = garcons;
                cmd.Parameters.Add(new SqlParameter("filles", SqlDbType.Int)).Value = filles;
                cmd.ExecuteNonQuery();
                var fr = new frm_membres();
                fr.txt_id_menage.Text = id_menage;
                fr.ShowDialog();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_menage(string id_menage)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_situation_menage(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_situation_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connections failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_sensibilisation(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_sensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_sensibilisation(string num_sensibilisation, DateTime date_debut, DateTime date_fin, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_sensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.NVarChar)).Value = num_sensibilisation;
                cmd.Parameters.Add(new SqlParameter("date_debut", SqlDbType.Date)).Value = date_debut;
                cmd.Parameters.Add(new SqlParameter("date_fin", SqlDbType.Date)).Value = date_fin;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_sensibilisation(int num_sensibilisation, DateTime date_debut, DateTime date_fin, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_sensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.Int)).Value = num_sensibilisation;
                cmd.Parameters.Add(new SqlParameter("date_debut", SqlDbType.Date)).Value = date_debut;
                cmd.Parameters.Add(new SqlParameter("date_fin", SqlDbType.Date)).Value = date_fin;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_sensibilisation(string num_sensibilisation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_sensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.NVarChar)).Value = num_sensibilisation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_sensibilisation(DataGridView dtg, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_sensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_sensibilisation_bycode_sensibilisation(DataGridView dtg, string num_sensibilisation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_sensibilisation_bycode_sensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.NVarChar)).Value = num_sensibilisation;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_ateliers_sensibilises(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_ateliers_sensibilises", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_ateliers_sensibilises_par_dates(DataGridView dtg, DateTime date_debut, DateTime date_fin)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_ateliers_sensibilises_par_dates", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };                
                cmd.Parameters.Add(new SqlParameter("date_debut", SqlDbType.Date)).Value = date_debut;
                cmd.Parameters.Add(new SqlParameter("date_fin", SqlDbType.Date)).Value = date_fin;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_ateliers_sensibilises_par_localite(DataGridView dtg, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_ateliers_sensibilises_par_localite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_ateliers_sensibilises_par_themes(DataGridView dtg, string theme)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_ateliers_sensibilises_par_themes", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("theme", SqlDbType.NVarChar)).Value = theme;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_membres(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_membres", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_membre(string id_membre, string noms, DateTime date_naissance, string sexe, string etat_civil, string id_vulnerabilite, string provenance, 
                                   string adresse, string num_tel, string repr_menage, string profession, string id_menage, DateTime date_enregistrement)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_membre", SqlDbType.NVarChar)).Value = id_membre;
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = noms;
                cmd.Parameters.Add(new SqlParameter("date_naissance", SqlDbType.Date)).Value = date_naissance;
                cmd.Parameters.Add(new SqlParameter("sexe", SqlDbType.NVarChar)).Value = sexe;
                cmd.Parameters.Add(new SqlParameter("etat_civil", SqlDbType.NVarChar)).Value = etat_civil;
                cmd.Parameters.Add(new SqlParameter("id_vulnerabilite", SqlDbType.NVarChar)).Value = id_vulnerabilite;
                cmd.Parameters.Add(new SqlParameter("provenance", SqlDbType.NVarChar)).Value = provenance;
                cmd.Parameters.Add(new SqlParameter("adresse", SqlDbType.NVarChar)).Value = adresse;
                cmd.Parameters.Add(new SqlParameter("num_tel", SqlDbType.NVarChar)).Value = num_tel;
                cmd.Parameters.Add(new SqlParameter("profession", SqlDbType.NVarChar)).Value = profession;
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.Parameters.Add(new SqlParameter("repr_menage", SqlDbType.NVarChar)).Value = repr_menage;
                cmd.Parameters.Add(new SqlParameter("date_enregistrement", SqlDbType.Date)).Value = date_enregistrement;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }        
        public void supprimer_membre(string id_membre)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_membre", SqlDbType.NVarChar)).Value = id_membre;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }

        public void rechercher_membres_parID(DataGridView dtg, string id_menage)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_membres_parID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }        
        public void rechercher_membres_parCodeMembre(DataGridView dtg, string id_membre)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_membres_parCodeMembre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_membre", SqlDbType.NVarChar)).Value = id_membre;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_membres_parNoms(DataGridView dtg, string noms)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_membres_parNoms", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = noms;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        //public void afficher_details_conflits(DataGridView dtg, string num_conflit)
        //{
        //    cnx = new SqlConnection(prms.ToString());
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        var cmd = new SqlCommand("afficher_details_conflits", cnx)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
        //        cmd.ExecuteNonQuery();
        //        var da = new SqlDataAdapter(cmd);
        //        var dt = new DataTable();
        //        da.Fill(dt);
        //        dtg.DataSource = dt;
        //    }
        //    catch (Exception exct)
        //    {
        //        var rs = new DialogResult();
        //        rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (rs == DialogResult.Yes)
        //        {
        //            MessageBox.Show(exct.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        cnx.Close(); cnx.Dispose();
        //    }
        //}
        //public void inserer_details(string descript_conflit, string num_conflit)
        //{
        //    cnx = new SqlConnection(prms.ToString());
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        var cmd = new SqlCommand("inserer_details", cnx)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.Add(new SqlParameter("descript_conflit", SqlDbType.NVarChar)).Value = descript_conflit;
        //        cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
        //        cmd.ExecuteNonQuery();
        //        //afficher_frais(dtg);
        //        MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception tdf)
        //    {
        //        var rs = new DialogResult();
        //        rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (rs == DialogResult.Yes)
        //        {
        //            MessageBox.Show(tdf.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        cnx.Close(); cnx.Dispose();
        //    }
        //}
        //public void modifier_details(int num_details_conflits, string descript_conflit, string num_conflit)
        //{
        //    cnx = new SqlConnection(prms.ToString());
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        var cmd = new SqlCommand("modifier_details", cnx)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.Add(new SqlParameter("num_details_conflits", SqlDbType.Int)).Value = num_details_conflits;
        //        cmd.Parameters.Add(new SqlParameter("descript_conflit", SqlDbType.NVarChar)).Value = descript_conflit;
        //        cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
        //        cmd.ExecuteNonQuery();
        //        //afficher_frais(dtg);
        //        MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception tdf)
        //    {
        //        var rs = new DialogResult();
        //        rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (rs == DialogResult.Yes)
        //        {
        //            MessageBox.Show(tdf.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        cnx.Close(); cnx.Dispose();
        //    }
        //}
        //public void supprimer_details_conflits(int num_details_conflits)
        //{
        //    cnx = new SqlConnection(prms.ToString());
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        var cmd = new SqlCommand("supprimer_details_conflits", cnx)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.Add(new SqlParameter("num_details_conflits", SqlDbType.Int)).Value = num_details_conflits;
        //        cmd.ExecuteNonQuery();
        //        //afficher_frais(dtg);
        //        MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception tdf)
        //    {
        //        var rs = new DialogResult();
        //        rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (rs == DialogResult.Yes)
        //        {
        //            MessageBox.Show(tdf.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        cnx.Close(); cnx.Dispose();
        //    }
        //}
        public void chart_nombre_menage(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text=Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_membre(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_conflits(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_conflits", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_menage(DataGridView dtg, string mot)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_menage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("mot", SqlDbType.NVarChar)).Value = mot;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_membres_parNoms(BunifuMaterialTextbox code_membre, BunifuMaterialTextbox code_menage, string noms)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_membres_parNoms", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = noms;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    code_membre.Text = Convert.ToString(dr[0]);
                    code_menage.Text = Convert.ToString(dr[1]);
                }
                
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        //public void search_membres_parNoms(string code_membre, string code_menage, string noms)
        //{
        //    cnx = new SqlConnection(prms.ToString());
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        var cmd = new SqlCommand("search_membres_parNoms", cnx)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = noms;
        //        cmd.ExecuteNonQuery();
        //        var da = new SqlDataAdapter(cmd);
        //        var dt = new DataTable();
        //        da.Fill(dt);
        //        code_membre = dt.Rows[0].ToString();
        //        code_menage = dt.Rows[2].ToString();
        //    }
        //    catch (Exception exct)
        //    {
        //        var rs = new DialogResult();
        //        rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (rs == DialogResult.Yes)
        //        {
        //            MessageBox.Show(exct.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        cnx.Close(); cnx.Dispose();
        //    }
        //}
        public void charger_membres(ListBox dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_membres", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("texte", SqlDbType.NVarChar)).Value = texte_a_chercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dtg.Items.Add(Convert.ToString(dr[0]));
                }                
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_nom_membre(ListBox dtg, string texte_a_chercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_nom_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = texte_a_chercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dtg.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_type_partie(ComboBox dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_type_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("texte", SqlDbType.NVarChar)).Value = texte_a_chercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dtg.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_partie(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_partie(string id_typ_partie, string id_menage, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("id_typ_partie", SqlDbType.NVarChar)).Value = id_typ_partie;
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_partie(int num_partie, string id_typ_partie, string id_menage, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_partie", SqlDbType.NVarChar)).Value = num_partie;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("id_typ_partie", SqlDbType.NVarChar)).Value = id_typ_partie;
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_partie(int num_partie)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_partie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_partie", SqlDbType.Int)).Value = num_partie;

                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_partie_byConflit(DataGridView dtg, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_partie_byConflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_partie_byMenage(DataGridView dtg, string id_menage)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_partie_byMenage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_menage", SqlDbType.NVarChar)).Value = id_menage;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_objet_conflit(ComboBox dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("texte", SqlDbType.NVarChar)).Value = texte_a_chercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dtg.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_assign_objets(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_assign_objets", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_assign_objet_conflit(string id_objets_conflits, string num_conflit, string observation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_assign_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_objets_conflits", SqlDbType.NVarChar)).Value = id_objets_conflits;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("observation", SqlDbType.NVarChar)).Value = observation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_assign_objet_conflit(int num_details_objet, string id_objets_conflits, string num_conflit, string observation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_assign_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details_objet", SqlDbType.NVarChar)).Value = num_details_objet;
                cmd.Parameters.Add(new SqlParameter("id_objets_conflits", SqlDbType.NVarChar)).Value = id_objets_conflits;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("observation", SqlDbType.NVarChar)).Value = observation;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_assign_objet_conflit(string num_details_objet)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_assign_objet_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details_objet", SqlDbType.NVarChar)).Value = num_details_objet;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_resolutions(ComboBox dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_resolutions", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("texte", SqlDbType.NVarChar)).Value = texte_a_chercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dtg.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_assign_resolutions(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_assign_resolutions", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_assign_resolutions(string id_resolution, string num_conflit,  DateTime date_resolution, string commentaires)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_assign_resolutions", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("commentaires", SqlDbType.NVarChar)).Value = commentaires;
                cmd.Parameters.Add(new SqlParameter("date_resolution", SqlDbType.DateTime)).Value = date_resolution;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_assign_resolutions(int num_assign_resol, string id_resolution, string num_conflit, DateTime date_resolution, string commentaires)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_assign_resolutions", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };                
                cmd.Parameters.Add(new SqlParameter("num_assign_resol", SqlDbType.Int)).Value = num_assign_resol;
                cmd.Parameters.Add(new SqlParameter("id_objets_conflits", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.Parameters.Add(new SqlParameter("commentaires", SqlDbType.NVarChar)).Value = commentaires;
                cmd.Parameters.Add(new SqlParameter("date_resolution", SqlDbType.DateTime)).Value = date_resolution;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_assign_resolutions(int num_assign_resol)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_assign_resolutions", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_assign_resol", SqlDbType.Int)).Value = num_assign_resol;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_atelier_masse(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_atelier_masse", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_atelier_masse_bysensibilisation(DataGridView dtg, string num_sensibilisation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_atelier_masse_bysensibilisation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.NVarChar)).Value = num_sensibilisation;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_atelier_masse(string code_sensibilisation, DateTime date_atelier, int hommes, 
            int femmes, int filles, int garcons, int autorite_femmes, int autorite_hommes, 
            int menages_deplaces, int menages_retournes, int menages_locaux, int menages_rapatries, 
            string themes, string observation, string noms_sensibilisateurs, string commentaires, string telephone)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_atelier_masse", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_atelier", SqlDbType.DateTime)).Value = date_atelier;
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.NVarChar)).Value = code_sensibilisation;
                cmd.Parameters.Add(new SqlParameter("nbre_hommes", SqlDbType.Int)).Value = hommes;
                cmd.Parameters.Add(new SqlParameter("nbre_femmes", SqlDbType.Int)).Value = femmes;
                cmd.Parameters.Add(new SqlParameter("nbre_filles", SqlDbType.Int)).Value = filles;
                cmd.Parameters.Add(new SqlParameter("nbre_garcons", SqlDbType.Int)).Value = garcons;
                cmd.Parameters.Add(new SqlParameter("nbre_autorite_femmes", SqlDbType.Int)).Value = autorite_femmes;
                cmd.Parameters.Add(new SqlParameter("nbre_autorite_hommes", SqlDbType.Int)).Value = autorite_hommes;
                cmd.Parameters.Add(new SqlParameter("nbre_menages_deplaces", SqlDbType.Int)).Value = menages_deplaces;
                cmd.Parameters.Add(new SqlParameter("nbre_menages_retournes", SqlDbType.Int)).Value = menages_retournes;
                cmd.Parameters.Add(new SqlParameter("nbre_menages_locaux", SqlDbType.Int)).Value = menages_locaux;
                cmd.Parameters.Add(new SqlParameter("nbre_menages_rapatrie", SqlDbType.Int)).Value = menages_rapatries;
                cmd.Parameters.Add(new SqlParameter("theme_developpe", SqlDbType.NVarChar)).Value = themes;
                cmd.Parameters.Add(new SqlParameter("observation", SqlDbType.NVarChar)).Value = observation;
                cmd.Parameters.Add(new SqlParameter("noms_sensibilisateur", SqlDbType.NVarChar)).Value = noms_sensibilisateurs;
                cmd.Parameters.Add(new SqlParameter("commentaires", SqlDbType.NVarChar)).Value = commentaires;
                cmd.Parameters.Add(new SqlParameter("telephone_sensibilisateur", SqlDbType.NVarChar)).Value = telephone;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_atelier_masse(int num_atelier_masse)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_atelier_masse", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_atelier_masse", SqlDbType.Int)).Value = num_atelier_masse;                
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_conflits_resolus(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_conflits_resolus", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_conflits_encours(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_conflits_encours", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_conflits_refere(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_conflits_refere", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_conflits_classe(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_conflits_classe", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_sensibilisations(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_sensibilisations", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_hommes_sensibilises(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_hommes_sensibilises", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_femmes_sensibilises(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_femmes_sensibilises", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_filles_sensibilises(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_filles_sensibilises", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void chart_nombre_garcons_sensibilises(Label cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("chart_nombre_garcons_sensibilises", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_rapport_conflit(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_rapport_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_localite(DataGridView dtg, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_localite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_conflit(DataGridView dtg, string num_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.NVarChar)).Value = num_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_typeconflit(DataGridView dtg, string type_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_typeconflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("type_conflit", SqlDbType.NVarChar)).Value = type_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_natureconflit(DataGridView dtg, string nature_conflit)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_natureconflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("nature_conflit", SqlDbType.NVarChar)).Value = nature_conflit;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_groupement(DataGridView dtg, string id_groupement)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_groupement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_groupement", SqlDbType.NVarChar)).Value = id_groupement;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_etat(DataGridView dtg, string etat)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_etat", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("etat", SqlDbType.NVarChar)).Value = etat;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapporsearch_rapport_conflit_by_date_conflit(DataGridView dtg, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_date_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void search_rapport_conflit_by_date_resolution(DataGridView dtg, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("search_rapport_conflit_by_date_resolution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void liste_conflits_par_groupements(DocumentViewer dcv)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("infos_general_conflits", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var rpt = new rpt_rapport_general_sur_conflit();
                DataSet dt = new DataSet();
                da.Fill(dt, "infos_general_conflits");
                rpt.DataSource = dt;
                //rpt.SetDataSource(dt.Tables["rechercher_pay_bill"]);                    
                dcv.DocumentSource = rpt;
                rpt.CreateDocument();
                dcv.Refresh();
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void Liste_sensibilisationa(DocumentViewer dcv)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("liste_sensibilises", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var rpt = new rpt_sensibilises();
                DataSet dt = new DataSet();
                da.Fill(dt, "liste_sensibilises");
                rpt.DataSource = dt;
                //rpt.SetDataSource(dt.Tables["rechercher_pay_bill"]);                    
                dcv.DocumentSource = rpt;
                rpt.CreateDocument();
                dcv.Refresh();
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void details_menages_par_conflit(DocumentViewer dcv, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("details_menages_par_conflit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var rpt = new rpt_conflits();
                DataSet dt = new DataSet();
                da.Fill(dt, "afficher_rapport_conflit");
                rpt.DataSource = dt;
                //rpt.SetDataSource(dt.Tables["rechercher_pay_bill"]);                    
                dcv.DocumentSource = rpt;
                rpt.CreateDocument();
                dcv.Refresh();
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }

        public void stats_total_conflit_parperiode(BunifuMaterialTextbox total, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_conflit_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if(dr[0].ToString()=="")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                    
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_hommes_conflit_parperiode(BunifuMaterialTextbox total, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_hommes_conflit_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_femmes_conflit_parperiode(BunifuMaterialTextbox total, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_femmes_conflit_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_filles_conflit_parperiode(BunifuMaterialTextbox total, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_filles_conflit_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_garcons_conflit_parperiode(BunifuMaterialTextbox total, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_garcons_conflit_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_menages_conflit_parperiode(BunifuMaterialTextbox total, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_menages_conflit_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_conflit_resolu_parperiode(BunifuMaterialTextbox total, string id_resolution, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_conflit_resolu_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_hommes_conflit_resolu_parperiode(BunifuMaterialTextbox total, string id_resolution, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_hommes_conflit_resolu_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_femmes_conflit_resolus_parperiode(BunifuMaterialTextbox total, string id_resolution, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_femmes_conflit_resolus_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_filles_conflit_resolus_parperiode(BunifuMaterialTextbox total, string id_resolution, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_filles_conflit_resolus_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_garcons_conflit_resolus_parperiode(BunifuMaterialTextbox total, string id_resolution, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_garcons_conflit_resolus_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_menages_conflit_resolus_parperiode(BunifuMaterialTextbox total, string id_resolution, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_menages_conflit_resolus_parperiode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_conflit_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_conflit_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_hommes_conflit_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_hommes_conflit_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_femmes_conflit_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_femmes_conflit_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_filles_conflit_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_filles_conflit_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_garcons_conflit_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_garcons_conflit_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_total_menages_conflit_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_total_menages_conflit_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_conflit_resolu_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_conflit_resolu_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_hommes_conflit_resolu_parlocalite(BunifuMaterialTextbox total, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_hommes_conflit_resolu_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_femmes_conflit_resolus_parlocalite(BunifuMaterialTextbox total,string id_resolution, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_femmes_conflit_resolus_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.Parameters.Add(new SqlParameter("i_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_filles_conflit_resolus_parlocalite(BunifuMaterialTextbox total, string id_resolution, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_filles_conflit_resolus_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.Parameters.Add(new SqlParameter("i_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_garcons_conflit_resolus_parlocalite(BunifuMaterialTextbox total, string id_resolution, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_garcons_conflit_resolus_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.Parameters.Add(new SqlParameter("i_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void stats_menages_conflit_resolus_parlocalite(BunifuMaterialTextbox total, string id_resolution, string id_localite, DateTime date_un, DateTime date_deux)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("stats_menages_conflit_resolus_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.DateTime)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.DateTime)).Value = date_deux;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.Parameters.Add(new SqlParameter("i_resolution", SqlDbType.NVarChar)).Value = id_resolution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == "")
                    {
                        total.Text = "0";
                    }
                    else
                    {
                        total.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception tdf)
            {
                //MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_projet(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_projet", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }        
        public void recuperer_executants(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_executants", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_agr(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_agr", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_distribution(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_distribution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_distribution(string code_distribution, DateTime date_distribution, string id_localite, string id_projet, 
                                                string id_agr, decimal qte, decimal valeur, string id_executant, string observation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_distribution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_distribution", SqlDbType.NVarChar)).Value = code_distribution;
                cmd.Parameters.Add(new SqlParameter("date_distribution", SqlDbType.DateTime)).Value = date_distribution;
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.Parameters.Add(new SqlParameter("id_projet", SqlDbType.NVarChar)).Value = id_projet;
                cmd.Parameters.Add(new SqlParameter("id_agr", SqlDbType.NVarChar)).Value = id_agr;
                cmd.Parameters.Add(new SqlParameter("qte", SqlDbType.Decimal)).Value = qte;
                cmd.Parameters.Add(new SqlParameter("valeur", SqlDbType.Decimal)).Value = valeur;
                cmd.Parameters.Add(new SqlParameter("id_executant", SqlDbType.NVarChar)).Value = id_executant;
                cmd.Parameters.Add(new SqlParameter("observation", SqlDbType.NVarChar)).Value = observation;

                cmd.ExecuteNonQuery();
                //var fr = new frm_membres();
                //fr.txt_id_menage.Text = id_menage;
                //fr.ShowDialog();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_distribution(string code_distribution)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_distribution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_distribution", SqlDbType.NVarChar)).Value = code_distribution;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_distribution_parcode(DataGridView dtg, string code_distribution)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_distribution_parcode", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_distribution", SqlDbType.NVarChar)).Value = code_distribution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_distrtibution_parlocalite(DataGridView dtg, string id_localite)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_distrtibution_parlocalite", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_localite", SqlDbType.NVarChar)).Value = id_localite;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_distrtibution_parprojet(DataGridView dtg, string id_projet)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_distrtibution_parprojet", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_projet", SqlDbType.NVarChar)).Value = id_projet;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_distribution_pardate(DataGridView dtg, DateTime date_distribution)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_distribution_pardate", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_distribution", SqlDbType.NVarChar)).Value = date_distribution;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_beneficiaires(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_beneficiaires", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_pays(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_pays", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
                MessageBox.Show("Chargement de la page réussi");
            }
        }
        public void ajouter_pays(string code_pays, string nom_pays_eng, string nom_pays_fr, string capitale)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("ajouter_pays", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_pays", SqlDbType.NVarChar)).Value = code_pays;
                cmd.Parameters.Add(new SqlParameter("nom_pays_eng", SqlDbType.NVarChar)).Value = nom_pays_eng;
                cmd.Parameters.Add(new SqlParameter("nom_pays_fr", SqlDbType.NVarChar)).Value = nom_pays_fr;
                cmd.Parameters.Add(new SqlParameter("capitale", SqlDbType.NVarChar)).Value = capitale;

                cmd.ExecuteNonQuery();
                //var fr = new frm_membres();
                //fr.txt_id_menage.Text = id_menage;
                //fr.ShowDialog();
                //afficher_frais(dtg);
                MessageBox.Show("Enregistrement avec succès!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_pays(string code_pays)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_pays", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_pays", SqlDbType.NVarChar)).Value = code_pays;

                cmd.ExecuteNonQuery();
                //var fr = new frm_membres();
                //fr.txt_id_menage.Text = id_menage;
                //fr.ShowDialog();
                //afficher_frais(dtg);
                MessageBox.Show("Suppresion avec succès!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
    }
}