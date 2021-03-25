using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;


namespace Mukflix
{
    public partial class nyeremeny_jatek : UserControl
    {
        MySqlDataAdapter adapter;
        string connectionString = "datasource=localhost;port=3306;username=root;database=mukflix";

        public nyeremeny_jatek()
        {
            InitializeComponent();
        }

        private void nyeremeny_jatek_Load(object sender, EventArgs e)
        {
            emailkuldes.Enabled = false;
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;
            GetGiveAwayDatas();
            GetPassedAnsweres();

            DataGridViewColumn column10 = dataGridView1.Columns[0];
            column10.Width = 25;
            DataGridViewColumn column20 = dataGridView2.Columns[0];
            column20.Width = 25;
            DataGridViewColumn column12 = dataGridView1.Columns[2];
            column12.Width = 200;
            DataGridViewColumn column22 = dataGridView2.Columns[2];
            column22.Width = 200;
        }

        private void GetPassedAnsweres()
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM giveaway WHERE answer1='jo' AND answer2='jo' AND answer3='jo' AND answer4='jo' AND answer5='jo'", connectionString);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                DataTable table = new DataTable();
                adapter.Fill(table);
                bindingSource2.DataSource = table;
                bindingSource2.Sort = "id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (bindingSource2.DataSource != null)
            {
                adapter.Update((DataTable)bindingSource2.DataSource);
            }
        }

        private void GetGiveAwayDatas()
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM giveaway", connectionString);
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
        private void sorsoloás_Click(object sender, EventArgs e)
        {
            sorsoloás.Enabled = false;
            Random rnd = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                lista.Add(Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value));
            }

            int random = rnd.Next(lista.Count);
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if ((int)dataGridView2.Rows[i].Cells[0].Value == lista[random])
                {
                    string dataName = dataGridView2.Rows[i].Cells[1].Value + string.Empty;
                    string dataEmail = dataGridView2.Rows[i].Cells[2].Value + string.Empty;
                    string dataPhone = dataGridView2.Rows[i].Cells[3].Value + string.Empty;

                    nev.Text = dataName;
                    email.Text = dataEmail;
                    telefonszam.Text = dataPhone;
                }
            }
            emailkuldes.Enabled = true;
            MessageBox.Show("Kisorolásra került a nyertes!");
        }

        private void emailkuldes_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                string massage = "Gratulálunk! \n Az e-havi nyereményjátékunk győztese vagy! \n " +
                                "Személyesen átvehető helyben a moziban. \n \n Üdvözlettel, A Mukflix Team.";
                MailMessage mail = new MailMessage("mukflix2021@gmail.com", email.Text, "Mukflix | Nyereményjáték", massage);
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
                    MessageBox.Show("Sikeresen elküldük az E-mailt!");
                }
            }
        }
    }
}
