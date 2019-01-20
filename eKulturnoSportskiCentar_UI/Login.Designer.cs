namespace eKulturnoSportskiCentar_UI
{
    partial class Login
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
            this.Prijava_BTN = new System.Windows.Forms.Button();
            this.LozinkaInput = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KorisnickoImeInput = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(63, 99);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(75, 23);
            this.Odustani_BTN.TabIndex = 23;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Prijava_BTN
            // 
            this.Prijava_BTN.Location = new System.Drawing.Point(208, 99);
            this.Prijava_BTN.Name = "Prijava_BTN";
            this.Prijava_BTN.Size = new System.Drawing.Size(75, 23);
            this.Prijava_BTN.TabIndex = 22;
            this.Prijava_BTN.Text = "Prijava";
            this.Prijava_BTN.UseVisualStyleBackColor = true;
            this.Prijava_BTN.Click += new System.EventHandler(this.Prijava_BTN_Click);
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(135, 54);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(148, 20);
            this.LozinkaInput.TabIndex = 21;
            this.LozinkaInput.Text = "mirzasisic";
            this.LozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.LozinkaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lozinka:";
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(135, 15);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(148, 20);
            this.KorisnickoImeInput.TabIndex = 19;
            this.KorisnickoImeInput.Text = "mirzasisic";
            this.KorisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoImeInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Korisnicko ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 133);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Prijava_BTN);
            this.Controls.Add(this.LozinkaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.Button Prijava_BTN;
        private System.Windows.Forms.MaskedTextBox LozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox KorisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}