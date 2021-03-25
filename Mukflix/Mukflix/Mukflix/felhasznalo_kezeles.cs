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
    public partial class felhasznalo_kezeles : UserControl
    {
        MySqlDataAdapter adapter;
        string connectionString = "datasource=localhost;port=3306;username=root;database=mukflix";

        public felhasznalo_kezeles()
        {
            InitializeComponent();

        }

        private void felhasznalo_kezeles_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetUsersData(connectionString);

            felvezetes.Enabled = false;
            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 25;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 120;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 120;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 200;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 120;
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 50;
        }
        private void GetUsersData(string connectionString)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM users", connectionString);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                DataTable table = new DataTable();
                adapter.Fill(table);
                bindingSource1.DataSource = table;

                bindingSource1.Sort = "id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (bindingSource1.DataSource != null)
            {
                adapter.Update((DataTable)bindingSource1.DataSource);
            }
        }

        private void felvezetes_Click(object sender, EventArgs e)
        {
            int admine = 0;
            if(admin.Checked)
            {
                admine = 1;
            }
            else
            {
                admine = 0;
            }

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                string sql = $"INSERT INTO `users` (`id`, `name`, `username`, `email`, `password`, `admin`) VALUES (NULL, '{nev.Text}', '{felhasznalonev.Text}', '{email.Text}', '{jelszo.Text}', '{admine}')";

                MySqlCommand insertCommand = new MySqlCommand(sql, connection);
                MySqlDataReader insertReader = insertCommand.ExecuteReader();

                MessageBox.Show("Sikeresen létrehoztuk a felhasználót!");
                GetUsersData(connectionString);
                connection.Close();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                modositas.Enabled = true;
                torles.Enabled = true;
                tartalomtorles.Enabled = true;

                string dataName = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string dataUserName = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string dataEmail = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string dataPassword = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                bool dataAdmin = (bool)dataGridView1.SelectedRows[0].Cells[5].Value;

                nev.Text = dataName;
                felhasznalonev.Text = dataUserName;
                email.Text = dataEmail;
                jelszo.Text = dataPassword;
                    if (dataAdmin == true)
                    {
                        admin.Checked = true;
                    }
                    else
                    {
                        admin.Checked = false;
                    }
                
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (item.Selected)
                {
                    dataGridView1.Rows.RemoveAt(item.Index - 1);
                    int deletThisId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    
                    MySqlConnection sqlconnection = new MySqlConnection(connectionString);
                    sqlconnection.Open();
                    string sqlcommand = $"DELETE FROM `users` WHERE id={deletThisId}";
                    MySqlCommand insertCommand2 = new MySqlCommand(sqlcommand, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();
                    

                    MessageBox.Show("Sikeresen töröltük a felhasználót!");
                    GetUsersData(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
        }

        private void kereses_TextChanged(object sender, EventArgs e)
        {
                var text = kereses.Text;
                bindingSource1.Filter = $"name LIKE '*{text}*' OR username LIKE '*{text}*' OR email LIKE '*{text}*'";
                bindingSource1.Sort = "name ASC";
        }

        private void tartalomtorles_Click(object sender, EventArgs e)
        {
            nev.Text = "";
            felhasznalonev.Text = "";
            email.Text = "";
            jelszo.Text = "";
            admin.Checked = false;

            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

        }

        private void modositas_Click(object sender, EventArgs e)
        {
            int admine = 0;
            if (admin.Checked)
            {
                admine = 1;
            }
            else
            {
                admine = 0;
            }

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (item.Selected)
                {
                    int putThis = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                    MySqlConnection sqlconnection = new MySqlConnection(connectionString);
                    sqlconnection.Open();
                    string sql = $"UPDATE `users` SET `name`='{nev.Text}', `username`='{felhasznalonev.Text}', `email`='{email.Text}', `password`='{jelszo.Text}', `admin`='{admine}' WHERE `id`={putThis}";

                    MySqlCommand insertCommand2 = new MySqlCommand(sql, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();

                    MessageBox.Show("Sikeresen módosítottuk a felhasználót!");
                    GetUsersData(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void felhasznalonev_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void nev_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }
        private void jelszo_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }
        private void SzovegDobozValtozas()
        {
            tartalomtorles.Enabled = true;
            if (nev.Text.Length > 0 && felhasznalonev.Text.Length > 0 && email.Text.Length > 0 && jelszo.Text.Length > 0)
            {
                felvezetes.Enabled = true;
            }
            else
            {
                felvezetes.Enabled = false;
            }
        }
    }
}
