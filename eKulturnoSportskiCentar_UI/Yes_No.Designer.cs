namespace eKulturnoSportskiCentar_UI
{
    partial class Yes_No
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ne_BTN = new System.Windows.Forms.Button();
            this.Da_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Ne_BTN
            // 
            this.Ne_BTN.Location = new System.Drawing.Point(153, 66);
            this.Ne_BTN.Name = "Ne_BTN";
            this.Ne_BTN.Size = new System.Drawing.Size(100, 23);
            this.Ne_BTN.TabIndex = 2;
            this.Ne_BTN.Text = "NE";
            this.Ne_BTN.UseVisualStyleBackColor = true;
            this.Ne_BTN.Click += new System.EventHandler(this.Ne_BTN_Click);
            // 
            // Da_BTN
            // 
            this.Da_BTN.Location = new System.Drawing.Point(19, 66);
            this.Da_BTN.Name = "Da_BTN";
            this.Da_BTN.Size = new System.Drawing.Size(102, 23);
            this.Da_BTN.TabIndex = 3;
            this.Da_BTN.Text = "DA";
            this.Da_BTN.UseVisualStyleBackColor = true;
            this.Da_BTN.Click += new System.EventHandler(this.Da_BTN_Click);
            // 
            // Yes_No
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 113);
            this.Controls.Add(this.Da_BTN);
            this.Controls.Add(this.Ne_BTN);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Yes_No";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upozorenje!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ne_BTN;
        private System.Windows.Forms.Button Da_BTN;
    }
}