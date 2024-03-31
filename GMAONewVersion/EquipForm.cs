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
    public partial class EquipForm : Form
    {
        private readonly MySqlConnection connection;
        public EquipForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            InsertDataInDataGridViewEquipFunction(0);
        }

        private void InsertDataInDataGridViewEquipFunction(int archiveStatus)
        {
            string query = "SELECT *  FROM equipements WHERE archiver = @archiveStatus";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@archiveStatus", archiveStatus);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Efface les colones existantes dans le DataGridView
                        DataGridEquip.Columns.Clear();

                        // Vérifie s'il y a des résultat
                        if (reader.HasRows)
                        {
                            // Crée les différentes colonnes
                            DataGridEquip.Columns.Add("NomEquipDataGridView", "nom");
                            DataGridEquip.Columns.Add("ConstructeurEquipDataGridView", "constructeur");
                            DataGridEquip.Columns.Add("ModelEquipDataGridView", "model");
                            DataGridEquip.Columns.Add("UsureEquipDataGridView", "usure");




                            // Crée une colonne image pour modifier
                            DataGridViewImageColumn dataGridViewImageModifierColumn = new DataGridViewImageColumn();
                            Image imageModifier = Image.FromFile("Img/bouton-modifier.png");
                            dataGridViewImageModifierColumn.Image = imageModifier;
                            dataGridViewImageModifierColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridEquip.Columns.Add(dataGridViewImageModifierColumn);



                            // Crée une colonne image pour archiver
                            DataGridViewImageColumn dataGridViewImageArchiverColumn = new DataGridViewImageColumn();
                            Image imageArchiver = Image.FromFile("Img/bouton-archiver.png");
                            dataGridViewImageArchiverColumn.Image = imageArchiver;
                            dataGridViewImageArchiverColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            DataGridEquip.Columns.Add(dataGridViewImageArchiverColumn);


                            // Ajustez la largeur des colonnes d'images
                            foreach (DataGridViewColumn column in DataGridEquip.Columns)
                            {
                                if (column is DataGridViewImageColumn)
                                {
                                    column.Width = 35;
                                }
                            }

                            // Ajustez la propriété AutoSizeColumnsMode
                            DataGridEquip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ou utilisez une autre option selon vos préférences     

                            // Ajoute les résultats au DataGridView
                            while (reader.Read())
                            {
                                // Récupère les valeurs des colonnes spécifiées
                                string nom = reader["EQUIP_NOM"].ToString();
                                string constructeur = reader["EQUIP_CONSTRUCTEUR"].ToString();
                                string model = reader["EQUIP_MODEL"].ToString();
                                string usure = reader["EQUIP_TEMPS_USURE"].ToString();

                                // Ajoute une nouvelle ligne au DataGridView avec les valeurs récupérées
                                DataGridEquip.Rows.Add(nom, constructeur, model, usure);
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

        private void DataGridEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si index 5 choisi
            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && checkBoxShowArchivageEquip.Checked == false)
            {
                string modelEquip = DataGridEquip.Rows[e.RowIndex].Cells["ModelEquipDataGridView"].Value.ToString();
                EquipModifierForm formModifierEquip = new EquipModifierForm(connection, modelEquip);

                formModifierEquip.FormClosed += FormCreerEquip_FormClosed;


                formModifierEquip.ShowDialog();

            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && checkBoxShowArchivageEquip.Checked == false)
            {
                // Récupère le numéro du BT
                string equipModel = DataGridEquip.Rows[e.RowIndex].Cells["ModelEquipDataGridView"].Value.ToString();

                MessageBox.Show(equipModel);

                Archive.archiveToSql(connection, equipModel, "equipements", "EQUIP_MODEL");

                InsertDataInDataGridViewEquipFunction(0);
            }
            else if (checkBoxShowArchivageEquip.Checked == true)
                MessageBox.Show("Il est impossible de modifer un équipement archivé.");
        }

        private void FormCreerEquip_FormClosed(object sender, FormClosedEventArgs e)
        {
            InsertDataInDataGridViewEquipFunction(0);
            checkBoxShowArchivageEquip.Checked = false;
        }

        private void kryptonCreerEquip_Click(object sender, EventArgs e)
        {
            EquipCreerForm formCreerEquip = new EquipCreerForm(connection);

            formCreerEquip.FormClosed += FomCreerEquip_FormClosed;

            formCreerEquip.ShowDialog();
        }

        //////////// Méthode à exécuter lorsque le formulaire est fermé
        private void FomCreerEquip_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Remplir le DataGridView
            InsertDataInDataGridViewEquipFunction(0);
            checkBoxShowArchivageEquip.Checked = false;
        }

        private void checkBoxShowArchivageEquip_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowArchivageEquip.Checked == false)
                InsertDataInDataGridViewEquipFunction(0);
            else if (checkBoxShowArchivageEquip.Checked == true)
                InsertDataInDataGridViewEquipFunction(1);
        }
    }
}
