namespace Auto.view
{
    partial class MainMenuu
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDbconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_1 = new System.Windows.Forms.MenuStrip();
            this.labelll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Edellinen = new System.Windows.Forms.Button();
            this.Seuraava = new System.Windows.Forms.Button();
            this.Tallenna_nappi = new System.Windows.Forms.Button();
            this.Merkki_laatikko = new System.Windows.Forms.ComboBox();
            this.malli_laatikko = new System.Windows.Forms.ComboBox();
            this.Vari_laatikko = new System.Windows.Forms.ComboBox();
            this.Polttoaine_laatikko = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Uusi_tietue_nappi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Moottirintilavuus_text = new System.Windows.Forms.TextBox();
            this.Mittarilukema_Text = new System.Windows.Forms.TextBox();
            this.Moottori_text = new System.Windows.Forms.TextBox();
            this.Hinta_text = new System.Windows.Forms.TextBox();
            this.rekisteri_PVM = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNykyinenID = new System.Windows.Forms.Label();
            this.menu_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDbconnectionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 39);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testDbconnectionToolStripMenuItem
            // 
            this.testDbconnectionToolStripMenuItem.Name = "testDbconnectionToolStripMenuItem";
            this.testDbconnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.testDbconnectionToolStripMenuItem.Text = "Test dbconnection";
            this.testDbconnectionToolStripMenuItem.Click += new System.EventHandler(this.testDbconnectionToolStripMenuItem_Click);
            // 
            // menu_1
            // 
            this.menu_1.BackColor = System.Drawing.Color.Gray;
            this.menu_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu_1.Location = new System.Drawing.Point(0, 0);
            this.menu_1.Name = "menu_1";
            this.menu_1.Size = new System.Drawing.Size(623, 43);
            this.menu_1.TabIndex = 0;
            this.menu_1.Text = "Menu1";
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.BackColor = System.Drawing.Color.Transparent;
            this.labelll.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelll.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelll.Location = new System.Drawing.Point(93, 58);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(37, 20);
            this.labelll.TabIndex = 6;
            this.labelll.Text = "Merkki";
            this.labelll.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(96, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Malli";
            // 
            // Edellinen
            // 
            this.Edellinen.BackColor = System.Drawing.Color.White;
            this.Edellinen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edellinen.Location = new System.Drawing.Point(12, 322);
            this.Edellinen.Name = "Edellinen";
            this.Edellinen.Size = new System.Drawing.Size(75, 23);
            this.Edellinen.TabIndex = 12;
            this.Edellinen.Text = "Edellinen";
            this.Edellinen.UseVisualStyleBackColor = false;
            this.Edellinen.Click += new System.EventHandler(this.Edellinen_Click);
            // 
            // Seuraava
            // 
            this.Seuraava.BackColor = System.Drawing.Color.White;
            this.Seuraava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seuraava.Location = new System.Drawing.Point(93, 322);
            this.Seuraava.Margin = new System.Windows.Forms.Padding(0);
            this.Seuraava.Name = "Seuraava";
            this.Seuraava.Size = new System.Drawing.Size(75, 23);
            this.Seuraava.TabIndex = 13;
            this.Seuraava.Text = "Seuraava";
            this.Seuraava.UseVisualStyleBackColor = false;
            this.Seuraava.Click += new System.EventHandler(this.Seuraava_Click);
            // 
            // Tallenna_nappi
            // 
            this.Tallenna_nappi.BackColor = System.Drawing.Color.White;
            this.Tallenna_nappi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tallenna_nappi.Location = new System.Drawing.Point(174, 322);
            this.Tallenna_nappi.Name = "Tallenna_nappi";
            this.Tallenna_nappi.Size = new System.Drawing.Size(75, 23);
            this.Tallenna_nappi.TabIndex = 14;
            this.Tallenna_nappi.Text = "Tallenna";
            this.Tallenna_nappi.UseVisualStyleBackColor = false;
            this.Tallenna_nappi.Click += new System.EventHandler(this.Tallenna_nappi_Click);
            // 
            // Merkki_laatikko
            // 
            this.Merkki_laatikko.FormattingEnabled = true;
            this.Merkki_laatikko.Location = new System.Drawing.Point(136, 54);
            this.Merkki_laatikko.Name = "Merkki_laatikko";
            this.Merkki_laatikko.Size = new System.Drawing.Size(102, 21);
            this.Merkki_laatikko.TabIndex = 15;
            this.Merkki_laatikko.SelectedIndexChanged += new System.EventHandler(this.Malli_laatikko_haeMallit);
            this.Merkki_laatikko.SelectionChangeCommitted += new System.EventHandler(this.Malli_laatikko_haeMallit);
            // 
            // malli_laatikko
            // 
            this.malli_laatikko.FormattingEnabled = true;
            this.malli_laatikko.Location = new System.Drawing.Point(136, 81);
            this.malli_laatikko.Name = "malli_laatikko";
            this.malli_laatikko.Size = new System.Drawing.Size(102, 21);
            this.malli_laatikko.TabIndex = 16;
            // 
            // Vari_laatikko
            // 
            this.Vari_laatikko.FormattingEnabled = true;
            this.Vari_laatikko.Location = new System.Drawing.Point(136, 135);
            this.Vari_laatikko.Name = "Vari_laatikko";
            this.Vari_laatikko.Size = new System.Drawing.Size(102, 21);
            this.Vari_laatikko.TabIndex = 20;
            // 
            // Polttoaine_laatikko
            // 
            this.Polttoaine_laatikko.FormattingEnabled = true;
            this.Polttoaine_laatikko.Location = new System.Drawing.Point(136, 108);
            this.Polttoaine_laatikko.Name = "Polttoaine_laatikko";
            this.Polttoaine_laatikko.Size = new System.Drawing.Size(102, 21);
            this.Polttoaine_laatikko.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(100, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Väri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Polttoaine";
            // 
            // Uusi_tietue_nappi
            // 
            this.Uusi_tietue_nappi.BackColor = System.Drawing.Color.White;
            this.Uusi_tietue_nappi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uusi_tietue_nappi.Location = new System.Drawing.Point(255, 322);
            this.Uusi_tietue_nappi.Name = "Uusi_tietue_nappi";
            this.Uusi_tietue_nappi.Size = new System.Drawing.Size(75, 23);
            this.Uusi_tietue_nappi.TabIndex = 21;
            this.Uusi_tietue_nappi.Text = "Uusi tietue";
            this.Uusi_tietue_nappi.UseVisualStyleBackColor = false;
            this.Uusi_tietue_nappi.Click += new System.EventHandler(this.Uusi_tietue_nappi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(81, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hinta(,)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(11, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Moottorintilavuus(,)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(44, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mittarilukema";
            // 
            // Moottirintilavuus_text
            // 
            this.Moottirintilavuus_text.Location = new System.Drawing.Point(99, 189);
            this.Moottirintilavuus_text.Name = "Moottirintilavuus_text";
            this.Moottirintilavuus_text.Size = new System.Drawing.Size(102, 20);
            this.Moottirintilavuus_text.TabIndex = 27;
            this.Moottirintilavuus_text.TextChanged += new System.EventHandler(this.Moottirintilavuus_text_TextChanged);
            // 
            // Mittarilukema_Text
            // 
            this.Mittarilukema_Text.Location = new System.Drawing.Point(136, 162);
            this.Mittarilukema_Text.Name = "Mittarilukema_Text";
            this.Mittarilukema_Text.Size = new System.Drawing.Size(102, 20);
            this.Mittarilukema_Text.TabIndex = 25;
            this.Mittarilukema_Text.TextChanged += new System.EventHandler(this.Mittarilukema_Text_TextChanged);
            // 
            // Moottori_text
            // 
            this.Moottori_text.AccessibleName = "";
            this.Moottori_text.Location = new System.Drawing.Point(136, 188);
            this.Moottori_text.Name = "Moottori_text";
            this.Moottori_text.Size = new System.Drawing.Size(102, 20);
            this.Moottori_text.TabIndex = 26;
            this.Moottori_text.TextChanged += new System.EventHandler(this.Moottirintilavuus_text_TextChanged);
            // 
            // Hinta_text
            // 
            this.Hinta_text.Location = new System.Drawing.Point(136, 214);
            this.Hinta_text.Name = "Hinta_text";
            this.Hinta_text.Size = new System.Drawing.Size(102, 20);
            this.Hinta_text.TabIndex = 27;
            this.Hinta_text.TextChanged += new System.EventHandler(this.Hinta_Text_TextChanged);
            // 
            // rekisteri_PVM
            // 
            this.rekisteri_PVM.Location = new System.Drawing.Point(136, 240);
            this.rekisteri_PVM.Name = "rekisteri_PVM";
            this.rekisteri_PVM.Size = new System.Drawing.Size(194, 20);
            this.rekisteri_PVM.TabIndex = 28;
            this.rekisteri_PVM.ValueChanged += new System.EventHandler(this.rekisteri_PVM_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(45, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Rekisteri_pvm";
            // 
            // lbNykyinenID
            // 
            this.lbNykyinenID.AutoSize = true;
            this.lbNykyinenID.Location = new System.Drawing.Point(294, 58);
            this.lbNykyinenID.Name = "lbNykyinenID";
            this.lbNykyinenID.Size = new System.Drawing.Size(35, 13);
            this.lbNykyinenID.TabIndex = 30;
            this.lbNykyinenID.Text = "label8";
            // 
            // MainMenuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 357);
            this.Controls.Add(this.lbNykyinenID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rekisteri_PVM);
            this.Controls.Add(this.Hinta_text);
            this.Controls.Add(this.Moottori_text);
            this.Controls.Add(this.Mittarilukema_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Uusi_tietue_nappi);
            this.Controls.Add(this.Vari_laatikko);
            this.Controls.Add(this.Polttoaine_laatikko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.malli_laatikko);
            this.Controls.Add(this.Merkki_laatikko);
            this.Controls.Add(this.Tallenna_nappi);
            this.Controls.Add(this.Seuraava);
            this.Controls.Add(this.Edellinen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelll);
            this.Controls.Add(this.menu_1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menu_1;
            this.Name = "MainMenuu";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menu_1.ResumeLayout(false);
            this.menu_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDbconnectionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu_1;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Edellinen;
        private System.Windows.Forms.Button Seuraava;
        private System.Windows.Forms.Button Tallenna_nappi;
        private System.Windows.Forms.ComboBox Merkki_laatikko;
        private System.Windows.Forms.ComboBox malli_laatikko;
        private System.Windows.Forms.ComboBox Vari_laatikko;
        private System.Windows.Forms.ComboBox Polttoaine_laatikko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Uusi_tietue_nappi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox Moottirintilavuus_text;
        private System.Windows.Forms.TextBox Mittarilukema_Text;
        private System.Windows.Forms.TextBox Moottori_text;
        private System.Windows.Forms.TextBox Hinta_text;
        private System.Windows.Forms.DateTimePicker rekisteri_PVM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNykyinenID;
    }
}