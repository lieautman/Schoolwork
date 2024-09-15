
namespace AbonatiTelefonici
{
    partial class FormMain_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_Client));
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbonament = new System.Windows.Forms.Button();
            this.btnExtraOptiuni = new System.Windows.Forms.Button();
            this.backButton1 = new User_Library.BackButton();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClient.Location = new System.Drawing.Point(109, 218);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(380, 148);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Formular &Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dati click pe butonul cu formularul ce trebuie completat!";
            // 
            // btnAbonament
            // 
            this.btnAbonament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbonament.Location = new System.Drawing.Point(567, 218);
            this.btnAbonament.Name = "btnAbonament";
            this.btnAbonament.Size = new System.Drawing.Size(380, 148);
            this.btnAbonament.TabIndex = 2;
            this.btnAbonament.Text = "Formular &Abonament";
            this.btnAbonament.UseVisualStyleBackColor = true;
            this.btnAbonament.Click += new System.EventHandler(this.btnAbonament_Click);
            // 
            // btnExtraOptiuni
            // 
            this.btnExtraOptiuni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExtraOptiuni.Location = new System.Drawing.Point(1026, 218);
            this.btnExtraOptiuni.Name = "btnExtraOptiuni";
            this.btnExtraOptiuni.Size = new System.Drawing.Size(380, 148);
            this.btnExtraOptiuni.TabIndex = 4;
            this.btnExtraOptiuni.Text = "Formular &ExtraOptiuni";
            this.btnExtraOptiuni.UseVisualStyleBackColor = true;
            this.btnExtraOptiuni.Click += new System.EventHandler(this.btnExtraOptiuni_Click);
            // 
            // backButton1
            // 
            this.backButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton1.Location = new System.Drawing.Point(1358, 588);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(181, 52);
            this.backButton1.TabIndex = 5;
            // 
            // FormMain_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1551, 652);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.btnExtraOptiuni);
            this.Controls.Add(this.btnAbonament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain_Client";
            this.Text = "Formular principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbonament;
        private System.Windows.Forms.Button btnExtraOptiuni;
        private User_Library.BackButton backButton1;
    }
}