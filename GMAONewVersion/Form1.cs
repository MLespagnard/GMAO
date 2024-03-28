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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            // Ajout des boutons au menu latéral
            Button btn1 = new Button();
            btn1.Text = "Page 1";
            btn1.Location = new Point(10, 10);
            btn1.Click += new EventHandler(Btn1_Click);
            panelMenu.Controls.Add(btn1);

            Button btn2 = new Button();
            btn2.Text = "Page 2";
            btn2.Location = new Point(10, 40);
            btn2.Click += new EventHandler(Btn2_Click);
            panelMenu.Controls.Add(btn2);

            // Contenu par défaut
            ChargerPage("Page1");
            */
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            ChargerPage("Page1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ChargerPage("Page2");
        }

        private void ChargerPage(string nomPage)
        {
            // Chargement du contenu en fonction du nom de la page
            switch (nomPage)
            {
                case "Page1":
                    // Code pour afficher le contenu de la page 1
                    panelContenu.Controls.Clear();
                    Label page1Label = new Label();
                    page1Label.Text = "Ceci est la page 1";
                    page1Label.AutoSize = true;
                    panelContenu.Controls.Add(page1Label);
                    break;
                case "Page2":
                    // Code pour afficher le contenu de la page 2
                    panelContenu.Controls.Clear();
                    Label page2Label = new Label();
                    page2Label.Text = "Ceci est la page 2";
                    page2Label.AutoSize = true;
                    panelContenu.Controls.Add(page2Label);
                    break;
            }
        }
    }
}
