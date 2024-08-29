
namespace AbonatiTelefonici
{
    partial class BdClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BdClienti));
            this.dgvBdClienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBdClienti
            // 
            this.dgvBdClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBdClienti.Location = new System.Drawing.Point(0, 0);
            this.dgvBdClienti.Name = "dgvBdClienti";
            this.dgvBdClienti.RowHeadersWidth = 51;
            this.dgvBdClienti.RowTemplate.Height = 24;
            this.dgvBdClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdClienti.Size = new System.Drawing.Size(1061, 530);
            this.dgvBdClienti.TabIndex = 16;
            // 
            // BdClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 530);
            this.Controls.Add(this.dgvBdClienti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BdClienti";
            this.Text = "BdClienti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBdClienti;
    }
}