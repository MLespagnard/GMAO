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
    public partial class UserCreerForm : Form
    {
        private readonly MySqlConnection connection;
        public UserCreerForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection; 
        }

        ////////////// Click sur le bouton de création d'un USER
        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO user (USER_TYPE, USER_FIRST_NAME, USER_LAST_NAME, USER_ID_CONNECTION, USER_PASSWORD) VALUES (@userType, @userFirstName, @userLastName, @userConnectionId, @userPassword)";

            // Crée une liste avec la valeur des champs
            List<(string, string)> lst_champs = new List<(string, string)>
            {
                ("Prénom", textBoxFirstNameUser.Text),
                ("Nom", textBoxLastNameUser.Text),
                ("Mot de passe", textBoxPasswordUser.Text),
                ("Niveau d'accès", comboBoxRankForUser.SelectedItem as string),
            };


            // Envoie la liste des champs a la classe error pour vérifier la nullitée des champs
            if (Error.testvaleur(lst_champs) == false)
            {
                // Si un champ vide, stop du code
                return;
            }

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Clear();

                    int userType;

                    // Assigne le grade d'accès à un utilisateur
                    if (comboBoxRankForUser.SelectedItem != null)
                    {
                        if (comboBoxRankForUser.SelectedItem.ToString() == "Technicien")
                        {
                            userType = 1;
                            command.Parameters.AddWithValue("@userType", userType);
                        }
                        else if (comboBoxRankForUser.SelectedItem.ToString() == "Magasinier")
                        {
                            userType = 2;
                            command.Parameters.AddWithValue("@userType", userType);
                        }
                        else if (comboBoxRankForUser.SelectedItem.ToString() == "Administrateur")
                        {
                            userType = 3;
                            command.Parameters.AddWithValue("@userType", userType);
                        }
                        else
                        {
                            MessageBox.Show("Aucun niveau d'accès séléctionné");
                            return;
                        }
                    }

                    command.Parameters.AddWithValue("@userFirstName", textBoxFirstNameUser.Text);
                    command.Parameters.AddWithValue("@userLastName", textBoxLastNameUser.Text);
                    command.Parameters.AddWithValue("@userConnectionId", textBoxLastNameUser.Text.Substring(0, 3).ToLower() + textBoxFirstNameUser.Text.Substring(0, 3).ToLower());
                    command.Parameters.AddWithValue("@userPassword", textBoxPasswordUser.Text);

                    command.ExecuteNonQuery();



                    MessageBox.Show("Données insérées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
