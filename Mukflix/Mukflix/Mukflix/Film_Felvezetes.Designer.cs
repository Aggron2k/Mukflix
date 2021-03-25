
namespace Mukflix
{
    partial class Film_Felvezetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film_Felvezetes));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cim = new System.Windows.Forms.TextBox();
            this.mufaj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rendezo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.korhatar = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.kep = new System.Windows.Forms.Button();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tartalomtorles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kereses = new System.Windows.Forms.TextBox();
            this.torles = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.felvezetes = new System.Windows.Forms.Button();
            this.fajlnev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film cím:";
            // 
            // cim
            // 
            this.cim.Location = new System.Drawing.Point(130, 33);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(187, 25);
            this.cim.TabIndex = 7;
            this.cim.TextChanged += new System.EventHandler(this.cim_TextChanged);
            // 
            // mufaj
            // 
            this.mufaj.FormattingEnabled = true;
            this.mufaj.Items.AddRange(new object[] {
            "Akció",
            "Dokumentumfilm",
            "Gyerek",
            "Horrorfilm",
            "Kaland",
            "Sci-fi",
            "Thriller",
            "Vígjáték",
            "Western"});
            this.mufaj.Location = new System.Drawing.Point(130, 73);
            this.mufaj.Name = "mufaj";
            this.mufaj.Size = new System.Drawing.Size(187, 25);
            this.mufaj.TabIndex = 8;
            this.mufaj.SelectedIndexChanged += new System.EventHandler(this.tema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Műfaj:";
            // 
            // rendezo
            // 
            this.rendezo.Location = new System.Drawing.Point(130, 113);
            this.rendezo.Name = "rendezo";
            this.rendezo.Size = new System.Drawing.Size(187, 25);
            this.rendezo.TabIndex = 11;
            this.rendezo.TextChanged += new System.EventHandler(this.rendezo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rendező:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Korhatár:";
            // 
            // korhatar
            // 
            this.korhatar.FormattingEnabled = true;
            this.korhatar.Items.AddRange(new object[] {
            "0",
            "6",
            "12",
            "16",
            "18"});
            this.korhatar.Location = new System.Drawing.Point(130, 155);
            this.korhatar.Name = "korhatar";
            this.korhatar.Size = new System.Drawing.Size(187, 25);
            this.korhatar.TabIndex = 12;
            this.korhatar.SelectedIndexChanged += new System.EventHandler(this.korhatar_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kép:";
            // 
            // kep
            // 
            this.kep.Location = new System.Drawing.Point(130, 194);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(187, 29);
            this.kep.TabIndex = 15;
            this.kep.Text = "Kép megnyitása";
            this.kep.UseVisualStyleBackColor = true;
            this.kep.Click += new System.EventHandler(this.kep_Click);
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum.Location = new System.Drawing.Point(130, 235);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(187, 25);
            this.datum.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Vetítés napja:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 181);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mufaj);
            this.groupBox1.Controls.Add(this.datum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rendezo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.korhatar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(33, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 281);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film felvezetés:";
            // 
            // tartalomtorles
            // 
            this.tartalomtorles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tartalomtorles.Location = new System.Drawing.Point(430, 31);
            this.tartalomtorles.Name = "tartalomtorles";
            this.tartalomtorles.Size = new System.Drawing.Size(115, 35);
            this.tartalomtorles.TabIndex = 20;
            this.tartalomtorles.Text = "Tartalom törlése";
            this.tartalomtorles.UseVisualStyleBackColor = true;
            this.tartalomtorles.Click += new System.EventHandler(this.tartalomtorles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(675, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Keresés:";
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(675, 354);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(187, 23);
            this.kereses.TabIndex = 24;
            this.kereses.TextChanged += new System.EventHandler(this.kereses_TextChanged);
            // 
            // torles
            // 
            this.torles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.torles.Location = new System.Drawing.Point(33, 333);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(115, 35);
            this.torles.TabIndex = 23;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // modositas
            // 
            this.modositas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modositas.Location = new System.Drawing.Point(154, 333);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(115, 35);
            this.modositas.TabIndex = 22;
            this.modositas.Text = "Modosítás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // felvezetes
            // 
            this.felvezetes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.felvezetes.Location = new System.Drawing.Point(275, 333);
            this.felvezetes.Name = "felvezetes";
            this.felvezetes.Size = new System.Drawing.Size(115, 35);
            this.felvezetes.TabIndex = 21;
            this.felvezetes.Text = "Felvezetés";
            this.felvezetes.UseVisualStyleBackColor = true;
            this.felvezetes.Click += new System.EventHandler(this.felvezetes_Click);
            // 
            // fajlnev
            // 
            this.fajlnev.Location = new System.Drawing.Point(430, 219);
            this.fajlnev.Name = "fajlnev";
            this.fajlnev.Size = new System.Drawing.Size(187, 23);
            this.fajlnev.TabIndex = 18;
            this.fajlnev.TextChanged += new System.EventHandler(this.fajlnev_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(428, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kép fájl neve:";
            // 
            // Film_Felvezetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fajlnev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.modositas);
            this.Controls.Add(this.felvezetes);
            this.Controls.Add(this.tartalomtorles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Film_Felvezetes";
            this.Size = new System.Drawing.Size(910, 603);
            this.Load += new System.EventHandler(this.Film_Felvezetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cim;
        private System.Windows.Forms.ComboBox mufaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rendezo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox korhatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kep;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tartalomtorles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kereses;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button felvezetes;
        private System.Windows.Forms.TextBox fajlnev;
        private System.Windows.Forms.Label label8;
    }
}
