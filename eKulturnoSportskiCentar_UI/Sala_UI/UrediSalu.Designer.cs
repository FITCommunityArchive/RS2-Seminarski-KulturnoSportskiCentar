namespace eKulturnoSportskiCentar_UI.Sala_UI
{
    partial class UrediSalu
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
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Centar_CMB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Odustani_BTN = new System.Windows.Forms.Button();
            this.Izmjeni_BTN = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(74, 31);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(152, 20);
            this.Naziv_Input.TabIndex = 18;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Naziv:";
            // 
            // Centar_CMB
            // 
            this.Centar_CMB.FormattingEnabled = true;
            this.Centar_CMB.Location = new System.Drawing.Point(74, 68);
            this.Centar_CMB.Name = "Centar_CMB";
            this.Centar_CMB.Size = new System.Drawing.Size(152, 21);
            this.Centar_CMB.TabIndex = 21;
            this.Centar_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Centar_CMB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Centar:";
            // 
            // Odustani_BTN
            // 
            this.Odustani_BTN.Location = new System.Drawing.Point(14, 122);
            this.Odustani_BTN.Name = "Odustani_BTN";
            this.Odustani_BTN.Size = new System.Drawing.Size(102, 31);
            this.Odustani_BTN.TabIndex = 23;
            this.Odustani_BTN.Text = "Odustani";
            this.Odustani_BTN.UseVisualStyleBackColor = true;
            this.Odustani_BTN.Click += new System.EventHandler(this.Odustani_BTN_Click);
            // 
            // Izmjeni_BTN
            // 
            this.Izmjeni_BTN.Location = new System.Drawing.Point(128, 122);
            this.Izmjeni_BTN.Name = "Izmjeni_BTN";
            this.Izmjeni_BTN.Size = new System.Drawing.Size(98, 31);
            this.Izmjeni_BTN.TabIndex = 20;
            this.Izmjeni_BTN.Text = "Izmjeni";
            this.Izmjeni_BTN.UseVisualStyleBackColor = true;
            this.Izmjeni_BTN.Click += new System.EventHandler(this.Izmjeni_BTN_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UrediSalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 174);
            this.Controls.Add(this.Centar_CMB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Odustani_BTN);
            this.Controls.Add(this.Izmjeni_BTN);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrediSalu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Salu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Centar_CMB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Odustani_BTN;
        private System.Windows.Forms.Button Izmjeni_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}