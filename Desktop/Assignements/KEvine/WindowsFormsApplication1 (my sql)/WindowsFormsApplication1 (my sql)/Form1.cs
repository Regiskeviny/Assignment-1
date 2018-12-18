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

namespace WindowsFormsApplication1__my_sql_
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;Database=hosteldb;Uid=root;Pwd=KADA  men<>?";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usernameText = textBox1.Text;
            var passwordText = textBox2.Text;

            var selectCommand = new MySqlCommand();
            selectCommand.CommandText = "select * from users where username=@username AND password=@password";
            selectCommand.Parameters.AddWithValue("@username", usernameText);
            selectCommand.Parameters.AddWithValue("@password", passwordText);

            selectCommand.Connection = connection;

            MySqlDataReader dataReader = selectCommand.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
