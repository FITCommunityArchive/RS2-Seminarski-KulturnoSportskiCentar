﻿namespace eKulturnoSportskiCentar_UI.Korisnik_UI
{
    partial class IndexKorisnici
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
            this.Izmjeni_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imePrezimeInput = new System.Windows.Forms.MaskedTextBox();
            this.DodajKorisnika_BTN = new System.Windows.Forms.Button();
            this.Korisnici_DGV = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UcitajKorisnike_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Korisnici_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(505, 39);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(75, 23);
            this.Izmjeni_BTN.TabIndex = 12;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime i prezime:";
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(120, 42);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(122, 20);
            this.imePrezimeInput.TabIndex = 10;
            // 
            // DodajKorisnika_BTN
            // 
            this.DodajKorisnika_BTN.Location = new System.Drawing.Point(379, 39);
            this.DodajKorisnika_BTN.Name = "DodajKorisnika_BTN";
            this.DodajKorisnika_BTN.Size = new System.Drawing.Size(75, 23);
            this.DodajKorisnika_BTN.TabIndex = 9;
            this.DodajKorisnika_BTN.Text = "Dodaj korisnika";
            this.DodajKorisnika_BTN.UseVisualStyleBackColor = true;
            this.DodajKorisnika_BTN.Click += new System.EventHandler(this.DodajKorisnika_BTN_Click);
            // 
            // Korisnici_DGV
            // 
            this.Korisnici_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Korisnici_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Ime,
            this.Prezime,
            this.Telefon,
            this.Email,
            this.KorisnickoIme,
            this.Status});
            this.Korisnici_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Korisnici_DGV.Location = new System.Drawing.Point(0, 102);
            this.Korisnici_DGV.Name = "Korisnici_DGV";
            this.Korisnici_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Korisnici_DGV.Size = new System.Drawing.Size(646, 150);
            this.Korisnici_DGV.TabIndex = 8;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UcitajKorisnike_BTN
            // 
            this.UcitajKorisnike_BTN.Location = new System.Drawing.Point(265, 39);
            this.UcitajKorisnike_BTN.Name = "UcitajKorisnike_BTN";
            this.UcitajKorisnike_BTN.Size = new System.Drawing.Size(75, 23);
            this.UcitajKorisnike_BTN.TabIndex = 7;
            this.UcitajKorisnike_BTN.Text = "Ucitaj korisnike";
            this.UcitajKorisnike_BTN.UseVisualStyleBackColor = true;
            this.UcitajKorisnike_BTN.Click += new System.EventHandler(this.UcitajKorisnike_BTN_Click);
            // 
            // IndexKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 252);
            this.Controls.Add(this.Izmjeni_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imePrezimeInput);
            this.Controls.Add(this.DodajKorisnika_BTN);
            this.Controls.Add(this.Korisnici_DGV);
            this.Controls.Add(this.UcitajKorisnike_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexKorisnici";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.IndexKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Korisnici_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Izmjeni_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox imePrezimeInput;
        private System.Windows.Forms.Button DodajKorisnika_BTN;
        private System.Windows.Forms.DataGridView Korisnici_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Button UcitajKorisnike_BTN;
    }
}