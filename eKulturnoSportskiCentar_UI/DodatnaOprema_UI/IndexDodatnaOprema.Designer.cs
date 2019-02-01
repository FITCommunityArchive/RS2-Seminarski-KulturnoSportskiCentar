namespace eKulturnoSportskiCentar_UI.DodatnaOprema_UI
{
    partial class IndexDodatnaOprema
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
            this.DodatnaOprema_DGV = new System.Windows.Forms.DataGridView();
            this.Izmjeni_BTN = new System.Windows.Forms.Button();
            this.Obrisi_BTN = new System.Windows.Forms.Button();
            this.Dodaj_BTN = new System.Windows.Forms.Button();
            this.DodatnaOpremaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DodatnaOprema_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DodatnaOprema_DGV
            // 
            this.DodatnaOprema_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DodatnaOprema_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DodatnaOprema_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DodatnaOprema_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DodatnaOpremaID,
            this.Naziv,
            this.Cijena,
            this.Slika});
            this.DodatnaOprema_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DodatnaOprema_DGV.Location = new System.Drawing.Point(0, 70);
            this.DodatnaOprema_DGV.Name = "DodatnaOprema_DGV";
            this.DodatnaOprema_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DodatnaOprema_DGV.Size = new System.Drawing.Size(341, 428);
            this.DodatnaOprema_DGV.TabIndex = 8;
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(122, 20);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(75, 23);
            this.Izmjeni_BTN.TabIndex = 7;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // Obrisi_BTN
            // 
            this.Obrisi_BTN.Location = new System.Drawing.Point(240, 20);
            this.Obrisi_BTN.Name = "Obrisi_BTN";
            this.Obrisi_BTN.Size = new System.Drawing.Size(75, 23);
            this.Obrisi_BTN.TabIndex = 6;
            this.Obrisi_BTN.Text = "Obirši";
            this.Obrisi_BTN.UseVisualStyleBackColor = true;
            this.Obrisi_BTN.Click += new System.EventHandler(this.Obrisi_BTN_Click);
            // 
            // Dodaj_BTN
            // 
            this.Dodaj_BTN.Location = new System.Drawing.Point(12, 20);
            this.Dodaj_BTN.Name = "Dodaj_BTN";
            this.Dodaj_BTN.Size = new System.Drawing.Size(75, 23);
            this.Dodaj_BTN.TabIndex = 5;
            this.Dodaj_BTN.Text = "Dodaj";
            this.Dodaj_BTN.UseVisualStyleBackColor = true;
            this.Dodaj_BTN.Click += new System.EventHandler(this.Dodaj_BTN_Click);
            // 
            // DodatnaOpremaID
            // 
            this.DodatnaOpremaID.DataPropertyName = "DodatnaOpremaID";
            this.DodatnaOpremaID.Frozen = true;
            this.DodatnaOpremaID.HeaderText = "DodatnaOpremaID";
            this.DodatnaOpremaID.Name = "DodatnaOpremaID";
            this.DodatnaOpremaID.ReadOnly = true;
            this.DodatnaOpremaID.Visible = false;
            this.DodatnaOpremaID.Width = 121;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.Frozen = true;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 59;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.Frozen = true;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 61;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "SlikaThumb";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // IndexDodatnaOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 498);
            this.Controls.Add(this.DodatnaOprema_DGV);
            this.Controls.Add(this.Izmjeni_BTN);
            this.Controls.Add(this.Obrisi_BTN);
            this.Controls.Add(this.Dodaj_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexDodatnaOprema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatna operma";
            ((System.ComponentModel.ISupportInitialize)(this.DodatnaOprema_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DodatnaOprema_DGV;
        private System.Windows.Forms.Button Izmjeni_BTN;
        private System.Windows.Forms.Button Obrisi_BTN;
        private System.Windows.Forms.Button Dodaj_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaOpremaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
    }
}