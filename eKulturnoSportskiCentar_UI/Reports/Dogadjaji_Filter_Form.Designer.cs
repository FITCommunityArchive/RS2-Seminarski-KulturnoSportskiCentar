namespace eKulturnoSportskiCentar_UI.Reports
{
    partial class Dogadjaji_Filter_Form
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
            this.PocetniDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Krajnji_Datum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sala_CMB = new System.Windows.Forms.ComboBox();
            this.Vrsta_CMB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KreirajIzvjestaj_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PocetniDatum
            // 
            this.PocetniDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PocetniDatum.Location = new System.Drawing.Point(119, 7);
            this.PocetniDatum.Name = "PocetniDatum";
            this.PocetniDatum.Size = new System.Drawing.Size(200, 20);
            this.PocetniDatum.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Početni datum:";
            // 
            // Krajnji_Datum
            // 
            this.Krajnji_Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Krajnji_Datum.Location = new System.Drawing.Point(421, 7);
            this.Krajnji_Datum.Name = "Krajnji_Datum";
            this.Krajnji_Datum.Size = new System.Drawing.Size(200, 20);
            this.Krajnji_Datum.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Krajnji datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sala:";
            // 
            // Sala_CMB
            // 
            this.Sala_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sala_CMB.FormattingEnabled = true;
            this.Sala_CMB.Location = new System.Drawing.Point(119, 52);
            this.Sala_CMB.Name = "Sala_CMB";
            this.Sala_CMB.Size = new System.Drawing.Size(121, 21);
            this.Sala_CMB.TabIndex = 37;
            // 
            // Vrsta_CMB
            // 
            this.Vrsta_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vrsta_CMB.FormattingEnabled = true;
            this.Vrsta_CMB.Location = new System.Drawing.Point(421, 52);
            this.Vrsta_CMB.Name = "Vrsta_CMB";
            this.Vrsta_CMB.Size = new System.Drawing.Size(156, 21);
            this.Vrsta_CMB.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Vrsta događaja:";
            // 
            // KreirajIzvjestaj_BTN
            // 
            this.KreirajIzvjestaj_BTN.Location = new System.Drawing.Point(658, 52);
            this.KreirajIzvjestaj_BTN.Name = "KreirajIzvjestaj_BTN";
            this.KreirajIzvjestaj_BTN.Size = new System.Drawing.Size(98, 23);
            this.KreirajIzvjestaj_BTN.TabIndex = 55;
            this.KreirajIzvjestaj_BTN.Text = "Kreiraj izvještaj";
            this.KreirajIzvjestaj_BTN.UseVisualStyleBackColor = true;
            this.KreirajIzvjestaj_BTN.Click += new System.EventHandler(this.KreirajIzvjestaj_BTN_Click);
            // 
            // Dogadjaji_Filter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 122);
            this.Controls.Add(this.KreirajIzvjestaj_BTN);
            this.Controls.Add(this.Vrsta_CMB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Krajnji_Datum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sala_CMB);
            this.Controls.Add(this.PocetniDatum);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dogadjaji_Filter_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogadjaji report";
            this.Load += new System.EventHandler(this.Dogadjaji_Filter_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PocetniDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Krajnji_Datum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Sala_CMB;
        private System.Windows.Forms.ComboBox Vrsta_CMB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KreirajIzvjestaj_BTN;
    }
}