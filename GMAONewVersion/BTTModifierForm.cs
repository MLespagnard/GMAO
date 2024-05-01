using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAONewVersion
{
    public partial class BTTModifierForm : Form
    {
        private  int accesLvl;
        private readonly MySqlConnection connection;
        private readonly string numeroBT;
        string nomInter;
        int indexIntervenant;
        int isChecked;
        public List<string> OGItems = new List<string>();
        public List<(string, string)> OldPRValue = new List<(string, string)>();
        public List<string> PRNewValeur = new List<string>();



        // Constructeur de la classe FormModifierBT
        public BTTModifierForm(MySqlConnection conn, string numero, int accesLvl)
        {
            InitializeComponent();
            connection = conn;
            numeroBT = numero;
            this.accesLvl = accesLvl;
            // Remplir toutes les cases avec les infos SQL au chargement 
            FillAllBoxModifierBT();
            labelHeaderBT.Text = labelHeaderBT.Text + numeroBT;
            if(accesLvl ==1)
            {
                groupBoxIntituleBT.Enabled = false;
                checkedListBoxPieceRechangeBT.Enabled = false;
                RichTextBoxTravailRealiserBT.Enabled = false;
                comboBoxNomInterBT.Enabled = false;
                textBoxCreateurBT.Enabled  = false;
            }

            foreach (string item in OGItems)
            {
                checkedListBoxPieceRechangeBT.Items.Add(item);
            }

        }

        // Remplir toutes les cases avec les infos SQL au chargement
        private void FillAllBoxModifierBT()
        {
            // Requête SQL pour récupérer toutes les informations de la BT spécifiée
            string query = "SELECT * FROM bt WHERE BT_NUMERO = @NumeroBT;";

            try
            {
                string PieceRechangeBT = "";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Utilise des paramètres pour éviter les problèmes de sécurité liés aux injections SQL (Sécuritée)
                    command.Parameters.AddWithValue("@NumeroBT", numeroBT);

                    // Nettoyer les contrôles
                    ClearAllControls();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Remplir les contrôles avec les données de la base de données
                            textBoxIntituleBT.Text = reader["BT_INTITULE"].ToString();
                            textBoxCreateurBT.Text = reader["BT_CREATEUR"].ToString();
                            ;
                            PieceRechangeBT = reader["BT_PIECE_RECHANGE"].ToString();

                            RichTextBoxTravailRealiserBT.Text = reader["BT_TRAVAIL_REALISER"].ToString().Trim();
                            RichTextBoxCommentaireInterBT.Text = reader["BT_COMMENTAIRE_INTERVENANT"].ToString().Trim();

                            String isChecked = reader["BT_ISFINISH"].ToString().Trim();

                            if (Convert.ToInt32(isChecked) == 0)
                            { 
                                checkBoxIsFinish.Checked = false;
                                checkBoxIsFinish.Enabled = true;
                            }
                            else if (Convert.ToInt32(isChecked) == 1)
                            {
                                checkBoxIsFinish.Checked = true;
                                DisableAllControls(this);
                            }


                            nomInter = reader["BT_NOM_INTERVENANT"].ToString().Trim();
                            comboBoxNomInterBT.Items.Add(nomInter);
                            // Stocker l'index de l'intervenant
                            indexIntervenant = comboBoxNomInterBT.Items.Count - 1;
                        }
                        reader.Close(); // Fermer le DataReader après avoir lu les données
                        fillGroupBoxNomInterBT(nomInter, indexIntervenant);
                        // Appeler la méthode pour remplir la CheckedListBox avec les pièces de rechange
                        FillCheckedListBoxPieceRechange(PieceRechangeBT);
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs potentielles lors de l'exécution de la requête
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        private void fillGroupBoxNomInterBT(String nomInter, int indexIntervenant)
        {

            string query = "SELECT * FROM user WHERE USER_TYPE = 1 or USER_TYPE = 2 AND archiver = 0";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string nomComplet = reader["USER_FIRST_NAME"].ToString() + " " + reader["USER_LAST_NAME"];

                            if (nomComplet != nomInter)
                            {
                                comboBoxNomInterBT.Items.Add(nomComplet);
                            }
                        }
                    }
                }

                // Sélectionner l'index de l'intervenant
                comboBoxNomInterBT.SelectedIndex = indexIntervenant;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        // Remplir la CheckedListBox avec les pièces de rechange
        private void FillCheckedListBoxPieceRechange(string pieceRechangeBT)
        {
            checkedListBoxPieceRechangeBT.Items.Clear();

            // Diviser la chaîne en plusieurs éléments basés sur le délimiteur ';'
            string[] items = pieceRechangeBT.Split(';');

            // Liste pour stocker les noms des pièces de rechange
            List<string> nomsPieceRechange = new List<string>();

            // Requête SQL pour récupérer les noms des pièces de rechange
            string query = "SELECT PR_NOM FROM piece_de_rechange WHERE archiver = 0";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nomPiece = reader["PR_NOM"].ToString();
                        nomsPieceRechange.Add(nomPiece);
                    }
                }
            }

            // Parcourir les noms des pièces de rechange récupérés de la base de données
            foreach (string nomPiece in nomsPieceRechange)
            {
                // Vérifie si la pièce de rechange est égale à l'un des éléments de items
                foreach (var itemAllPR in items)
                {
                    string[] ItemAllSplit = itemAllPR.Split('=');
                        if (ItemAllSplit[0] == nomPiece)
                        {
                        OldPRValue.Add((ItemAllSplit[0].Trim().ToString(), ItemAllSplit[1].ToString()));
                        // Ajouter la pièce de rechange à checkedListBoxPieceRechange en la cochant
                        checkedListBoxPieceRechangeBT.Items.Add(nomPiece, true);
                            // Recherche du contrôle avec le nom spécifié dans le FlowLayoutPanel
                            Control[] foundControls = flowLayoutPanelNumeros.Controls.Find("textBoxNumero_" + ItemAllSplit[0], true);

                            // Vérification si le contrôle est trouvé
                            if (foundControls.Length > 0 && foundControls[0] is TextBox)
                            {
                                // Cast du contrôle trouvé en tant que Label et affectation de la propriété Text
                                ((TextBox)foundControls[0]).Text = (ItemAllSplit[1]).ToString();
                            }
                            break; // Sortir de la boucle foreach si la pièce est trouvée
                        }
                }

                // Si la pièce de rechange n'a pas été trouvée dans items, l'ajouter sans la cocher
                if (!checkedListBoxPieceRechangeBT.Items.Contains(nomPiece))
                {
                    checkedListBoxPieceRechangeBT.Items.Add(nomPiece, false);
                }
            }
        }


        // Nettoye tous les contrôles dans le formulaire
        private void ClearAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Items.Clear();
                }
                else if (control is CheckedListBox checkedListBox)
                {
                    checkedListBox.Items.Clear();
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void DisableAllControls(Control container)
        {
            foreach (Control control in container.Controls) // toutes les box qui sont dans la fenetre
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                }
                else if (control is CheckedListBox checkedListBox)
                {
                    checkedListBox.Enabled = false;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Enabled = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Enabled = false;
                }
                else if (control is Control)
                {
                    // Si le contrôle est un autre conteneur, récursivement désactiver ses contrôles
                    DisableAllControls((Control)control);
                }
            }
        }

        private void UpdateBTInBDD()
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
                        PRNewValeur.Add(pieceDeRechange + "=" + texbox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Aucune valeur n'est assignée à la pièce: " + pieceDeRechange);
                    }
                }

                string updateQuery = "UPDATE piece_de_rechange SET PR_STOCK_ACTUEL = PR_STOCK_ACTUEL - @NombreDansLaBox WHERE PR_NOM = @PieceRechange";

                // Vérifier si la liste OldPRValue contient des éléments
                if (OldPRValue.Count > 0)
                {
                    foreach (var item in OldPRValue)
                    {
                        string pieceDeRechange = item.Item1;
                        int oldValue = Convert.ToInt32(item.Item2);

                        // Vérifier si PRNewValeur contient la pièce de rechange
                        var newValueItem = PRNewValeur.FirstOrDefault(x => x.StartsWith(pieceDeRechange + "="));
                        if (newValueItem != null)
                        {
                            int newValue = Convert.ToInt32(newValueItem.Split('=')[1]);
                            int ModifValue = oldValue - newValue;

                            using (MySqlCommand command2 = new MySqlCommand(updateQuery, connection))
                            {
                                // Ajouter les paramètres à la commande SQL
                                command2.Parameters.Clear();
                                command2.Parameters.AddWithValue("@PieceRechange", pieceDeRechange);
                                command2.Parameters.AddWithValue("@NombreDansLaBox", ModifValue);

                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                }

                // Définir la requête d'insertion
                string query = "UPDATE bt SET BT_INTITULE = @Intitule, BT_PIECE_RECHANGE = @PieceRechange, " +
                               " BT_TRAVAIL_REALISER = @TravailRealise, BT_COMMENTAIRE_INTERVENANT = @CommentaireInterne, " +
                               "BT_NOM_INTERVENANT = @NomIntervenant, BT_TEMPS_TRAVAIL = @TempsPreste, BT_ISFINISH = @isFinish, BT_DATE_REALISATION = @BtDateRealisation  WHERE BT_NUMERO = @numeroBT";

                if (checkBoxIsFinish.Checked)
                {
                    isChecked = 1;
                }
                else
                {
                    isChecked = 0;
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@Intitule", textBoxIntituleBT.Text);
                    // Concaténer les noms des pièces de rechange uniquement
                    command.Parameters.AddWithValue("@PieceRechange", string.Join(";", PRNewValeur.Select(x => x.Split('=')[0])));
                    command.Parameters.AddWithValue("@TravailRealise", RichTextBoxTravailRealiserBT.Text);
                    command.Parameters.AddWithValue("@CommentaireInterne", RichTextBoxCommentaireInterBT.Text);
                    command.Parameters.AddWithValue("@NomIntervenant", comboBoxNomInterBT.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TempsPreste", textBoxTempsPresteBT.Text);
                    command.Parameters.AddWithValue("@isFinish", isChecked);
                    command.Parameters.AddWithValue("@BtDateRealisation", DateTime.Now);
                    command.Parameters.AddWithValue("@numeroBT", numeroBT);
                    Enabled = false;

                    // Exécuter la commande d'insertion
                    command.ExecuteNonQuery();

                    // Afficher un message de succès
                    MessageBox.Show("Données modifiées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fermer le formulaire
                    this.Close();
                }
        }


        private void kryptonButtonBTModifierValider_Click(object sender, EventArgs e)
        {
            UpdateBTInBDD();
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
    }
}
