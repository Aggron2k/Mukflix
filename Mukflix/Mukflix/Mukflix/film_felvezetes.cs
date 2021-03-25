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
    public partial class Film_Felvezetes : UserControl
    {
        MySqlDataAdapter adapter;
        string connectionString = "datasource=localhost;port=3306;username=root;database=mukflix";
        public Film_Felvezetes()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Film_Felvezetes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetFilmsData(connectionString);

            datum.CustomFormat = "yyyy-MM-dd";

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 25;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 175;
            DataGridViewColumn column2 = dataGridView1.Columns[3];
            column2.Width = 175;
            felvezetes.Enabled = false;
            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

        }

        private void GetFilmsData(string connectionString)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM films", connectionString);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void felvezetes_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string sql = $"INSERT INTO `films` (`id`, `title`, `theme`, `director`, `age_limit`, `picture`, `projection date`) VALUES (NULL, '{cim.Text}', '{mufaj.Text}', '{rendezo.Text}', '{korhatar.Text}', '{fajlnev.Text}', '{datum.Text}')";

            MySqlCommand insertCommand = new MySqlCommand(sql, connection);
            MySqlDataReader insertReader = insertCommand.ExecuteReader();

            MessageBox.Show("Sikeresen létrehoztuk a filmet!");
            GetFilmsData(connectionString);
            connection.Close();
        }
        private void kep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileNév = openFileDialog1.SafeFileName;
                fajlnev.Text = fileNév;
            }
        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                modositas.Enabled = true;
                torles.Enabled = true;
                tartalomtorles.Enabled = true;

                string dataTitle = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string dataTheme = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string dataDirector = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string dataAgelimit = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string datePicture = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                string dateDate = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;


                cim.Text = dataTitle;
                mufaj.Text = dataTheme;
                rendezo.Text = dataDirector;
                korhatar.Text = dataAgelimit;
                fajlnev.Text = datePicture;
                datum.Text = dateDate;
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
                    string sqlcommand = $"DELETE FROM `films` WHERE id={deletThisId}";
                    MySqlCommand insertCommand2 = new MySqlCommand(sqlcommand, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();


                    MessageBox.Show("Sikeresen töröltük a filmet!");
                    GetFilmsData(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
        }
        private void kereses_TextChanged(object sender, EventArgs e)
        {
            var text = kereses.Text;
            bindingSource1.Filter = $"title LIKE '*{text}*' OR theme LIKE '*{text}*' OR director LIKE '*{text}*'";
            bindingSource1.Sort = "title ASC";
        }
        private void tartalomtorles_Click(object sender, EventArgs e)
        {
            cim.Text = "";
            mufaj.Text = "";
            rendezo.Text = "";
            korhatar.Text = "";
            fajlnev.Text = "";

            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

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
                    string sql = $"UPDATE `films` SET `title`='{cim.Text}', `theme`='{mufaj.Text}'," +
                        $" `director`='{rendezo.Text}', `age_limit`='{korhatar.Text}'," +
                        $" `picture`='{fajlnev.Text}', `projection date`='{datum.Text}' WHERE `id`={putThis}";

                    MySqlCommand insertCommand2 = new MySqlCommand(sql, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();

                    MessageBox.Show("Sikeresen módosítottuk a filmet!");
                    GetFilmsData(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
        }
        
        private void cim_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void tema_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void rendezo_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void korhatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void fajlnev_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }
        private void SzovegDobozValtozas()
        {
            tartalomtorles.Enabled = true;
            if (cim.Text.Length > 0 && mufaj.Text.Length > 0 && rendezo.Text.Length > 0 && korhatar.Text.Length > 0 && fajlnev.Text.Length > 0)
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
