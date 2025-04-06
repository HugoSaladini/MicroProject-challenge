namespace MicroOndas.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRapido = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo (s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(302, 145);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 1;
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(299, 182);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(0, 13);
            this.lblPotencia.TabIndex = 2;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(302, 198);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(302, 236);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnRapido
            // 
            this.btnRapido.Location = new System.Drawing.Point(396, 236);
            this.btnRapido.Name = "btnRapido";
            this.btnRapido.Size = new System.Drawing.Size(112, 23);
            this.btnRapido.TabIndex = 5;
            this.btnRapido.UseVisualStyleBackColor = true;
            this.btnRapido.Click += new System.EventHandler(this.btnRapido_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(302, 276);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(169, 23);
            this.btnPausar.TabIndex = 6;
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(324, 327);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnRapido);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lblTempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRapido;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Label lblStatus;
    }
}

