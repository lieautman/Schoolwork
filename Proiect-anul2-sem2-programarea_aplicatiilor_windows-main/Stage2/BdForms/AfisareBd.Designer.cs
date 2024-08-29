
namespace AbonatiTelefonici
{
    partial class AfisareBd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfisareBd));
            this.btnDisplayBDClient = new System.Windows.Forms.Button();
            this.btnDisplayBDAbonament = new System.Windows.Forms.Button();
            this.btnDisplayBDExtraOptiune = new System.Windows.Forms.Button();
            this.btnDisplayBDTipAbonament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayBDClient
            // 
            this.btnDisplayBDClient.Location = new System.Drawing.Point(228, 66);
            this.btnDisplayBDClient.Name = "btnDisplayBDClient";
            this.btnDisplayBDClient.Size = new System.Drawing.Size(324, 30);
            this.btnDisplayBDClient.TabIndex = 8;
            this.btnDisplayBDClient.Text = "Display baza de date clienti";
            this.btnDisplayBDClient.UseVisualStyleBackColor = true;
            this.btnDisplayBDClient.Click += new System.EventHandler(this.btnDisplayBDClient_Click);
            // 
            // btnDisplayBDAbonament
            // 
            this.btnDisplayBDAbonament.Location = new System.Drawing.Point(228, 126);
            this.btnDisplayBDAbonament.Name = "btnDisplayBDAbonament";
            this.btnDisplayBDAbonament.Size = new System.Drawing.Size(324, 30);
            this.btnDisplayBDAbonament.TabIndex = 16;
            this.btnDisplayBDAbonament.Text = "Display baza de date abonamente";
            this.btnDisplayBDAbonament.UseVisualStyleBackColor = true;
            this.btnDisplayBDAbonament.Click += new System.EventHandler(this.btnDisplayBDAbonament_Click);
            // 
            // btnDisplayBDExtraOptiune
            // 
            this.btnDisplayBDExtraOptiune.Location = new System.Drawing.Point(228, 186);
            this.btnDisplayBDExtraOptiune.Name = "btnDisplayBDExtraOptiune";
            this.btnDisplayBDExtraOptiune.Size = new System.Drawing.Size(324, 30);
            this.btnDisplayBDExtraOptiune.TabIndex = 17;
            this.btnDisplayBDExtraOptiune.Text = "Display baza de date extra optiune";
            this.btnDisplayBDExtraOptiune.UseVisualStyleBackColor = true;
            this.btnDisplayBDExtraOptiune.Click += new System.EventHandler(this.btnDisplayBDExtraOptiune_Click);
            // 
            // btnDisplayBDTipAbonament
            // 
            this.btnDisplayBDTipAbonament.Location = new System.Drawing.Point(228, 246);
            this.btnDisplayBDTipAbonament.Name = "btnDisplayBDTipAbonament";
            this.btnDisplayBDTipAbonament.Size = new System.Drawing.Size(324, 30);
            this.btnDisplayBDTipAbonament.TabIndex = 18;
            this.btnDisplayBDTipAbonament.Text = "Display baza de date tip abonamente";
            this.btnDisplayBDTipAbonament.UseVisualStyleBackColor = true;
            this.btnDisplayBDTipAbonament.Click += new System.EventHandler(this.btnDisplayBDTipAbonament_Click);
            // 
            // AfisareBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayBDTipAbonament);
            this.Controls.Add(this.btnDisplayBDExtraOptiune);
            this.Controls.Add(this.btnDisplayBDAbonament);
            this.Controls.Add(this.btnDisplayBDClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AfisareBd";
            this.Text = "AfisareBd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayBDClient;
        private System.Windows.Forms.Button btnDisplayBDAbonament;
        private System.Windows.Forms.Button btnDisplayBDExtraOptiune;
        private System.Windows.Forms.Button btnDisplayBDTipAbonament;
    }
}