namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class ListaPrisutnih
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
            this.NazivDogadjaj_INPUT = new System.Windows.Forms.TextBox();
            this.listaPrisutnih_DGV = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrisutnih_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Događaj:";
            // 
            // NazivDogadjaj_INPUT
            // 
            this.NazivDogadjaj_INPUT.Enabled = false;
            this.NazivDogadjaj_INPUT.Location = new System.Drawing.Point(81, 21);
            this.NazivDogadjaj_INPUT.Name = "NazivDogadjaj_INPUT";
            this.NazivDogadjaj_INPUT.ReadOnly = true;
            this.NazivDogadjaj_INPUT.Size = new System.Drawing.Size(193, 20);
            this.NazivDogadjaj_INPUT.TabIndex = 4;
            // 
            // listaPrisutnih_DGV
            // 
            this.listaPrisutnih_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPrisutnih_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Korisnik});
            this.listaPrisutnih_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaPrisutnih_DGV.Location = new System.Drawing.Point(0, 69);
            this.listaPrisutnih_DGV.Name = "listaPrisutnih_DGV";
            this.listaPrisutnih_DGV.Size = new System.Drawing.Size(284, 381);
            this.listaPrisutnih_DGV.TabIndex = 3;
            // 
            // KorisnikID
            // 
            this.KorisnikID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "R.Br.";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            this.KorisnikID.Width = 56;
            // 
            // Korisnik
            // 
            this.Korisnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // ListaPrisutnih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivDogadjaj_INPUT);
            this.Controls.Add(this.listaPrisutnih_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaPrisutnih";
            this.ShowIcon = false;
            this.Text = "Lista Prisutnih";
            ((System.ComponentModel.ISupportInitialize)(this.listaPrisutnih_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NazivDogadjaj_INPUT;
        private System.Windows.Forms.DataGridView listaPrisutnih_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
    }
}