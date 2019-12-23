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

namespace WindowsForms
{
    public partial class FoundPerson : Form
    {
        public FoundPerson()
        {
            InitializeComponent();
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from client ", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void CueTextBox3_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter(String.Format("Select * from client where csurname Like'%{0}%'",cueTextBox3.Text),con);
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
