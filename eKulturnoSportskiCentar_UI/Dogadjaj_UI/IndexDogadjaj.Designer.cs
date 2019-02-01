namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    partial class IndexDogadjaj
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
            this.Administracija_BTN = new System.Windows.Forms.Button();
            this.Javni_BTN = new System.Windows.Forms.Button();
            this.GoingEvents = new System.Windows.Forms.Button();
            this.Vlastiti_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reports_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Administracija_BTN
            // 
            this.Administracija_BTN.Location = new System.Drawing.Point(37, 74);
            this.Administracija_BTN.Name = "Administracija_BTN";
            this.Administracija_BTN.Size = new System.Drawing.Size(106, 38);
            this.Administracija_BTN.TabIndex = 0;
            this.Administracija_BTN.Text = "Administracija događaja";
            this.Administracija_BTN.UseVisualStyleBackColor = true;
            this.Administracija_BTN.Click += new System.EventHandler(this.Administracija_BTN_Click);
            // 
            // Javni_BTN
            // 
            this.Javni_BTN.Location = new System.Drawing.Point(168, 74);
            this.Javni_BTN.Name = "Javni_BTN";
            this.Javni_BTN.Size = new System.Drawing.Size(106, 38);
            this.Javni_BTN.TabIndex = 1;
            this.Javni_BTN.Text = "Javni događaji";
            this.Javni_BTN.UseVisualStyleBackColor = true;
            this.Javni_BTN.Click += new System.EventHandler(this.Javni_BTN_Click);
            // 
            // GoingEvents
            // 
            this.GoingEvents.Location = new System.Drawing.Point(168, 131);
            this.GoingEvents.Name = "GoingEvents";
            this.GoingEvents.Size = new System.Drawing.Size(106, 38);
            this.GoingEvents.TabIndex = 2;
            this.GoingEvents.Text = "Događaji za posjetiti";
            this.GoingEvents.UseVisualStyleBackColor = true;
            this.GoingEvents.Click += new System.EventHandler(this.GoingEvents_Click);
            // 
            // Vlastiti_BTN
            // 
            this.Vlastiti_BTN.Location = new System.Drawing.Point(37, 131);
            this.Vlastiti_BTN.Name = "Vlastiti_BTN";
            this.Vlastiti_BTN.Size = new System.Drawing.Size(106, 38);
            this.Vlastiti_BTN.TabIndex = 3;
            this.Vlastiti_BTN.Text = "Vlastiti događaji";
            this.Vlastiti_BTN.UseVisualStyleBackColor = true;
            this.Vlastiti_BTN.Click += new System.EventHandler(this.Vlastiti_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Događaji";
            // 
            // Reports_BTN
            // 
            this.Reports_BTN.Location = new System.Drawing.Point(104, 184);
            this.Reports_BTN.Name = "Reports_BTN";
            this.Reports_BTN.Size = new System.Drawing.Size(106, 38);
            this.Reports_BTN.TabIndex = 5;
            this.Reports_BTN.Text = "Reports";
            this.Reports_BTN.UseVisualStyleBackColor = true;
            this.Reports_BTN.Click += new System.EventHandler(this.Reports_BTN_Click);
            // 
            // IndexDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 244);
            this.Controls.Add(this.Reports_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vlastiti_BTN);
            this.Controls.Add(this.GoingEvents);
            this.Controls.Add(this.Javni_BTN);
            this.Controls.Add(this.Administracija_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexDogadjaj";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogadjaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Administracija_BTN;
        private System.Windows.Forms.Button Javni_BTN;
        private System.Windows.Forms.Button GoingEvents;
        private System.Windows.Forms.Button Vlastiti_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reports_BTN;
    }
}