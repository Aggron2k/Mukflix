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
    public partial class hirek : UserControl
    {
        MySqlDataAdapter adapter;
        string connectionString = "datasource=localhost;port=3306;username=root;database=mukflix;";
        public hirek()
        {
            InitializeComponent();
        }

        private void blog_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetPostDatas(connectionString);

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 25;
            DataGridViewColumn column1 = dataGridView1.Columns[2];
            column1.Width = 540;

            datum.CustomFormat = "yyyy-MM-dd";

            felvezetes.Enabled = false;
            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

            
        }
        private void GetPostDatas(string connectionString)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM news", connectionString);
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
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string sql = $"INSERT INTO `news` (`id`, `username`, `date`, `post`) VALUES (NULL, '{felhasznalonev.Text}', '{datum.Text}', '{poszt.Text}')";

            MySqlCommand insertCommand = new MySqlCommand(sql, connection);
            MySqlDataReader insertReader = insertCommand.ExecuteReader();

            MessageBox.Show("Sikeresen létrehoztuk a posztot!");
            GetPostDatas(connectionString);
            connection.Close();
        }

        private void modositas_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (item.Selected)
                {
                    int putThis = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                    MySqlConnection sqlconnection = new MySqlConnection(connectionString);
                    sqlconnection.Open();
                    string sql = $"UPDATE `news` SET `username`='{felhasznalonev.Text}', `post`='{poszt.Text}', `date`='{datum.Text}' WHERE `id`={putThis}";

                    MySqlCommand insertCommand2 = new MySqlCommand(sql, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();

                    MessageBox.Show("Sikeresen módosítottuk a posztot!");
                    GetPostDatas(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
        }
        private void kereses_TextChanged(object sender, EventArgs e)
        {
            var text = kereses.Text;
            bindingSource1.Filter = $"username LIKE '*{text}*' OR post LIKE '*{text}*'";
            bindingSource1.Sort = "username ASC";
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
                    string sqlcommand = $"DELETE FROM `news` WHERE id={deletThisId}";
                    MySqlCommand insertCommand2 = new MySqlCommand(sqlcommand, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();

                    MessageBox.Show("Sikeresen töröltük a posztot!");
                    GetPostDatas(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
        }
        
        private void tartalomtorles_Click(object sender, EventArgs e)
        {
            felhasznalonev.Text = "";
            poszt.Text = "";

            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                modositas.Enabled = true;
                torles.Enabled = true;
                tartalomtorles.Enabled = true;

                string dataUserName = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string dataPost = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string dataDate = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;

                felhasznalonev.Text = dataUserName;
                poszt.Text = dataPost;
                datum.Text = dataDate;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void post_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }
        private void SzovegDobozValtozas()
        {
            tartalomtorles.Enabled = true;
            if (felhasznalonev.Text.Length > 0 && poszt.Text.Length > 0)
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
