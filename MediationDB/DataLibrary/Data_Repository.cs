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
//using DevExpress.XtraPrinting.Preview;
//using KK_DependentsApp.UI_Library.UI_Frames;
using MediationDB.FormLibrary;
//using System.Windows.Forms.DataVisualization.Charting;

namespace MediationDB.DataLibrary
{
    public class Data_Repository
    {
        static SqlConnection cnx;
        Params prms = new Params();
        public Data_Repository()
        {
            //prms.Serveur = "tcp:conebase.database.windows.net";                    
            //prms.Nom_user = "LensX";
            //prms.Mot_de_passe = "Cony@2017.com?";
            //prms.Serveur = "JOHNSEVEN";
            //prms.Base_de_donnees = "db_kkdependants";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "123456789";
            prms.Serveur = "DESKTOP-PO0I2OH";
            prms.Base_de_donnees = "db_mediator";
            prms.Nom_user = "sa";
            prms.Mot_de_passe = "Windy@2019.com?";
            //prms.Serveur = "DESKTOP-NFR9KTI";
            //prms.Base_de_donnees = "db_mediator";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "Server@2019.com?";
            //prms.Serveur = "DESKTOP-3M7GUQ9";
            //prms.Base_de_donnees = "db_kkdependants";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "Admin123_";
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
        public void inserer_conflit(DateTime date_debut_conflit, string id_type_conflit, string id_nature_conflit, string id_localite)
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
        public void modifier_conflit(int num_conflit, DateTime date_debut_conflit, string id_type_conflit, string id_nature_conflit, string id_localite)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void supprimer_conflit(int num_conflit)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void afficher_details_conflits(DataGridView dtg, int num_conflit)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void inserer_details(string descript_conflit, int num_conflit)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void modifier_details(int num_details_conflits, string descript_conflit, int num_conflit)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void afficher_mediation(DataGridView dtg, int num_conflit)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void inserer_mediation(DateTime date_debut_mediation, int num_conflit, string id_mediateur, string noms_mediateur, string lieu, string appreciation, DateTime date_fin_mediation)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void modifier_mediation(int num_mediation, DateTime date_debut_mediation, int num_conflit, string id_mediateur, string noms_mediateur, string lieu, string appreciation, DateTime date_fin_mediation)
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
                cmd.Parameters.Add(new SqlParameter("num_conflit", SqlDbType.Int)).Value = num_conflit;
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
        public void enregistrer_menage(string id_menage, string id_situation)
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
                MessageBox.Show("Connection failed!\n" + tdf);
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
        public void inserer_sensibilisation(DateTime date_debut, DateTime date_fin, string id_localite)
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
        public void supprimer_sensibilisation(int num_sensibilisation)
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
                cmd.Parameters.Add(new SqlParameter("num_sensibilisation", SqlDbType.Int)).Value = num_sensibilisation;
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









        public void recuperer_combobox_lien(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_combobox_lien", cnx)
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
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_combo_structure(MetroComboBox cbx, string id_ville)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_combo_structure", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_ville", SqlDbType.NVarChar)).Value = id_ville;
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
        public void recherche_listbox_agent(ListBox lst, string search_name)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recherche_listbox_agent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@searchname", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
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
        public void recuperer_listbox_agent(ListBox lst)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_listbox_agent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
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
        public void rechercher_agent_parnom(DataGridView dtg, string searchname)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_agent_parnom", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("searchname", SqlDbType.NVarChar)).Value = searchname;
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
        public void rechercher_code_agent(MaterialSingleLineTextField txt, string search_name)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_code_agent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                txt.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    txt.Text = Convert.ToString(dr[0]);
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
        public void afficher_dependents(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_dependents", cnx)
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
        public void enregistrer_dependent(string id_dependents, string noms, DateTime date_naissance,
                        string sexe, string adresse, string id_lien, byte[] photo, string code_agent)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_dependent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_dependents", SqlDbType.NVarChar)).Value = id_dependents;
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.NVarChar)).Value = noms;
                cmd.Parameters.Add(new SqlParameter("date_naissance", SqlDbType.Date)).Value = date_naissance;
                cmd.Parameters.Add(new SqlParameter("sexe", SqlDbType.NVarChar)).Value = sexe;
                cmd.Parameters.Add(new SqlParameter("adresse", SqlDbType.NVarChar)).Value = adresse;
                cmd.Parameters.Add(new SqlParameter("id_lien", SqlDbType.NVarChar)).Value = id_lien;
                cmd.Parameters.Add(new SqlParameter("photo", SqlDbType.Image)).Value = photo;
                cmd.Parameters.Add(new SqlParameter("code_agent", SqlDbType.NVarChar)).Value = code_agent;
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
        public void supprimer_dependents(string id_dependents)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_dependents", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_dependents", SqlDbType.NVarChar)).Value = id_dependents;
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
        public void rechercher_dependents(DataGridView dtg, string code_agent)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_dependents", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_agent", SqlDbType.NVarChar)).Value = code_agent;
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
        public void rechercher_nom_dependents(DataGridView dtg, string noms)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_nom_dependents", cnx)
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
        public void afficher_affectation(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_affectation", cnx)
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
        public void remplir_node_enfant(TreeNode node_parent, string noms_agent)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("treeview_charge_byname", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("noms", SqlDbType.Int)).Value = noms_agent;

                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    {
                        TreeNode child = new TreeNode();
                        child.Text = dr["Name"].ToString().Trim();
                        string temp = dr["IID"].ToString();
                        child.Collapse();
                        node_parent.Nodes.Add(child);
                        remplir_node_enfant(child, temp);
                    }
                }
            }
            catch (Exception etr)
            {
                MessageBox.Show("Erreur lors du chargement!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(etr.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }

        }
        public void remplir_treeview(TreeView trvw)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "treeview_distinct";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                trvw.Nodes.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    //if ((int)dr[2]==0)
                    //{
                    //TreeNode tnParent = new TreeNode();
                    //tnParent.Text = dr[1].ToString();
                    //string value = dr[0].ToString();
                    //tnParent.Expand();
                    //trvw.Nodes.Add(tnParent);
                    //remplir_node_enfant(tnParent, value);
                    //}
                    TreeNode node = new TreeNode(dr[0].ToString() + " - " + dr[1].ToString());
                    node.Nodes.Add(dr[2].ToString());
                    trvw.Nodes.Add(node);
                }
            }
            catch (Exception etr)
            {
                MessageBox.Show("Erreur lors du chargement!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(etr.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void liste_dependants_structure(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("liste_dependants_structure", cnx)
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
        public void rechercher_dependants_structure_paragent(DataGridView dtg, string noms_agent)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_dependants_structure_paragent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("noms_agent", SqlDbType.NVarChar)).Value = noms_agent;
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
        public void rechercher_code_dependents(DataGridView dtg, string code_dependant)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_code_dependents", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_dependents", SqlDbType.NVarChar)).Value = code_dependant;
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
        public void rechercher_dependants_structure_parstructure(DataGridView dtg, string id_structure)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_dependants_structure_parstructure", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_structure", SqlDbType.NVarChar)).Value = id_structure;
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
        public void rechercher_login(string username, string pwd, int y)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_login", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar)).Value = username;
                cmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.NVarChar)).Value = pwd;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    y = 1;
                    var fr = new frm_menu ();
                    fr.Show();
                    cnx.Close(); cnx.Dispose();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas acces a cette application, Veuillez consulter le DSI!");
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
        public void charts_nombre_agent(Label nombre_agent)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_agent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_agent.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_nombre_conjoint(Label nombre_conjoint)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_conjoint", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_conjoint.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_nombre_dependants(Label nombre_dependant)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_dependants", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_dependant.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_nombre_enfants(Label nombre_enfant)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_enfants", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_enfant.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_nombre_familles(Label nombre_famille)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_familles", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_famille.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_nombre_filles(Label nombre_filles)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_filles", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_filles.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_nombre_garcons(Label nombre_garcons)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_nombre_garcons", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre_garcons.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
        public void charts_sans_dependants(Label sans_dependants)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charts_sans_dependants", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    sans_dependants.Text = Convert.ToString(dr[0]);
                    cnx.Close(); cnx.Dispose();
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
    }
}