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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GMAONewVersion
{
    public partial class BTForm : Form
    {
        private readonly MySqlConnection connection;
        private readonly string name;

        public BTForm(MySqlConnection connection, string name)
        {
            InitializeComponent();

            this.connection = connection;
            this.name = name;

            InsertDataInDataGridViewBTFunction(0);
        }


        private void InsertDataInDataGridViewBTFunction(int archiveStatus)
        {
            string query = "SELECT BT_NUMERO, BT_EQUIPEMENT_CONCERNE , BT_MOTIF, BT_INTITULE, BT_CREATEUR FROM bt WHERE archiver = @archiveStatus";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@archiveStatus", archiveStatus);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Efface les colones existantes dans le DataGridView
                        DataGridBT.Columns.Clear();

                        // Vérifie s'il y a des résultat
                        if (reader.HasRows)
                        {
                            // Crée les différentes colonnes
                            DataGridBT.Columns.Add("NumeroBTDataGridView", "Numéro");
                            DataGridBT.Columns.Add("MotiBTDataGridView", "Motif");
                            DataGridBT.Columns.Add("EquipementBTDataGridView", "Equipement");
                            DataGridBT.Columns.Add("IntituleBTDataGridView", "Intitulé");
                            DataGridBT.Columns.Add("CreateurBTDataGridView", "Créateur");

                            // Crée une colonne image pour visualiser 
                            DataGridViewImageColumn dataGridViewImageVisualiserColumn = new DataGridViewImageColumn();
                            Image imageVisualiser = Image.FromFile("img/bouton-visualiser.png");
                            dataGridViewImageVisualiserColumn.Image = imageVisualiser;
                            dataGridViewImageVisualiserColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridBT.Columns.Add(dataGridViewImageVisualiserColumn);

                            // Crée une colonne image pour modifier
                            DataGridViewImageColumn dataGridViewImageModifierColumn = new DataGridViewImageColumn();
                            Image imageModifier = Image.FromFile("img/bouton-modifier.png");
                            dataGridViewImageModifierColumn.Image = imageModifier;
                            dataGridViewImageModifierColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridBT.Columns.Add(dataGridViewImageModifierColumn);

                            // Crée une colonne image pour imprimer
                            DataGridViewImageColumn dataGridViewImageImprimerColumn = new DataGridViewImageColumn();
                            Image imageImprimer = Image.FromFile("img/bouton-imprimer.png");
                            dataGridViewImageImprimerColumn.Image = imageImprimer;
                            dataGridViewImageImprimerColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridBT.Columns.Add(dataGridViewImageImprimerColumn);

                            // Crée une colonne image pour archiver
                            DataGridViewImageColumn dataGridViewImageArchiverColumn = new DataGridViewImageColumn();
                            Image imageArchiver = Image.FromFile("img/bouton-archiver.png");
                            dataGridViewImageArchiverColumn.Image = imageArchiver;
                            dataGridViewImageArchiverColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridBT.Columns.Add(dataGridViewImageArchiverColumn);


                            // Ajustez la largeur des colonnes d'images
                            foreach (DataGridViewColumn column in DataGridBT.Columns)
                            {
                                if (column is DataGridViewImageColumn)
                                {
                                    // Resize the column width
                                    column.Width = 30;
                                }
                            }


                            // Ajustez la propriété AutoSizeColumnsMode

                            // Ajoute les résultats au DataGridView
                            while (reader.Read())
                            {
                                // Récupère les valeurs des colonnes spécifiées
                                string numero = reader["BT_NUMERO"].ToString();
                                string motif = reader["BT_MOTIF"].ToString();
                                string equipement = reader["BT_EQUIPEMENT_CONCERNE"].ToString();
                                string intitule = reader["BT_INTITULE"].ToString();
                                string createur = reader["BT_CREATEUR"].ToString();

                                // Ajoute une nouvelle ligne au DataGridView avec les valeurs récupérées
                                DataGridBT.Rows.Add(numero, motif, equipement, intitule, createur);
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

        //////////// Gestionnaire de clics sur le DataGridView BT
        private void DataGridBT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si index 5 choisi
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                string numeroBT = DataGridBT.Rows[e.RowIndex].Cells["NumeroBTDataGridView"].Value.ToString();
                // Ouvre visualisetBT
                BTVisualiserForm formVisualiserBT = new BTVisualiserForm(connection, numeroBT);
                formVisualiserBT.ShowDialog();
            }
        }

        //////////// Lors d'un clic sur le bouton créé du BT, ouvre le formulaire de création
        private void kryptonButtonOpenFormCreerBT_Click(object sender, EventArgs e)
        {
            BTCreationForm fomCreerBT = new BTCreationForm(connection, name);

            // Crée un évenement à la fermeture du BTCréer à l'événement FormClosed
            fomCreerBT.FormClosed += FomCreerBT_FormClosed;

            // Affichez fomCreerBT
            fomCreerBT.ShowDialog();
        }

    }
}
