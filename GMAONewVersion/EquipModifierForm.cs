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
    public partial class EquipModifierForm : Form
    {
        private readonly MySqlConnection connection;
        string equipModel;
        public EquipModifierForm(MySqlConnection conn, string model)
        {
            InitializeComponent();

            connection = conn;
            equipModel = model;

            FillAllBoxModifierEquip();
            labelHeaderEquip.Text = labelHeaderEquip.Text;
        }

        // Remplir toutes les cases avec les infos SQL au chargement
        private void FillAllBoxModifierEquip()
        {
            // Requête SQL pour récupérer toutes les informations de la BT spécifiée
            string query = "SELECT * FROM equipements WHERE EQUIP_MODEL = @model";

            try
            {

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    // Nettoyer les contrôles
                    ClearAllControls();
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@model", equipModel);



                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Remplir les contrôles avec les données de la base de données
                            textBoxNomEquip.Text = reader["EQUIP_NOM"].ToString();
                            textBoxConstructeurEquip.Text = reader["EQUIP_CONSTRUCTEUR"].ToString();
                            textBoxModelEquip.Text = reader["EQUIP_MODEL"].ToString();
                            textBoxUsureEquip.Text = reader["EQUIP_TEMPS_USURE"].ToString();
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

        private void ButtonEquipModifier_Click(object sender, EventArgs e)
        {
            UpdateEquipInBDD();
        }


        private void UpdateEquipInBDD()
        {
            // Définir la requête d'insertion
            string query = "UPDATE equipements SET  EQUIP_NOM = @Nom, EQUIP_CONSTRUCTEUR = @Constructeur, EQUIP_MODEL = @Model, EQUIP_TEMPS_USURE = @Usure WHERE EQUIP_MODEL = @models ";


            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    // Ajouter les paramètres à la commande
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Nom", textBoxNomEquip.Text);
                    command.Parameters.AddWithValue("@Constructeur", textBoxConstructeurEquip.Text);
                    command.Parameters.AddWithValue("@Model", textBoxModelEquip.Text);
                    command.Parameters.AddWithValue("@Usure", textBoxUsureEquip.Text);
                    command.Parameters.AddWithValue("@models", equipModel);


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


    }
}
