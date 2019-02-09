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
            this.components = new System.ComponentModel.Container();
            this.DodatnaOprema_DGV = new System.Windows.Forms.DataGridView();
            this.DodatnaOpremaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cijena_Input = new System.Windows.Forms.MaskedTextBox();
            this.Slika_Input = new System.Windows.Forms.TextBox();
            this.DodajSliku_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sacuvaj_BTN = new System.Windows.Forms.Button();
            this.Obrisi_BTN = new System.Windows.Forms.Button();
            this.Slika_PCB = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DodatnaOprema_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.DodatnaOprema_DGV.Location = new System.Drawing.Point(0, 176);
            this.DodatnaOprema_DGV.Name = "DodatnaOprema_DGV";
            this.DodatnaOprema_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DodatnaOprema_DGV.Size = new System.Drawing.Size(579, 519);
            this.DodatnaOprema_DGV.TabIndex = 8;
            this.DodatnaOprema_DGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DodatnaOprema_DGV_CellContentDoubleClick);
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
            // Cijena_Input
            // 
            this.Cijena_Input.Location = new System.Drawing.Point(63, 36);
            this.Cijena_Input.Mask = "00000";
            this.Cijena_Input.Name = "Cijena_Input";
            this.Cijena_Input.Size = new System.Drawing.Size(93, 20);
            this.Cijena_Input.TabIndex = 60;
            this.Cijena_Input.Text = "00000";
            // 
            // Slika_Input
            // 
            this.Slika_Input.Location = new System.Drawing.Point(63, 74);
            this.Slika_Input.Name = "Slika_Input";
            this.Slika_Input.ReadOnly = true;
            this.Slika_Input.Size = new System.Drawing.Size(187, 20);
            this.Slika_Input.TabIndex = 61;
            // 
            // DodajSliku_BTN
            // 
            this.DodajSliku_BTN.Location = new System.Drawing.Point(256, 74);
            this.DodajSliku_BTN.Name = "DodajSliku_BTN";
            this.DodajSliku_BTN.Size = new System.Drawing.Size(41, 23);
            this.DodajSliku_BTN.TabIndex = 62;
            this.DodajSliku_BTN.Text = "...";
            this.DodajSliku_BTN.UseVisualStyleBackColor = true;
            this.DodajSliku_BTN.Click += new System.EventHandler(this.DodajSliku_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Slika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Cijena:";
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(63, 10);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(234, 20);
            this.Naziv_Input.TabIndex = 59;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Naziv:";
            // 
            // Sacuvaj_BTN
            // 
            this.Sacuvaj_BTN.Location = new System.Drawing.Point(168, 119);
            this.Sacuvaj_BTN.Name = "Sacuvaj_BTN";
            this.Sacuvaj_BTN.Size = new System.Drawing.Size(129, 41);
            this.Sacuvaj_BTN.TabIndex = 64;
            this.Sacuvaj_BTN.Text = "Sačuvaj";
            this.Sacuvaj_BTN.UseVisualStyleBackColor = true;
            this.Sacuvaj_BTN.Click += new System.EventHandler(this.Sacuvaj_BTN_Click);
            // 
            // Obrisi_BTN
            // 
            this.Obrisi_BTN.Location = new System.Drawing.Point(27, 119);
            this.Obrisi_BTN.Name = "Obrisi_BTN";
            this.Obrisi_BTN.Size = new System.Drawing.Size(99, 41);
            this.Obrisi_BTN.TabIndex = 6;
            this.Obrisi_BTN.Text = "Obirši";
            this.Obrisi_BTN.UseVisualStyleBackColor = true;
            this.Obrisi_BTN.Click += new System.EventHandler(this.Obrisi_BTN_Click);
            // 
            // Slika_PCB
            // 
            this.Slika_PCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika_PCB.Location = new System.Drawing.Point(348, 10);
            this.Slika_PCB.Name = "Slika_PCB";
            this.Slika_PCB.Size = new System.Drawing.Size(200, 150);
            this.Slika_PCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Slika_PCB.TabIndex = 68;
            this.Slika_PCB.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // IndexDodatnaOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 695);
            this.Controls.Add(this.Slika_PCB);
            this.Controls.Add(this.Cijena_Input);
            this.Controls.Add(this.Slika_Input);
            this.Controls.Add(this.DodajSliku_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sacuvaj_BTN);
            this.Controls.Add(this.DodatnaOprema_DGV);
            this.Controls.Add(this.Obrisi_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexDodatnaOprema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatna operma";
            ((System.ComponentModel.ISupportInitialize)(this.DodatnaOprema_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DodatnaOprema_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaOpremaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.MaskedTextBox Cijena_Input;
        private System.Windows.Forms.TextBox Slika_Input;
        private System.Windows.Forms.Button DodajSliku_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sacuvaj_BTN;
        private System.Windows.Forms.Button Obrisi_BTN;
        private System.Windows.Forms.PictureBox Slika_PCB;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}