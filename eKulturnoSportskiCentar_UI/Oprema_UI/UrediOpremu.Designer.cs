namespace eKulturnoSportskiCentar_UI.Oprema_UI
{
    partial class UrediOpremu
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Slika_PCB = new System.Windows.Forms.PictureBox();
            this.Slika_Input = new System.Windows.Forms.TextBox();
            this.DodajSliku_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Kolicina_Input = new System.Windows.Forms.MaskedTextBox();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.Izmjeni_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Slika_PCB
            // 
            this.Slika_PCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika_PCB.Location = new System.Drawing.Point(429, 31);
            this.Slika_PCB.Name = "Slika_PCB";
            this.Slika_PCB.Size = new System.Drawing.Size(333, 197);
            this.Slika_PCB.TabIndex = 59;
            this.Slika_PCB.TabStop = false;
            // 
            // Slika_Input
            // 
            this.Slika_Input.Location = new System.Drawing.Point(78, 109);
            this.Slika_Input.Name = "Slika_Input";
            this.Slika_Input.Size = new System.Drawing.Size(222, 20);
            this.Slika_Input.TabIndex = 51;
            // 
            // DodajSliku_BTN
            // 
            this.DodajSliku_BTN.Location = new System.Drawing.Point(326, 107);
            this.DodajSliku_BTN.Name = "DodajSliku_BTN";
            this.DodajSliku_BTN.Size = new System.Drawing.Size(40, 23);
            this.DodajSliku_BTN.TabIndex = 52;
            this.DodajSliku_BTN.Text = "...";
            this.DodajSliku_BTN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Slika:";
            // 
            // Kolicina_Input
            // 
            this.Kolicina_Input.Location = new System.Drawing.Point(77, 68);
            this.Kolicina_Input.Mask = "0000";
            this.Kolicina_Input.Name = "Kolicina_Input";
            this.Kolicina_Input.Size = new System.Drawing.Size(53, 20);
            this.Kolicina_Input.TabIndex = 49;
            this.Kolicina_Input.Text = "0000";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(195, 67);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(171, 21);
            this.Sala_CMB.TabIndex = 50;
            this.Sala_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Sala_CMB_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Količina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Sala:";
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(77, 31);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(289, 20);
            this.Naziv_Input.TabIndex = 48;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Naziv:";
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(25, 192);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(136, 36);
            this.Odustani_BTN.TabIndex = 54;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(237, 192);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(142, 36);
            this.Izmjeni_BTN.TabIndex = 53;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // UrediOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 260);
            this.Controls.Add(this.Slika_PCB);
            this.Controls.Add(this.Slika_Input);
            this.Controls.Add(this.DodajSliku_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kolicina_Input);
            this.Controls.Add(this.Sala_CMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Izmjeni_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrediOpremu";
            this.ShowIcon = false;
            this.Text = "Uredi opremu";
            this.Load += new System.EventHandler(this.UrediOpremu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox Slika_PCB;
        private System.Windows.Forms.TextBox Slika_Input;
        private System.Windows.Forms.Button DodajSliku_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Kolicina_Input;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.Button Izmjeni_BTN;
    }
}