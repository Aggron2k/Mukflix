
namespace Mukflix
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aktivgomb = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.nyer = new System.Windows.Forms.Button();
            this.blog = new System.Windows.Forms.Button();
            this.fogl = new System.Windows.Forms.Button();
            this.film = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.film_Felvezetes1 = new Mukflix.Film_Felvezetes();
            this.helyi_foglalas1 = new Mukflix.helyi_foglalas();
            this.nyeremeny_jatek1 = new Mukflix.nyeremeny_jatek();
            this.felhasznalo_kezeles1 = new Mukflix.felhasznalo_kezeles();
            this.hirek = new Mukflix.hirek();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.aktivgomb);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.nyer);
            this.panel1.Controls.Add(this.blog);
            this.panel1.Controls.Add(this.fogl);
            this.panel1.Controls.Add(this.film);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 603);
            this.panel1.TabIndex = 0;
            // 
            // aktivgomb
            // 
            this.aktivgomb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aktivgomb.Location = new System.Drawing.Point(208, 118);
            this.aktivgomb.Name = "aktivgomb";
            this.aktivgomb.Size = new System.Drawing.Size(11, 85);
            this.aktivgomb.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Yellow;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(0, 573);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(212, 32);
            this.exit.TabIndex = 7;
            this.exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Yellow;
            this.user.FlatAppearance.BorderSize = 0;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(0, 482);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(212, 85);
            this.user.TabIndex = 6;
            this.user.Text = "Felhasználó kezelés";
            this.user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // nyer
            // 
            this.nyer.BackColor = System.Drawing.Color.Yellow;
            this.nyer.FlatAppearance.BorderSize = 0;
            this.nyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nyer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nyer.ForeColor = System.Drawing.Color.Black;
            this.nyer.Image = ((System.Drawing.Image)(resources.GetObject("nyer.Image")));
            this.nyer.Location = new System.Drawing.Point(0, 391);
            this.nyer.Name = "nyer";
            this.nyer.Size = new System.Drawing.Size(212, 85);
            this.nyer.TabIndex = 5;
            this.nyer.Text = "Nyereményjáték";
            this.nyer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nyer.UseVisualStyleBackColor = false;
            this.nyer.Click += new System.EventHandler(this.nyer_Click);
            // 
            // blog
            // 
            this.blog.BackColor = System.Drawing.Color.Yellow;
            this.blog.FlatAppearance.BorderSize = 0;
            this.blog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blog.ForeColor = System.Drawing.Color.Black;
            this.blog.Image = ((System.Drawing.Image)(resources.GetObject("blog.Image")));
            this.blog.Location = new System.Drawing.Point(-1, 300);
            this.blog.Name = "blog";
            this.blog.Size = new System.Drawing.Size(213, 85);
            this.blog.TabIndex = 4;
            this.blog.Text = "Hírek";
            this.blog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.blog.UseVisualStyleBackColor = false;
            this.blog.Click += new System.EventHandler(this.blog_Click);
            // 
            // fogl
            // 
            this.fogl.BackColor = System.Drawing.Color.Yellow;
            this.fogl.FlatAppearance.BorderSize = 0;
            this.fogl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fogl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fogl.ForeColor = System.Drawing.Color.Black;
            this.fogl.Image = ((System.Drawing.Image)(resources.GetObject("fogl.Image")));
            this.fogl.Location = new System.Drawing.Point(-1, 209);
            this.fogl.Name = "fogl";
            this.fogl.Size = new System.Drawing.Size(213, 85);
            this.fogl.TabIndex = 3;
            this.fogl.Text = "Helyi foglalás";
            this.fogl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fogl.UseVisualStyleBackColor = false;
            this.fogl.Click += new System.EventHandler(this.fogl_Click);
            // 
            // film
            // 
            this.film.BackColor = System.Drawing.Color.Yellow;
            this.film.FlatAppearance.BorderSize = 0;
            this.film.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.film.ForeColor = System.Drawing.Color.Black;
            this.film.Image = ((System.Drawing.Image)(resources.GetObject("film.Image")));
            this.film.Location = new System.Drawing.Point(0, 118);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(212, 85);
            this.film.TabIndex = 2;
            this.film.Text = "Film felvezetés";
            this.film.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.film.UseVisualStyleBackColor = false;
            this.film.Click += new System.EventHandler(this.film_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // film_Felvezetes1
            // 
            this.film_Felvezetes1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("film_Felvezetes1.BackgroundImage")));
            this.film_Felvezetes1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.film_Felvezetes1.Location = new System.Drawing.Point(218, 0);
            this.film_Felvezetes1.Name = "film_Felvezetes1";
            this.film_Felvezetes1.Size = new System.Drawing.Size(910, 603);
            this.film_Felvezetes1.TabIndex = 3;
            // 
            // helyi_foglalas1
            // 
            this.helyi_foglalas1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helyi_foglalas1.BackgroundImage")));
            this.helyi_foglalas1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helyi_foglalas1.Location = new System.Drawing.Point(218, 0);
            this.helyi_foglalas1.Name = "helyi_foglalas1";
            this.helyi_foglalas1.Size = new System.Drawing.Size(910, 603);
            this.helyi_foglalas1.TabIndex = 4;
            // 
            // nyeremeny_jatek1
            // 
            this.nyeremeny_jatek1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nyeremeny_jatek1.BackgroundImage")));
            this.nyeremeny_jatek1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nyeremeny_jatek1.Location = new System.Drawing.Point(218, 0);
            this.nyeremeny_jatek1.Name = "nyeremeny_jatek1";
            this.nyeremeny_jatek1.Size = new System.Drawing.Size(910, 603);
            this.nyeremeny_jatek1.TabIndex = 5;
            // 
            // felhasznalo_kezeles1
            // 
            this.felhasznalo_kezeles1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("felhasznalo_kezeles1.BackgroundImage")));
            this.felhasznalo_kezeles1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.felhasznalo_kezeles1.Location = new System.Drawing.Point(218, 0);
            this.felhasznalo_kezeles1.Name = "felhasznalo_kezeles1";
            this.felhasznalo_kezeles1.Size = new System.Drawing.Size(910, 603);
            this.felhasznalo_kezeles1.TabIndex = 6;
            // 
            // blog1
            // 
            this.hirek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blog1.BackgroundImage")));
            this.hirek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hirek.Location = new System.Drawing.Point(218, 0);
            this.hirek.Name = "blog1";
            this.hirek.Size = new System.Drawing.Size(910, 603);
            this.hirek.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 603);
            this.Controls.Add(this.hirek);
            this.Controls.Add(this.felhasznalo_kezeles1);
            this.Controls.Add(this.nyeremeny_jatek1);
            this.Controls.Add(this.helyi_foglalas1);
            this.Controls.Add(this.film_Felvezetes1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főoldal | Mukflix";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button film;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fogl;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button nyer;
        private System.Windows.Forms.Button blog;
        private System.Windows.Forms.Panel aktivgomb;
        private Film_Felvezetes film_Felvezetes1;
        private helyi_foglalas helyi_foglalas1;
        private nyeremeny_jatek nyeremeny_jatek1;
        private felhasznalo_kezeles felhasznalo_kezeles1;
        private hirek hirek;
    }
}