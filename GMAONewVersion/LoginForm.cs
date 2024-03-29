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
using MySql.Data.MySqlClient;

namespace GMAONewVersion
{
    public partial class LoginForm : Form
    {
        // Déclaration variable 
        private readonly string connectionString = "server=mysql-kokoldex.alwaysdata.net;database=kokoldex_gmao;uid=kokoldex_public;pwd=Public123!;";
        private MySqlConnection connection;


        public LoginForm()
        {
            InitializeComponent();
        }

        // Initialise la connexion lors du chargement du formulaire
        private void LoginForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        private void buttonConnectionLoginForm_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user WHERE USER_ID_CONNECTION = @IDConnection";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDConnection", textBoxConnectionId.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // si un utilisateur avec ce id existe
                        {
                            string storedPassword = reader["USER_PASSWORD"].ToString(); // Récupérer le mdp stocké
                            string enteredPassword = textBoxPassword.Text; // Récupérer le mdp entré par user

                            // Comparer les mots de passe
                            if (storedPassword == enteredPassword)
                            {
                                string fullUserName = reader["USER_FIRST_NAME"].ToString().Trim() + " " + reader["USER_LAST_NAME"].ToString().Trim();
                                int grade = Int32.Parse(reader["USER_TYPE"].ToString());



                                ParentForm formPrincipal = new ParentForm(connection, fullUserName, grade);
                                this.Hide();
                                // Afficher le form principal
                                formPrincipal.Show();
                            }
                            else
                            {
                                MessageBox.Show("Mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Utilisateur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'authentification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
