namespace eKulturnoSportskiCentar_UI.Sala_UI
{
    partial class IndexSala
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
            this.label1 = new System.Windows.Forms.Label();
            this.Centar_CMB = new System.Windows.Forms.ComboBox();
            this.Sala_DGV = new System.Windows.Forms.DataGridView();
            this.SalaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Centar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sacuvaj_BTN = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Naziv_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sala_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Centar:";
            // 
            // Centar_CMB
            // 
            this.Centar_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Centar_CMB.FormattingEnabled = true;
            this.Centar_CMB.Location = new System.Drawing.Point(82, 35);
            this.Centar_CMB.Name = "Centar_CMB";
            this.Centar_CMB.Size = new System.Drawing.Size(213, 21);
            this.Centar_CMB.TabIndex = 8;
            this.Centar_CMB.SelectedIndexChanged += new System.EventHandler(this.Centar_CMB_SelectedIndexChanged);
            this.Centar_CMB.Validating += new System.ComponentModel.CancelEventHandler(this.Centar_CMB_Validating);
            // 
            // Sala_DGV
            // 
            this.Sala_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sala_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaID,
            this.Naziv,
            this.Centar});
            this.Sala_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sala_DGV.Location = new System.Drawing.Point(0, 83);
            this.Sala_DGV.Name = "Sala_DGV";
            this.Sala_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sala_DGV.Size = new System.Drawing.Size(419, 281);
            this.Sala_DGV.TabIndex = 7;
            this.Sala_DGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sala_DGV_CellContentDoubleClick);
            // 
            // SalaID
            // 
            this.SalaID.DataPropertyName = "SalaID";
            this.SalaID.HeaderText = "SalaID";
            this.SalaID.Name = "SalaID";
            this.SalaID.ReadOnly = true;
            this.SalaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Sala";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Centar
            // 
            this.Centar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Centar.DataPropertyName = "Centar";
            this.Centar.HeaderText = "Centar";
            this.Centar.Name = "Centar";
            this.Centar.ReadOnly = true;
            // 
            // Sacuvaj_BTN
            // 
            this.Sacuvaj_BTN.Location = new System.Drawing.Point(316, 12);
            this.Sacuvaj_BTN.Name = "Sacuvaj_BTN";
            this.Sacuvaj_BTN.Size = new System.Drawing.Size(91, 40);
            this.Sacuvaj_BTN.TabIndex = 13;
            this.Sacuvaj_BTN.Text = "Sačuvaj";
            this.Sacuvaj_BTN.UseVisualStyleBackColor = true;
            this.Sacuvaj_BTN.Click += new System.EventHandler(this.Sacuvaj_BTN_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Naziv_Input
            // 
            this.Naziv_Input.Location = new System.Drawing.Point(82, 9);
            this.Naziv_Input.Name = "Naziv_Input";
            this.Naziv_Input.Size = new System.Drawing.Size(213, 20);
            this.Naziv_Input.TabIndex = 26;
            this.Naziv_Input.Validating += new System.ComponentModel.CancelEventHandler(this.Naziv_Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Naziv:";
            // 
            // IndexSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 364);
            this.Controls.Add(this.Naziv_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sacuvaj_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Centar_CMB);
            this.Controls.Add(this.Sala_DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexSala";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.IndexSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sala_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Centar_CMB;
        private System.Windows.Forms.DataGridView Sala_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centar;
        private System.Windows.Forms.Button Sacuvaj_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox Naziv_Input;
        private System.Windows.Forms.Label label2;
    }
}