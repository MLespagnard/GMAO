using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GMAONewVersion
{
    public partial class BTForm : Form 
    {
        
        private readonly MySqlConnection connection;
        private readonly string name;
        private string btNumeroForPrint;
        private int accesLvl; 

        public BTForm(MySqlConnection connection, string name, int accesLvl)
        {
            InitializeComponent();

            this.connection = connection;
            this.name = name;
            this.accesLvl = accesLvl;
            if(accesLvl < 3 ) 
            {
                ButtonOpenFormCreerBT.Enabled = false;
            }

            InsertDataInDataGridViewBTFunction(0);

        }

        private void BTForm_Load(object sender, EventArgs e)
        {
        }

        private void InsertDataInDataGridViewBTFunction(int archiveStatus)
        {
            string query;
            if (accesLvl == 1)
            {
                query = "SELECT BT_NUMERO, BT_EQUIPEMENT_CONCERNE, BT_MOTIF, BT_INTITULE, BT_CREATEUR FROM bt WHERE BT_NOM_INTERVENANT = @name AND archiver = @archiveStatus";
            }
            else
            {
                query = "SELECT BT_NUMERO, BT_EQUIPEMENT_CONCERNE, BT_MOTIF, BT_INTITULE, BT_CREATEUR FROM bt WHERE archiver = @archiveStatus";
            }

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@archiveStatus", archiveStatus);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Efface les colonnes existantes dans le DataGridView si elles existent
                        if (DataGridBT.Columns.Count > 0)
                        {
                            DataGridBT.Columns.Clear();
                        }

                        // Vérifie s'il y a des résultats
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
                            if (accesLvl != 2)
                            {
                                DataGridViewImageColumn dataGridViewImageModifierColumn = new DataGridViewImageColumn();
                                Image imageModifier = Image.FromFile("img/bouton-modifier.png");
                                dataGridViewImageModifierColumn.Image = imageModifier;
                                dataGridViewImageModifierColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                                DataGridBT.Columns.Add(dataGridViewImageModifierColumn);
                                Visible = false;
                            }

                            // Crée une colonne image pour imprimer
                            DataGridViewImageColumn dataGridViewImageImprimerColumn = new DataGridViewImageColumn();
                            Image imageImprimer = Image.FromFile("img/bouton-imprimer.png");
                            dataGridViewImageImprimerColumn.Image = imageImprimer;
                            dataGridViewImageImprimerColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridBT.Columns.Add(dataGridViewImageImprimerColumn);

                            if (accesLvl != 2)
                            {
                                DataGridViewImageColumn dataGridViewImageArchiverColumn = new DataGridViewImageColumn();
                                Image imageArchiver = Image.FromFile("img/bouton-archiver.png");
                                dataGridViewImageArchiverColumn.Image = imageArchiver;
                                dataGridViewImageArchiverColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                                DataGridBT.Columns.Add(dataGridViewImageArchiverColumn);
                                Visible = false;
                            }

                            // Ajuste la largeur des colonnes d'images
                            foreach (DataGridViewColumn column in DataGridBT.Columns)
                            {
                                if (column is DataGridViewImageColumn)
                                {
                                    // Resize the column width
                                    column.Width = 30;
                                }
                            }

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
            }// Si index 6 choisi
            else if (e.ColumnIndex == 6 && e.RowIndex >= 0 && checkBoxShowArchivageBT.Checked == false)
            {
                // Récupère le numéro du BT
                string numeroBT = DataGridBT.Rows[e.RowIndex].Cells["NumeroBTDataGridView"].Value.ToString();

                // Ouvre la page modofier BT avec les infos nécéssaires
                BTTModifierForm formModifierBT = new BTTModifierForm(connection, numeroBT, accesLvl);

                formModifierBT.FormClosed += BTTModifierForm_FormClosed;

                formModifierBT.ShowDialog();
            }// Si index 7 choisi Archivage
            else if (e.ColumnIndex == 7 && e.RowIndex >= 0 && checkBoxShowArchivageBT.Checked == false)
            {
                

                    PrintDocument document = new PrintDocument();
                    document.PrintPage += Document_PrintPage;

                    btNumeroForPrint = DataGridBT.Rows[e.RowIndex].Cells["NumeroBTDataGridView"].Value.ToString();

                    PrintDialog dialog = new PrintDialog();
                    dialog.Document = document;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        document.Print();
                    }
                
            }
            // Si index 8 choisi Archivage
            else if (e.ColumnIndex == 8 && e.RowIndex >= 0 && checkBoxShowArchivageBT.Checked == false)
            {
               
                    // Récupère le numéro du BT
                    string numeroBT = DataGridBT.Rows[e.RowIndex].Cells["NumeroBTDataGridView"].Value.ToString();

                    Archive.archiveToSql(connection, numeroBT, "bt", "BT_NUMERO");


                InsertDataInDataGridViewBTFunction(0);
            }
            else if (checkBoxShowArchivageBT.Checked == true)
                MessageBox.Show("Il est impossible de modifer un bon de travail archivé.");
        }

        //////////// Lors d'un clic sur le bouton créé du BT, ouvre le formulaire de création
        private void ButtonOpenFormCreerBT_Click(object sender, EventArgs e)

        {
            
                BTCreationForm fomCreerBT = new BTCreationForm(connection, name);

                // Crée un évenement à la fermeture du BTCréer à l'événement FormClosed
                fomCreerBT.FormClosed += FomCreerBT_FormClosed;

                // Affichez fomCreerBT
                fomCreerBT.ShowDialog();
                
            
        }

        ///////////  Gère le click pour gérer la visualisation de l'Archivage BT
        private void checkBoxShowArchivageBT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowArchivageBT.Checked == false)
            {
                InsertDataInDataGridViewBTFunction(0);
            }
            else if (checkBoxShowArchivageBT.Checked == true)
            {
                InsertDataInDataGridViewBTFunction(1);
            }
        }

        // Après form créer fermer créer, actualiser
        private void FomCreerBT_FormClosed(object sender, FormClosedEventArgs e)
        {
            InsertDataInDataGridViewBTFunction(0);
            checkBoxShowArchivageBT.Checked = false;
        }

        // Après form modifier fermer créer, actualiser
        private void BTTModifierForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            InsertDataInDataGridViewBTFunction(0);
            checkBoxShowArchivageBT.Checked = false;
        }


        // Impression
        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            string query = "SELECT * FROM bt WHERE BT_NUMERO = @btNumero";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@btNumero", btNumeroForPrint);
                using (MySqlDataReader reader = command.ExecuteReader()) { 
                
                    reader.Read();
                    Graphics g = e.Graphics; // déclaration de l'objet graphic
                    Font font = new Font("Arial", 12); // Objet définissant la police
                    Font fontPetit = new Font("Arial", 11); // Objet définissant la police

                    // En-tête
                    g.DrawString("Bon de Travail n°:   " + reader["BT_NUMERO"].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);

                    // Informations générales
                    int x = e.MarginBounds.Left; // Début sur la gauche
                    int y = e.MarginBounds.Top + 50; // début 50px du haut

                    g.DrawString("Nom de l’école: ", font, Brushes.Black, x, y);
                    g.DrawString("Cardijn Lorraine Arlon", font, Brushes.Black, x + 400, y);
                    y += 30; // Descends de 20

                    g.DrawString("Motif du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_MOTIF"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;

                    g.DrawString("Équipement concerné du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_EQUIPEMENT_CONCERNE"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;

                    g.DrawString("Pièces de rechange concerné du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_PIECE_RECHANGE"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;

                    g.DrawString("Nombre d’heures de l’équipement du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_HEURE_EQUIPEMENT"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;

                    g.DrawString("Travail à réaliser du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_TRAVAIL_REALISER"].ToString(), fontPetit, Brushes.Black, x, y += 25);
                    y += 30;

                    g.DrawString("Commentaire de l’intervenant du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_COMMENTAIRE_INTERVENANT"].ToString(), fontPetit, Brushes.Black, x, y += 25);
                    y += 30;

                    g.DrawString("Nom de l'intervenant du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_NOM_INTERVENANT"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;

                    g.DrawString("Temps de prestation du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["BT_TEMPS_TRAVAIL"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;

                    g.DrawString("Date de creation du BT: ", font, Brushes.Black, x, y);
                    g.DrawString(reader["DATE_CREATION"].ToString(), font, Brushes.Black, x + 400, y);
                    y += 30;


                    // Pied de page 
                    string date = DateTime.Now.ToString("dd/MM/yyyy"); // Récupère la date

                    g.DrawString(date, font, Brushes.Black, e.MarginBounds.Right - 100, e.MarginBounds.Bottom); // écrit la date

                    // Libérer les ressources // Pas important
                    font.Dispose();
                    g.Dispose();
                }
            }
        }
    }
}
