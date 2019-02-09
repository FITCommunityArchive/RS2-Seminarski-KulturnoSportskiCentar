namespace eKulturnoSportskiCentar_UI
{
    partial class MainForm
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opremaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatnaOpremaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogadjajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.terminiToolStripMenuItem.Text = "Termini";
            this.terminiToolStripMenuItem.Click += new System.EventHandler(this.terminiToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kSCToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.dogadjajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kSCToolStripMenuItem
            // 
            this.kSCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centriToolStripMenuItem,
            this.seleToolStripMenuItem,
            this.opremaToolStripMenuItem1,
            this.dodatnaOpremaToolStripMenuItem1});
            this.kSCToolStripMenuItem.Name = "kSCToolStripMenuItem";
            this.kSCToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.kSCToolStripMenuItem.Text = "Kulturno sportski centar";
            // 
            // centriToolStripMenuItem
            // 
            this.centriToolStripMenuItem.Name = "centriToolStripMenuItem";
            this.centriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centriToolStripMenuItem.Text = "Centri";
            this.centriToolStripMenuItem.Click += new System.EventHandler(this.centriToolStripMenuItem_Click);
            // 
            // seleToolStripMenuItem
            // 
            this.seleToolStripMenuItem.Name = "seleToolStripMenuItem";
            this.seleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seleToolStripMenuItem.Text = "Sele";
            this.seleToolStripMenuItem.Click += new System.EventHandler(this.seleToolStripMenuItem_Click);
            // 
            // opremaToolStripMenuItem1
            // 
            this.opremaToolStripMenuItem1.Name = "opremaToolStripMenuItem1";
            this.opremaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.opremaToolStripMenuItem1.Text = "Oprema";
            this.opremaToolStripMenuItem1.Click += new System.EventHandler(this.opremaToolStripMenuItem1_Click);
            // 
            // dodatnaOpremaToolStripMenuItem1
            // 
            this.dodatnaOpremaToolStripMenuItem1.Name = "dodatnaOpremaToolStripMenuItem1";
            this.dodatnaOpremaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dodatnaOpremaToolStripMenuItem1.Text = "Dodatna oprema";
            this.dodatnaOpremaToolStripMenuItem1.Click += new System.EventHandler(this.dodatnaOpremaToolStripMenuItem1_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // dogadjajiToolStripMenuItem
            // 
            this.dogadjajiToolStripMenuItem.Name = "dogadjajiToolStripMenuItem";
            this.dogadjajiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dogadjajiToolStripMenuItem.Text = "Događaji";
            this.dogadjajiToolStripMenuItem.Click += new System.EventHandler(this.dogadjajiToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 513);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main menu :: eKulturnoSportskiCentar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opremaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodatnaOpremaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dogadjajiToolStripMenuItem;
    }
}