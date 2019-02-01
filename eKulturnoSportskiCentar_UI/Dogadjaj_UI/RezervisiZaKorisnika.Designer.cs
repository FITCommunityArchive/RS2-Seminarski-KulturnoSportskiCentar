namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class RezervisiZaKorisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.imePrezimeInput = new System.Windows.Forms.MaskedTextBox();
            this.Korisnici_DGV = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervisi_BTN = new System.Windows.Forms.Button();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Korisnici_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ime i prezime:";
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(126, 28);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(179, 20);
            this.imePrezimeInput.TabIndex = 12;
            this.imePrezimeInput.TextChanged += new System.EventHandler(this.imePrezimeInput_TextChanged);
            // 
            // Korisnici_DGV
            // 
            this.Korisnici_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Korisnici_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Ime,
            this.Prezime});
            this.Korisnici_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Korisnici_DGV.Location = new System.Drawing.Point(0, 100);
            this.Korisnici_DGV.Name = "Korisnici_DGV";
            this.Korisnici_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Korisnici_DGV.Size = new System.Drawing.Size(374, 341);
            this.Korisnici_DGV.TabIndex = 14;
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
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Rezervisi_BTN
            // 
            this.Rezervisi_BTN.Location = new System.Drawing.Point(182, 59);
            this.Rezervisi_BTN.Name = "Rezervisi_BTN";
            this.Rezervisi_BTN.Size = new System.Drawing.Size(123, 23);
            this.Rezervisi_BTN.TabIndex = 15;
            this.Rezervisi_BTN.Text = "Rezervisi za korisnika";
            this.Rezervisi_BTN.UseVisualStyleBackColor = true;
            this.Rezervisi_BTN.Click += new System.EventHandler(this.Rezervisi_BTN_Click);
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(52, 59);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(75, 23);
            this.Odustani_BTN.TabIndex = 15;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // RezervisiZaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 441);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Rezervisi_BTN);
            this.Controls.Add(this.Korisnici_DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imePrezimeInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RezervisiZaKorisnika";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervisi za korisnika";
            this.Load += new System.EventHandler(this.RezervisiZaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Korisnici_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox imePrezimeInput;
        private System.Windows.Forms.DataGridView Korisnici_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.Button Rezervisi_BTN;
        private System.Windows.Forms.Button Odustani_BTN;
    }
}