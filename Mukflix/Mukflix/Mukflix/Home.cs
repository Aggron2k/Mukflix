using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mukflix
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            film_Felvezetes1.Visible = false;
            helyi_foglalas1.Visible = false;
            hirek.Visible = false;
            nyeremeny_jatek1.Visible = false;
            felhasznalo_kezeles1.Visible = false;
            aktivgomb.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void film_Click(object sender, EventArgs e)
        {
            aktivgomb.Height = film.Height;
            aktivgomb.Top = film.Top;

            film_Felvezetes1.Visible = true;
            helyi_foglalas1.Visible = false;
            hirek.Visible = false;
            nyeremeny_jatek1.Visible = false;
            felhasznalo_kezeles1.Visible = false;
        }
        private void fogl_Click(object sender, EventArgs e)
        {
            aktivgomb.Height = fogl.Height;
            aktivgomb.Top = fogl.Top;

            film_Felvezetes1.Visible = false;
            helyi_foglalas1.Visible = true;
            hirek.Visible = false;
            nyeremeny_jatek1.Visible = false;
            felhasznalo_kezeles1.Visible = false;
        }

        private void blog_Click(object sender, EventArgs e)
        {
            aktivgomb.Height = blog.Height;
            aktivgomb.Top = blog.Top;

            film_Felvezetes1.Visible = false;
            helyi_foglalas1.Visible = false;
            hirek.Visible = true;
            nyeremeny_jatek1.Visible = false;
            felhasznalo_kezeles1.Visible = false;
        }

        private void nyer_Click(object sender, EventArgs e)
        {
            aktivgomb.Height = nyer.Height;
            aktivgomb.Top = nyer.Top;

            film_Felvezetes1.Visible = false;
            helyi_foglalas1.Visible = false;
            hirek.Visible = false;
            nyeremeny_jatek1.Visible = true;
            felhasznalo_kezeles1.Visible = false;
        }

        private void user_Click(object sender, EventArgs e)
        {
            aktivgomb.Height = user.Height;
            aktivgomb.Top = user.Top;

            film_Felvezetes1.Visible = false;
            helyi_foglalas1.Visible = false;
            hirek.Visible = false;
            nyeremeny_jatek1.Visible = false;
            felhasznalo_kezeles1.Visible = true;
        }
    }
}
