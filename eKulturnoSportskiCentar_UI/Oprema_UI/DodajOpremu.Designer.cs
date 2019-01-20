namespace eKulturnoSportskiCentar_UI.Oprema_UI
{
    partial class DodajOpremu
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
            this.Dodaj_BTN = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Slika_PCB
            // 
            this.Slika_PCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika_PCB.Location = new System.Drawing.Point(427, 21);
            this.Slika_PCB.Name = "Slika_PCB";
            this.Slika_PCB.Size = new System.Drawing.Size(333, 197);
            this.Slika_PCB.TabIndex = 47;
            this.Slika_PCB.TabStop = false;
            // 
            // Slika_Input
            // 
            this.Slika_Input.Location = new System.Drawing.Point(76, 99);
            this.Slika_Input.Name = "Slika_Input";
            this.Slika_Input.Size = new System.Drawing.Size(222, 20);
            this.Slika_Input.TabIndex = 39;
            // 
            // DodajSliku_BTN
            // 
            this.DodajSliku_BTN.Location = new System.Drawing.Point(324, 97);
            this.DodajSliku_BTN.Name = "DodajSliku_BTN";
            this.DodajSliku_BTN.Size = new System.Drawing.Size(40, 23);
            this.DodajSliku_BTN.TabIndex = 40;
            this.DodajSliku_BTN.Text = "...";
            this.DodajSliku_BTN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Slika:";
            // 
            // Kolicina_Input
            // 
            this.Kolicina_Input.Location = new System.Drawing.Point(75, 58);
            this.Kolicina_Input.Mask = "0000";
            this.Kolicina_Input.Name = "Kolicina_Input";
            this.Kolicina_Input.Size = new System.Drawing.Size(53, 20);
            this.Kolicina_Input.TabIndex = 37;
            this.Kolicina_Input.Text = "0000";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(193, 57);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(171, 21);
            this.Sala_CMB.TabIndex = 38;
            this.Sala_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Sala_CMB_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Količina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Sala:";
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(75, 21);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(289, 20);
            this.Naziv_Input.TabIndex = 36;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Naziv:";
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(23, 182);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(136, 36);
            this.Odustani_BTN.TabIndex = 42;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Dodaj_BTN
            // 
            this.Dodaj_BTN.Location = new System.Drawing.Point(235, 182);
            this.Dodaj_BTN.Name = "Dodaj_BTN";
            this.Dodaj_BTN.Size = new System.Drawing.Size(142, 36);
            this.Dodaj_BTN.TabIndex = 41;
            this.Dodaj_BTN.Text = "Dodaj";
            this.Dodaj_BTN.UseVisualStyleBackColor = true;
            this.Dodaj_BTN.Click += new System.EventHandler(this.Dodaj_BTN_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DodajOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 240);
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
            this.Controls.Add(this.Dodaj_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajOpremu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Opremu";
            this.Load += new System.EventHandler(this.DodajOpremu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slika_PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button Dodaj_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}