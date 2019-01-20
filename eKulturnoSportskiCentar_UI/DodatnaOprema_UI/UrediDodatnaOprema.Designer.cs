namespace eKulturnoSportskiCentar_UI.DodatnaOprema_UI
{
    partial class UrediDodatnaOprema
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
            this.Cijena_Input = new System.Windows.Forms.MaskedTextBox();
            this.Slika_PCB = new System.Windows.Forms.PictureBox();
            this.Slika_Input = new System.Windows.Forms.TextBox();
            this.DodajSliku_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.Izmjeni_BTN = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Cijena_Input
            // 
            this.Cijena_Input.Location = new System.Drawing.Point(69, 63);
            this.Cijena_Input.Mask = "000,00";
            this.Cijena_Input.Name = "Cijena_Input";
            this.Cijena_Input.Size = new System.Drawing.Size(93, 20);
            this.Cijena_Input.TabIndex = 61;
            this.Cijena_Input.Text = "00000";
            // 
            // Slika_PCB
            // 
            this.Slika_PCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika_PCB.Location = new System.Drawing.Point(333, 12);
            this.Slika_PCB.Name = "Slika_PCB";
            this.Slika_PCB.Size = new System.Drawing.Size(305, 185);
            this.Slika_PCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Slika_PCB.TabIndex = 69;
            this.Slika_PCB.TabStop = false;
            // 
            // Slika_Input
            // 
            this.Slika_Input.Location = new System.Drawing.Point(69, 104);
            this.Slika_Input.Name = "Slika_Input";
            this.Slika_Input.Size = new System.Drawing.Size(187, 20);
            this.Slika_Input.TabIndex = 62;
            // 
            // DodajSliku_BTN
            // 
            this.DodajSliku_BTN.Location = new System.Drawing.Point(262, 104);
            this.DodajSliku_BTN.Name = "DodajSliku_BTN";
            this.DodajSliku_BTN.Size = new System.Drawing.Size(41, 23);
            this.DodajSliku_BTN.TabIndex = 63;
            this.DodajSliku_BTN.Text = "...";
            this.DodajSliku_BTN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Slika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Cijena:";
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(69, 23);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(234, 20);
            this.Naziv_Input.TabIndex = 60;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Naziv:";
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(17, 161);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(121, 36);
            this.Odustani_BTN.TabIndex = 64;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(174, 161);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(129, 36);
            this.Izmjeni_BTN.TabIndex = 65;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UrediDodatnaOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 242);
            this.Controls.Add(this.Cijena_Input);
            this.Controls.Add(this.Slika_PCB);
            this.Controls.Add(this.Slika_Input);
            this.Controls.Add(this.DodajSliku_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Izmjeni_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrediDodatnaOprema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi dodatna oprema";
            this.Load += new System.EventHandler(this.UrediDodatnaOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Cijena_Input;
        private System.Windows.Forms.PictureBox Slika_PCB;
        private System.Windows.Forms.TextBox Slika_Input;
        private System.Windows.Forms.Button DodajSliku_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.Button Izmjeni_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}