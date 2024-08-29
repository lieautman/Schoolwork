
namespace AbonatiTelefonici
{
    partial class BdExtraOptiune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BdExtraOptiune));
            this.dgvBdExtraOptiune = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdExtraOptiune)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBdExtraOptiune
            // 
            this.dgvBdExtraOptiune.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdExtraOptiune.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBdExtraOptiune.Location = new System.Drawing.Point(0, 0);
            this.dgvBdExtraOptiune.Name = "dgvBdExtraOptiune";
            this.dgvBdExtraOptiune.RowHeadersWidth = 51;
            this.dgvBdExtraOptiune.RowTemplate.Height = 24;
            this.dgvBdExtraOptiune.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdExtraOptiune.Size = new System.Drawing.Size(800, 450);
            this.dgvBdExtraOptiune.TabIndex = 18;
            // 
            // BdExtraOptiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBdExtraOptiune);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BdExtraOptiune";
            this.Text = "BdExtraOptiune";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdExtraOptiune)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBdExtraOptiune;
    }
}