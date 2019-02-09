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
            this.components = new System.ComponentModel.Container();
            this.Centar_DGV = new System.Windows.Forms.DataGridView();
            this.CentarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NazivInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Sacuvaj_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Centar_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.Centar_DGV.Location = new System.Drawing.Point(0, 151);
            this.Centar_DGV.Name = "Centar_DGV";
            this.Centar_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Centar_DGV.Size = new System.Drawing.Size(608, 453);
            this.Centar_DGV.TabIndex = 8;
            this.Centar_DGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Centar_DGV_CellContentDoubleClick);
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
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // AdresaInput
            // 
            this.AdresaInput.Location = new System.Drawing.Point(89, 57);
            this.AdresaInput.Name = "AdresaInput";
            this.AdresaInput.Size = new System.Drawing.Size(164, 20);
            this.AdresaInput.TabIndex = 28;
            this.AdresaInput.Validating += new System.ComponentModel.CancelEventHandler(this.AdresaInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Adresa: ";
            // 
            // TelefonInput
            // 
            this.TelefonInput.Location = new System.Drawing.Point(357, 21);
            this.TelefonInput.Mask = "0000000000";
            this.TelefonInput.Name = "TelefonInput";
            this.TelefonInput.Size = new System.Drawing.Size(164, 20);
            this.TelefonInput.TabIndex = 30;
            this.TelefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonInput_Validating_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Telefon:";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(357, 60);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(164, 20);
            this.EmailInput.TabIndex = 31;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Email:";
            // 
            // NazivInput
            // 
            this.NazivInput.Location = new System.Drawing.Point(89, 21);
            this.NazivInput.Name = "NazivInput";
            this.NazivInput.Size = new System.Drawing.Size(164, 20);
            this.NazivInput.TabIndex = 27;
            this.NazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naziv: ";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Sacuvaj_BTN
            // 
            this.Sacuvaj_BTN.Location = new System.Drawing.Point(410, 99);
            this.Sacuvaj_BTN.Name = "Sacuvaj_BTN";
            this.Sacuvaj_BTN.Size = new System.Drawing.Size(132, 40);
            this.Sacuvaj_BTN.TabIndex = 35;
            this.Sacuvaj_BTN.Text = "Sačuvaj";
            this.Sacuvaj_BTN.UseVisualStyleBackColor = true;
            this.Sacuvaj_BTN.Click += new System.EventHandler(this.Sacuvaj_BTN_Click);
            // 
            // IndexCentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 604);
            this.Controls.Add(this.Sacuvaj_BTN);
            this.Controls.Add(this.AdresaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelefonInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NazivInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Centar_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexCentar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centar";
            this.Load += new System.EventHandler(this.IndexCentar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Centar_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Centar_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.MaskedTextBox AdresaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TelefonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox EmailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Sacuvaj_BTN;
    }
}