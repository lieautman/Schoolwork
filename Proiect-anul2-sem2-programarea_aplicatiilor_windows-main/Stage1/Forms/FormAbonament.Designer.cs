
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
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelNrOrdineClient = new System.Windows.Forms.Label();
            this.labelTipAbonament = new System.Windows.Forms.Label();
            this.btnDisplayCategorii = new System.Windows.Forms.Button();
            this.cbTipAbonament = new System.Windows.Forms.ComboBox();
            this.btnSalvareClient = new System.Windows.Forms.Button();
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNrOrdineClient = new System.Windows.Forms.ComboBox();
            this.labelNrOrdineAbonament = new System.Windows.Forms.Label();
            this.tbNrOrdineAbonament = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(142, 80);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(208, 17);
            this.labelTitlu.TabIndex = 4;
            this.labelTitlu.Text = "Completati campurile urmatoare";
            // 
            // labelNrOrdineClient
            // 
            this.labelNrOrdineClient.AutoSize = true;
            this.labelNrOrdineClient.Location = new System.Drawing.Point(70, 207);
            this.labelNrOrdineClient.Name = "labelNrOrdineClient";
            this.labelNrOrdineClient.Size = new System.Drawing.Size(131, 17);
            this.labelNrOrdineClient.TabIndex = 5;
            this.labelNrOrdineClient.Text = "Numar ordine client";
            // 
            // labelTipAbonament
            // 
            this.labelTipAbonament.AutoSize = true;
            this.labelTipAbonament.Location = new System.Drawing.Point(70, 256);
            this.labelTipAbonament.Name = "labelTipAbonament";
            this.labelTipAbonament.Size = new System.Drawing.Size(137, 17);
            this.labelTipAbonament.TabIndex = 6;
            this.labelTipAbonament.Text = "Tipul Abonamentului";
            // 
            // btnDisplayCategorii
            // 
            this.btnDisplayCategorii.Location = new System.Drawing.Point(145, 423);
            this.btnDisplayCategorii.Name = "btnDisplayCategorii";
            this.btnDisplayCategorii.Size = new System.Drawing.Size(214, 25);
            this.btnDisplayCategorii.TabIndex = 7;
            this.btnDisplayCategorii.Text = "&Display tipuri abonament";
            this.btnDisplayCategorii.UseVisualStyleBackColor = true;
            this.btnDisplayCategorii.Click += new System.EventHandler(this.btnDisplayCategorii_Click);
            // 
            // cbTipAbonament
            // 
            this.cbTipAbonament.FormattingEnabled = true;
            this.cbTipAbonament.Location = new System.Drawing.Point(318, 253);
            this.cbTipAbonament.Name = "cbTipAbonament";
            this.cbTipAbonament.Size = new System.Drawing.Size(132, 24);
            this.cbTipAbonament.TabIndex = 2;
            // 
            // btnSalvareClient
            // 
            this.btnSalvareClient.Location = new System.Drawing.Point(205, 344);
            this.btnSalvareClient.Name = "btnSalvareClient";
            this.btnSalvareClient.Size = new System.Drawing.Size(100, 23);
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
            this.cbNrOrdineClient.FormattingEnabled = true;
            this.cbNrOrdineClient.Location = new System.Drawing.Point(318, 204);
            this.cbNrOrdineClient.Name = "cbNrOrdineClient";
            this.cbNrOrdineClient.Size = new System.Drawing.Size(132, 24);
            this.cbNrOrdineClient.TabIndex = 1;
            // 
            // labelNrOrdineAbonament
            // 
            this.labelNrOrdineAbonament.AutoSize = true;
            this.labelNrOrdineAbonament.Location = new System.Drawing.Point(70, 156);
            this.labelNrOrdineAbonament.Name = "labelNrOrdineAbonament";
            this.labelNrOrdineAbonament.Size = new System.Drawing.Size(169, 17);
            this.labelNrOrdineAbonament.TabIndex = 27;
            this.labelNrOrdineAbonament.Text = "Numar ordine abonament";
            // 
            // tbNrOrdineAbonament
            // 
            this.tbNrOrdineAbonament.Location = new System.Drawing.Point(318, 153);
            this.tbNrOrdineAbonament.Name = "tbNrOrdineAbonament";
            this.tbNrOrdineAbonament.ReadOnly = true;
            this.tbNrOrdineAbonament.Size = new System.Drawing.Size(132, 22);
            this.tbNrOrdineAbonament.TabIndex = 0;
            // 
            // FormAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 525);
            this.Controls.Add(this.tbNrOrdineAbonament);
            this.Controls.Add(this.labelNrOrdineAbonament);
            this.Controls.Add(this.cbNrOrdineClient);
            this.Controls.Add(this.btnSalvareClient);
            this.Controls.Add(this.cbTipAbonament);
            this.Controls.Add(this.btnDisplayCategorii);
            this.Controls.Add(this.labelTipAbonament);
            this.Controls.Add(this.labelNrOrdineClient);
            this.Controls.Add(this.labelTitlu);
            this.Name = "FormAbonament";
            this.Text = "FormAbonament";
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelNrOrdineClient;
        private System.Windows.Forms.Label labelTipAbonament;
        private System.Windows.Forms.Button btnDisplayCategorii;
        private System.Windows.Forms.ComboBox cbTipAbonament;
        private System.Windows.Forms.Button btnSalvareClient;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.ComboBox cbNrOrdineClient;
        private System.Windows.Forms.TextBox tbNrOrdineAbonament;
        private System.Windows.Forms.Label labelNrOrdineAbonament;
    }
}