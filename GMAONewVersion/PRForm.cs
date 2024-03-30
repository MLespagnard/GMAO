using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAONewVersion
{
    public partial class PRForm : Form
    {
        private readonly MySqlConnection connection;
        public PRForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            InsertDataInDataGridViewPRFunction(0);
        }

        private void InsertDataInDataGridViewPRFunction(int archiveStatus)
        {
            string query = "SELECT *  FROM piece_de_rechange WHERE archiver = @archiveStatus";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@archiveStatus", archiveStatus);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Efface les colones existantes dans le DataGridView
                        DataGridPR.Columns.Clear();

                        // Vérifie s'il y a des résultat
                        if (reader.HasRows)
                        {
                            // Crée les différentes colonnes
                            DataGridPR.Columns.Add("NomPRDataGridView", "nom");
                            DataGridPR.Columns.Add("ConstructeurPRDataGridView", "constructeur");
                            DataGridPR.Columns.Add("RefConstructeurPRDataGridView", "referenceconstructeur");
                            DataGridPR.Columns.Add("FournisseurPRDataGridView", "fournisseur");
                            DataGridPR.Columns.Add("RefFournisseurPRDataGridView", "referencefournisseur");
                            DataGridPR.Columns.Add("StockMiniPRDataGridView", "stockminimal");
                            DataGridPR.Columns.Add("StockMaxPRDataGridView", "stockmaximal");
                            DataGridPR.Columns.Add("StockActuelPRDataGridView", "stockactuel");
                            DataGridPR.Columns.Add("CommanderPRDataGridView", "commander");

                            // Crée une colonne image pour modifier
                            DataGridViewImageColumn dataGridViewImageModifierColumn = new DataGridViewImageColumn();
                            Image imageModifier = Image.FromFile("Img/bouton-modifier.png");
                            dataGridViewImageModifierColumn.Image = imageModifier;
                            dataGridViewImageModifierColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridPR.Columns.Add(dataGridViewImageModifierColumn);



                            // Crée une colonne image pour archiver
                            DataGridViewImageColumn dataGridViewImageArchiverColumn = new DataGridViewImageColumn();
                            Image imageArchiver = Image.FromFile("Img/bouton-archiver.png");
                            dataGridViewImageArchiverColumn.Image = imageArchiver;
                            dataGridViewImageArchiverColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridPR.Columns.Add(dataGridViewImageArchiverColumn);


                            // Ajustez la largeur des colonnes d'images
                            foreach (DataGridViewColumn column in DataGridPR.Columns)
                            {
                                if (column is DataGridViewImageColumn)
                                {
                                    column.Width = 35;
                                }
                            }


                            // Ajustez la propriété AutoSizeColumnsMode

                            DataGridPR.CellFormatting += DataGridPR_CellFormatting; // Evenement à l'ajout de données (Dans ce cas ci c'est pour le rouge des commandes)


                            // Ajoute les résultats au DataGridView
                            while (reader.Read())
                            {
                                // Récupère les valeurs des colonnes spécifiées
                                string nom = reader["PR_NOM"].ToString();
                                string constructeur = reader["PR_CONSTRUCTEUR"].ToString();
                                string refconstructeur = reader["PR_REF_CONSTRUCTEUR"].ToString();
                                string fournisseur = reader["PR_FOURNISSEUR"].ToString();
                                string reffournisseur = reader["PR_REF_FOURNISSEUR"].ToString();
                                int stockmini = Convert.ToInt32(reader["PR_STOCK_MINI"]);
                                int stockmax = Convert.ToInt32(reader["PR_STOCK_MAX"]);
                                int stockactuel = Convert.ToInt32(reader["PR_STOCK_ACTUEL"]);

                                if (stockmini > stockactuel)
                                {
                                    string commander = "Oui";
                                    DataGridPR.Rows.Add(nom, constructeur, refconstructeur, fournisseur, reffournisseur, stockmini, stockmax, stockactuel, commander);
                                } else
                                {
                                    string commander = "Non";
                                    DataGridPR.Rows.Add(nom, constructeur, refconstructeur, fournisseur, reffournisseur, stockmini, stockmax, stockactuel, commander);
                                }
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

        private void DataGridPR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifie si la cellule est dans la colonne "Commander" et si sa valeur est "Oui"
            if (DataGridPR.Columns[e.ColumnIndex].Name == "CommanderPRDataGridView" && e.Value != null && e.Value.ToString() == "Oui")
            {
                // Définissez la couleur de fond de la cellule sur rouge
                e.CellStyle.ForeColor = Color.Red;
            }
        }



        private void ButtonCreerPR_Click(object sender, EventArgs e)
        {
            PRCreerForm formCreerPR = new PRCreerForm(connection);

            formCreerPR.FormClosed += FormPR_FormClosed;

            formCreerPR.ShowDialog();
        } 

        private void DataGridPR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.ColumnIndex == 9 && e.RowIndex >= 0 && checkBoxShowArchivagePR.Checked == false)
            {
                string nomPR = DataGridPR.Rows[e.RowIndex].Cells["NomPRDataGridView"].Value.ToString();
                PRModifierForm formModifierPR = new PRModifierForm(connection, nomPR);

                formModifierPR.FormClosed += FormPR_FormClosed;

                formModifierPR.ShowDialog();
            }
            else if (e.ColumnIndex == 10 && e.RowIndex >= 0 && checkBoxShowArchivagePR.Checked == false)
            {
                string nomPR = DataGridPR.Rows[e.RowIndex].Cells["NomPRDataGridView"].Value.ToString();

                Archive.archiveToSql(connection, nomPR, "piece_de_rechange", "PR_NOM");

                InsertDataInDataGridViewPRFunction(0);
            }
            else
                MessageBox.Show("Il est impossible de modifer une pièce de rechange archivée.");
        }

        private void FormPR_FormClosed(object sender, FormClosedEventArgs e)
        {
            InsertDataInDataGridViewPRFunction(0);
        }


        ///////////  Gère le click pour gérer la visualisation de l'Archivage BT
        private void checkBoxShowArchivagePR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowArchivagePR.Checked == false)
            {
                InsertDataInDataGridViewPRFunction(0);
            }
            else if (checkBoxShowArchivagePR.Checked == true)
            {
                InsertDataInDataGridViewPRFunction(1);
            }
        }
    }
}
