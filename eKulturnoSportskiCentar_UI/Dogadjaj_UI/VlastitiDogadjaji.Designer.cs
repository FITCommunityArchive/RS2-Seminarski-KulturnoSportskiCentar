namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class VlastitiDogadjaji
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
            this.Dogadjaj_DGV = new System.Windows.Forms.DataGridView();
            this.Datum_PCK = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.Vrsta_CMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrikaziSve_BTN = new System.Windows.Forms.Button();
            this.Otkazi_BTN = new System.Windows.Forms.Button();
            this.listaPristunih_BTN = new System.Windows.Forms.Button();
            this.detalji_BTN = new System.Windows.Forms.Button();
            this.DogadjajID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogadjaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrisutnih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobrena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaj_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Dogadjaj_DGV
            // 
            this.Dogadjaj_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dogadjaj_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dogadjaj_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogadjajID,
            this.Dogadjaj,
            this.Vrsta,
            this.Datum,
            this.Satnica,
            this.Sala,
            this.BrojPrisutnih,
            this.ProsjecnaOcjena,
            this.Odobrena,
            this.Aktivna});
            this.Dogadjaj_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dogadjaj_DGV.Location = new System.Drawing.Point(0, 135);
            this.Dogadjaj_DGV.Name = "Dogadjaj_DGV";
            this.Dogadjaj_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dogadjaj_DGV.Size = new System.Drawing.Size(761, 240);
            this.Dogadjaj_DGV.TabIndex = 4;
            // 
            // Datum_PCK
            // 
            this.Datum_PCK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum_PCK.Location = new System.Drawing.Point(68, 26);
            this.Datum_PCK.Name = "Datum_PCK";
            this.Datum_PCK.Size = new System.Drawing.Size(113, 20);
            this.Datum_PCK.TabIndex = 36;
            this.Datum_PCK.ValueChanged += new System.EventHandler(this.Datum_PCK_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(249, 24);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(121, 21);
            this.Sala_CMB.TabIndex = 33;
            this.Sala_CMB.SelectedIndexChanged += new System.EventHandler(this.Sala_CMB_SelectedIndexChanged);
            // 
            // Vrsta_CMB
            // 
            this.Vrsta_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vrsta_CMB.FormattingEnabled = true;
            this.Vrsta_CMB.Location = new System.Drawing.Point(459, 24);
            this.Vrsta_CMB.Name = "Vrsta_CMB";
            this.Vrsta_CMB.Size = new System.Drawing.Size(156, 21);
            this.Vrsta_CMB.TabIndex = 38;
            this.Vrsta_CMB.SelectedIndexChanged += new System.EventHandler(this.Vrsta_CMB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vrsta:";
            // 
            // PrikaziSve_BTN
            // 
            this.PrikaziSve_BTN.Location = new System.Drawing.Point(641, 25);
            this.PrikaziSve_BTN.Name = "PrikaziSve_BTN";
            this.PrikaziSve_BTN.Size = new System.Drawing.Size(100, 30);
            this.PrikaziSve_BTN.TabIndex = 39;
            this.PrikaziSve_BTN.Text = "Prikaži sve";
            this.PrikaziSve_BTN.UseVisualStyleBackColor = true;
            this.PrikaziSve_BTN.Click += new System.EventHandler(this.PrikaziSve_BTN_Click);
            // 
            // Otkazi_BTN
            // 
            this.Otkazi_BTN.Location = new System.Drawing.Point(270, 79);
            this.Otkazi_BTN.Name = "Otkazi_BTN";
            this.Otkazi_BTN.Size = new System.Drawing.Size(100, 30);
            this.Otkazi_BTN.TabIndex = 40;
            this.Otkazi_BTN.Text = "Otkaži";
            this.Otkazi_BTN.UseVisualStyleBackColor = true;
            this.Otkazi_BTN.Click += new System.EventHandler(this.Otkazi_BTN_Click);
            // 
            // listaPristunih_BTN
            // 
            this.listaPristunih_BTN.Location = new System.Drawing.Point(459, 79);
            this.listaPristunih_BTN.Name = "listaPristunih_BTN";
            this.listaPristunih_BTN.Size = new System.Drawing.Size(100, 30);
            this.listaPristunih_BTN.TabIndex = 41;
            this.listaPristunih_BTN.Text = "Lista prisutnih";
            this.listaPristunih_BTN.UseVisualStyleBackColor = true;
            this.listaPristunih_BTN.Click += new System.EventHandler(this.listaPristunih_BTN_Click);
            // 
            // detalji_BTN
            // 
            this.detalji_BTN.Location = new System.Drawing.Point(641, 79);
            this.detalji_BTN.Name = "detalji_BTN";
            this.detalji_BTN.Size = new System.Drawing.Size(100, 30);
            this.detalji_BTN.TabIndex = 42;
            this.detalji_BTN.Text = "Detalji događaja";
            this.detalji_BTN.UseVisualStyleBackColor = true;
            this.detalji_BTN.Click += new System.EventHandler(this.detalji_BTN_Click);
            // 
            // DogadjajID
            // 
            this.DogadjajID.DataPropertyName = "DogadjajID";
            this.DogadjajID.HeaderText = "DogadjajID";
            this.DogadjajID.Name = "DogadjajID";
            this.DogadjajID.ReadOnly = true;
            this.DogadjajID.Visible = false;
            // 
            // Dogadjaj
            // 
            this.Dogadjaj.DataPropertyName = "Dogadjaj";
            this.Dogadjaj.HeaderText = "Dogadjaj";
            this.Dogadjaj.Name = "Dogadjaj";
            this.Dogadjaj.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Satnica
            // 
            this.Satnica.DataPropertyName = "Satnica";
            this.Satnica.HeaderText = "Satnica";
            this.Satnica.Name = "Satnica";
            this.Satnica.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // BrojPrisutnih
            // 
            this.BrojPrisutnih.DataPropertyName = "BrojPrisutnih";
            this.BrojPrisutnih.HeaderText = "Broj prisutnih";
            this.BrojPrisutnih.Name = "BrojPrisutnih";
            this.BrojPrisutnih.ReadOnly = true;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            // 
            // Odobrena
            // 
            this.Odobrena.DataPropertyName = "Odobrena";
            this.Odobrena.HeaderText = "Odobrena";
            this.Odobrena.Name = "Odobrena";
            this.Odobrena.ReadOnly = true;
            this.Odobrena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Odobrena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivan";
            this.Aktivna.Name = "Aktivna";
            this.Aktivna.ReadOnly = true;
            this.Aktivna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VlastitiDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 375);
            this.Controls.Add(this.detalji_BTN);
            this.Controls.Add(this.listaPristunih_BTN);
            this.Controls.Add(this.Otkazi_BTN);
            this.Controls.Add(this.PrikaziSve_BTN);
            this.Controls.Add(this.Vrsta_CMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Datum_PCK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sala_CMB);
            this.Controls.Add(this.Dogadjaj_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VlastitiDogadjaji";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vlastiti Dogadjaji";
            this.Load += new System.EventHandler(this.VlastitiDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaj_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dogadjaj_DGV;
        private System.Windows.Forms.DateTimePicker Datum_PCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.ComboBox Vrsta_CMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrikaziSve_BTN;
        private System.Windows.Forms.Button Otkazi_BTN;
        private System.Windows.Forms.Button listaPristunih_BTN;
        private System.Windows.Forms.Button detalji_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogadjajID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogadjaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrisutnih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobrena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
    }
}