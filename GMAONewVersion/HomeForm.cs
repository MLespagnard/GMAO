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
        public HomeForm(string name)
        {
            InitializeComponent();
            this.name = name;

            labelName.Text = labelName.Text + " " + name;
        }
    }
}
