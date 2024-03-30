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
    public partial class UserForm : Form
    {
        private readonly MySqlConnection connection;
        public UserForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            InsertDataInDataGridViewUserFunction(0);
        }

        private void InsertDataInDataGridViewUserFunction(int archiveStatus)
        {
            string query = "SELECT * FROM user WHERE  archiver = @archiveStatus";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@archiveStatus", archiveStatus);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Efface les colones existantes dans le DataGridView
                        DataGridViewUser.Columns.Clear();

                        // Vérifie s'il y a des résultat
                        if (reader.HasRows)
                        {
                            // Crée les différentes colonnes
                            DataGridViewUser.Columns.Add("FirstNameUserDataGridView", "Prénom");
                            DataGridViewUser.Columns.Add("LastNameUserDataGridView", "Nom");
                            DataGridViewUser.Columns.Add("ConnectionIdUserDataGridView", "Nom d'accès");
                            DataGridViewUser.Columns.Add("PasswordUserDataGridView", "Mot de passe");
                            DataGridViewUser.Columns.Add("UserTypeUserDataGridView", "Type");

                            // Crée une colonne image pour modifier
                            DataGridViewImageColumn dataGridViewImageModifierColumn = new DataGridViewImageColumn();
                            Image imageModifier = Image.FromFile("Img/bouton-modifier.png");
                            dataGridViewImageModifierColumn.Image = imageModifier;
                            dataGridViewImageModifierColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridViewUser.Columns.Add(dataGridViewImageModifierColumn);

                            // Crée une colonne image pour archiver
                            DataGridViewImageColumn dataGridViewImageArchiverColumn = new DataGridViewImageColumn();
                            Image imageArchiver = Image.FromFile("Img/bouton-archiver.png");
                            dataGridViewImageArchiverColumn.Image = imageArchiver;
                            dataGridViewImageArchiverColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridViewUser.Columns.Add(dataGridViewImageArchiverColumn);

   
                            // Ajustez la largeur des colonnes d'images
                            foreach (DataGridViewColumn column in DataGridViewUser.Columns)
                            {
                                if (column is DataGridViewImageColumn)
                                {
                                    column.Width = 35;
                                }
                            }

                            // Ajustez la propriété AutoSizeColumnsMode 
                            DataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ou utilisez une autre option selon vos préférences     // Ajoute un évenement sur les cellules du tableau;


                            // Ajoute les résultats au DataGridView
                            while (reader.Read())
                            {
                                // Récupère les valeurs des colonnes spécifiées
                                string FirstName = reader["USER_FIRST_NAME"].ToString();
                                string LastName = reader["USER_LAST_NAME"].ToString();
                                string ConnectionID = reader["USER_ID_CONNECTION"].ToString();
                                string Password = reader["USER_PASSWORD"].ToString();
                                string UserType = reader["USER_TYPE"].ToString();
                                if (UserType == "1")
                                    UserType = "Technicien";
                                else if (UserType == "2")
                                    UserType = "Magasinier";
                                else if (UserType == "3")
                                    UserType = "Admin";

                                // Ajoute une nouvelle ligne au DataGridView avec les valeurs récupérées
                                DataGridViewUser.Rows.Add(FirstName, LastName, ConnectionID, Password, UserType);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucun résultat trouvé.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
        }

        //////////// Gestionnaire de clics sur le DataGridView User
        private void DataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBoxShowArchivageUser.Checked == false)
            {
                // Si index 5 choisi // Index modif
                if (e.ColumnIndex == 5 && e.RowIndex >= 0)
                {
                    string UserIDConnection = DataGridViewUser.Rows[e.RowIndex].Cells["ConnectionIdUserDataGridView"].Value.ToString();
                    string UserFName = DataGridViewUser.Rows[e.RowIndex].Cells["FirstNameUserDataGridView"].Value.ToString();
                    string UserLName = DataGridViewUser.Rows[e.RowIndex].Cells["LastNameUserDataGridView"].Value.ToString();
                    string UserPassword = DataGridViewUser.Rows[e.RowIndex].Cells["PasswordUserDataGridView"].Value.ToString();
                    string UserAcces = DataGridViewUser.Rows[e.RowIndex].Cells["UserTypeUserDataGridView"].Value.ToString();

                    // Ouvre ModifierUser 
                    UserModifierForm formVisualiserBT = new UserModifierForm(connection, UserIDConnection, UserFName, UserLName, UserPassword, UserAcces);

                    formVisualiserBT.FormClosed += FormModifierUser_FormClosed;


                    formVisualiserBT.ShowDialog();
                }
                // Si index 6 choisi
                else if (e.ColumnIndex == 6 && e.RowIndex >= 0)
                {
                    // Récupère le IdConnexion
                    string IdConnection = DataGridViewUser.Rows[e.RowIndex].Cells["ConnectionIdUserDataGridView"].Value.ToString();

                    Archive.archiveToSql(connection, IdConnection, "user", "USER_ID_CONNECTION");

                    InsertDataInDataGridViewUserFunction(0);
                }
            }
            else
                MessageBox.Show("Il est impossible de modifer un utilisateur archivé.");
            
        }

        private void checkBoxShowArchivageBT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowArchivageUser.Checked == false)
            {
                InsertDataInDataGridViewUserFunction(0);
            }
            else if (checkBoxShowArchivageUser.Checked == true)
            {
                InsertDataInDataGridViewUserFunction(1);
            }
        }

        private void FormModifierUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Remplir le DataGridView
            InsertDataInDataGridViewUserFunction(0);
        }


        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            UserCreerForm userCreerForm = new UserCreerForm(connection);

            userCreerForm.FormClosed += FormModifierUser_FormClosed;

            userCreerForm.ShowDialog();

        }
    }
}
