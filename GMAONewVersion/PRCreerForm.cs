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
    public partial class PRCreerForm : Form
    {

        private readonly MySqlConnection connection;
        public PRCreerForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void ButtonPRCreerValider_Click(object sender, EventArgs e)
        {
            List<(string, string)> lst_champs = new List<(string, string)>
            {
                ("Nom", textBoxNomPR.Text),
                ("Constructeur", textBoxConstructeurPR.Text),
                ("RefConstructeur", textBoxRefConstructeurPR.Text),
                ("Fournisseur", textBoxFournisseurPR.Text),
                ("RefFournisseur",textBoxRefFournisseurPR.Text),
                ("StockMini",textBoxStockMiniPR.Text),
                ("StockMax",textBoxStockMaxPR.Text),
            };

            // Envoie la liste des champs a la classe error pour vérifier la nullitée des champs
            if (Error.testvaleur(lst_champs) == false)
            {
                // Si un champ vide, stop du code
                return;
            }
            InsererDonneesDansDB();

        }
        private void InsererDonneesDansDB()
        {
            // Définir la requête d'insertion
            string query = "INSERT INTO piece_de_rechange (PR_NOM, PR_CONSTRUCTEUR, PR_REF_CONSTRUCTEUR, PR_FOURNISSEUR, PR_REF_FOURNISSEUR,PR_STOCK_MINI, PR_STOCK_MAX, PR_STOCK_ACTUEL ) VALUES (@Nom, @Constructeur, @RefConstructeur, @Fournisseur, @RefFournisseur, @StockMini, @StockMax, @StockActuel)";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@Nom", textBoxNomPR.Text);
                    command.Parameters.AddWithValue("@Constructeur", textBoxConstructeurPR.Text);
                    command.Parameters.AddWithValue("@RefConstructeur", textBoxRefConstructeurPR.Text);
                    command.Parameters.AddWithValue("@Fournisseur", textBoxFournisseurPR.Text);
                    command.Parameters.AddWithValue("@RefFournisseur", textBoxRefFournisseurPR.Text);
                    command.Parameters.AddWithValue("@StockMini", textBoxStockMiniPR.Text);
                    command.Parameters.AddWithValue("@StockMax", textBoxStockMaxPR.Text);
                    command.Parameters.AddWithValue("@StockActuel", textBoxStockActuelPR.Text);


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
