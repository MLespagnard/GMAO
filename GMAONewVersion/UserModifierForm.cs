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
    public partial class UserModifierForm : Form
    {
        MySqlConnection connection;
        string UserIdConnection;
        string FirstName;
        string LastName;
        string UserPassword;
        string UserGradeAcces;
        Int32 UserType;
        public UserModifierForm(MySqlConnection conn, String userIdconn, String fName, string lName, string mdp, string lvlAcces)
        {
            InitializeComponent();
            connection = conn;

            UserIdConnection = userIdconn;
            FirstName = fName;
            LastName = lName;
            UserPassword = mdp;
            UserGradeAcces = lvlAcces;

            labelHeaderCreateUser.Text = labelHeaderCreateUser.Text + FirstName + " " + LastName;

            textBoxFirstNameUser.Text = FirstName;
            textBoxLastNameUser.Text = LastName;
            textBoxIdConnectionUser.Text = UserIdConnection;
            textBoxPasswordUser.Text = UserPassword;

            comboBoxRankForUser.Items.Clear();
            if (UserGradeAcces == "Admin")
            {
                comboBoxRankForUser.Items.Add("Administrateur");
                comboBoxRankForUser.Items.Add("Magasinier");
                comboBoxRankForUser.Items.Add("Technicien");
                comboBoxRankForUser.SelectedIndex = 0;
            }
            else if (UserGradeAcces == "Magasinier")
            {
                comboBoxRankForUser.Items.Add("Magasinier");
                comboBoxRankForUser.Items.Add("Technicien");
                comboBoxRankForUser.Items.Add("Administrateur");
                comboBoxRankForUser.SelectedIndex = 0;
            }
            else if (UserGradeAcces == "Technicien")
            {
                comboBoxRankForUser.Items.Add("Technicien");
                comboBoxRankForUser.Items.Add("Magasinier");
                comboBoxRankForUser.Items.Add("Administrateur");
                comboBoxRankForUser.SelectedIndex = 0;
            }
        }

        private void ButtonModifierUser_Click(object sender, EventArgs e)
        {
            if (comboBoxRankForUser.SelectedItem as string == "Technicien")
                UserType = 1;
            else if (comboBoxRankForUser.SelectedItem as string == "Magasinier")
                UserType = 2;
            else if (comboBoxRankForUser.SelectedItem as string == "Administrateur")
                UserType = 3;



            // Définir la requête d'insertion
            string query = "UPDATE user SET USER_PASSWORD = @UserPassword, USER_TYPE = @UserType WHERE USER_ID_CONNECTION = @IDConnection;";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@UserPassword", textBoxPasswordUser.Text);
                    command.Parameters.AddWithValue("@UserType", UserType);
                    command.Parameters.AddWithValue("@IDConnection", UserIdConnection);

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
