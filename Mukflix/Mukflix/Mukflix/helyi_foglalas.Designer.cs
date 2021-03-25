
namespace Mukflix
{
    partial class helyi_foglalas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helyi_foglalas));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ar = new System.Windows.Forms.TextBox();
            this.jegy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.film = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.telefonszam = new System.Windows.Forms.TextBox();
            this.szek4 = new System.Windows.Forms.TextBox();
            this.szek3 = new System.Windows.Forms.TextBox();
            this.szek2 = new System.Windows.Forms.TextBox();
            this.szek1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kereses = new System.Windows.Forms.TextBox();
            this.torles = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.felvezetes = new System.Windows.Forms.Button();
            this.tartalomtorles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vászon = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.vászon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.Ft);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ar);
            this.groupBox1.Controls.Add(this.jegy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datum);
            this.groupBox1.Controls.Add(this.film);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nev);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.telefonszam);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(23, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 336);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Helyi foglalás:";
            // 
            // Ft
            // 
            this.Ft.AutoSize = true;
            this.Ft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ft.Location = new System.Drawing.Point(320, 292);
            this.Ft.Name = "Ft";
            this.Ft.Size = new System.Drawing.Size(21, 19);
            this.Ft.TabIndex = 29;
            this.Ft.Text = "Ft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ár:";
            // 
            // ar
            // 
            this.ar.Location = new System.Drawing.Point(159, 289);
            this.ar.Name = "ar";
            this.ar.Size = new System.Drawing.Size(159, 25);
            this.ar.TabIndex = 27;
            this.ar.Text = "0";
            // 
            // jegy
            // 
            this.jegy.FormattingEnabled = true;
            this.jegy.Items.AddRange(new object[] {
            "Normál jegy",
            "Kedvezményes jegy",
            "Családi jegy",
            "Baráti jegy"});
            this.jegy.Location = new System.Drawing.Point(159, 248);
            this.jegy.Name = "jegy";
            this.jegy.Size = new System.Drawing.Size(187, 25);
            this.jegy.TabIndex = 20;
            this.jegy.SelectedIndexChanged += new System.EventHandler(this.jegy_SelectedIndexChanged);
            this.jegy.SelectedValueChanged += new System.EventHandler(this.jegy_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Jegy fajta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vetítés napja:";
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum.Location = new System.Drawing.Point(159, 207);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(187, 25);
            this.datum.TabIndex = 17;
            this.datum.CloseUp += new System.EventHandler(this.datum_CloseUp);
            this.datum.ValueChanged += new System.EventHandler(this.datum_ValueChanged);
            // 
            // film
            // 
            this.film.FormattingEnabled = true;
            this.film.Location = new System.Drawing.Point(159, 165);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(187, 25);
            this.film.TabIndex = 11;
            this.film.SelectedIndexChanged += new System.EventHandler(this.film_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefonszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Film:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(159, 38);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(187, 25);
            this.nev.TabIndex = 6;
            this.nev.TextChanged += new System.EventHandler(this.nev_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(159, 80);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(187, 25);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // telefonszam
            // 
            this.telefonszam.Location = new System.Drawing.Point(159, 123);
            this.telefonszam.Name = "telefonszam";
            this.telefonszam.Size = new System.Drawing.Size(187, 25);
            this.telefonszam.TabIndex = 8;
            this.telefonszam.TextChanged += new System.EventHandler(this.telefonszam_TextChanged);
            // 
            // szek4
            // 
            this.szek4.Location = new System.Drawing.Point(625, 306);
            this.szek4.Name = "szek4";
            this.szek4.Size = new System.Drawing.Size(46, 23);
            this.szek4.TabIndex = 26;
            // 
            // szek3
            // 
            this.szek3.Location = new System.Drawing.Point(573, 306);
            this.szek3.Name = "szek3";
            this.szek3.Size = new System.Drawing.Size(46, 23);
            this.szek3.TabIndex = 25;
            // 
            // szek2
            // 
            this.szek2.Location = new System.Drawing.Point(521, 306);
            this.szek2.Name = "szek2";
            this.szek2.Size = new System.Drawing.Size(46, 23);
            this.szek2.TabIndex = 24;
            // 
            // szek1
            // 
            this.szek1.Location = new System.Drawing.Point(469, 306);
            this.szek1.Name = "szek1";
            this.szek1.Size = new System.Drawing.Size(46, 23);
            this.szek1.TabIndex = 23;
            this.szek1.TextChanged += new System.EventHandler(this.szek1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(410, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Székek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(689, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Keresés:";
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(689, 369);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(187, 23);
            this.kereses.TabIndex = 29;
            this.kereses.TextChanged += new System.EventHandler(this.kereses_TextChanged);
            // 
            // torles
            // 
            this.torles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.torles.Location = new System.Drawing.Point(23, 357);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(115, 35);
            this.torles.TabIndex = 28;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // modositas
            // 
            this.modositas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modositas.Location = new System.Drawing.Point(144, 357);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(115, 35);
            this.modositas.TabIndex = 27;
            this.modositas.Text = "Modosítás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // felvezetes
            // 
            this.felvezetes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.felvezetes.Location = new System.Drawing.Point(265, 357);
            this.felvezetes.Name = "felvezetes";
            this.felvezetes.Size = new System.Drawing.Size(115, 35);
            this.felvezetes.TabIndex = 26;
            this.felvezetes.Text = "Felvezetés";
            this.felvezetes.UseVisualStyleBackColor = true;
            this.felvezetes.Click += new System.EventHandler(this.felvezetes_Click);
            // 
            // tartalomtorles
            // 
            this.tartalomtorles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tartalomtorles.Location = new System.Drawing.Point(386, 357);
            this.tartalomtorles.Name = "tartalomtorles";
            this.tartalomtorles.Size = new System.Drawing.Size(115, 35);
            this.tartalomtorles.TabIndex = 31;
            this.tartalomtorles.Text = "Tartalom törlése";
            this.tartalomtorles.UseVisualStyleBackColor = true;
            this.tartalomtorles.Click += new System.EventHandler(this.tartalomtorles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(853, 192);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(410, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 222);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(788, 347);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(88, 16);
            this.dataGridView2.TabIndex = 37;
            this.dataGridView2.Visible = false;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // vászon
            // 
            this.vászon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vászon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vászon.Controls.Add(this.label10);
            this.vászon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vászon.Location = new System.Drawing.Point(411, 253);
            this.vászon.Name = "vászon";
            this.vászon.Size = new System.Drawing.Size(443, 37);
            this.vászon.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(116, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "M  O  Z  I  V  Á  S  Z  O  N";
            // 
            // helyi_foglalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.vászon);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.szek4);
            this.Controls.Add(this.tartalomtorles);
            this.Controls.Add(this.szek3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.szek2);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.szek1);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.modositas);
            this.Controls.Add(this.felvezetes);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "helyi_foglalas";
            this.Size = new System.Drawing.Size(910, 603);
            this.Load += new System.EventHandler(this.helyi_foglalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.vászon.ResumeLayout(false);
            this.vászon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefonszam;
        private System.Windows.Forms.ComboBox film;
        private System.Windows.Forms.ComboBox jegy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ar;
        private System.Windows.Forms.TextBox szek4;
        private System.Windows.Forms.TextBox szek3;
        private System.Windows.Forms.TextBox szek2;
        private System.Windows.Forms.TextBox szek1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kereses;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button felvezetes;
        private System.Windows.Forms.Button tartalomtorles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Ft;
        private System.Windows.Forms.Panel vászon;
        private System.Windows.Forms.Label label10;
    }
}
