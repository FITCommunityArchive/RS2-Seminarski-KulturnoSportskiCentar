namespace eKulturnoSportskiCentar_UI.Sala_UI
{
    partial class IndexSala
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
            this.Dodaj_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Centar_CMB = new System.Windows.Forms.ComboBox();
            this.Sala_DGV = new System.Windows.Forms.DataGridView();
            this.SalaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Centar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Sala_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(142, 68);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(91, 23);
            this.Izmjeni_BTN.TabIndex = 12;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // Dodaj_BTN
            // 
            this.Dodaj_BTN.Location = new System.Drawing.Point(20, 68);
            this.Dodaj_BTN.Name = "Dodaj_BTN";
            this.Dodaj_BTN.Size = new System.Drawing.Size(91, 23);
            this.Dodaj_BTN.TabIndex = 11;
            this.Dodaj_BTN.Text = "Dodaj";
            this.Dodaj_BTN.UseVisualStyleBackColor = true;
            this.Dodaj_BTN.Click += new System.EventHandler(this.Dodaj_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Centar:";
            // 
            // Centar_CMB
            // 
            this.Centar_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Centar_CMB.FormattingEnabled = true;
            this.Centar_CMB.Location = new System.Drawing.Point(81, 32);
            this.Centar_CMB.Name = "Centar_CMB";
            this.Centar_CMB.Size = new System.Drawing.Size(213, 21);
            this.Centar_CMB.TabIndex = 8;
            this.Centar_CMB.SelectedIndexChanged += new System.EventHandler(this.Centar_CMB_SelectedIndexChanged);
            // 
            // Sala_DGV
            // 
            this.Sala_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sala_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaID,
            this.Naziv,
            this.Centar});
            this.Sala_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sala_DGV.Location = new System.Drawing.Point(0, 108);
            this.Sala_DGV.Name = "Sala_DGV";
            this.Sala_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sala_DGV.Size = new System.Drawing.Size(361, 210);
            this.Sala_DGV.TabIndex = 7;
            // 
            // SalaID
            // 
            this.SalaID.DataPropertyName = "SalaID";
            this.SalaID.HeaderText = "SalaID";
            this.SalaID.Name = "SalaID";
            this.SalaID.ReadOnly = true;
            this.SalaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Sala";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Centar
            // 
            this.Centar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Centar.DataPropertyName = "Centar";
            this.Centar.HeaderText = "Centar";
            this.Centar.Name = "Centar";
            this.Centar.ReadOnly = true;
            // 
            // IndexSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 318);
            this.Controls.Add(this.Izmjeni_BTN);
            this.Controls.Add(this.Dodaj_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Centar_CMB);
            this.Controls.Add(this.Sala_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexSala";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.IndexSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sala_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Izmjeni_BTN;
        private System.Windows.Forms.Button Dodaj_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Centar_CMB;
        private System.Windows.Forms.DataGridView Sala_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centar;
    }
}