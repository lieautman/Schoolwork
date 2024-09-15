
namespace AbonatiTelefonici
{
    partial class FormTipAbonament
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
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNrOrdineTipAbonament = new System.Windows.Forms.Label();
            this.tbNrTipAbonament = new System.Windows.Forms.TextBox();
            this.labelNrMesaje = new System.Windows.Forms.Label();
            this.labelNrMinute = new System.Windows.Forms.Label();
            this.labelNrGbInternet = new System.Windows.Forms.Label();
            this.tbNrMesaje = new System.Windows.Forms.TextBox();
            this.tbNrMinute = new System.Windows.Forms.TextBox();
            this.tbNrGbInternet = new System.Windows.Forms.TextBox();
            this.btnSalvareTipAbonament = new System.Windows.Forms.Button();
            this.labelPretLunar = new System.Windows.Forms.Label();
            this.tbPretLunar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(141, 38);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(208, 17);
            this.labelTitlu.TabIndex = 5;
            this.labelTitlu.Text = "Completati campurile urmatoare";
            // 
            // epNecompletat
            // 
            this.epNecompletat.ContainerControl = this;
            // 
            // labelNrOrdineTipAbonament
            // 
            this.labelNrOrdineTipAbonament.AutoSize = true;
            this.labelNrOrdineTipAbonament.Location = new System.Drawing.Point(54, 97);
            this.labelNrOrdineTipAbonament.Name = "labelNrOrdineTipAbonament";
            this.labelNrOrdineTipAbonament.Size = new System.Drawing.Size(188, 17);
            this.labelNrOrdineTipAbonament.TabIndex = 28;
            this.labelNrOrdineTipAbonament.Text = "Numar ordine tip abonament";
            // 
            // tbNrTipAbonament
            // 
            this.tbNrTipAbonament.Location = new System.Drawing.Point(295, 94);
            this.tbNrTipAbonament.Name = "tbNrTipAbonament";
            this.tbNrTipAbonament.ReadOnly = true;
            this.tbNrTipAbonament.Size = new System.Drawing.Size(131, 22);
            this.tbNrTipAbonament.TabIndex = 29;
            // 
            // labelNrMesaje
            // 
            this.labelNrMesaje.AutoSize = true;
            this.labelNrMesaje.Location = new System.Drawing.Point(54, 149);
            this.labelNrMesaje.Name = "labelNrMesaje";
            this.labelNrMesaje.Size = new System.Drawing.Size(99, 17);
            this.labelNrMesaje.TabIndex = 30;
            this.labelNrMesaje.Text = "Numar mesaje";
            // 
            // labelNrMinute
            // 
            this.labelNrMinute.AutoSize = true;
            this.labelNrMinute.Location = new System.Drawing.Point(54, 198);
            this.labelNrMinute.Name = "labelNrMinute";
            this.labelNrMinute.Size = new System.Drawing.Size(96, 17);
            this.labelNrMinute.TabIndex = 31;
            this.labelNrMinute.Text = "Numar minute";
            // 
            // labelNrGbInternet
            // 
            this.labelNrGbInternet.AutoSize = true;
            this.labelNrGbInternet.Location = new System.Drawing.Point(54, 251);
            this.labelNrGbInternet.Name = "labelNrGbInternet";
            this.labelNrGbInternet.Size = new System.Drawing.Size(125, 17);
            this.labelNrGbInternet.TabIndex = 32;
            this.labelNrGbInternet.Text = "Numar Gb internet";
            // 
            // tbNrMesaje
            // 
            this.tbNrMesaje.Location = new System.Drawing.Point(295, 146);
            this.tbNrMesaje.Name = "tbNrMesaje";
            this.tbNrMesaje.Size = new System.Drawing.Size(131, 22);
            this.tbNrMesaje.TabIndex = 33;
            // 
            // tbNrMinute
            // 
            this.tbNrMinute.Location = new System.Drawing.Point(295, 195);
            this.tbNrMinute.Name = "tbNrMinute";
            this.tbNrMinute.Size = new System.Drawing.Size(131, 22);
            this.tbNrMinute.TabIndex = 34;
            // 
            // tbNrGbInternet
            // 
            this.tbNrGbInternet.Location = new System.Drawing.Point(295, 246);
            this.tbNrGbInternet.Name = "tbNrGbInternet";
            this.tbNrGbInternet.Size = new System.Drawing.Size(131, 22);
            this.tbNrGbInternet.TabIndex = 35;
            // 
            // btnSalvareTipAbonament
            // 
            this.btnSalvareTipAbonament.Location = new System.Drawing.Point(156, 349);
            this.btnSalvareTipAbonament.Name = "btnSalvareTipAbonament";
            this.btnSalvareTipAbonament.Size = new System.Drawing.Size(148, 29);
            this.btnSalvareTipAbonament.TabIndex = 36;
            this.btnSalvareTipAbonament.Text = "Salveaza";
            this.btnSalvareTipAbonament.UseVisualStyleBackColor = true;
            this.btnSalvareTipAbonament.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelPretLunar
            // 
            this.labelPretLunar.AutoSize = true;
            this.labelPretLunar.Location = new System.Drawing.Point(54, 300);
            this.labelPretLunar.Name = "labelPretLunar";
            this.labelPretLunar.Size = new System.Drawing.Size(70, 17);
            this.labelPretLunar.TabIndex = 37;
            this.labelPretLunar.Text = "Pret lunar";
            // 
            // tbPretLunar
            // 
            this.tbPretLunar.Location = new System.Drawing.Point(295, 297);
            this.tbPretLunar.Name = "tbPretLunar";
            this.tbPretLunar.Size = new System.Drawing.Size(131, 22);
            this.tbPretLunar.TabIndex = 38;
            // 
            // FormTipAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 438);
            this.Controls.Add(this.tbPretLunar);
            this.Controls.Add(this.labelPretLunar);
            this.Controls.Add(this.btnSalvareTipAbonament);
            this.Controls.Add(this.tbNrGbInternet);
            this.Controls.Add(this.tbNrMinute);
            this.Controls.Add(this.tbNrMesaje);
            this.Controls.Add(this.labelNrGbInternet);
            this.Controls.Add(this.labelNrMinute);
            this.Controls.Add(this.labelNrMesaje);
            this.Controls.Add(this.tbNrTipAbonament);
            this.Controls.Add(this.labelNrOrdineTipAbonament);
            this.Controls.Add(this.labelTitlu);
            this.Name = "FormTipAbonament";
            this.Text = "FormTipAbonament";
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.Label labelNrOrdineTipAbonament;
        private System.Windows.Forms.TextBox tbNrTipAbonament;
        private System.Windows.Forms.Label labelNrMesaje;
        private System.Windows.Forms.Label labelNrGbInternet;
        private System.Windows.Forms.Label labelNrMinute;
        private System.Windows.Forms.TextBox tbNrGbInternet;
        private System.Windows.Forms.TextBox tbNrMinute;
        private System.Windows.Forms.TextBox tbNrMesaje;
        private System.Windows.Forms.Button btnSalvareTipAbonament;
        private System.Windows.Forms.TextBox tbPretLunar;
        private System.Windows.Forms.Label labelPretLunar;
    }
}