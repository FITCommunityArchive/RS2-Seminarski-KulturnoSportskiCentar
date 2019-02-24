namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class KreirajDogadjaj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DodatnaOprema_DGV = new System.Windows.Forms.DataGridView();
            this.DodatnaOpremaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaUlaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odabrano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.NE_RDB = new System.Windows.Forms.RadioButton();
            this.Da_RDB = new System.Windows.Forms.RadioButton();
            this.javniDogadjaj_box = new System.Windows.Forms.GroupBox();
            this.Plakat_PBX = new System.Windows.Forms.PictureBox();
            this.Slika_BTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Plakat_Input = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BrojMijesta_Input = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cijena_Input = new System.Windows.Forms.MaskedTextBox();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.Rezevisi_BTN = new System.Windows.Forms.Button();
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.Vrsta_CMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatumInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DodatnaOprema_DGV)).BeginInit();
            this.javniDogadjaj_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plakat_PBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DodatnaOprema_DGV);
            this.groupBox1.Location = new System.Drawing.Point(14, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 165);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatna Oprema";
            // 
            // DodatnaOprema_DGV
            // 
            this.DodatnaOprema_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DodatnaOprema_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DodatnaOprema_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DodatnaOprema_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DodatnaOpremaID,
            this.Naziv,
            this.CijenaUlaza,
            this.Odabrano,
            this.SlikaThumb});
            this.DodatnaOprema_DGV.Location = new System.Drawing.Point(6, 32);
            this.DodatnaOprema_DGV.Name = "DodatnaOprema_DGV";
            this.DodatnaOprema_DGV.Size = new System.Drawing.Size(454, 122);
            this.DodatnaOprema_DGV.TabIndex = 24;
            // 
            // DodatnaOpremaID
            // 
            this.DodatnaOpremaID.DataPropertyName = "DodatnaOpremaID";
            this.DodatnaOpremaID.Frozen = true;
            this.DodatnaOpremaID.HeaderText = "DodatnaOpremaID";
            this.DodatnaOpremaID.Name = "DodatnaOpremaID";
            this.DodatnaOpremaID.ReadOnly = true;
            this.DodatnaOpremaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // CijenaUlaza
            // 
            this.CijenaUlaza.DataPropertyName = "Cijena";
            this.CijenaUlaza.HeaderText = "Cijena";
            this.CijenaUlaza.Name = "CijenaUlaza";
            this.CijenaUlaza.ReadOnly = true;
            // 
            // Odabrano
            // 
            this.Odabrano.HeaderText = "Odabrano";
            this.Odabrano.Name = "Odabrano";
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            // 
            // NE_RDB
            // 
            this.NE_RDB.AutoSize = true;
            this.NE_RDB.Location = new System.Drawing.Point(202, 165);
            this.NE_RDB.Name = "NE_RDB";
            this.NE_RDB.Size = new System.Drawing.Size(40, 17);
            this.NE_RDB.TabIndex = 34;
            this.NE_RDB.TabStop = true;
            this.NE_RDB.Text = "NE";
            this.NE_RDB.UseVisualStyleBackColor = true;
            this.NE_RDB.CheckedChanged += new System.EventHandler(this.NE_RDB_CheckedChanged);
            // 
            // Da_RDB
            // 
            this.Da_RDB.AutoSize = true;
            this.Da_RDB.Location = new System.Drawing.Point(134, 165);
            this.Da_RDB.Name = "Da_RDB";
            this.Da_RDB.Size = new System.Drawing.Size(40, 17);
            this.Da_RDB.TabIndex = 33;
            this.Da_RDB.TabStop = true;
            this.Da_RDB.Text = "DA";
            this.Da_RDB.UseVisualStyleBackColor = true;
            this.Da_RDB.CheckedChanged += new System.EventHandler(this.Da_RDB_CheckedChanged);
            // 
            // javniDogadjaj_box
            // 
            this.javniDogadjaj_box.Controls.Add(this.Plakat_PBX);
            this.javniDogadjaj_box.Controls.Add(this.Slika_BTN);
            this.javniDogadjaj_box.Controls.Add(this.label6);
            this.javniDogadjaj_box.Controls.Add(this.Plakat_Input);
            this.javniDogadjaj_box.Controls.Add(this.label7);
            this.javniDogadjaj_box.Controls.Add(this.BrojMijesta_Input);
            this.javniDogadjaj_box.Controls.Add(this.label5);
            this.javniDogadjaj_box.Controls.Add(this.Cijena_Input);
            this.javniDogadjaj_box.Location = new System.Drawing.Point(497, 27);
            this.javniDogadjaj_box.Name = "javniDogadjaj_box";
            this.javniDogadjaj_box.Size = new System.Drawing.Size(355, 277);
            this.javniDogadjaj_box.TabIndex = 32;
            this.javniDogadjaj_box.TabStop = false;
            this.javniDogadjaj_box.Text = "Javni dogadjaj";
            // 
            // Plakat_PBX
            // 
            this.Plakat_PBX.Location = new System.Drawing.Point(40, 105);
            this.Plakat_PBX.Name = "Plakat_PBX";
            this.Plakat_PBX.Size = new System.Drawing.Size(276, 127);
            this.Plakat_PBX.TabIndex = 18;
            this.Plakat_PBX.TabStop = false;
            // 
            // Slika_BTN
            // 
            this.Slika_BTN.Location = new System.Drawing.Point(245, 48);
            this.Slika_BTN.Name = "Slika_BTN";
            this.Slika_BTN.Size = new System.Drawing.Size(71, 23);
            this.Slika_BTN.TabIndex = 17;
            this.Slika_BTN.Text = "Dodaj sliku";
            this.Slika_BTN.UseVisualStyleBackColor = true;
            this.Slika_BTN.Click += new System.EventHandler(this.Slika_BTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj mjesta:";
            // 
            // Plakat_Input
            // 
            this.Plakat_Input.Location = new System.Drawing.Point(92, 51);
            this.Plakat_Input.Name = "Plakat_Input";
            this.Plakat_Input.ReadOnly = true;
            this.Plakat_Input.Size = new System.Drawing.Size(144, 20);
            this.Plakat_Input.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cijena ulaza:";
            // 
            // BrojMijesta_Input
            // 
            this.BrojMijesta_Input.Location = new System.Drawing.Point(255, 16);
            this.BrojMijesta_Input.Mask = "0000";
            this.BrojMijesta_Input.Name = "BrojMijesta_Input";
            this.BrojMijesta_Input.Size = new System.Drawing.Size(61, 20);
            this.BrojMijesta_Input.TabIndex = 15;
            this.BrojMijesta_Input.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Plakat:";
            // 
            // Cijena_Input
            // 
            this.Cijena_Input.Location = new System.Drawing.Point(92, 16);
            this.Cijena_Input.Mask = "000.00";
            this.Cijena_Input.Name = "Cijena_Input";
            this.Cijena_Input.Size = new System.Drawing.Size(69, 20);
            this.Cijena_Input.TabIndex = 14;
            this.Cijena_Input.Text = "00000";
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(555, 330);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(100, 30);
            this.Odustani_BTN.TabIndex = 31;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Rezevisi_BTN
            // 
            this.Rezevisi_BTN.Location = new System.Drawing.Point(684, 330);
            this.Rezevisi_BTN.Name = "Rezevisi_BTN";
            this.Rezevisi_BTN.Size = new System.Drawing.Size(100, 30);
            this.Rezevisi_BTN.TabIndex = 30;
            this.Rezevisi_BTN.Text = "Rezerviši";
            this.Rezevisi_BTN.UseVisualStyleBackColor = true;
            this.Rezevisi_BTN.Click += new System.EventHandler(this.Rezevisi_BTN_Click);
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(123, 95);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(271, 20);
            this.Naziv_Input.TabIndex = 29;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // Vrsta_CMB
            // 
            this.Vrsta_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vrsta_CMB.FormattingEnabled = true;
            this.Vrsta_CMB.Location = new System.Drawing.Point(123, 124);
            this.Vrsta_CMB.Name = "Vrsta_CMB";
            this.Vrsta_CMB.Size = new System.Drawing.Size(156, 21);
            this.Vrsta_CMB.TabIndex = 28;
            this.Vrsta_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Vrsta_CMB_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Javni događaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vrsta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Naziv:";
            // 
            // SalaInput
            // 
            this.SalaInput.Location = new System.Drawing.Point(123, 20);
            this.SalaInput.Name = "SalaInput";
            this.SalaInput.ReadOnly = true;
            this.SalaInput.Size = new System.Drawing.Size(271, 20);
            this.SalaInput.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Sala:";
            // 
            // DatumInput
            // 
            this.DatumInput.Location = new System.Drawing.Point(123, 59);
            this.DatumInput.Name = "DatumInput";
            this.DatumInput.ReadOnly = true;
            this.DatumInput.Size = new System.Drawing.Size(271, 20);
            this.DatumInput.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Datum:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // KreirajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 392);
            this.Controls.Add(this.DatumInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SalaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NE_RDB);
            this.Controls.Add(this.Da_RDB);
            this.Controls.Add(this.javniDogadjaj_box);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Rezevisi_BTN);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.Vrsta_CMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KreirajDogadjaj";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiraj događaj";
            this.Load += new System.EventHandler(this.KreirajDogadjaj_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DodatnaOprema_DGV)).EndInit();
            this.javniDogadjaj_box.ResumeLayout(false);
            this.javniDogadjaj_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plakat_PBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DodatnaOprema_DGV;
        private System.Windows.Forms.RadioButton NE_RDB;
        private System.Windows.Forms.RadioButton Da_RDB;
        private System.Windows.Forms.GroupBox javniDogadjaj_box;
        private System.Windows.Forms.PictureBox Plakat_PBX;
        private System.Windows.Forms.Button Slika_BTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Plakat_Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox BrojMijesta_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Cijena_Input;
        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.Button Rezevisi_BTN;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.ComboBox Vrsta_CMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DatumInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaOpremaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaUlaza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odabrano;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
    }
}