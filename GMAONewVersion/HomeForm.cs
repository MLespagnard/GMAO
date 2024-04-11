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
    public partial class HomeForm : Form
    {
        string name;
        private readonly MySqlConnection connection;
        private ParentForm parentForm;
        private readonly int accesLvl;

        public HomeForm(string name, MySqlConnection connection, ParentForm parentForm, int accesLvl)
        {
            InitializeComponent();
            this.name = name;
            this.connection = connection;
            this.parentForm = parentForm;
            this.accesLvl = accesLvl;


            labelName.Text = labelName.Text + " " + name;

            // Cacher le btn Gestion des User si pas admin
            if (accesLvl != 3)
            {
                buttonUser.Visible = false;
            }
        }

        private void buttonEquip_Click(object sender, EventArgs e)
        {
            parentForm.EventOnbuttonClickHomeForm(1);
        }

        private void buttonPR_Click(object sender, EventArgs e)
        {
            parentForm.EventOnbuttonClickHomeForm(2);
        }

        private void buttonBT_Click(object sender, EventArgs e)
        {
            parentForm.EventOnbuttonClickHomeForm(3);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            parentForm.EventOnbuttonClickHomeForm(4);
        }
    }
}
