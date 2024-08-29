
namespace AbonatiTelefonici
{
    partial class BdLogFiles
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
            this.dgvBdLogFile = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton1 = new User_Library.BackButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdLogFile)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBdLogFile
            // 
            this.dgvBdLogFile.AllowUserToAddRows = false;
            this.dgvBdLogFile.AllowUserToDeleteRows = false;
            this.dgvBdLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBdLogFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdLogFile.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBdLogFile.Location = new System.Drawing.Point(0, 26);
            this.dgvBdLogFile.Name = "dgvBdLogFile";
            this.dgvBdLogFile.ReadOnly = true;
            this.dgvBdLogFile.RowHeadersWidth = 51;
            this.dgvBdLogFile.RowTemplate.Height = 24;
            this.dgvBdLogFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdLogFile.Size = new System.Drawing.Size(626, 424);
            this.dgvBdLogFile.TabIndex = 17;
            this.dgvBdLogFile.DoubleClick += new System.EventHandler(this.dgvBdLogFile_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 28);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dati dublu click pe un cont pentru a vedea tranzactii";
            // 
            // backButton1
            // 
            this.backButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton1.Location = new System.Drawing.Point(628, 395);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(160, 43);
            this.backButton1.TabIndex = 19;
            // 
            // BdLogFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBdLogFile);
            this.Name = "BdLogFiles";
            this.Text = "BdLogFiles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdLogFile)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBdLogFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private User_Library.BackButton backButton1;
    }
}