using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsForms
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

            refresh();
        }
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from useraccept", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO useraccept(Log,Pass) values('" + cLog.Text + "','" + cPass.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
