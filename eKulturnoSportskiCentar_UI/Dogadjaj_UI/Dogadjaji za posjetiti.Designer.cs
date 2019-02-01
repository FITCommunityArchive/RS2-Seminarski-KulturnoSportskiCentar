namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class Dogadjaji_za_posjetiti
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
            this.Ocijeni_BTN = new System.Windows.Forms.Button();
            this.Otkazi_BTN = new System.Windows.Forms.Button();
            this.Dogadjaji_DGV = new System.Windows.Forms.DataGridView();
            this.DogadjajID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaji_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Ocijeni_BTN
            // 
            this.Ocijeni_BTN.Location = new System.Drawing.Point(171, 12);
            this.Ocijeni_BTN.Name = "Ocijeni_BTN";
            this.Ocijeni_BTN.Size = new System.Drawing.Size(75, 23);
            this.Ocijeni_BTN.TabIndex = 5;
            this.Ocijeni_BTN.Text = "Ocijeni";
            this.Ocijeni_BTN.UseVisualStyleBackColor = true;
            this.Ocijeni_BTN.Click += new System.EventHandler(this.Ocijeni_BTN_Click);
            // 
            // Otkazi_BTN
            // 
            this.Otkazi_BTN.Location = new System.Drawing.Point(41, 13);
            this.Otkazi_BTN.Name = "Otkazi_BTN";
            this.Otkazi_BTN.Size = new System.Drawing.Size(75, 23);
            this.Otkazi_BTN.TabIndex = 4;
            this.Otkazi_BTN.Text = "Otkaži";
            this.Otkazi_BTN.UseVisualStyleBackColor = true;
            this.Otkazi_BTN.Click += new System.EventHandler(this.Otkazi_BTN_Click);
            // 
            // Dogadjaji_DGV
            // 
            this.Dogadjaji_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dogadjaji_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogadjajID,
            this.Naziv,
            this.Datum,
            this.Aktivan});
            this.Dogadjaji_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dogadjaji_DGV.GridColor = System.Drawing.SystemColors.HighlightText;
            this.Dogadjaji_DGV.Location = new System.Drawing.Point(0, 60);
            this.Dogadjaji_DGV.Name = "Dogadjaji_DGV";
            this.Dogadjaji_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dogadjaji_DGV.Size = new System.Drawing.Size(413, 175);
            this.Dogadjaji_DGV.TabIndex = 3;
            // 
            // DogadjajID
            // 
            this.DogadjajID.DataPropertyName = "DogadjajID";
            this.DogadjajID.HeaderText = "DogadjajID";
            this.DogadjajID.Name = "DogadjajID";
            this.DogadjajID.ReadOnly = true;
            this.DogadjajID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivna";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Dogadjaji_za_posjetiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 235);
            this.Controls.Add(this.Ocijeni_BTN);
            this.Controls.Add(this.Otkazi_BTN);
            this.Controls.Add(this.Dogadjaji_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dogadjaji_za_posjetiti";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Događaji za posjetiti";
            this.Load += new System.EventHandler(this.Dogadjaji_za_posjetiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dogadjaji_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ocijeni_BTN;
        private System.Windows.Forms.Button Otkazi_BTN;
        private System.Windows.Forms.DataGridView Dogadjaji_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogadjajID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}