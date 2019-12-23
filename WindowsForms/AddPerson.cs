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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
           
            refresh();
        }
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from client", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
                MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO client(CSurname,CName,CMiddleName,CNumderClass) values('" + fClient.Text + "','" + nClient.Text + "','" + mClient.Text + "','" + NumberClass.Text + "')", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                refresh();
            }
            catch (MySqlException)
            {
                MessageBox.Show("");
            }
            
            
            
        }
               private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void NumberClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM client Where id_c="+textBox1.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

      
    }
}
