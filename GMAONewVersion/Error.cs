using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAONewVersion
{
    class Error
    {
        public static Boolean testvaleur(List<(string, string)> lst_champs)
        {

            // Parcourir la liste et vérifier si les champs sont vides
            foreach (var (nomChamp, valeurChamp) in lst_champs)
            {
                if (string.IsNullOrEmpty(valeurChamp))
                {
                    MessageBox.Show($"Veuillez saisir un(e) {nomChamp}.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}
