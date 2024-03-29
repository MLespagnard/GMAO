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
    public partial class BTVisualiserForm : Form
    {

        private string numeroBT;
        private readonly MySqlConnection connection;
        public BTVisualiserForm(MySqlConnection conn, String numero)
        {
            InitializeComponent();

            connection = conn;
            numeroBT = numero;
            fillAllBoxVisualiserBT();
            labelHeaderBT.Text = labelHeaderBT.Text + numeroBT;
        }

        private void fillAllBoxVisualiserBT()
        {
            string query = "SELECT * FROM bt WHERE BT_NUMERO = '" + numeroBT + "'";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Vide tout les textes des box
                    textBoxIntituleBT.Clear();
                    textBoxMotifBT.Clear();
                    textBoxCreateurBT.Clear();
                    textBoxEquipementConcerneBT.Clear();
                    ListBoxPieceRechangeBT.Items.Clear();
                    textBoxNbHeuresBT.Clear();
                    RichTextBoxTravailRealiserBT.Clear();
                    RichTextBoxCommentaireInterBT.Clear();
                    textBoxNomInterBT.Clear();
                    textBoxTempsPresteBT.Clear();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBoxMotifBT.Text = reader["BT_MOTIF"].ToString();
                            textBoxIntituleBT.Text = reader["BT_INTITULE"].ToString();
                            textBoxCreateurBT.Text = reader["BT_CREATEUR"].ToString();
                            textBoxEquipementConcerneBT.Text = reader["BT_EQUIPEMENT_CONCERNE"].ToString();

                            String itemSqlPieceRechange = reader["BT_PIECE_RECHANGE"].ToString().Trim();
                            String[] items = itemSqlPieceRechange.Split(';');

                            foreach (String item in items)
                            {
                                ListBoxPieceRechangeBT.Items.Add(item);
                            }
                            textBoxNbHeuresBT.Text = reader["BT_HEURE_EQUIPEMENT"].ToString();
                            RichTextBoxTravailRealiserBT.Text = reader["BT_TRAVAIL_REALISER"].ToString();
                            RichTextBoxCommentaireInterBT.Text = reader["BT_COMMENTAIRE_INTERVENANT"].ToString();
                            textBoxNomInterBT.Text = reader["BT_NOM_INTERVENANT"].ToString();
                            textBoxTempsPresteBT.Text = reader["BT_TEMPS_TRAVAIL"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
