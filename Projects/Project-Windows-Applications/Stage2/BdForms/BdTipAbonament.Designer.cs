
namespace AbonatiTelefonici
{
    partial class BdTipAbonament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BdTipAbonament));
            this.dgvBdTipAbonament = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdTipAbonament)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBdTipAbonament
            // 
            this.dgvBdTipAbonament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdTipAbonament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBdTipAbonament.Location = new System.Drawing.Point(0, 0);
            this.dgvBdTipAbonament.Name = "dgvBdTipAbonament";
            this.dgvBdTipAbonament.RowHeadersWidth = 51;
            this.dgvBdTipAbonament.RowTemplate.Height = 24;
            this.dgvBdTipAbonament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdTipAbonament.Size = new System.Drawing.Size(800, 450);
            this.dgvBdTipAbonament.TabIndex = 18;
            // 
            // BdTipAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBdTipAbonament);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BdTipAbonament";
            this.Text = "BdTipAbonament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdTipAbonament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBdTipAbonament;
    }
}