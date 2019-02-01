namespace eKulturnoSportskiCentar_UI.Sala_UI
{
    partial class DodajSalu
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
            this.Centar_CMB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dodaj_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Centar_CMB
            // 
            this.Centar_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Centar_CMB.FormattingEnabled = true;
            this.Centar_CMB.Location = new System.Drawing.Point(73, 49);
            this.Centar_CMB.Name = "Centar_CMB";
            this.Centar_CMB.Size = new System.Drawing.Size(152, 21);
            this.Centar_CMB.TabIndex = 27;
            this.Centar_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Centar_CMB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Centar:";
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(13, 103);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(102, 31);
            this.Odustani_BTN.TabIndex = 29;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(73, 12);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(152, 20);
            this.Naziv_Input.TabIndex = 24;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Naziv:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Dodaj_BTN
            // 
            this.Dodaj_BTN.Location = new System.Drawing.Point(132, 103);
            this.Dodaj_BTN.Name = "Dodaj_BTN";
            this.Dodaj_BTN.Size = new System.Drawing.Size(105, 31);
            this.Dodaj_BTN.TabIndex = 30;
            this.Dodaj_BTN.Text = "Dodaj";
            this.Dodaj_BTN.UseVisualStyleBackColor = true;
            this.Dodaj_BTN.Click += new System.EventHandler(this.Dodaj_BTN_Click);
            // 
            // DodajSalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 146);
            this.Controls.Add(this.Dodaj_BTN);
            this.Controls.Add(this.Centar_CMB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajSalu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Salu";
            this.Load += new System.EventHandler(this.DodajSalu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Centar_CMB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Dodaj_BTN;
    }
}