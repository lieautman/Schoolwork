
namespace AbonatiTelefonici
{
    partial class FormMain_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_Manager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayBazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipAbonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTipAbonament = new System.Windows.Forms.Button();
            this.btnExtraOptiuni = new System.Windows.Forms.Button();
            this.btnAbonament = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.backButton1 = new User_Library.BackButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayBazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1587, 28);
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
            this.displayBazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.displayBazaDeDateToolStripMenuItem.Text = "Display Baza de date";
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
            // btnTipAbonament
            // 
            this.btnTipAbonament.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTipAbonament.Location = new System.Drawing.Point(595, 460);
            this.btnTipAbonament.Name = "btnTipAbonament";
            this.btnTipAbonament.Size = new System.Drawing.Size(380, 148);
            this.btnTipAbonament.TabIndex = 11;
            this.btnTipAbonament.Text = "Formular &Tip Abonament";
            this.btnTipAbonament.UseVisualStyleBackColor = true;
            this.btnTipAbonament.Click += new System.EventHandler(this.btnTipAbonament_Click);
            // 
            // btnExtraOptiuni
            // 
            this.btnExtraOptiuni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExtraOptiuni.Location = new System.Drawing.Point(1109, 248);
            this.btnExtraOptiuni.Name = "btnExtraOptiuni";
            this.btnExtraOptiuni.Size = new System.Drawing.Size(380, 148);
            this.btnExtraOptiuni.TabIndex = 10;
            this.btnExtraOptiuni.Text = "Formular &ExtraOptiuni";
            this.btnExtraOptiuni.UseVisualStyleBackColor = true;
            this.btnExtraOptiuni.Click += new System.EventHandler(this.btnExtraOptiuni_Click);
            // 
            // btnAbonament
            // 
            this.btnAbonament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbonament.Location = new System.Drawing.Point(595, 248);
            this.btnAbonament.Name = "btnAbonament";
            this.btnAbonament.Size = new System.Drawing.Size(380, 148);
            this.btnAbonament.TabIndex = 9;
            this.btnAbonament.Text = "Formular &Abonament";
            this.btnAbonament.UseVisualStyleBackColor = true;
            this.btnAbonament.Click += new System.EventHandler(this.btnAbonament_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dati click pe butonul cu formularul ce trebuie completat!";
            // 
            // btnClient
            // 
            this.btnClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClient.Location = new System.Drawing.Point(81, 248);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(380, 148);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "Formular &Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // backButton1
            // 
            this.backButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton1.Location = new System.Drawing.Point(1394, 644);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(181, 52);
            this.backButton1.TabIndex = 12;
            // 
            // FormMain_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1587, 708);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.btnTipAbonament);
            this.Controls.Add(this.btnExtraOptiuni);
            this.Controls.Add(this.btnAbonament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain_Manager";
            this.Text = "Manager panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayBazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraOptiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipAbonamentToolStripMenuItem;
        private System.Windows.Forms.Button btnTipAbonament;
        private System.Windows.Forms.Button btnExtraOptiuni;
        private System.Windows.Forms.Button btnAbonament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private User_Library.BackButton backButton1;
    }
}