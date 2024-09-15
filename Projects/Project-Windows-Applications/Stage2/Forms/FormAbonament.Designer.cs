
namespace AbonatiTelefonici
{
    partial class FormAbonament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbonament));
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelNrOrdineClient = new System.Windows.Forms.Label();
            this.labelTipAbonament = new System.Windows.Forms.Label();
            this.cbTipAbonament = new System.Windows.Forms.ComboBox();
            this.btnSalvareClient = new System.Windows.Forms.Button();
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNrOrdineClient = new System.Windows.Forms.ComboBox();
            this.labelNrOrdineAbonament = new System.Windows.Forms.Label();
            this.tbNrOrdineAbonament = new System.Windows.Forms.TextBox();
            this.dgvBdTipAbonament = new System.Windows.Forms.DataGridView();
            this.labelTipAbonamentBD = new System.Windows.Forms.Label();
            this.dgvBdClienti = new System.Windows.Forms.DataGridView();
            this.labelClientiBD = new System.Windows.Forms.Label();
            this.backButton2 = new User_Library.BackButton();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdTipAbonament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(132, 93);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(208, 17);
            this.labelTitlu.TabIndex = 4;
            this.labelTitlu.Text = "Completati campurile urmatoare";
            // 
            // labelNrOrdineClient
            // 
            this.labelNrOrdineClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNrOrdineClient.AutoSize = true;
            this.labelNrOrdineClient.Location = new System.Drawing.Point(73, 218);
            this.labelNrOrdineClient.Name = "labelNrOrdineClient";
            this.labelNrOrdineClient.Size = new System.Drawing.Size(131, 17);
            this.labelNrOrdineClient.TabIndex = 5;
            this.labelNrOrdineClient.Text = "Numar ordine client";
            // 
            // labelTipAbonament
            // 
            this.labelTipAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTipAbonament.AutoSize = true;
            this.labelTipAbonament.Location = new System.Drawing.Point(73, 280);
            this.labelTipAbonament.Name = "labelTipAbonament";
            this.labelTipAbonament.Size = new System.Drawing.Size(137, 17);
            this.labelTipAbonament.TabIndex = 6;
            this.labelTipAbonament.Text = "Tipul Abonamentului";
            // 
            // cbTipAbonament
            // 
            this.cbTipAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipAbonament.FormattingEnabled = true;
            this.cbTipAbonament.Location = new System.Drawing.Point(308, 285);
            this.cbTipAbonament.Name = "cbTipAbonament";
            this.cbTipAbonament.Size = new System.Drawing.Size(124, 24);
            this.cbTipAbonament.TabIndex = 2;
            // 
            // btnSalvareClient
            // 
            this.btnSalvareClient.Location = new System.Drawing.Point(128, 343);
            this.btnSalvareClient.Name = "btnSalvareClient";
            this.btnSalvareClient.Size = new System.Drawing.Size(162, 57);
            this.btnSalvareClient.TabIndex = 3;
            this.btnSalvareClient.Text = "Salveaza";
            this.btnSalvareClient.UseVisualStyleBackColor = true;
            this.btnSalvareClient.Click += new System.EventHandler(this.btnSalvareClient_Click);
            // 
            // epNecompletat
            // 
            this.epNecompletat.ContainerControl = this;
            // 
            // cbNrOrdineClient
            // 
            this.cbNrOrdineClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbNrOrdineClient.FormattingEnabled = true;
            this.cbNrOrdineClient.Location = new System.Drawing.Point(308, 218);
            this.cbNrOrdineClient.Name = "cbNrOrdineClient";
            this.cbNrOrdineClient.Size = new System.Drawing.Size(124, 24);
            this.cbNrOrdineClient.TabIndex = 1;
            // 
            // labelNrOrdineAbonament
            // 
            this.labelNrOrdineAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNrOrdineAbonament.AutoSize = true;
            this.labelNrOrdineAbonament.Location = new System.Drawing.Point(73, 156);
            this.labelNrOrdineAbonament.Name = "labelNrOrdineAbonament";
            this.labelNrOrdineAbonament.Size = new System.Drawing.Size(169, 17);
            this.labelNrOrdineAbonament.TabIndex = 27;
            this.labelNrOrdineAbonament.Text = "Numar ordine abonament";
            // 
            // tbNrOrdineAbonament
            // 
            this.tbNrOrdineAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNrOrdineAbonament.Location = new System.Drawing.Point(308, 153);
            this.tbNrOrdineAbonament.Name = "tbNrOrdineAbonament";
            this.tbNrOrdineAbonament.ReadOnly = true;
            this.tbNrOrdineAbonament.Size = new System.Drawing.Size(124, 22);
            this.tbNrOrdineAbonament.TabIndex = 0;
            // 
            // dgvBdTipAbonament
            // 
            this.dgvBdTipAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBdTipAbonament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdTipAbonament.Location = new System.Drawing.Point(532, 37);
            this.dgvBdTipAbonament.Name = "dgvBdTipAbonament";
            this.dgvBdTipAbonament.RowHeadersWidth = 51;
            this.dgvBdTipAbonament.RowTemplate.Height = 24;
            this.dgvBdTipAbonament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdTipAbonament.Size = new System.Drawing.Size(958, 325);
            this.dgvBdTipAbonament.TabIndex = 28;
            this.dgvBdTipAbonament.DoubleClick += new System.EventHandler(this.dgvBdAbonament_DoubleClick);
            // 
            // labelTipAbonamentBD
            // 
            this.labelTipAbonamentBD.AutoSize = true;
            this.labelTipAbonamentBD.Location = new System.Drawing.Point(554, 17);
            this.labelTipAbonamentBD.Name = "labelTipAbonamentBD";
            this.labelTipAbonamentBD.Size = new System.Drawing.Size(194, 17);
            this.labelTipAbonamentBD.TabIndex = 29;
            this.labelTipAbonamentBD.Text = "Baza de date tip abonamente";
            // 
            // dgvBdClienti
            // 
            this.dgvBdClienti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBdClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdClienti.Location = new System.Drawing.Point(532, 385);
            this.dgvBdClienti.Name = "dgvBdClienti";
            this.dgvBdClienti.RowHeadersWidth = 51;
            this.dgvBdClienti.RowTemplate.Height = 24;
            this.dgvBdClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdClienti.Size = new System.Drawing.Size(958, 325);
            this.dgvBdClienti.TabIndex = 30;
            this.dgvBdClienti.DoubleClick += new System.EventHandler(this.dgvBdClienti_DoubleClick);
            // 
            // labelClientiBD
            // 
            this.labelClientiBD.AutoSize = true;
            this.labelClientiBD.Location = new System.Drawing.Point(554, 365);
            this.labelClientiBD.Name = "labelClientiBD";
            this.labelClientiBD.Size = new System.Drawing.Size(132, 17);
            this.labelClientiBD.TabIndex = 31;
            this.labelClientiBD.Text = "Baza de date clienti";
            // 
            // backButton2
            // 
            this.backButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton2.Location = new System.Drawing.Point(1271, 746);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(219, 60);
            this.backButton2.TabIndex = 49;
            this.backButton2.Load += new System.EventHandler(this.backButton2_Load);
            // 
            // FormAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1518, 818);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.labelClientiBD);
            this.Controls.Add(this.dgvBdClienti);
            this.Controls.Add(this.labelTipAbonamentBD);
            this.Controls.Add(this.tbNrOrdineAbonament);
            this.Controls.Add(this.labelNrOrdineAbonament);
            this.Controls.Add(this.cbNrOrdineClient);
            this.Controls.Add(this.btnSalvareClient);
            this.Controls.Add(this.cbTipAbonament);
            this.Controls.Add(this.labelTipAbonament);
            this.Controls.Add(this.labelNrOrdineClient);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.dgvBdTipAbonament);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbonament";
            this.Text = "FormAbonament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdTipAbonament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelNrOrdineClient;
        private System.Windows.Forms.Label labelTipAbonament;
        private System.Windows.Forms.ComboBox cbTipAbonament;
        private System.Windows.Forms.Button btnSalvareClient;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.ComboBox cbNrOrdineClient;
        private System.Windows.Forms.TextBox tbNrOrdineAbonament;
        private System.Windows.Forms.Label labelNrOrdineAbonament;
        private System.Windows.Forms.DataGridView dgvBdTipAbonament;
        private System.Windows.Forms.Label labelTipAbonamentBD;
        private System.Windows.Forms.Label labelClientiBD;
        private System.Windows.Forms.DataGridView dgvBdClienti;
        private User_Library.BackButton backButton2;
    }
}