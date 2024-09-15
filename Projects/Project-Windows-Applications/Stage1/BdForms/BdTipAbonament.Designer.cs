
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
            this.dgvBdAbonament = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdAbonament)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBdAbonament
            // 
            this.dgvBdAbonament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdAbonament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBdAbonament.Location = new System.Drawing.Point(0, 0);
            this.dgvBdAbonament.Name = "dgvBdAbonament";
            this.dgvBdAbonament.RowHeadersWidth = 51;
            this.dgvBdAbonament.RowTemplate.Height = 24;
            this.dgvBdAbonament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdAbonament.Size = new System.Drawing.Size(800, 450);
            this.dgvBdAbonament.TabIndex = 18;
            // 
            // BdTipAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBdAbonament);
            this.Name = "BdTipAbonament";
            this.Text = "BdTipAbonament";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdAbonament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBdAbonament;
    }
}