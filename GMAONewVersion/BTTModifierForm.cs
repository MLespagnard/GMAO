using Google.Protobuf.WellKnownTypes;
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
    public partial class BTTModifierForm : Form
    {
        private int accesLvl;
        private readonly MySqlConnection connection;
        private readonly string numeroBT;
        private string nomInter;
        private int indexIntervenant;
        private int isChecked;
        public List<string> OGItems = new List<string>();
        public List<(string, string)> OldPRValue = new List<(string, string)>();
        public List<string> PRNewValeur = new List<string>();

        public BTTModifierForm(MySqlConnection conn, string numero, int accesLvl)
        {
            InitializeComponent();
            connection = conn;
            numeroBT = numero;
            this.accesLvl = accesLvl;

            FillAllBoxModifierBT();
            labelHeaderBT.Text = labelHeaderBT.Text + numeroBT;

            if (accesLvl == 1)
            {
                groupBoxIntituleBT.Enabled = false;
                checkedListBoxPieceRechangeBT.Enabled = false;
                RichTextBoxTravailRealiserBT.Enabled = false;
                comboBoxNomInterBT.Enabled = false;
                textBoxCreateurBT.Enabled = false;
            }

            foreach (string item in OGItems)
            {
                checkedListBoxPieceRechangeBT.Items.Add(item);
            }
        }

        private void FillAllBoxModifierBT()
        {
            string query = "SELECT * FROM bt WHERE BT_NUMERO = @NumeroBT;";

            try
            {
                string PieceRechangeBT = "";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeroBT", numeroBT);
                    ClearAllControls();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBoxIntituleBT.Text = reader["BT_INTITULE"].ToString();
                            textBoxCreateurBT.Text = reader["BT_CREATEUR"].ToString();
                            PieceRechangeBT = reader["BT_PIECE_RECHANGE"].ToString();
                            RichTextBoxTravailRealiserBT.Text = reader["BT_TRAVAIL_REALISER"].ToString().Trim();
                            RichTextBoxCommentaireInterBT.Text = reader["BT_COMMENTAIRE_INTERVENANT"].ToString().Trim();

                            isChecked = Convert.ToInt32(reader["BT_ISFINISH"].ToString().Trim());

                            if (isChecked == 0)
                            {
                                checkBoxIsFinish.Checked = false;
                                checkBoxIsFinish.Enabled = true;
                            }
                            else if (isChecked == 1)
                            {
                                checkBoxIsFinish.Checked = true;
                                DisableAllControls(this);
                            }

                            nomInter = reader["BT_NOM_INTERVENANT"].ToString().Trim();
                            comboBoxNomInterBT.Items.Add(nomInter);
                            indexIntervenant = comboBoxNomInterBT.Items.Count - 1;
                        }

                        reader.Close();
                        fillGroupBoxNomInterBT(nomInter, indexIntervenant);
                        FillCheckedListBoxPieceRechange(PieceRechangeBT);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        private void fillGroupBoxNomInterBT(string nomInter, int indexIntervenant)
        {
            string query = "SELECT * FROM user WHERE USER_TYPE = 1 or USER_TYPE = 2 AND archiver = 0";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nomComplet = reader["USER_FIRST_NAME"].ToString() + " " + reader["USER_LAST_NAME"];

                            if (nomComplet != nomInter)
                            {
                                comboBoxNomInterBT.Items.Add(nomComplet);
                            }
                        }
                    }
                }

                comboBoxNomInterBT.SelectedIndex = indexIntervenant;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête: " + ex.Message);
            }
        }

        private void FillCheckedListBoxPieceRechange(string pieceRechangeBT)
        {
            checkedListBoxPieceRechangeBT.Items.Clear();
            string[] items = pieceRechangeBT.Split(';');
            List<string> nomsPieceRechange = new List<string>();

            string query = "SELECT PR_NOM FROM piece_de_rechange WHERE archiver = 0";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nomPiece = reader["PR_NOM"].ToString();
                        nomsPieceRechange.Add(nomPiece);
                    }
                }
            }

            foreach (string nomPiece in nomsPieceRechange)
            {
                foreach (var itemAllPR in items)
                {
                    string[] ItemAllSplit = itemAllPR.Split('=');
                    if (ItemAllSplit.Length == 2 && ItemAllSplit[0] == nomPiece)
                    {
                        OldPRValue.Add((ItemAllSplit[0].Trim(), ItemAllSplit[1].Trim()));
                        checkedListBoxPieceRechangeBT.Items.Add(nomPiece, true);

                        Control[] foundControls = flowLayoutPanelNumeros.Controls.Find("textBoxNumero_" + ItemAllSplit[0], true);

                        if (foundControls.Length > 0 && foundControls[0] is TextBox)
                        {
                            ((TextBox)foundControls[0]).Text = ItemAllSplit[1].Trim();
                        }
                        break;
                    }
                }
            }
        }

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
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void DisableAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                }
                else if (control is CheckedListBox checkedListBox)
                {
                    checkedListBox.Enabled = false;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Enabled = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Enabled = false;
                }
                else if (control is Control)
                {
                    DisableAllControls((Control)control);
                }
            }
        }

        private void UpdateBTInBDD()
        {
            foreach (var item in checkedListBoxPieceRechangeBT.CheckedItems)
            {
                string pieceDeRechange = item.ToString();
                string TexBoxName = "textBoxNumero_" + pieceDeRechange;
                TextBox texbox = flowLayoutPanelNumeros.Controls.Find(TexBoxName, true).FirstOrDefault() as TextBox;

                if (texbox != null)
                {
                    PRNewValeur.Add(pieceDeRechange + "=" + texbox.Text);
                }
                else
                {
                    MessageBox.Show("Aucune valeur n'est assignée à la pièce: " + pieceDeRechange);
                }
            }

            string updateQuery;
        try { 
            if (OldPRValue.Count > 0)
            {
                foreach (var item in OldPRValue)
                {
                    string pieceDeRechange = item.Item1;
                    int oldValue = Convert.ToInt32(item.Item2);

                    var newValueItem = PRNewValeur.FirstOrDefault(x => x.StartsWith(pieceDeRechange + "="));

                    if (newValueItem != null)
                    {
                        int newValue = Convert.ToInt32(newValueItem.Split('=')[1]);
                            if (newValue > oldValue)
                            {
                                updateQuery = "UPDATE piece_de_rechange SET PR_STOCK_ACTUEL = PR_STOCK_ACTUEL - @NombreDansLaBox WHERE PR_NOM = @PieceRechange";
                                int ModifValue = newValue - oldValue;

                                using (MySqlCommand command2 = new MySqlCommand(updateQuery, connection))
                                {
                                    command2.Parameters.Clear();
                                    command2.Parameters.AddWithValue("@PieceRechange", pieceDeRechange);
                                    command2.Parameters.AddWithValue("@NombreDansLaBox", ModifValue);
                                    command2.ExecuteNonQuery();
                                }
                            }
                    else if (newValue < oldValue)
                        {
                            updateQuery = "UPDATE piece_de_rechange SET PR_STOCK_ACTUEL = PR_STOCK_ACTUEL + @NombreDansLaBox WHERE PR_NOM = @PieceRechange";
                                int ModifValue = oldValue - newValue;

                                using (MySqlCommand command2 = new MySqlCommand(updateQuery, connection))
                            {
                                command2.Parameters.Clear();
                                command2.Parameters.AddWithValue("@PieceRechange", pieceDeRechange);
                                command2.Parameters.AddWithValue("@NombreDansLaBox", ModifValue);
                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE bt SET BT_INTITULE = @Intitule, BT_PIECE_RECHANGE = @PieceRechange, " +
                           " BT_TRAVAIL_REALISER = @TravailRealise, BT_COMMENTAIRE_INTERVENANT = @CommentaireInterne, " +
                           "BT_NOM_INTERVENANT = @NomIntervenant, BT_TEMPS_TRAVAIL = @TempsPreste, BT_ISFINISH = @isFinish, BT_DATE_REALISATION = @BtDateRealisation  WHERE BT_NUMERO = @numeroBT";

            isChecked = checkBoxIsFinish.Checked ? 1 : 0;

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Intitule", textBoxIntituleBT.Text);
                command.Parameters.AddWithValue("@PieceRechange", string.Join(";", PRNewValeur));
                command.Parameters.AddWithValue("@TravailRealise", RichTextBoxTravailRealiserBT.Text);
                command.Parameters.AddWithValue("@CommentaireInterne", RichTextBoxCommentaireInterBT.Text);
                command.Parameters.AddWithValue("@NomIntervenant", comboBoxNomInterBT.SelectedItem.ToString());
                command.Parameters.AddWithValue("@TempsPreste", textBoxTempsPresteBT.Text);
                command.Parameters.AddWithValue("@isFinish", isChecked);
                command.Parameters.AddWithValue("@BtDateRealisation", DateTime.Now);
                command.Parameters.AddWithValue("@numeroBT", numeroBT);

                Enabled = false;
                command.ExecuteNonQuery();

                MessageBox.Show("Données modifiées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void kryptonButtonBTModifierValider_Click(object sender, EventArgs e)
        {
            UpdateBTInBDD();
        }

        private void textBoxNbHeuresBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxTempsPresteBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void checkedListBoxPieceRechangeBT_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string elementNameListPR = checkedListBoxPieceRechangeBT.Items[e.Index].ToString();

                if (flowLayoutPanelNumeros.Controls.Find("LabelBoxNumero_" + elementNameListPR, true).Length == 0)
                {
                    Label label = new Label();
                    label.Name = "LabelBoxNumero_" + elementNameListPR;
                    label.Text = "Quantité(e) " + elementNameListPR;
                    label.Location = new Point(10, (e.Index * 50) + 5);
                    flowLayoutPanelNumeros.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.Name = "textBoxNumero_" + elementNameListPR;
                    textBox.MaxLength = 3;
                    textBox.Location = new Point(10, (e.Index * 50) + 25);
                    flowLayoutPanelNumeros.Controls.Add(textBox);
                }
            }
            else
            {
                string elementNameListPR = checkedListBoxPieceRechangeBT.Items[e.Index].ToString();
                for (int i = flowLayoutPanelNumeros.Controls.Count - 1; i >= 0; i--)
                {
                    Control control = flowLayoutPanelNumeros.Controls[i];
                    if (control.Name == "textBoxNumero_" + elementNameListPR || control.Name == "LabelBoxNumero_" + elementNameListPR)
                    {
                        flowLayoutPanelNumeros.Controls.Remove(control);
                    }
                }
            }
        }

        private List<string> checkedTest = new List<string>();

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxFilter.Text.ToLower();

            foreach (var item in checkedListBoxPieceRechangeBT.CheckedItems)
            {
                checkedTest.Add(item.ToString());
            }

            checkedListBoxPieceRechangeBT.Items.Clear();

            foreach (string item in OGItems)
            {
                if (item.ToLower().Contains(searchText))
                {
                    checkedListBoxPieceRechangeBT.Items.Add(item);
                }
            }

            foreach (string item in checkedTest)
            {
                int index = checkedListBoxPieceRechangeBT.Items.IndexOf(item);
                if (index != -1)
                {
                    checkedListBoxPieceRechangeBT.SetItemChecked(index, true);
                }
            }
        }
    }
}
