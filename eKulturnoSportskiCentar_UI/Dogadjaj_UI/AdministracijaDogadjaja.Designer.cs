namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class AdministracijaDogadjaja
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
            this.Detalji_BTN = new System.Windows.Forms.Button();
            this.Odbij_BTN = new System.Windows.Forms.Button();
            this.Odobri_Btn = new System.Windows.Forms.Button();
            this.Dogadjaj_DGV = new System.Windows.Forms.DataGridView();
            this.Vrsta_CMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Datum_PCK = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.PrikaziSve_BTN = new System.Windows.Forms.Button();
            this.DogadjajID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogadjaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JavniDogadjaj = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaj_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalji_BTN
            // 
            this.Detalji_BTN.Location = new System.Drawing.Point(60, 79);
            this.Detalji_BTN.Name = "Detalji_BTN";
            this.Detalji_BTN.Size = new System.Drawing.Size(103, 34);
            this.Detalji_BTN.TabIndex = 7;
            this.Detalji_BTN.Text = "Detalji";
            this.Detalji_BTN.UseVisualStyleBackColor = true;
            this.Detalji_BTN.Click += new System.EventHandler(this.Detalji_BTN_Click);
            // 
            // Odbij_BTN
            // 
            this.Odbij_BTN.Location = new System.Drawing.Point(356, 79);
            this.Odbij_BTN.Name = "Odbij_BTN";
            this.Odbij_BTN.Size = new System.Drawing.Size(99, 34);
            this.Odbij_BTN.TabIndex = 6;
            this.Odbij_BTN.Text = "Odbij";
            this.Odbij_BTN.UseVisualStyleBackColor = true;
            this.Odbij_BTN.Click += new System.EventHandler(this.Odbij_BTN_Click);
            // 
            // Odobri_Btn
            // 
            this.Odobri_Btn.Location = new System.Drawing.Point(205, 79);
            this.Odobri_Btn.Name = "Odobri_Btn";
            this.Odobri_Btn.Size = new System.Drawing.Size(99, 34);
            this.Odobri_Btn.TabIndex = 5;
            this.Odobri_Btn.Text = "Odobri";
            this.Odobri_Btn.UseVisualStyleBackColor = true;
            this.Odobri_Btn.Click += new System.EventHandler(this.Odobri_Btn_Click);
            // 
            // Dogadjaj_DGV
            // 
            this.Dogadjaj_DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.Dogadjaj_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dogadjaj_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogadjajID,
            this.Dogadjaj,
            this.VrstaDogadjaja,
            this.Datum,
            this.Satnica,
            this.Sala,
            this.Korisnik,
            this.JavniDogadjaj});
            this.Dogadjaj_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dogadjaj_DGV.Location = new System.Drawing.Point(0, 150);
            this.Dogadjaj_DGV.Name = "Dogadjaj_DGV";
            this.Dogadjaj_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dogadjaj_DGV.Size = new System.Drawing.Size(745, 253);
            this.Dogadjaj_DGV.TabIndex = 4;
            // 
            // Vrsta_CMB
            // 
            this.Vrsta_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vrsta_CMB.FormattingEnabled = true;
            this.Vrsta_CMB.Location = new System.Drawing.Point(472, 23);
            this.Vrsta_CMB.Name = "Vrsta_CMB";
            this.Vrsta_CMB.Size = new System.Drawing.Size(156, 21);
            this.Vrsta_CMB.TabIndex = 52;
            this.Vrsta_CMB.SelectedIndexChanged += new System.EventHandler(this.Vrsta_CMB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Vrsta:";
            // 
            // Datum_PCK
            // 
            this.Datum_PCK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum_PCK.Location = new System.Drawing.Point(60, 24);
            this.Datum_PCK.Name = "Datum_PCK";
            this.Datum_PCK.Size = new System.Drawing.Size(130, 20);
            this.Datum_PCK.TabIndex = 50;
            this.Datum_PCK.ValueChanged += new System.EventHandler(this.Datum_PCK_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(263, 21);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(121, 21);
            this.Sala_CMB.TabIndex = 47;
            this.Sala_CMB.SelectedIndexChanged += new System.EventHandler(this.Sala_CMB_SelectedIndexChanged);
            // 
            // PrikaziSve_BTN
            // 
            this.PrikaziSve_BTN.Location = new System.Drawing.Point(658, 24);
            this.PrikaziSve_BTN.Name = "PrikaziSve_BTN";
            this.PrikaziSve_BTN.Size = new System.Drawing.Size(75, 23);
            this.PrikaziSve_BTN.TabIndex = 53;
            this.PrikaziSve_BTN.Text = "Prikaži sve";
            this.PrikaziSve_BTN.UseVisualStyleBackColor = true;
            this.PrikaziSve_BTN.Click += new System.EventHandler(this.PrikaziSve_BTN_Click);
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
            // 
            // VrstaDogadjaja
            // 
            this.VrstaDogadjaja.DataPropertyName = "Vrsta";
            this.VrstaDogadjaja.HeaderText = "Vrsta dogadjaja";
            this.VrstaDogadjaja.Name = "VrstaDogadjaja";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
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
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            // 
            // JavniDogadjaj
            // 
            this.JavniDogadjaj.DataPropertyName = "javni";
            this.JavniDogadjaj.FalseValue = "NE";
            this.JavniDogadjaj.HeaderText = "JavniDogadjaj";
            this.JavniDogadjaj.IndeterminateValue = "NEDEFINISANO";
            this.JavniDogadjaj.Name = "JavniDogadjaj";
            this.JavniDogadjaj.ReadOnly = true;
            this.JavniDogadjaj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JavniDogadjaj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.JavniDogadjaj.TrueValue = "DA";
            // 
            // AdministracijaDogadjaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 403);
            this.Controls.Add(this.PrikaziSve_BTN);
            this.Controls.Add(this.Vrsta_CMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Datum_PCK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sala_CMB);
            this.Controls.Add(this.Detalji_BTN);
            this.Controls.Add(this.Odbij_BTN);
            this.Controls.Add(this.Odobri_Btn);
            this.Controls.Add(this.Dogadjaj_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministracijaDogadjaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija Dogadjaja";
            this.Load += new System.EventHandler(this.AdministracijaDogadjaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaj_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Detalji_BTN;
        private System.Windows.Forms.Button Odbij_BTN;
        private System.Windows.Forms.Button Odobri_Btn;
        private System.Windows.Forms.DataGridView Dogadjaj_DGV;
        private System.Windows.Forms.ComboBox Vrsta_CMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Datum_PCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.Button PrikaziSve_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogadjajID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogadjaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JavniDogadjaj;
    }
}