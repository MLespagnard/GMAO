using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public List<string> OGItems = new List<string>();
        public List<string> PRValeur = new List<string>();

        public BTCreationForm(MySqlConnection conn, String username)
        {
            InitializeComponent();
            connection = conn;
            this.username = username;
           
            fillCreatorNameBT();
            fillGroupBoxEquipementConcerneBT();
            fillcheckedListBoxPieceRechangeBT();
            fillGroupBoxNomInterBT();


            foreach(string item in OGItems)
            {
                checkedListBoxPieceRechangeBT.Items.Add(item);
            }
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
                            OGItems.Add(reader["PR_NOM"].ToString());
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
                ("Nom intervenant", comboBoxNomInterBT.SelectedItem?.ToString() ?? ""),
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
                // Parcourir tous les éléments cochés dans checkedListBoxPieceRechangeBT
                foreach (var item in checkedListBoxPieceRechangeBT.CheckedItems)
                {
                    string pieceDeRechange = item.ToString(); // Nom de la pièce de rechange

                    // Recherche du label correspondant dans le panel
                    string TexBoxName = "textBoxNumero_" + pieceDeRechange;
                    TextBox texbox = flowLayoutPanelNumeros.Controls.Find(TexBoxName, true).FirstOrDefault() as TextBox;
                    // Vérifier si le label correspondant a été trouvé
                    if (texbox != null)
                    {
                        PRValeur.Add(pieceDeRechange + "=" + texbox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Aucune valeur n'est assigné à la pièce: " + pieceDeRechange);
                    }
                }


                // Récupère la date d'aujourd'hui
                DateTime currentDate = DateTime.Now;
                String numeroBT = "";
                // Crée les numéros des BT
                if (comboBoxMotifBT.SelectedItem as string == "Préventif")
                {
                    numeroBT = "PR" + currentDate.Year + "-" + CountNumberOfBT("Préventif").ToString("D4");
                    InsererDonneesDansDB(numeroBT);

                }
                else if (comboBoxMotifBT.SelectedItem as string == "Correctif")
                {
                    numeroBT = "CO" + currentDate.Year;
                    numeroBT += "-";
                    numeroBT += CountNumberOfBT("Correctif").ToString("D4");
                    InsererDonneesDansDB(numeroBT);
                }
                else if (comboBoxMotifBT.SelectedItem as string == "Curatif")
                {
                    numeroBT = "CU" + currentDate.Year + "-" + CountNumberOfBT("Curatif").ToString("D4");
                    InsererDonneesDansDB(numeroBT);
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


        private void InsererDonneesDansDB(string numeroBT)
        {

            try
            { // 
                string updateQuery = "UPDATE piece_de_rechange SET PR_STOCK_ACTUEL = PR_STOCK_ACTUEL - @NombreDansLaBox WHERE PR_NOM = @PieceRechange";

                foreach (var item in PRValeur)
                {
                    if (!string.IsNullOrEmpty(item) && item.Contains("="))
                    {
                        string[] elements = item.Split('=');
                        if (elements.Length == 2)
                        {
                            string piecederechange = elements[0];
                            string valeur = elements[1];

                            using (MySqlCommand command2 = new MySqlCommand(updateQuery, connection))
                            {
                                // Ajouter les paramètres à la commande SQL
                                command2.Parameters.Clear();
                                command2.Parameters.AddWithValue("@PieceRechange", piecederechange); 
                                command2.Parameters.AddWithValue("@NombreDansLaBox", valeur);

                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    command.Parameters.AddWithValue("@PieceRechange", string.Join(";", PRValeur));
                    command.Parameters.AddWithValue("@NbHeures", textBoxNbHeuresBT.Text);
                    command.Parameters.AddWithValue("@TravailRealise", RichTextBoxTravailRealiserBT.Text);
                    command.Parameters.AddWithValue("@CommentaireInterne", RichTextBoxCommentaireInterBT.Text);
                    command.Parameters.AddWithValue("@NomIntervenant", comboBoxNomInterBT.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TempsPreste", textBoxTempsPresteBT.Text);

                    // Exécuter la commande d'insertion
                    command.ExecuteNonQuery();

                    // Afficher un message de succès
                    MessageBox.Show("Données insérées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }


        private void checkedListBoxPieceRechangeBT_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Si l'élément est en cours de coche
            if (e.NewValue == CheckState.Checked)
            {
                string elementNameListPR = checkedListBoxPieceRechangeBT.Items[e.Index].ToString();

                // Vérifier si le contrôle correspondant à cet élément est déjà présent dans le flowLayoutPanel
                if (flowLayoutPanelNumeros.Controls.Find("LabelBoxNumero_" + elementNameListPR, true).Length == 0)
                {
                    // Créer un nouveau contrôle Label
                    Label label = new Label();
                    label.Name = "LabelBoxNumero_" + elementNameListPR;
                    label.Text = "Quantité(e) " + elementNameListPR; // Texte du Label
                    label.Location = new System.Drawing.Point(10, (e.Index * 50) + 5); // Positionnez le contrôle Label (avec un espace de 5 pixels)
                    flowLayoutPanelNumeros.Controls.Add(label); // Ajoutez le contrôle à votre panel

                    // Créer un nouveau contrôle TextBox
                    TextBox textBox = new TextBox();
                    textBox.Name = "textBoxNumero_" + elementNameListPR;
                    textBox.MaxLength = 3;
                    textBox.Location = new System.Drawing.Point(10, (e.Index * 50) + 25); // Positionnez le contrôle TextBox juste en dessous du Label
                    flowLayoutPanelNumeros.Controls.Add(textBox); // Ajoutez le contrôle à votre panel
                }
            }
            else // Si l'élément est en cours de décoche
            {
                string elementNameListPR = checkedListBoxPieceRechangeBT.Items[e.Index].ToString();
                // Recherchez et supprimez le contrôle TextBox et Label correspondant
                for (int i = flowLayoutPanelNumeros.Controls.Count - 1; i >= 0; i--)  // Compte tout les contrôls
                {
                    Control control = flowLayoutPanelNumeros.Controls[i];
                    if (control.Name == "textBoxNumero_" + elementNameListPR || control.Name == "LabelBoxNumero_" + elementNameListPR)
                    {
                        flowLayoutPanelNumeros.Controls.Remove(control);
                    }
                }
            }
        }

        private List<string> checkedTest = new List<string>(); // Liste pour stocker les éléments cochés

        // Label pour filter PR
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxFilter.Text.ToLower(); // Convertir le texte en minuscules pour une comparaison insensible à la casse

            foreach (var item in checkedListBoxPieceRechangeBT.CheckedItems) // Parcourir tous les éléments cochés
            {
                checkedTest.Add(item.ToString()); // Ajouter l'élément cochée à la liste
            }

            checkedListBoxPieceRechangeBT.Items.Clear(); // Effacer les éléments précédents

            foreach (string item in OGItems) // Parcourir tous les éléments d'origine
            {
                if (item.ToLower().Contains(searchText)) // Vérifier si l'élément correspond au critère de filtrage
                {
                    checkedListBoxPieceRechangeBT.Items.Add(item); // Ajouter l'élément filtré à la liste
                }
            }

            // Rétablir les états cochés
            foreach (string item in checkedTest)
            {
                int index = checkedListBoxPieceRechangeBT.Items.IndexOf(item);
                if (index != -1)
                {
                    checkedListBoxPieceRechangeBT.SetItemChecked(index, true);
                }
            }
        }


        private void textBoxNbHeuresBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère entré n'est pas un chiffre ou la touche de contrôle (comme Backspace) // Chat GPT
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Annule la saisie du caractère en empêchant l'événement KeyPress de se propager
                e.Handled = true;
            }
        }

        private void textBoxTempsPresteBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère entré n'est pas un chiffre ou la touche de contrôle (comme Backspace) // Chat GPT
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Annule la saisie du caractère en empêchant l'événement KeyPress de se propager
                e.Handled = true;
            }
        }
    }
}
