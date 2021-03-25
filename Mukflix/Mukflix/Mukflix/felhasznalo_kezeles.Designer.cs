
namespace Mukflix
{
    partial class felhasznalo_kezeles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(felhasznalo_kezeles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.felhasznalonev = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.jelszo = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.CheckBox();
            this.felvezetes = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.kereses = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tartalomtorles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
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
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jelszó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Admin joggal feruházás:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(159, 38);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(187, 25);
            this.nev.TabIndex = 6;
            this.nev.TextChanged += new System.EventHandler(this.nev_TextChanged);
            // 
            // felhasznalonev
            // 
            this.felhasznalonev.Location = new System.Drawing.Point(159, 80);
            this.felhasznalonev.Name = "felhasznalonev";
            this.felhasznalonev.Size = new System.Drawing.Size(187, 25);
            this.felhasznalonev.TabIndex = 7;
            this.felhasznalonev.TextChanged += new System.EventHandler(this.felhasznalonev_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(159, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(187, 25);
            this.email.TabIndex = 8;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // jelszo
            // 
            this.jelszo.Location = new System.Drawing.Point(159, 168);
            this.jelszo.Name = "jelszo";
            this.jelszo.Size = new System.Drawing.Size(187, 25);
            this.jelszo.TabIndex = 9;
            this.jelszo.TextChanged += new System.EventHandler(this.jelszo_TextChanged);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admin.Location = new System.Drawing.Point(209, 213);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(68, 23);
            this.admin.TabIndex = 10;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // felvezetes
            // 
            this.felvezetes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.felvezetes.Location = new System.Drawing.Point(284, 330);
            this.felvezetes.Name = "felvezetes";
            this.felvezetes.Size = new System.Drawing.Size(115, 35);
            this.felvezetes.TabIndex = 11;
            this.felvezetes.Text = "Felvezetés";
            this.felvezetes.UseVisualStyleBackColor = true;
            this.felvezetes.Click += new System.EventHandler(this.felvezetes_Click);
            // 
            // modositas
            // 
            this.modositas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modositas.Location = new System.Drawing.Point(163, 330);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(115, 35);
            this.modositas.TabIndex = 12;
            this.modositas.Text = "Modosítás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // torles
            // 
            this.torles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.torles.Location = new System.Drawing.Point(42, 330);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(115, 35);
            this.torles.TabIndex = 13;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(684, 351);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(187, 23);
            this.kereses.TabIndex = 14;
            this.kereses.TextChanged += new System.EventHandler(this.kereses_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(684, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Keresés:";
            // 
            // tartalomtorles
            // 
            this.tartalomtorles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tartalomtorles.Location = new System.Drawing.Point(416, 41);
            this.tartalomtorles.Name = "tartalomtorles";
            this.tartalomtorles.Size = new System.Drawing.Size(115, 35);
            this.tartalomtorles.TabIndex = 17;
            this.tartalomtorles.Text = "Tartalom törlése";
            this.tartalomtorles.UseVisualStyleBackColor = true;
            this.tartalomtorles.Click += new System.EventHandler(this.tartalomtorles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nev);
            this.groupBox1.Controls.Add(this.felhasznalonev);
            this.groupBox1.Controls.Add(this.admin);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.jelszo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(42, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 286);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felhasználó adatai:";
            // 
            // felhasznalo_kezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tartalomtorles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.modositas);
            this.Controls.Add(this.felvezetes);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "felhasznalo_kezeles";
            this.Size = new System.Drawing.Size(910, 603);
            this.Load += new System.EventHandler(this.felhasznalo_kezeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox felhasznalonev;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox jelszo;
        private System.Windows.Forms.CheckBox admin;
        private System.Windows.Forms.Button felvezetes;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.TextBox kereses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tartalomtorles;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
