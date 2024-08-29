
namespace AbonatiTelefonici
{
    partial class FormExtraOptiuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtraOptiuni));
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipExtraoptiune = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExtraOptiuneNumar = new System.Windows.Forms.TextBox();
            this.labelExtraOptiune1 = new System.Windows.Forms.Label();
            this.btnSalvareExtraOptiune = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNrOrdineExtraoptiune = new System.Windows.Forms.TextBox();
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNrOrdineAbonament = new System.Windows.Forms.ComboBox();
            this.dgvBdAbonament = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBdClienti = new System.Windows.Forms.DataGridView();
            this.labelTipAbonamentBD = new System.Windows.Forms.Label();
            this.dgvBdTipAbonament = new System.Windows.Forms.DataGridView();
            this.backButton2 = new User_Library.BackButton();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdAbonament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdTipAbonament)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipul de extra optiune";
            // 
            // cbTipExtraoptiune
            // 
            this.cbTipExtraoptiune.FormattingEnabled = true;
            this.cbTipExtraoptiune.Items.AddRange(new object[] {
            "Minute Convorbire",
            "Mesaje",
            "Gb Internet"});
            this.cbTipExtraoptiune.Location = new System.Drawing.Point(226, 179);
            this.cbTipExtraoptiune.Name = "cbTipExtraoptiune";
            this.cbTipExtraoptiune.Size = new System.Drawing.Size(214, 24);
            this.cbTipExtraoptiune.TabIndex = 2;
            this.cbTipExtraoptiune.SelectedIndexChanged += new System.EventHandler(this.cbTipExtraoptiune_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Completati campurile urmatoare";
            // 
            // tbExtraOptiuneNumar
            // 
            this.tbExtraOptiuneNumar.Location = new System.Drawing.Point(226, 223);
            this.tbExtraOptiuneNumar.Name = "tbExtraOptiuneNumar";
            this.tbExtraOptiuneNumar.Size = new System.Drawing.Size(214, 22);
            this.tbExtraOptiuneNumar.TabIndex = 3;
            // 
            // labelExtraOptiune1
            // 
            this.labelExtraOptiune1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExtraOptiune1.AutoSize = true;
            this.labelExtraOptiune1.Location = new System.Drawing.Point(43, 223);
            this.labelExtraOptiune1.Name = "labelExtraOptiune1";
            this.labelExtraOptiune1.Size = new System.Drawing.Size(50, 17);
            this.labelExtraOptiune1.TabIndex = 11;
            this.labelExtraOptiune1.Text = "Numar";
            // 
            // btnSalvareExtraOptiune
            // 
            this.btnSalvareExtraOptiune.Location = new System.Drawing.Point(133, 319);
            this.btnSalvareExtraOptiune.Name = "btnSalvareExtraOptiune";
            this.btnSalvareExtraOptiune.Size = new System.Drawing.Size(307, 37);
            this.btnSalvareExtraOptiune.TabIndex = 4;
            this.btnSalvareExtraOptiune.Text = "Salveaza";
            this.btnSalvareExtraOptiune.UseVisualStyleBackColor = true;
            this.btnSalvareExtraOptiune.Click += new System.EventHandler(this.btnSalvareExtraOptiune_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numar ordine Extraoptiune";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numar ordine Abonament";
            // 
            // tbNrOrdineExtraoptiune
            // 
            this.tbNrOrdineExtraoptiune.Location = new System.Drawing.Point(226, 84);
            this.tbNrOrdineExtraoptiune.Name = "tbNrOrdineExtraoptiune";
            this.tbNrOrdineExtraoptiune.ReadOnly = true;
            this.tbNrOrdineExtraoptiune.Size = new System.Drawing.Size(214, 22);
            this.tbNrOrdineExtraoptiune.TabIndex = 0;
            // 
            // epNecompletat
            // 
            this.epNecompletat.ContainerControl = this;
            // 
            // cbNrOrdineAbonament
            // 
            this.cbNrOrdineAbonament.FormattingEnabled = true;
            this.cbNrOrdineAbonament.Location = new System.Drawing.Point(226, 134);
            this.cbNrOrdineAbonament.Name = "cbNrOrdineAbonament";
            this.cbNrOrdineAbonament.Size = new System.Drawing.Size(214, 24);
            this.cbNrOrdineAbonament.TabIndex = 1;
            // 
            // dgvBdAbonament
            // 
            this.dgvBdAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBdAbonament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdAbonament.Location = new System.Drawing.Point(473, 51);
            this.dgvBdAbonament.Name = "dgvBdAbonament";
            this.dgvBdAbonament.RowHeadersWidth = 51;
            this.dgvBdAbonament.RowTemplate.Height = 24;
            this.dgvBdAbonament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdAbonament.Size = new System.Drawing.Size(820, 189);
            this.dgvBdAbonament.TabIndex = 41;
            this.dgvBdAbonament.DoubleClick += new System.EventHandler(this.dgvBdAbonament_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Baza de date abonamente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Baza de date clienti";
            // 
            // dgvBdClienti
            // 
            this.dgvBdClienti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBdClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdClienti.Location = new System.Drawing.Point(473, 273);
            this.dgvBdClienti.Name = "dgvBdClienti";
            this.dgvBdClienti.RowHeadersWidth = 51;
            this.dgvBdClienti.RowTemplate.Height = 24;
            this.dgvBdClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdClienti.Size = new System.Drawing.Size(820, 194);
            this.dgvBdClienti.TabIndex = 44;
            // 
            // labelTipAbonamentBD
            // 
            this.labelTipAbonamentBD.AutoSize = true;
            this.labelTipAbonamentBD.Location = new System.Drawing.Point(470, 475);
            this.labelTipAbonamentBD.Name = "labelTipAbonamentBD";
            this.labelTipAbonamentBD.Size = new System.Drawing.Size(194, 17);
            this.labelTipAbonamentBD.TabIndex = 46;
            this.labelTipAbonamentBD.Text = "Baza de date tip abonamente";
            // 
            // dgvBdTipAbonament
            // 
            this.dgvBdTipAbonament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBdTipAbonament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdTipAbonament.Location = new System.Drawing.Point(473, 495);
            this.dgvBdTipAbonament.Name = "dgvBdTipAbonament";
            this.dgvBdTipAbonament.RowHeadersWidth = 51;
            this.dgvBdTipAbonament.RowTemplate.Height = 24;
            this.dgvBdTipAbonament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBdTipAbonament.Size = new System.Drawing.Size(820, 194);
            this.dgvBdTipAbonament.TabIndex = 45;
            // 
            // backButton2
            // 
            this.backButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton2.Location = new System.Drawing.Point(1074, 720);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(219, 60);
            this.backButton2.TabIndex = 47;
            this.backButton2.Load += new System.EventHandler(this.backButton2_Load);
            // 
            // FormExtraOptiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 792);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.labelTipAbonamentBD);
            this.Controls.Add(this.dgvBdTipAbonament);
            this.Controls.Add(this.dgvBdClienti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBdAbonament);
            this.Controls.Add(this.cbNrOrdineAbonament);
            this.Controls.Add(this.tbNrOrdineExtraoptiune);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvareExtraOptiune);
            this.Controls.Add(this.labelExtraOptiune1);
            this.Controls.Add(this.tbExtraOptiuneNumar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipExtraoptiune);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExtraOptiuni";
            this.Text = "FormExtraOptiuni";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdAbonament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdTipAbonament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipExtraoptiune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExtraOptiuneNumar;
        private System.Windows.Forms.Label labelExtraOptiune1;
        private System.Windows.Forms.Button btnSalvareExtraOptiune;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNrOrdineExtraoptiune;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.ComboBox cbNrOrdineAbonament;
        private System.Windows.Forms.DataGridView dgvBdAbonament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBdClienti;
        private System.Windows.Forms.Label labelTipAbonamentBD;
        private System.Windows.Forms.DataGridView dgvBdTipAbonament;
        private User_Library.BackButton backButton2;
    }
}