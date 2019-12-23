using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddPerson f = new AddPerson();
            f.ShowDialog();
        }

        private void CheckPerson_Click(object sender, EventArgs e)
        {
            FoundPerson f = new FoundPerson();
            f.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddUser f = new AddUser();
            f.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
