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

            // Affiche la page Home dès le début de l'appli
            panelContenu.Controls.Clear();
            HomeForm homeForm = new HomeForm(name);
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            homeForm.Size = panelContenu.Size;
            homeForm.BringToFront();
            homeForm.Visible = true;
            panelContenu.Controls.Add(homeForm);

            // Cacher le btn Gestion des User si pas admin
            if (accesLvl != 3)
            {
            }

        }


        //////////////// Gère les clics sur les bouttons latéreaux ////////////////


        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            HomeFormShow(sender, e);
        }

        private void pictureBoxEquip_Click(object sender, EventArgs e)
        {
            EquipFormShow(sender, e);
        }

        private void pictureBoxPR_Click(object sender, EventArgs e)
        {
            PRFormShow(sender, e);
        }


        private void pictureBoxBT_Click(object sender, EventArgs e)
        {
            BTFormShow(sender, e);
        }


        private void pictureBoxGestionUser_Click(object sender, EventArgs e)
        {
            UserFormShow(sender, e);
        }

        //////////////// Gère l'affichage des fenetres sur le controle ////////////////


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

        private void EquipFormShow(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            EquipForm equipForm = new EquipForm();
            equipForm.TopLevel = false;
            equipForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            equipForm.Size = panelContenu.Size;
            equipForm.BringToFront();
            equipForm.Visible = true;
            panelContenu.Controls.Add(equipForm);
        }

        private void PRFormShow(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            PRForm prForm = new PRForm();
            prForm.TopLevel = false;
            prForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            prForm.Size = panelContenu.Size;
            prForm.BringToFront();
            prForm.Visible = true;
            panelContenu.Controls.Add(prForm);
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

        private void UserFormShow(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            UserForm userForm = new UserForm();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userForm.Size = panelContenu.Size;
            userForm.BringToFront();
            userForm.Visible = true;
            panelContenu.Controls.Add(userForm);
        }

    }
}
