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
            this.components = new System.ComponentModel.Container();
            this.Obrisi_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.Oprema_DGV = new System.Windows.Forms.DataGridView();
            this.Slika_PCB = new System.Windows.Forms.PictureBox();
            this.Slika_Input = new System.Windows.Forms.TextBox();
            this.DodajSliku_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Kolicina_Input = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dodaj_BTN = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Oprema_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Obrisi_BTN
            // 
            this.Obrisi_BTN.Location = new System.Drawing.Point(28, 129);
            this.Obrisi_BTN.Name = "Obrisi_BTN";
            this.Obrisi_BTN.Size = new System.Drawing.Size(100, 30);
            this.Obrisi_BTN.TabIndex = 19;
            this.Obrisi_BTN.Text = "Obriši";
            this.Obrisi_BTN.UseVisualStyleBackColor = true;
            this.Obrisi_BTN.Click += new System.EventHandler(this.Obrisi_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(70, 12);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(170, 21);
            this.Sala_CMB.TabIndex = 14;
            this.Sala_CMB.SelectedIndexChanged += new System.EventHandler(this.Sala_CMB_SelectedIndexChanged);
            // 
            // Oprema_DGV
            // 
            this.Oprema_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Oprema_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Oprema_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Oprema_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Kolicina,
            this.Sala,
            this.Slika});
            this.Oprema_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Oprema_DGV.Location = new System.Drawing.Point(0, 205);
            this.Oprema_DGV.Name = "Oprema_DGV";
            this.Oprema_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Oprema_DGV.Size = new System.Drawing.Size(684, 306);
            this.Oprema_DGV.TabIndex = 13;
            this.Oprema_DGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Oprema_DGV_CellContentDoubleClick);
            // 
            // Slika_PCB
            // 
            this.Slika_PCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika_PCB.Location = new System.Drawing.Point(411, 15);
            this.Slika_PCB.Name = "Slika_PCB";
            this.Slika_PCB.Size = new System.Drawing.Size(250, 160);
            this.Slika_PCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Slika_PCB.TabIndex = 59;
            this.Slika_PCB.TabStop = false;
            // 
            // Slika_Input
            // 
            this.Slika_Input.Location = new System.Drawing.Point(70, 87);
            this.Slika_Input.Name = "Slika_Input";
            this.Slika_Input.ReadOnly = true;
            this.Slika_Input.Size = new System.Drawing.Size(222, 20);
            this.Slika_Input.TabIndex = 51;
            // 
            // DodajSliku_BTN
            // 
            this.DodajSliku_BTN.Location = new System.Drawing.Point(318, 85);
            this.DodajSliku_BTN.Name = "DodajSliku_BTN";
            this.DodajSliku_BTN.Size = new System.Drawing.Size(60, 30);
            this.DodajSliku_BTN.TabIndex = 52;
            this.DodajSliku_BTN.Text = "...";
            this.DodajSliku_BTN.UseVisualStyleBackColor = true;
            this.DodajSliku_BTN.Click += new System.EventHandler(this.DodajSliku_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Slika:";
            // 
            // Kolicina_Input
            // 
            this.Kolicina_Input.Location = new System.Drawing.Point(310, 13);
            this.Kolicina_Input.Mask = "0000";
            this.Kolicina_Input.Name = "Kolicina_Input";
            this.Kolicina_Input.Size = new System.Drawing.Size(53, 20);
            this.Kolicina_Input.TabIndex = 49;
            this.Kolicina_Input.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Količina:";
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(70, 47);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(293, 20);
            this.Naziv_Input.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Naziv:";
            // 
            // Dodaj_BTN
            // 
            this.Dodaj_BTN.Location = new System.Drawing.Point(258, 129);
            this.Dodaj_BTN.Name = "Dodaj_BTN";
            this.Dodaj_BTN.Size = new System.Drawing.Size(100, 30);
            this.Dodaj_BTN.TabIndex = 53;
            this.Dodaj_BTN.Text = "Sačuvaj";
            this.Dodaj_BTN.UseVisualStyleBackColor = true;
            this.Dodaj_BTN.Click += new System.EventHandler(this.Dodaj_BTN_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Za odabir opreme kliknite dva puta na željenu opremu!";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Oprema";
            this.Naziv.FillWeight = 106.2606F;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.FillWeight = 50F;
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.FillWeight = 106.2606F;
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "SlikaThumb";
            this.Slika.FillWeight = 106.2606F;
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // IndexOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Slika_PCB);
            this.Controls.Add(this.Slika_Input);
            this.Controls.Add(this.DodajSliku_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kolicina_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dodaj_BTN);
            this.Controls.Add(this.Obrisi_BTN);
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
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Obrisi_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.DataGridView Oprema_DGV;
        private System.Windows.Forms.PictureBox Slika_PCB;
        private System.Windows.Forms.TextBox Slika_Input;
        private System.Windows.Forms.Button DodajSliku_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Kolicina_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Dodaj_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.Label label2;
    }
}