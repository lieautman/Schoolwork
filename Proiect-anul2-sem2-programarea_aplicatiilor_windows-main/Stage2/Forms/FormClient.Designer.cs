
namespace AbonatiTelefonici
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNationalitate = new System.Windows.Forms.Label();
            this.btnSalvareClient = new System.Windows.Forms.Button();
            this.labelNrOrdine = new System.Windows.Forms.Label();
            this.tbNrOrdine = new System.Windows.Forms.TextBox();
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNationalitate = new System.Windows.Forms.ComboBox();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.cbPlata = new System.Windows.Forms.ComboBox();
            this.labelPlata = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.backButton2 = new User_Library.BackButton();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(334, 200);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(389, 22);
            this.tbNume.TabIndex = 2;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(334, 239);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(389, 22);
            this.tbPrenume.TabIndex = 3;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(334, 161);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(389, 22);
            this.tbCNP.TabIndex = 1;
            // 
            // labelCNP
            // 
            this.labelCNP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(117, 166);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(36, 17);
            this.labelCNP.TabIndex = 11;
            this.labelCNP.Text = "CNP";
            // 
            // labelNume
            // 
            this.labelNume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(117, 205);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(117, 244);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 13;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelNationalitate
            // 
            this.labelNationalitate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNationalitate.AutoSize = true;
            this.labelNationalitate.Location = new System.Drawing.Point(117, 322);
            this.labelNationalitate.Name = "labelNationalitate";
            this.labelNationalitate.Size = new System.Drawing.Size(87, 17);
            this.labelNationalitate.TabIndex = 14;
            this.labelNationalitate.Text = "Nationalitate";
            // 
            // btnSalvareClient
            // 
            this.btnSalvareClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvareClient.Location = new System.Drawing.Point(206, 407);
            this.btnSalvareClient.Name = "btnSalvareClient";
            this.btnSalvareClient.Size = new System.Drawing.Size(471, 48);
            this.btnSalvareClient.TabIndex = 6;
            this.btnSalvareClient.Text = "Salveaza";
            this.btnSalvareClient.UseVisualStyleBackColor = true;
            this.btnSalvareClient.Click += new System.EventHandler(this.btnSalvareClient_Click);
            // 
            // labelNrOrdine
            // 
            this.labelNrOrdine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNrOrdine.AutoSize = true;
            this.labelNrOrdine.Location = new System.Drawing.Point(117, 127);
            this.labelNrOrdine.Name = "labelNrOrdine";
            this.labelNrOrdine.Size = new System.Drawing.Size(74, 17);
            this.labelNrOrdine.TabIndex = 10;
            this.labelNrOrdine.Text = "Nr. Ordine";
            // 
            // tbNrOrdine
            // 
            this.tbNrOrdine.Location = new System.Drawing.Point(334, 122);
            this.tbNrOrdine.Name = "tbNrOrdine";
            this.tbNrOrdine.ReadOnly = true;
            this.tbNrOrdine.Size = new System.Drawing.Size(389, 22);
            this.tbNrOrdine.TabIndex = 0;
            // 
            // epNecompletat
            // 
            this.epNecompletat.ContainerControl = this;
            // 
            // cbNationalitate
            // 
            this.cbNationalitate.FormattingEnabled = true;
            this.cbNationalitate.Items.AddRange(new object[] {
            "Bulgara",
            "Moldoveana",
            "Romana",
            "Serba",
            "Ucrainiana",
            "Ungara"});
            this.cbNationalitate.Location = new System.Drawing.Point(334, 317);
            this.cbNationalitate.Name = "cbNationalitate";
            this.cbNationalitate.Size = new System.Drawing.Size(389, 24);
            this.cbNationalitate.Sorted = true;
            this.cbNationalitate.TabIndex = 4;
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(148, 50);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(208, 17);
            this.labelTitlu.TabIndex = 9;
            this.labelTitlu.Text = "Completati campurile urmatoare";
            // 
            // cbPlata
            // 
            this.cbPlata.FormattingEnabled = true;
            this.cbPlata.Items.AddRange(new object[] {
            "Numerar",
            "Card",
            "Ambele"});
            this.cbPlata.Location = new System.Drawing.Point(334, 358);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(389, 24);
            this.cbPlata.TabIndex = 5;
            // 
            // labelPlata
            // 
            this.labelPlata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlata.AutoSize = true;
            this.labelPlata.Location = new System.Drawing.Point(117, 361);
            this.labelPlata.Name = "labelPlata";
            this.labelPlata.Size = new System.Drawing.Size(110, 17);
            this.labelPlata.TabIndex = 14;
            this.labelPlata.Text = "Metoda de plata";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(117, 283);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 42;
            this.labelEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(334, 278);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(389, 22);
            this.tbEmail.TabIndex = 41;
            // 
            // backButton2
            // 
            this.backButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton2.Location = new System.Drawing.Point(634, 527);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(219, 60);
            this.backButton2.TabIndex = 48;
            this.backButton2.Load += new System.EventHandler(this.backButton2_Load);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 599);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelPlata);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.cbNationalitate);
            this.Controls.Add(this.tbNrOrdine);
            this.Controls.Add(this.labelNrOrdine);
            this.Controls.Add(this.btnSalvareClient);
            this.Controls.Add(this.labelNationalitate);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.Text = "Formular Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelNationalitate;
        private System.Windows.Forms.Button btnSalvareClient;
        private System.Windows.Forms.Label labelNrOrdine;
        private System.Windows.Forms.TextBox tbNrOrdine;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.ComboBox cbNationalitate;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelPlata;
        private System.Windows.Forms.ComboBox cbPlata;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private User_Library.BackButton backButton2;
    }
}

