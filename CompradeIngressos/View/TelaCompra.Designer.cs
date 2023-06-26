namespace CompradeIngressos.View
{
    partial class TelaCompra
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
            this.Calcular = new System.Windows.Forms.Button();
            this.tx_resultado = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calcular.Location = new System.Drawing.Point(262, 140);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(118, 23);
            this.Calcular.TabIndex = 17;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // tx_resultado
            // 
            this.tx_resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tx_resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tx_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tx_resultado.Location = new System.Drawing.Point(12, 93);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(239, 108);
            this.tx_resultado.TabIndex = 16;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(202, 22);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(100, 23);
            this.Valor.TabIndex = 15;
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(202, 59);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(100, 23);
            this.Quantidade.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Digite o valor do Ingresso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Deseja quantas quantidades?";
            // 
            // TelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 217);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCompra";
            this.Text = "TelaCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calcular;
        private Label tx_resultado;
        private TextBox Valor;
        private TextBox Quantidade;
        private Label label2;
        private Label label1;
    }
}