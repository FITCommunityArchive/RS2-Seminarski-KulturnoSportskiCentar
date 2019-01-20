namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class OcjeniDogadjaj
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ocijeni_BTN = new System.Windows.Forms.Button();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.Ocjene_CMB = new System.Windows.Forms.ComboBox();
            this.Korisnik_Input = new System.Windows.Forms.TextBox();
            this.Dogadjaj_Input = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Korisnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ocjena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Događaj:";
            // 
            // Ocijeni_BTN
            // 
            this.Ocijeni_BTN.Location = new System.Drawing.Point(154, 130);
            this.Ocijeni_BTN.Name = "Ocijeni_BTN";
            this.Ocijeni_BTN.Size = new System.Drawing.Size(111, 23);
            this.Ocijeni_BTN.TabIndex = 13;
            this.Ocijeni_BTN.Text = "Ocijeni";
            this.Ocijeni_BTN.UseVisualStyleBackColor = true;
            this.Ocijeni_BTN.Click += new System.EventHandler(this.Ocijeni_BTN_Click);
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(30, 130);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(99, 23);
            this.Odustani_BTN.TabIndex = 12;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Ocjene_CMB
            // 
            this.Ocjene_CMB.FormattingEnabled = true;
            this.Ocjene_CMB.Location = new System.Drawing.Point(92, 84);
            this.Ocjene_CMB.Name = "Ocjene_CMB";
            this.Ocjene_CMB.Size = new System.Drawing.Size(185, 21);
            this.Ocjene_CMB.TabIndex = 11;
            this.Ocjene_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Ocjene_CMB_Validating);
            // 
            // Korisnik_Input
            // 
            this.Korisnik_Input.Location = new System.Drawing.Point(92, 49);
            this.Korisnik_Input.Name = "Korisnik_Input";
            this.Korisnik_Input.ReadOnly = true;
            this.Korisnik_Input.Size = new System.Drawing.Size(185, 20);
            this.Korisnik_Input.TabIndex = 10;
            // 
            // Dogadjaj_Input
            // 
            this.Dogadjaj_Input.Location = new System.Drawing.Point(92, 14);
            this.Dogadjaj_Input.Name = "Dogadjaj_Input";
            this.Dogadjaj_Input.ReadOnly = true;
            this.Dogadjaj_Input.Size = new System.Drawing.Size(185, 20);
            this.Dogadjaj_Input.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OcjeniDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ocijeni_BTN);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Ocjene_CMB);
            this.Controls.Add(this.Korisnik_Input);
            this.Controls.Add(this.Dogadjaj_Input);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OcjeniDogadjaj";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocjeni Dogadjaj";
            this.Load += new System.EventHandler(this.OcjeniDogadjaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ocijeni_BTN;
        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.ComboBox Ocjene_CMB;
        private System.Windows.Forms.TextBox Korisnik_Input;
        private System.Windows.Forms.TextBox Dogadjaj_Input;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}