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
                comboBoxEquipementConcerneBT.Enabled = false;
                checkedListBoxPieceRechangeBT.Enabled = false;
                RichTextBoxTravailRealiserBT.Enabled = false;
                groupBoxNbHeuresBT.Enabled = false;
                comboBoxNomInterBT.Enabled = false;
                textBoxCreateurBT.Enabled  = false;
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
                            comboBoxEquipementConcerneBT.Items.Add(reader["BT_EQUIPEMENT_CONCERNE"].ToString());
                            comboBoxEquipementConcerneBT.SelectedIndex = 0;
                            ;
                            PieceRechangeBT = reader["BT_PIECE_RECHANGE"].ToString();

                            textBoxNbHeuresBT.Text = reader["BT_HEURE_EQUIPEMENT"].ToString().Trim();
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

            // Requête SQL pour récupérer les noms des pièces de rechange
            string query = "SELECT PR_NOM FROM piece_de_rechange WHERE archiver = 0";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nomPiece = reader["PR_NOM"].ToString();

                        // Vérifier si la pièce de rechange est égale à l'un des éléments de items
                        if (Array.Exists(items, item => item == nomPiece))
                        {
                            // Ajouter la pièce de rechange à checkedListBoxPieceRechange
                            checkedListBoxPieceRechangeBT.Items.Add(nomPiece, true);
                        }
                        else
                        {
                            // Ajouter les autres pièces sans les cocher
                            checkedListBoxPieceRechangeBT.Items.Add(nomPiece, false);
                        }
                    }
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

        // Pour désactiver tous les contrôles du formulaire principal

        private String checkPieceRechange()
        {
            string s = "";
            if (checkedListBoxPieceRechangeBT.CheckedItems.Count != 0)
            {
                // Boucler sur les éléments sélectionnés et les mettre dans la variable S
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
            }
            return s;
        }
        private void UpdateBTInBDD()
        {
           
            
                // Définir la requête d'insertion
                string query = "UPDATE bt SET BT_INTITULE = @Intitule, BT_EQUIPEMENT_CONCERNE = @EquipementConcerne, BT_PIECE_RECHANGE = @PieceRechange, " +
                               "BT_HEURE_EQUIPEMENT = @NbHeures, BT_TRAVAIL_REALISER = @TravailRealise, BT_COMMENTAIRE_INTERVENANT = @CommentaireInterne, " +
                               "BT_NOM_INTERVENANT = @NomIntervenant, BT_TEMPS_TRAVAIL = @TempsPreste, BT_ISFINISH = @isFinish, BT_DATE_REALISATION = @BtDateRealisation  WHERE BT_NUMERO = @numeroBT";

                if (checkBoxIsFinish.Checked)
                {
                    isChecked = 1;
                }
                else
                {
                    isChecked = 0;
                }

                try
                {

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                   
                        // Ajouter les paramètres à la commande
                        command.Parameters.AddWithValue("@Intitule", textBoxIntituleBT.Text);
                        command.Parameters.AddWithValue("@EquipementConcerne", comboBoxEquipementConcerneBT.SelectedItem as string);
                        command.Parameters.AddWithValue("@PieceRechange", checkPieceRechange());
                        command.Parameters.AddWithValue("@NbHeures", textBoxNbHeuresBT.Text);
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


                        // Ferme le formulaire
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
