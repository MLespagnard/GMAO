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
    public partial class ParentForm : Form
    {
        private MySqlConnection connection;
        private String name;
        private int accesLvl;

        public ParentForm(MySqlConnection conn, String usernameFromLoginForm, int grade)
        {
            InitializeComponent();

            connection = conn;
            name = usernameFromLoginForm;
            accesLvl = grade;

            // Cacher le btn Gestion des User si pas admin
            if (accesLvl != 3)
            {
            }

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

        private void pictureBoxBT_Click(object sender, EventArgs e)
        {
            BTFormShow(sender, e);
        }

        private void BTFormShow(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            BTForm btForm = new BTForm();
            btForm.TopLevel = false;
            btForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            btForm.Size = panelContenu.Size;
            btForm.BringToFront();
            btForm.Visible = true;
            panelContenu.Controls.Add(btForm);
        }

        private void HomeFormShow(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            HomeForm homeForm = new HomeForm(name);
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            homeForm.Size = panelContenu.Size;
            homeForm.BringToFront();
            homeForm.Visible = true;
            panelContenu.Controls.Add(homeForm);
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            HomeFormShow(sender, e);
        }
    }
}
