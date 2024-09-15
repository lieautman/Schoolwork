
namespace AbonatiTelefonici
{
    partial class FormMain_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_Admin));
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbonament = new System.Windows.Forms.Button();
            this.btnExtraOptiuni = new System.Windows.Forms.Button();
            this.btnTipAbonament = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayBazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipAbonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arataLogFileAngajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton1 = new User_Library.BackButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClient.Location = new System.Drawing.Point(97, 156);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(364, 153);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Formular &Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dati click pe butonul cu formularul ce trebuie completat!";
            // 
            // btnAbonament
            // 
            this.btnAbonament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbonament.Location = new System.Drawing.Point(552, 156);
            this.btnAbonament.Name = "btnAbonament";
            this.btnAbonament.Size = new System.Drawing.Size(364, 153);
            this.btnAbonament.TabIndex = 2;
            this.btnAbonament.Text = "Formular &Abonament";
            this.btnAbonament.UseVisualStyleBackColor = true;
            this.btnAbonament.Click += new System.EventHandler(this.btnAbonament_Click);
            // 
            // btnExtraOptiuni
            // 
            this.btnExtraOptiuni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExtraOptiuni.Location = new System.Drawing.Point(1006, 156);
            this.btnExtraOptiuni.Name = "btnExtraOptiuni";
            this.btnExtraOptiuni.Size = new System.Drawing.Size(364, 153);
            this.btnExtraOptiuni.TabIndex = 4;
            this.btnExtraOptiuni.Text = "Formular &ExtraOptiuni";
            this.btnExtraOptiuni.UseVisualStyleBackColor = true;
            this.btnExtraOptiuni.Click += new System.EventHandler(this.btnExtraOptiuni_Click);
            // 
            // btnTipAbonament
            // 
            this.btnTipAbonament.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTipAbonament.Location = new System.Drawing.Point(552, 386);
            this.btnTipAbonament.Name = "btnTipAbonament";
            this.btnTipAbonament.Size = new System.Drawing.Size(364, 153);
            this.btnTipAbonament.TabIndex = 5;
            this.btnTipAbonament.Text = "Formular &Tip Abonament";
            this.btnTipAbonament.UseVisualStyleBackColor = true;
            this.btnTipAbonament.Click += new System.EventHandler(this.btnTipAbonament_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayBazaDeDateToolStripMenuItem,
            this.arataLogFileAngajatiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1432, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayBazaDeDateToolStripMenuItem
            // 
            this.displayBazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.abonamentToolStripMenuItem,
            this.extraOptiuniToolStripMenuItem,
            this.tipAbonamentToolStripMenuItem});
            this.displayBazaDeDateToolStripMenuItem.Name = "displayBazaDeDateToolStripMenuItem";
            this.displayBazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.displayBazaDeDateToolStripMenuItem.Text = "Arata Baza de date";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // abonamentToolStripMenuItem
            // 
            this.abonamentToolStripMenuItem.Name = "abonamentToolStripMenuItem";
            this.abonamentToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.abonamentToolStripMenuItem.Text = "Abonament";
            this.abonamentToolStripMenuItem.Click += new System.EventHandler(this.abonamentToolStripMenuItem_Click);
            // 
            // extraOptiuniToolStripMenuItem
            // 
            this.extraOptiuniToolStripMenuItem.Name = "extraOptiuniToolStripMenuItem";
            this.extraOptiuniToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.extraOptiuniToolStripMenuItem.Text = "Extra optiuni";
            this.extraOptiuniToolStripMenuItem.Click += new System.EventHandler(this.extraOptiuniToolStripMenuItem_Click);
            // 
            // tipAbonamentToolStripMenuItem
            // 
            this.tipAbonamentToolStripMenuItem.Name = "tipAbonamentToolStripMenuItem";
            this.tipAbonamentToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.tipAbonamentToolStripMenuItem.Text = "Tip abonament";
            this.tipAbonamentToolStripMenuItem.Click += new System.EventHandler(this.tipAbonamentToolStripMenuItem_Click);
            // 
            // arataLogFileAngajatiToolStripMenuItem
            // 
            this.arataLogFileAngajatiToolStripMenuItem.Name = "arataLogFileAngajatiToolStripMenuItem";
            this.arataLogFileAngajatiToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.arataLogFileAngajatiToolStripMenuItem.Text = "Arata Log File Angajati";
            this.arataLogFileAngajatiToolStripMenuItem.Click += new System.EventHandler(this.arataLogFileAngajatiToolStripMenuItem_Click);
            // 
            // backButton1
            // 
            this.backButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton1.Location = new System.Drawing.Point(1239, 541);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(181, 52);
            this.backButton1.TabIndex = 7;
            // 
            // FormMain_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1432, 605);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.btnTipAbonament);
            this.Controls.Add(this.btnExtraOptiuni);
            this.Controls.Add(this.btnAbonament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain_Admin";
            this.Text = "Admin panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbonament;
        private System.Windows.Forms.Button btnExtraOptiuni;
        private System.Windows.Forms.Button btnTipAbonament;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayBazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraOptiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipAbonamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arataLogFileAngajatiToolStripMenuItem;
        private User_Library.BackButton backButton1;
    }
}