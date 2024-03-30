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
    public partial class EquipCreerForm : Form
    {
        private readonly MySqlConnection connection;
        public EquipCreerForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void ButtonEquipCreerValider_Click(object sender, EventArgs e)
        {
            List<(string, string)> lst_champs = new List<(string, string)>
            {
                ("Nom", textBoxNomEquip.Text),
                ("Constructeur", textBoxConstructeurEquip.Text),
                ("Model", textBoxModelEquip.Text),
                ("Heures_usure", textBoxUsureEquip.Text),

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
            string query = "INSERT INTO equipements (EQUIP_NOM, EQUIP_CONSTRUCTEUR, EQUIP_MODEL, EQUIP_TEMPS_USURE) VALUES (@Nom, @Constructeur, @Model, @Heures_usure)";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@Nom", textBoxNomEquip.Text);
                    command.Parameters.AddWithValue("@Constructeur", textBoxConstructeurEquip.Text);
                    command.Parameters.AddWithValue("@Model", textBoxModelEquip.Text);
                    command.Parameters.AddWithValue("@Heures_usure", textBoxUsureEquip.Text);

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

        private void textBoxUsureEquip_KeyPress(object sender, KeyPressEventArgs e)
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
