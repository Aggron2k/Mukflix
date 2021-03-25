using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Mukflix
{
    public partial class Registration : Form
    {
        private readonly string connectionString;
        public Registration()
        {
            InitializeComponent();
            connectionString = "server=localhost;database=mukflix;uid=root";
            jelszo.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string sql = $"SELECT COUNT(*) FROM users WHERE username = '{felhasznalonev.Text}' OR email = '{email.Text}'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                bool existingUser = false;

                while (reader.Read())
                {
                    existingUser = Convert.ToInt32(reader[0]) > 0;
                }
                reader.Close();

                bool success = false;
                if (existingUser)
                {
                    MessageBox.Show("Már van felhasználó ezzel a felh.névvel vagy email címmel!");
                }
                else
                {
                    if(nev.Text == "" || felhasznalonev.Text == "" || email.Text == ""  || jelszo.Text == "" )
                    {
                        MessageBox.Show("Tölts ki minden mezőt hogy regisztrálni tudjuk az admint!");
                    }
                    else
                    { 
                        string insert = $"INSERT INTO `users` (`id`, `name`, `username`, `email`, `password`, `admin`) VALUES (NULL, '{nev.Text}', '{felhasznalonev.Text}', '{email.Text}', '{jelszo.Text}', '1')";
                        MySqlCommand insertCommand = new MySqlCommand(insert, connection);
                        MySqlDataReader insertReader = insertCommand.ExecuteReader();
                        try
                        {
                            string massage = $"Regisztráció vissza igazoló e-mail!\n \n{nev.Text} névvel új adminként regisztráltál hozzánk. Bejelentkezéshez szükséges adataidat itt találhatod:\n    Felhasználónév:{felhasznalonev.Text}\n    Jelszó:{jelszo.Text}\n \nÜdvözlettel, A Mukflix Team.";
                            MailMessage mail = new MailMessage("mukflix2021@gmail.com", email.Text, "Mukflix | Regisztráció", massage);
                            SmtpClient client = new SmtpClient("smtp.gmail.com");
                            client.Port = 587;
                            client.Credentials = new System.Net.NetworkCredential("mukflix2021@gmail.com", "c#mukflix");
                            client.EnableSsl = true;
                            client.Send(mail);
                            success = true;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nem sikerült az E-mailt elküldeni!");
                        }
                        finally
                        {
                            if (success)
                            {
                                MessageBox.Show("Sikeresen létrehoztuk az admint! Email-be értesítettük erről!");
                            }
                        }
                        this.Close();
                    }
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
