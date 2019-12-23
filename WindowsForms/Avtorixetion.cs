using System;
using MySql.Data.MySqlClient;
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
    public partial class Avtorixetion : Form
    {
        public Avtorixetion()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            String userLogin = LoginText.Text;
            String userPass = PasswordText.Text;



            MySqlConnection con = new MySqlConnection("Server = localhost; Database=electronicmagazine1;uid=root;pwd= ;Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `useraccept` WHERE `Log`=@uL AND `Pass`=@uP", con);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;
            da.SelectCommand = command;
            da.Fill(dt);

            con.Close();
            if (dt.Rows.Count > 0)
            {
                Menu f = new Menu();
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No");
            }
            
        


        }
    }
}
