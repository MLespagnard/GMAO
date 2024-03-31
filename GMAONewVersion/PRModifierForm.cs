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
    public partial class PRModifierForm : Form
    {
        private readonly MySqlConnection connection;
        string nomPR;
        public PRModifierForm(MySqlConnection conn, string nom)
        {
            InitializeComponent();
            connection = conn;
            nomPR = nom;

            // Remplir toutes les cases avec les infos SQL au chargement
            FillAllBoxModifierPR();
            labelHeaderPR.Text = labelHeaderPR.Text;
        }
        // Remplir toutes les cases avec les infos SQL au chargement
        private void FillAllBoxModifierPR()
        {
            // Requête SQL pour récupérer toutes les informations de la BT spécifiée
            string query = "SELECT * FROM piece_de_rechange WHERE PR_NOM = @nom";

            try
            {

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    // Nettoyer les contrôles
                    ClearAllControls();
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@nom", nomPR);



                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Remplir les contrôles avec les données de la base de données
                            textBoxNomPR.Text = reader["PR_NOM"].ToString();
                            textBoxConstructeurPR.Text = reader["PR_CONSTRUCTEUR"].ToString();
                            textBoxRefConstructeurPR.Text = reader["PR_REF_CONSTRUCTEUR"].ToString();
                            textBoxFournisseurPR.Text = reader["PR_FOURNISSEUR"].ToString();
                            textBoxRefFournisseurPR.Text = reader["PR_REF_FOURNISSEUR"].ToString();
                            textBoxStockMiniPR.Text = reader["PR_STOCK_MINI"].ToString();
                            textBoxStockMaxPR.Text = reader["PR_STOCK_MAX"].ToString();
                            textBoxStockActuelPR.Text = reader["PR_STOCK_ACTUEL"].ToString();

                        }
                        reader.Close(); // Fermer le DataReader après avoir lu les données

                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs potentielles lors de l'exécution de la requête
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
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
            }
        }


        private void UpdatePRInBDD()
        {
            // Définir la requête d'insertion
            string query = "UPDATE piece_de_rechange SET  PR_NOM = @Nom, PR_CONSTRUCTEUR = @Constructeur, PR_REF_CONSTRUCTEUR = @RefConstructeur, PR_FOURNISSEUR = @Fournisseur, PR_REF_FOURNISSEUR = @RefFournisseur, PR_STOCK_MINI = @StockMini," +
                 " PR_STOCK_MAX = @StockMax, PR_STOCK_ACTUEL = @StockActuel WHERE PR_NOM = @noms ";


            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    // Ajouter les paramètres à la commande
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Nom", textBoxNomPR.Text);
                    command.Parameters.AddWithValue("@Constructeur", textBoxConstructeurPR.Text);
                    command.Parameters.AddWithValue("@RefConstructeur", textBoxRefConstructeurPR.Text);
                    command.Parameters.AddWithValue("@Fournisseur", textBoxFournisseurPR.Text);
                    command.Parameters.AddWithValue("@RefFournisseur", textBoxRefFournisseurPR.Text);
                    command.Parameters.AddWithValue("@StockMini", textBoxStockMiniPR.Text);
                    command.Parameters.AddWithValue("@StockMax", textBoxStockMaxPR.Text);
                    command.Parameters.AddWithValue("@StockActuel", textBoxStockActuelPR.Text);
                    command.Parameters.AddWithValue("@noms", nomPR);


                    // Exécuter la commande d'insertion
                    command.ExecuteNonQuery();

                    // Afficher un message de succèse
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

        private void ButtonPRModifierValider_Click(object sender, EventArgs e)
        {
            UpdatePRInBDD();
        }

        private void textBoxRefFournisseurPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère entré n'est pas un chiffre ou la touche de contrôle (comme Backspace) // Chat GPT
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Annule la saisie du caractère en empêchant l'événement KeyPress de se propager
                e.Handled = true;
            }
        }

        private void textBoxStockMiniPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère entré n'est pas un chiffre ou la touche de contrôle (comme Backspace) // Chat GPT
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Annule la saisie du caractère en empêchant l'événement KeyPress de se propager
                e.Handled = true;
            }
        }

        private void textBoxStockMaxPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère entré n'est pas un chiffre ou la touche de contrôle (comme Backspace) // Chat GPT
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Annule la saisie du caractère en empêchant l'événement KeyPress de se propager
                e.Handled = true;
            }
        }

        private void textBoxStockActuelPR_KeyPress(object sender, KeyPressEventArgs e)
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
