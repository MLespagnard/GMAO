using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAONewVersion
{
    public partial class BTCreationForm : Form
    {
        private MySqlConnection connection;
        private String username;

        public BTCreationForm(MySqlConnection conn, String username)
        {
            InitializeComponent();
            connection = conn;
            this.username = username;
            fillCreatorNameBT();
            fillGroupBoxEquipementConcerneBT();
            fillcheckedListBoxPieceRechangeBT();
            fillGroupBoxNomInterBT();

        }

        private void fillGroupBoxEquipementConcerneBT()
        {
            string query = "SELECT EQUIP_NOM FROM equipements WHERE archiver = 0";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    comboBoxEquipementConcerneBT.Items.Clear();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            comboBoxEquipementConcerneBT.Items.Add(reader["EQUIP_NOM"].ToString());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        public void fillcheckedListBoxPieceRechangeBT()
        {
            string query = "SELECT PR_NOM FROM piece_de_rechange WHERE archiver = 0";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    checkedListBoxPieceRechangeBT.Items.Clear();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkedListBoxPieceRechangeBT.Items.Add(reader["PR_NOM"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
        }

        private void fillGroupBoxNomInterBT()
        {
            string query = "SELECT * FROM user WHERE USER_TYPE = 1 or USER_TYPE = 2 AND archiver = 0";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    comboBoxNomInterBT.Items.Clear();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            comboBoxNomInterBT.Items.Add(reader["USER_FIRST_NAME"].ToString() + " " + reader["USER_LAST_NAME"].ToString());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        private void fillCreatorNameBT()
        {
            textBoxCreateurBT.Text = username;
        }

        private int CountNumberOfBT(String motif)
        {
            string query = "SELECT COUNT(BT_NUMERO) FROM bt WHERE BT_MOTIF = @BtMotif;";

            int count = 0;

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BtMotif", motif);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            count++;
            return count;
        }

        // Lors du clic sur le bouton créer
        private void kryptonButtonBTCreerValider_Click(object sender, EventArgs e)
        {
            // Crée une liste avec la valeur des champs
            List<(string, string)> lst_champs = new List<(string, string)>
            {
                ("Motif", comboBoxMotifBT.SelectedItem as string ?? ""),
                ("Intitulé", textBoxIntituleBT.Text),
                ("Créateur", textBoxCreateurBT.Text),
                ("Équipement concerné", comboBoxEquipementConcerneBT.SelectedItem as string ?? ""),
                ("Nombre d'heures", textBoxNbHeuresBT.Text),
                ("Travail réalisé", RichTextBoxTravailRealiserBT.Text),
                ("Commentaire interne", RichTextBoxCommentaireInterBT.Text),
                ("Nom intervenant", comboBoxNomInterBT.SelectedItem?.ToString() ?? ""),
                ("Temps presté", textBoxTempsPresteBT.Text)
};

            // Envoie la liste des champs a la classe error pour vérifier la nullitée des champs
            if (Error.testvaleur(lst_champs) == false)
            {
                // Stop du code
                return;
            }
            // Si minimum 1 pièce de rechange
            if (checkedListBoxPieceRechangeBT.CheckedItems.Count != 0)
            {
                // Boucler sur les éléments sélectionnés et les mettre dans la variable S
                string s = "";
                for (int x = 0; x < checkedListBoxPieceRechangeBT.CheckedItems.Count; x++)
                {
                    //Mettre les éléments checké dans S
                    s += checkedListBoxPieceRechangeBT.CheckedItems[x].ToString();

                    // Ajouter le point-virgule uniquement si ce n'est pas le dernier élément
                    if (x < checkedListBoxPieceRechangeBT.CheckedItems.Count - 1)
                    {
                        s += ";";
                    }
                }

                // Récupère la date d'aujourd'hui
                DateTime currentDate = DateTime.Now;
                String numeroBT = "";
                // Crée les numéros des BT
                if (comboBoxMotifBT.SelectedItem as string == "Préventif")
                {
                    numeroBT = "PR" + currentDate.Year + "-" + CountNumberOfBT("Préventif").ToString("D4");
                    InsererDonneesDansDB(s, numeroBT);

                }
                else if (comboBoxMotifBT.SelectedItem as string == "Correctif")
                {
                    numeroBT = "CO" + currentDate.Year;
                    numeroBT += "-";
                    numeroBT += CountNumberOfBT("Correctif").ToString("D4");
                    InsererDonneesDansDB(s, numeroBT);
                }
                else if (comboBoxMotifBT.SelectedItem as string == "Curatif")
                {
                    numeroBT = "CU" + currentDate.Year + "-" + CountNumberOfBT("Curatif").ToString("D4");
                    InsererDonneesDansDB(s, numeroBT);
                }

                // Appel a l'insertion une fois les valeurs réccuperées
                // InsererDonneesDansDB(s);
            }
            else
            {
                MessageBox.Show($"Veuillez saisir une ou plusieurs pièces de rechanges", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InsererDonneesDansDB(String PieceRechange, String numeroBT)
        {


            // Définir la requête d'insertion
            string query = "INSERT INTO bt (BT_NUMERO, BT_MOTIF, BT_INTITULE, BT_CREATEUR, BT_EQUIPEMENT_CONCERNE, BT_PIECE_RECHANGE, " +
                           "BT_HEURE_EQUIPEMENT, BT_TRAVAIL_REALISER, BT_COMMENTAIRE_INTERVENANT, BT_NOM_INTERVENANT, BT_TEMPS_TRAVAIL) " +
                           "VALUES (@BtNumero, @Motif, @Intitule, @Createur, @EquipementConcerne, @PieceRechange, @NbHeures, @TravailRealise, " +
                           "@CommentaireInterne, @NomIntervenant, @TempsPreste)";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@BtNumero", numeroBT);
                    command.Parameters.AddWithValue("@Motif", comboBoxMotifBT.SelectedItem as string);
                    command.Parameters.AddWithValue("@Intitule", textBoxIntituleBT.Text);
                    command.Parameters.AddWithValue("@Createur", textBoxCreateurBT.Text);
                    command.Parameters.AddWithValue("@EquipementConcerne", comboBoxEquipementConcerneBT.SelectedItem as string);
                    command.Parameters.AddWithValue("@PieceRechange", PieceRechange);
                    command.Parameters.AddWithValue("@NbHeures", textBoxNbHeuresBT.Text);
                    command.Parameters.AddWithValue("@TravailRealise", RichTextBoxTravailRealiserBT.Text);
                    command.Parameters.AddWithValue("@CommentaireInterne", RichTextBoxCommentaireInterBT.Text);
                    command.Parameters.AddWithValue("@NomIntervenant", comboBoxNomInterBT.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TempsPreste", textBoxTempsPresteBT.Text);


                    // Exécuter la commande d'insertion
                    command.ExecuteNonQuery();

                    // Afficher un message de succès
                    MessageBox.Show("Données insérées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Ferme le formulaire
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
