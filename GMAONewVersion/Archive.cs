using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAONewVersion
{
    internal class Archive
    {

        public static void archiveToSql(MySqlConnection conn, string identifiant, string categorie, string uniqueField)
        {
            string query = $"UPDATE {categorie} SET archiver = true WHERE {uniqueField} = @id";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", identifiant);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("L'archivage a été effectué avec succès.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement n'a été mis à jour.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une exception technique est survenue : " + ex.Message);
                return;
            }
        }
    }
}
