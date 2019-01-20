namespace eKulturnoSportskiCentar_UI.Termin_UI
{
    partial class IndexTermin
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
            this.RezervisiZaKorisnika_BTN = new System.Windows.Forms.Button();
            this.Rezervisi_BTN = new System.Windows.Forms.Button();
            this.Datum_PCK = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Obrisi_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.Termin_DGV = new System.Windows.Forms.DataGridView();
            this.TerminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Termin_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RezervisiZaKorisnika_BTN
            // 
            this.RezervisiZaKorisnika_BTN.Location = new System.Drawing.Point(155, 102);
            this.RezervisiZaKorisnika_BTN.Name = "RezervisiZaKorisnika_BTN";
            this.RezervisiZaKorisnika_BTN.Size = new System.Drawing.Size(142, 23);
            this.RezervisiZaKorisnika_BTN.TabIndex = 34;
            this.RezervisiZaKorisnika_BTN.Text = "Rezerviši za korisnika";
            this.RezervisiZaKorisnika_BTN.UseVisualStyleBackColor = true;
            this.RezervisiZaKorisnika_BTN.Click += new System.EventHandler(this.RezervisiZaKorisnika_BTN_Click);
            // 
            // Rezervisi_BTN
            // 
            this.Rezervisi_BTN.Location = new System.Drawing.Point(24, 102);
            this.Rezervisi_BTN.Name = "Rezervisi_BTN";
            this.Rezervisi_BTN.Size = new System.Drawing.Size(75, 23);
            this.Rezervisi_BTN.TabIndex = 33;
            this.Rezervisi_BTN.Text = "Rezerviši";
            this.Rezervisi_BTN.UseVisualStyleBackColor = true;
            this.Rezervisi_BTN.Click += new System.EventHandler(this.Rezervisi_BTN_Click);
            // 
            // Datum_PCK
            // 
            this.Datum_PCK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum_PCK.Location = new System.Drawing.Point(58, 8);
            this.Datum_PCK.Name = "Datum_PCK";
            this.Datum_PCK.Size = new System.Drawing.Size(200, 20);
            this.Datum_PCK.TabIndex = 32;
            this.Datum_PCK.ValueChanged += new System.EventHandler(this.Datum_PCK_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Datum:";
            // 
            // Obrisi_BTN
            // 
            this.Obrisi_BTN.Location = new System.Drawing.Point(363, 102);
            this.Obrisi_BTN.Name = "Obrisi_BTN";
            this.Obrisi_BTN.Size = new System.Drawing.Size(75, 23);
            this.Obrisi_BTN.TabIndex = 30;
            this.Obrisi_BTN.Text = "Obriši";
            this.Obrisi_BTN.UseVisualStyleBackColor = true;
            this.Obrisi_BTN.Click += new System.EventHandler(this.Obrisi_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(58, 44);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(121, 21);
            this.Sala_CMB.TabIndex = 26;
            this.Sala_CMB.SelectedIndexChanged += new System.EventHandler(this.Sala_CMB_SelectedIndexChanged);
            // 
            // Termin_DGV
            // 
            this.Termin_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Termin_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminID,
            this.Datum,
            this.Pocetak,
            this.Kraj,
            this.Sala});
            this.Termin_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Termin_DGV.Location = new System.Drawing.Point(0, 160);
            this.Termin_DGV.Name = "Termin_DGV";
            this.Termin_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Termin_DGV.Size = new System.Drawing.Size(444, 330);
            this.Termin_DGV.TabIndex = 25;
            // 
            // TerminID
            // 
            this.TerminID.DataPropertyName = "TerminID";
            this.TerminID.HeaderText = "TerminID";
            this.TerminID.Name = "TerminID";
            this.TerminID.ReadOnly = true;
            this.TerminID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Pocetak
            // 
            this.Pocetak.DataPropertyName = "Pocetak";
            this.Pocetak.HeaderText = "Početak";
            this.Pocetak.Name = "Pocetak";
            this.Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            this.Kraj.DataPropertyName = "Kraj";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            this.Kraj.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(141, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Slobodni termini";
            // 
            // IndexTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RezervisiZaKorisnika_BTN);
            this.Controls.Add(this.Rezervisi_BTN);
            this.Controls.Add(this.Datum_PCK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Obrisi_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sala_CMB);
            this.Controls.Add(this.Termin_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexTermin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termin";
            this.Load += new System.EventHandler(this.IndexTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Termin_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RezervisiZaKorisnika_BTN;
        private System.Windows.Forms.Button Rezervisi_BTN;
        private System.Windows.Forms.DateTimePicker Datum_PCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Obrisi_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.DataGridView Termin_DGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    }
}