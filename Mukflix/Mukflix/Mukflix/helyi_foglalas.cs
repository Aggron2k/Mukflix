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
    public partial class helyi_foglalas : UserControl
    {
        MySqlDataAdapter adapter;
        string connectionString = "datasource=localhost;port=3306;username=root;database=mukflix";
        List<string> szekek = new List<string>();
        List<TextBox> szövegdobozok = new List<TextBox>();
        List<Button> gombok = new List<Button>();
        List<string> lefgolaltszekek = new List<string>();
        int darab = 0;
        public helyi_foglalas()
        {
            InitializeComponent();
        }

        private void helyi_foglalas_Load(object sender, EventArgs e)
        {
            felvezetes.Enabled = false;
            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;

            GetReservationDatas(connectionString);
            datum.CustomFormat = "yyyy-MM-dd";

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 25;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 150;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 75;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 150;
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 30;
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.Width = 30;
            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.Width = 30;
            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.Width = 30;
            DataGridViewColumn column9 = dataGridView1.Columns[9];
            column9.Width = 75;
            DataGridViewColumn column10 = dataGridView1.Columns[10];
            column10.Width = 75;

            
            GombokLétrehozása();
            Filmek();
        }

        private void Filmek()
        {
            adapter = new MySqlDataAdapter("SELECT * FROM films", connectionString);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource2.DataSource = table;

            bindingSource2.Sort = "id";

            HashSet<string> filmeklista = new HashSet<string>();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                filmeklista.Add(Convert.ToString(dataGridView2.Rows[i].Cells[1].Value));
            }
            foreach (var item in filmeklista)
            {
                film.Items.Add(Convert.ToString(item));
            }
            
        }
        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (bindingSource2.DataSource != null)
            {
                adapter.Update((DataTable)bindingSource2.DataSource);
            }
        }

        private void GombokLétrehozása()
        {
            string sor = "";
            for (int j = 1; j <= 4; j++)
            {
                if (j == 1) sor = "A";

                if (j == 2) sor = "B";

                if (j == 3) sor = "C";

                if (j == 4) sor = "D";

                for (int i = 1; i <= 8; i++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Text = $"{sor}{i}";
                    btn.ForeColor = Color.White;
                    btn.Image = Image.FromFile("szekek/chair.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.TextAlign = ContentAlignment.TopCenter;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += btn_Click;
                    btn.BackColor = Color.LightGray;
                    flowLayoutPanel1.Controls.Add(btn);
                    gombok.Add(btn);
                }
                szövegdobozok.Add(szek1);
                szövegdobozok.Add(szek2);
                szövegdobozok.Add(szek3);
                szövegdobozok.Add(szek4);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.LightGray && darab < 4)
            {
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.Gainsboro;
                btn.Image = Image.FromFile("szekek/chair_green.png");
                szekek.Add(btn.Text);
                darab++;

                foreach (TextBox item in szövegdobozok)
                {
                    if (item.Text == "")
                    {
                        item.Text = btn.Text;
                        break;
                    }
                }
            }
            else
            {
                if (darab <= 5 && btn.BackColor == Color.LightGray)
                {
                    MessageBox.Show("Nem lehet több széket kiválasztani!");
                }
                else
                {
                    foreach (TextBox item in szövegdobozok)
                    {
                        if (item.Text == btn.Text)
                        {
                            item.Text = "";
                        }
                    }
                    if (btn.BackColor==Color.Silver)
                    {
                        MessageBox.Show("Ez a szék már foglalt!");
                    }
                    else
                    {
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.LightGray;
                        btn.Image = Image.FromFile("szekek/chair.png");
                        darab--;
                        int torlendo = szekek.IndexOf(btn.Text);
                        szekek.RemoveAt(torlendo);
                    }
                    
                }
            }
            Árazás();
        }

        private void GetReservationDatas(string connectionString)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM reservation", connectionString);
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
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                modositas.Enabled = true;
                torles.Enabled = true;
                tartalomtorles.Enabled = true;
                int rowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                string dataName = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string dataEmail = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string dataPhone = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string dataFilm = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string dataChair1 = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                string dataChair2 = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                string dataChair3 = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                string dataChair4 = dataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                string dataDate = dataGridView1.SelectedRows[0].Cells[9].Value + string.Empty;
                string dataPrice = dataGridView1.SelectedRows[0].Cells[10].Value + string.Empty;

                nev.Text = dataName;
                email.Text = dataEmail;
                telefonszam.Text = dataPhone;
                film.Text = dataFilm;
                szek1.Text = dataChair1;
                szek2.Text = dataChair2;
                szek3.Text = dataChair3;
                szek4.Text = dataChair4;
                datum.Text = dataDate;
                ar.Text = dataPrice;
            }
            
            Árazás();
        }

        private void Árazás()
        {
            if (jegy.Text == "Normál jegy")
            {
                ar.Text = $"{1400 * darab}";
            }
            if (jegy.Text == "Kedvezményes jegy")
            {
                ar.Text = $"{1150 * darab}";
            }
            if (jegy.Text == "Családi jegy")
            {
                ar.Text = $"{4500}";
            }
            if (jegy.Text == "Baráti jegy")
            {
                ar.Text = $"{4650}";
            }
        }
        private void film_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (film.Text == Convert.ToString(dataGridView2.Rows[i].Cells[1].Value))
                {
                    datum.Text = Convert.ToString(dataGridView2.Rows[i].Cells[6].Value);
                }
            }
        }
        private void kereses_TextChanged(object sender, EventArgs e)
        {
            var text = kereses.Text;
            bindingSource1.Filter = $"name LIKE '*{text}*' OR email LIKE '*{text}*' OR film LIKE '*{text}*'";
            bindingSource1.Sort = "date ASC";
        }
        private void szek_foglalas_Click(object sender, EventArgs e)
        {
           
        }
        private void felvezetes_Click(object sender, EventArgs e)
        {
            bool success = false;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string sql = $"INSERT INTO `reservation` (`id`, `name`, `email`, `phone`, `film`, `chair1`, `chair2`, `chair3`, `chair4`, `date`, `price`) VALUES (NULL, '{nev.Text}', '{email.Text}', '{telefonszam.Text}', '{film.Text}', '{szek1.Text}', '{szek2.Text}', '{szek3.Text}', '{szek4.Text}', '{datum.Text}', '{ar.Text}')";

            MySqlCommand insertCommand = new MySqlCommand(sql, connection);
            MySqlDataReader insertReader = insertCommand.ExecuteReader();
            try
            {
                string massage = $"Sikeresen rögzítve lett a foglalása a Mukflixnél!\n \nAlábi néven: {nev.Text}\nFilm címe: {film.Text}\nVetítés napja: {datum.Text} \nLefoglalt szék(ek): {szek1.Text} {szek2.Text} {szek3.Text} {szek4.Text} \nFizetendő összeg: {ar.Text} Ft\nJegy felügyelőnek mutassa fel ezt az emailt!\n \nÜdvözlettel, A Mukflix Team.";
                MailMessage mail = new MailMessage("mukflix2021@gmail.com", email.Text, "Mukflix | Foglalás", massage);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("mukflix2021@gmail.com", "c#mukflix");
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült az E-mailt elküldeni!");
            }
            finally
            {
                if (success)
                {
                    MessageBox.Show("Sikeresen létrehoztuk a foglalást! | Emailbe elküldve!");
                }
            }
            

            GetReservationDatas(connectionString);
            connection.Close();

        }
        private void jegy_SelectedValueChanged(object sender, EventArgs e)
        {
            ar.Text = "0";
            if (szek1.Text != "")
            {
                darab = 1;
                if (szek2.Text!="")
                {
                    darab = 2;
                    if (szek3.Text!="")
                    {
                        darab = 3;
                        if (szek4.Text!="")
                        {
                            darab = 4;
                        }
                    }
                }
            }
            Árazás();
        }
        private void jegy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                    string sqlcommand = $"DELETE FROM `reservation` WHERE id={deletThisId}";
                    MySqlCommand insertCommand2 = new MySqlCommand(sqlcommand, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();


                    MessageBox.Show("Sikeresen töröltük a foglalást!");
                    GetReservationDatas(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
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
                    string sql = $"UPDATE `reservation` SET `name`='{nev.Text}', `email`='{email.Text}', `phone`='{telefonszam.Text}', `film`='{film.Text}', `chair1`='{szek1.Text}', `chair2`='{szek2.Text}', `chair3`='{szek3.Text}', `chair4`='{szek4.Text}', `date`='{datum.Text}', `price`='{ar.Text}' WHERE `id`={putThis}";

                    MySqlCommand insertCommand2 = new MySqlCommand(sql, sqlconnection);
                    MySqlDataReader insertReader2;
                    insertReader2 = insertCommand2.ExecuteReader();

                    MessageBox.Show("Sikeresen módosítottuk a foglalást!");
                    GetReservationDatas(connectionString);
                    insertReader2.Close();
                    sqlconnection.Close();
                }
            }
            Árazás();
        }
        private void tartalomtorles_Click(object sender, EventArgs e)
        {
            nev.Text = "";
            email.Text = "";
            telefonszam.Text = "";
            film.Text = "";
            szek1.Text = "";
            szek2.Text = "";
            szek3.Text = "";
            szek4.Text = "";
            datum.Text = "";

            Pirosszekek(lefgolaltszekek, gombok);

            modositas.Enabled = false;
            torles.Enabled = false;
            tartalomtorles.Enabled = false;

        }
        private void datum_ValueChanged(object sender, EventArgs e)
        {
            szek1.Text = "";
            szek2.Text = "";
            szek3.Text = "";
            szek4.Text = "";
            HashSet<DateTime> lista = new HashSet<DateTime>();
            lefgolaltszekek.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                lista.Add(Convert.ToDateTime(dataGridView1.Rows[i].Cells[9].Value));
            }
            foreach (var item in lista)
            {
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    if (Convert.ToDateTime(datum.Text) == Convert.ToDateTime(dataGridView1.Rows[j].Cells[9].Value))
                    {
                        lefgolaltszekek.Add(Convert.ToString(dataGridView1.Rows[j].Cells[5].Value));
                        lefgolaltszekek.Add(Convert.ToString(dataGridView1.Rows[j].Cells[6].Value));
                        lefgolaltszekek.Add(Convert.ToString(dataGridView1.Rows[j].Cells[7].Value));
                        lefgolaltszekek.Add(Convert.ToString(dataGridView1.Rows[j].Cells[8].Value));
                    }
                }
                break;
            }
            Pirosszekek(lefgolaltszekek, gombok);
        }

        private void datum_CloseUp(object sender, EventArgs e)
        {
        }

        private void Pirosszekek(List<string> lefgolaltszekek, List<Button> gombok)
        {
            foreach (var gomb in gombok)
            {
                gomb.ForeColor = Color.White;
                gomb.BackColor = Color.LightGray;
                gomb.Image = Image.FromFile("szekek/chair.png");
            }
            foreach (var gomb in gombok)
            {
                foreach (var foglalt in lefgolaltszekek)
                {
                    if (foglalt.Contains(gomb.Text))
                    {
                        gomb.BackColor = Color.Silver;
                        gomb.Image = Image.FromFile("szekek/chair_red.png");
                    }
                }
            }
        }

        private void nev_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void telefonszam_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }

        private void szek1_TextChanged(object sender, EventArgs e)
        {
            SzovegDobozValtozas();
        }
        private void SzovegDobozValtozas()
        {
            tartalomtorles.Enabled = true;
            if (nev.Text.Length > 0 && email.Text.Length > 0 && telefonszam.Text.Length > 0 && szek1.Text.Length > 0)
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
