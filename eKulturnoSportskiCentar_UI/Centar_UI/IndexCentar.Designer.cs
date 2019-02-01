namespace eKulturnoSportskiCentar_UI.Centar_UI
{
    partial class IndexCentar
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
            this.UrediCentar_BTN = new System.Windows.Forms.Button();
            this.DodajKorisnika_BTN = new System.Windows.Forms.Button();
            this.Centar_DGV = new System.Windows.Forms.DataGridView();
            this.CentarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Centar_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UrediCentar_BTN
            // 
            this.UrediCentar_BTN.Location = new System.Drawing.Point(183, 21);
            this.UrediCentar_BTN.Name = "UrediCentar_BTN";
            this.UrediCentar_BTN.Size = new System.Drawing.Size(89, 32);
            this.UrediCentar_BTN.TabIndex = 10;
            this.UrediCentar_BTN.Text = "Uredi centar";
            this.UrediCentar_BTN.UseVisualStyleBackColor = true;
            this.UrediCentar_BTN.Click += new System.EventHandler(this.UrediCentar_BTN_Click);
            // 
            // DodajKorisnika_BTN
            // 
            this.DodajKorisnika_BTN.Location = new System.Drawing.Point(45, 21);
            this.DodajKorisnika_BTN.Name = "DodajKorisnika_BTN";
            this.DodajKorisnika_BTN.Size = new System.Drawing.Size(89, 32);
            this.DodajKorisnika_BTN.TabIndex = 9;
            this.DodajKorisnika_BTN.Text = "Dodaj centar";
            this.DodajKorisnika_BTN.UseVisualStyleBackColor = true;
            this.DodajKorisnika_BTN.Click += new System.EventHandler(this.DodajKorisnika_BTN_Click);
            // 
            // Centar_DGV
            // 
            this.Centar_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Centar_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CentarID,
            this.Naziv,
            this.Adresa,
            this.Telefon,
            this.Email});
            this.Centar_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Centar_DGV.Location = new System.Drawing.Point(0, 69);
            this.Centar_DGV.Name = "Centar_DGV";
            this.Centar_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Centar_DGV.Size = new System.Drawing.Size(459, 191);
            this.Centar_DGV.TabIndex = 8;
            // 
            // CentarID
            // 
            this.CentarID.DataPropertyName = "CentarID";
            this.CentarID.HeaderText = "CentarID";
            this.CentarID.Name = "CentarID";
            this.CentarID.ReadOnly = true;
            this.CentarID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
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
            // IndexCentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 260);
            this.Controls.Add(this.UrediCentar_BTN);
            this.Controls.Add(this.DodajKorisnika_BTN);
            this.Controls.Add(this.Centar_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexCentar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centar";
            this.Load += new System.EventHandler(this.IndexCentar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Centar_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UrediCentar_BTN;
        private System.Windows.Forms.Button DodajKorisnika_BTN;
        private System.Windows.Forms.DataGridView Centar_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}