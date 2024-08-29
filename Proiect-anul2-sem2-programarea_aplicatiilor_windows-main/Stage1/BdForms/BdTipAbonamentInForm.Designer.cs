
namespace AbonatiTelefonici
{
    partial class BdTipAbonamentInForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.tbIdTipAbonament = new System.Windows.Forms.TextBox();
            this.tbNrMinute = new System.Windows.Forms.TextBox();
            this.tbNrMesaje = new System.Windows.Forms.TextBox();
            this.tbNrGbInternet = new System.Windows.Forms.TextBox();
            this.tbPretLunar = new System.Windows.Forms.TextBox();
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
            this.dgvBdAbonament.DoubleClick += new System.EventHandler(this.dgvBdAbonament_DoubleClick);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(335, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            // 
            // tbIdTipAbonament
            // 
            this.tbIdTipAbonament.Location = new System.Drawing.Point(93, 36);
            this.tbIdTipAbonament.Name = "tbIdTipAbonament";
            this.tbIdTipAbonament.Size = new System.Drawing.Size(100, 22);
            this.tbIdTipAbonament.TabIndex = 20;
            this.tbIdTipAbonament.Visible = false;
            // 
            // tbNrMinute
            // 
            this.tbNrMinute.Location = new System.Drawing.Point(93, 92);
            this.tbNrMinute.Name = "tbNrMinute";
            this.tbNrMinute.Size = new System.Drawing.Size(100, 22);
            this.tbNrMinute.TabIndex = 21;
            this.tbNrMinute.Visible = false;
            // 
            // tbNrMesaje
            // 
            this.tbNrMesaje.Location = new System.Drawing.Point(93, 64);
            this.tbNrMesaje.Name = "tbNrMesaje";
            this.tbNrMesaje.Size = new System.Drawing.Size(100, 22);
            this.tbNrMesaje.TabIndex = 21;
            this.tbNrMesaje.Visible = false;
            // 
            // tbNrGbInternet
            // 
            this.tbNrGbInternet.Location = new System.Drawing.Point(93, 120);
            this.tbNrGbInternet.Name = "tbNrGbInternet";
            this.tbNrGbInternet.Size = new System.Drawing.Size(100, 22);
            this.tbNrGbInternet.TabIndex = 22;
            this.tbNrGbInternet.Visible = false;
            // 
            // tbPretLunar
            // 
            this.tbPretLunar.Location = new System.Drawing.Point(93, 148);
            this.tbPretLunar.Name = "tbPretLunar";
            this.tbPretLunar.Size = new System.Drawing.Size(100, 22);
            this.tbPretLunar.TabIndex = 23;
            this.tbPretLunar.Visible = false;
            // 
            // BdTipAbonamentInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPretLunar);
            this.Controls.Add(this.tbNrGbInternet);
            this.Controls.Add(this.tbNrMesaje);
            this.Controls.Add(this.tbNrMinute);
            this.Controls.Add(this.tbIdTipAbonament);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvBdAbonament);
            this.Name = "BdTipAbonamentInForm";
            this.Text = "BdTipAbonament";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdAbonament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBdAbonament;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox tbIdTipAbonament;
        public System.Windows.Forms.TextBox tbNrMinute;
        public System.Windows.Forms.TextBox tbNrMesaje;
        public System.Windows.Forms.TextBox tbNrGbInternet;
        public System.Windows.Forms.TextBox tbPretLunar;
    }
}