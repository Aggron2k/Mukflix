using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mukflix
{
    
    public partial class Login : Form
    {
        private readonly string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = "server=localhost;database=mukflix;uid=root";
            jelszo.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string sql = $"SELECT COUNT(*) FROM users WHERE username = '{felhasznalonev.Text}' AND password = '{jelszo.Text}' AND admin = '1'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                bool userFound = false;

                while (reader.Read())
                {
                    userFound = Convert.ToInt32(reader[0]) > 0;
                }
                
                connection.Close();

                if (userFound)
                {
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    if (felhasznalonev.Text == "" || jelszo.Text == "")
                    {
                        MessageBox.Show("Egyik vagy mindkét mező üres kérem töltse ki!");
                    }
                    else
                    {
                    MessageBox.Show("Rossz adatokat adtál meg!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
