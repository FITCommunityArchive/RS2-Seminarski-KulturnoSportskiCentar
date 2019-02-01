namespace eKulturnoSportskiCentar_UI.Oprema_UI
{
    partial class IndexOprema
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
            this.Obrisi_BTN = new System.Windows.Forms.Button();
            this.Izmjeni_BTN = new System.Windows.Forms.Button();
            this.Dodaj_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.Oprema_DGV = new System.Windows.Forms.DataGridView();
            this.OpremaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Oprema_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Obrisi_BTN
            // 
            this.Obrisi_BTN.Location = new System.Drawing.Point(322, 53);
            this.Obrisi_BTN.Name = "Obrisi_BTN";
            this.Obrisi_BTN.Size = new System.Drawing.Size(91, 23);
            this.Obrisi_BTN.TabIndex = 19;
            this.Obrisi_BTN.Text = "Obriši";
            this.Obrisi_BTN.UseVisualStyleBackColor = true;
            this.Obrisi_BTN.Click += new System.EventHandler(this.Obrisi_BTN_Click);
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(171, 53);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(102, 23);
            this.Izmjeni_BTN.TabIndex = 18;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // Dodaj_BTN
            // 
            this.Dodaj_BTN.Location = new System.Drawing.Point(26, 53);
            this.Dodaj_BTN.Name = "Dodaj_BTN";
            this.Dodaj_BTN.Size = new System.Drawing.Size(99, 23);
            this.Dodaj_BTN.TabIndex = 17;
            this.Dodaj_BTN.Text = "Dodaj";
            this.Dodaj_BTN.UseVisualStyleBackColor = true;
            this.Dodaj_BTN.Click += new System.EventHandler(this.Dodaj_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(88, 12);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(185, 21);
            this.Sala_CMB.TabIndex = 14;
            this.Sala_CMB.SelectedIndexChanged += new System.EventHandler(this.Sala_CMB_SelectedIndexChanged);
            // 
            // Oprema_DGV
            // 
            this.Oprema_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Oprema_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Oprema_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Oprema_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OpremaID,
            this.Naziv,
            this.Kolicina,
            this.Sala,
            this.Slika});
            this.Oprema_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Oprema_DGV.Location = new System.Drawing.Point(0, 101);
            this.Oprema_DGV.Name = "Oprema_DGV";
            this.Oprema_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Oprema_DGV.Size = new System.Drawing.Size(465, 382);
            this.Oprema_DGV.TabIndex = 13;
            // 
            // OpremaID
            // 
            this.OpremaID.DataPropertyName = "OpremaID";
            this.OpremaID.HeaderText = "OpremaID";
            this.OpremaID.Name = "OpremaID";
            this.OpremaID.ReadOnly = true;
            this.OpremaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Oprema";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "SlikaThumb";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // IndexOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 483);
            this.Controls.Add(this.Obrisi_BTN);
            this.Controls.Add(this.Izmjeni_BTN);
            this.Controls.Add(this.Dodaj_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sala_CMB);
            this.Controls.Add(this.Oprema_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexOprema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oprema";
            this.Load += new System.EventHandler(this.IndexOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Oprema_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Obrisi_BTN;
        private System.Windows.Forms.Button Izmjeni_BTN;
        private System.Windows.Forms.Button Dodaj_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.DataGridView Oprema_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpremaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
    }
}