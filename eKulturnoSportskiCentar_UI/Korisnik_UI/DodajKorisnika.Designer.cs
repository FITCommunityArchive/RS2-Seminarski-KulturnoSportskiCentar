namespace eKulturnoSportskiCentar_UI.Korisnik_UI
{
    partial class DodajKorisnika
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
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.DodajKorisnika_BTN = new System.Windows.Forms.Button();
            this.ulogeLista_CHB = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LozinkaInput = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KorisnickoImeInput = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrezimeInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImeInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(14, 382);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(100, 30);
            this.Odustani_BTN.TabIndex = 31;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // DodajKorisnika_BTN
            // 
            this.DodajKorisnika_BTN.Location = new System.Drawing.Point(170, 382);
            this.DodajKorisnika_BTN.Name = "DodajKorisnika_BTN";
            this.DodajKorisnika_BTN.Size = new System.Drawing.Size(100, 30);
            this.DodajKorisnika_BTN.TabIndex = 30;
            this.DodajKorisnika_BTN.Text = "Dodaj";
            this.DodajKorisnika_BTN.UseVisualStyleBackColor = true;
            this.DodajKorisnika_BTN.Click += new System.EventHandler(this.DodajKorisnika_BTN_Click);
            // 
            // ulogeLista_CHB
            // 
            this.ulogeLista_CHB.FormattingEnabled = true;
            this.ulogeLista_CHB.Location = new System.Drawing.Point(128, 262);
            this.ulogeLista_CHB.Name = "ulogeLista_CHB";
            this.ulogeLista_CHB.Size = new System.Drawing.Size(148, 94);
            this.ulogeLista_CHB.TabIndex = 29;
            this.ulogeLista_CHB.Validating += new System.ComponentModel.CancelEventHandler(this.ulogeLista_CHB_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Uloge:";
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(128, 208);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(148, 20);
            this.LozinkaInput.TabIndex = 27;
            this.LozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.LozinkaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Lozinka:";
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(128, 169);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(148, 20);
            this.KorisnickoImeInput.TabIndex = 25;
            this.KorisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoImeInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Korisnicko ime:";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(128, 130);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(148, 20);
            this.EmailInput.TabIndex = 23;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email:";
            // 
            // TelefonInput
            // 
            this.TelefonInput.Location = new System.Drawing.Point(128, 93);
            this.TelefonInput.Mask = "0000000000";
            this.TelefonInput.Name = "TelefonInput";
            this.TelefonInput.Size = new System.Drawing.Size(148, 20);
            this.TelefonInput.TabIndex = 21;
            this.TelefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon:";
            // 
            // PrezimeInput
            // 
            this.PrezimeInput.Location = new System.Drawing.Point(128, 56);
            this.PrezimeInput.Name = "PrezimeInput";
            this.PrezimeInput.Size = new System.Drawing.Size(148, 20);
            this.PrezimeInput.TabIndex = 19;
            this.PrezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prezime:";
            // 
            // ImeInput
            // 
            this.ImeInput.Location = new System.Drawing.Point(128, 19);
            this.ImeInput.Name = "ImeInput";
            this.ImeInput.Size = new System.Drawing.Size(148, 20);
            this.ImeInput.TabIndex = 17;
            this.ImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.ImeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 427);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.DodajKorisnika_BTN);
            this.Controls.Add(this.ulogeLista_CHB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LozinkaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelefonInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImeInput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajKorisnika";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Korisnika";
            this.Load += new System.EventHandler(this.DodajKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.Button DodajKorisnika_BTN;
        private System.Windows.Forms.CheckedListBox ulogeLista_CHB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox LozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox KorisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox EmailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TelefonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox PrezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ImeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}