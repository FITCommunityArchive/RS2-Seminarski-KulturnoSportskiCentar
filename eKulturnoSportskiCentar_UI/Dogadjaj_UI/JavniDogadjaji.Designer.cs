namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class JavniDogadjaji
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
            this.PrikaziSve_BTN = new System.Windows.Forms.Button();
            this.Vrsta_CMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Datum_PCK = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.Dogadjaj_DGV = new System.Windows.Forms.DataGridView();
            this.DogadjajID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogadjaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrisutnih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plakat = new System.Windows.Forms.DataGridViewImageColumn();
            this.OznaciSe_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaj_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PrikaziSve_BTN
            // 
            this.PrikaziSve_BTN.Location = new System.Drawing.Point(726, 14);
            this.PrikaziSve_BTN.Name = "PrikaziSve_BTN";
            this.PrikaziSve_BTN.Size = new System.Drawing.Size(75, 23);
            this.PrikaziSve_BTN.TabIndex = 47;
            this.PrikaziSve_BTN.Text = "Prikaži sve";
            this.PrikaziSve_BTN.UseVisualStyleBackColor = true;
            this.PrikaziSve_BTN.Click += new System.EventHandler(this.PrikaziSve_BTN_Click);
            // 
            // Vrsta_CMB
            // 
            this.Vrsta_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vrsta_CMB.FormattingEnabled = true;
            this.Vrsta_CMB.Location = new System.Drawing.Point(544, 13);
            this.Vrsta_CMB.Name = "Vrsta_CMB";
            this.Vrsta_CMB.Size = new System.Drawing.Size(156, 21);
            this.Vrsta_CMB.TabIndex = 46;
            this.Vrsta_CMB.SelectedIndexChanged += new System.EventHandler(this.Vrsta_CMB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Vrsta:";
            // 
            // Datum_PCK
            // 
            this.Datum_PCK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum_PCK.Location = new System.Drawing.Point(67, 13);
            this.Datum_PCK.Name = "Datum_PCK";
            this.Datum_PCK.Size = new System.Drawing.Size(200, 20);
            this.Datum_PCK.TabIndex = 44;
            this.Datum_PCK.ValueChanged += new System.EventHandler(this.Datum_PCK_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(334, 13);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(121, 21);
            this.Sala_CMB.TabIndex = 41;
            this.Sala_CMB.SelectedIndexChanged += new System.EventHandler(this.Sala_CMB_SelectedIndexChanged);
            // 
            // Dogadjaj_DGV
            // 
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
            this.Plakat});
            this.Dogadjaj_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dogadjaj_DGV.Location = new System.Drawing.Point(0, 169);
            this.Dogadjaj_DGV.Name = "Dogadjaj_DGV";
            this.Dogadjaj_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dogadjaj_DGV.Size = new System.Drawing.Size(846, 281);
            this.Dogadjaj_DGV.TabIndex = 40;
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
            // 
            // Plakat
            // 
            this.Plakat.DataPropertyName = "PlakatThumb";
            this.Plakat.HeaderText = "Plakat";
            this.Plakat.Name = "Plakat";
            this.Plakat.ReadOnly = true;
            // 
            // OznaciSe_BTN
            // 
            this.OznaciSe_BTN.Location = new System.Drawing.Point(678, 80);
            this.OznaciSe_BTN.Name = "OznaciSe_BTN";
            this.OznaciSe_BTN.Size = new System.Drawing.Size(104, 47);
            this.OznaciSe_BTN.TabIndex = 48;
            this.OznaciSe_BTN.Text = "Oznaci se";
            this.OznaciSe_BTN.UseVisualStyleBackColor = true;
            this.OznaciSe_BTN.Click += new System.EventHandler(this.OznaciSe_BTN_Click);
            // 
            // JavniDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.OznaciSe_BTN);
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
            this.Name = "JavniDogadjaji";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Javni Dogadjaji";
            this.Load += new System.EventHandler(this.JavniDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaj_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrikaziSve_BTN;
        private System.Windows.Forms.ComboBox Vrsta_CMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Datum_PCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.DataGridView Dogadjaj_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogadjajID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogadjaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrisutnih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewImageColumn Plakat;
        private System.Windows.Forms.Button OznaciSe_BTN;
    }
}