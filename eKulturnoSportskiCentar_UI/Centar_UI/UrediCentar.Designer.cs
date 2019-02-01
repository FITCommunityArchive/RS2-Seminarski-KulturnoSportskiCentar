namespace eKulturnoSportskiCentar_UI.Centar_UI
{
    partial class UrediCentar
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
            this.AdresaInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NazivInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Uredi_BTN = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(24, 162);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(87, 32);
            this.Odustani_BTN.TabIndex = 27;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // AdresaInput
            // 
            this.AdresaInput.Location = new System.Drawing.Point(87, 45);
            this.AdresaInput.Name = "AdresaInput";
            this.AdresaInput.Size = new System.Drawing.Size(164, 20);
            this.AdresaInput.TabIndex = 19;
            this.AdresaInput.Validating += new System.ComponentModel.CancelEventHandler(this.AdresaInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Adresa: ";
            // 
            // TelefonInput
            // 
            this.TelefonInput.Location = new System.Drawing.Point(87, 84);
            this.TelefonInput.Mask = "0000000000";
            this.TelefonInput.Name = "TelefonInput";
            this.TelefonInput.Size = new System.Drawing.Size(164, 20);
            this.TelefonInput.TabIndex = 21;
            this.TelefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefon:";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(87, 123);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(164, 20);
            this.EmailInput.TabIndex = 22;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email:";
            // 
            // NazivInput
            // 
            this.NazivInput.Location = new System.Drawing.Point(87, 9);
            this.NazivInput.Name = "NazivInput";
            this.NazivInput.Size = new System.Drawing.Size(164, 20);
            this.NazivInput.TabIndex = 18;
            this.NazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naziv: ";
            // 
            // Uredi_BTN
            // 
            this.Uredi_BTN.Location = new System.Drawing.Point(165, 162);
            this.Uredi_BTN.Name = "Uredi_BTN";
            this.Uredi_BTN.Size = new System.Drawing.Size(86, 32);
            this.Uredi_BTN.TabIndex = 24;
            this.Uredi_BTN.Text = "Uredi";
            this.Uredi_BTN.UseVisualStyleBackColor = true;
            this.Uredi_BTN.Click += new System.EventHandler(this.Uredi_BTN_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UrediCentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 218);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.AdresaInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelefonInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NazivInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uredi_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrediCentar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Centar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.MaskedTextBox AdresaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TelefonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox EmailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Uredi_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}