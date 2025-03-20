
namespace sistemadedesconto
{
    partial class FrmCalculoDesconto
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
            this.lblInsiraValor = new System.Windows.Forms.Label();
            this.lblInsiraDesconto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultadoCompra = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInsiraValor
            // 
            this.lblInsiraValor.AutoSize = true;
            this.lblInsiraValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiraValor.ForeColor = System.Drawing.Color.White;
            this.lblInsiraValor.Location = new System.Drawing.Point(61, 153);
            this.lblInsiraValor.Name = "lblInsiraValor";
            this.lblInsiraValor.Size = new System.Drawing.Size(206, 20);
            this.lblInsiraValor.TabIndex = 0;
            this.lblInsiraValor.Text = "Insira o valor da compra:";
            // 
            // lblInsiraDesconto
            // 
            this.lblInsiraDesconto.AutoSize = true;
            this.lblInsiraDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiraDesconto.ForeColor = System.Drawing.Color.White;
            this.lblInsiraDesconto.Location = new System.Drawing.Point(64, 213);
            this.lblInsiraDesconto.Name = "lblInsiraDesconto";
            this.lblInsiraDesconto.Size = new System.Drawing.Size(429, 20);
            this.lblInsiraDesconto.TabIndex = 1;
            this.lblInsiraDesconto.Text = "Insira o desconto (considerar que 10 siginifica 10%):";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gold;
            this.lblTitulo.Location = new System.Drawing.Point(169, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 37);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema de Cálculo de Desconto";
            // 
            // lblResultadoCompra
            // 
            this.lblResultadoCompra.AutoSize = true;
            this.lblResultadoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCompra.ForeColor = System.Drawing.Color.White;
            this.lblResultadoCompra.Location = new System.Drawing.Point(64, 278);
            this.lblResultadoCompra.Name = "lblResultadoCompra";
            this.lblResultadoCompra.Size = new System.Drawing.Size(302, 20);
            this.lblResultadoCompra.TabIndex = 3;
            this.lblResultadoCompra.Text = "Resultado da compra com desconto:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(273, 150);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 26);
            this.txtValorCompra.TabIndex = 4;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.Location = new System.Drawing.Point(499, 210);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(100, 26);
            this.txtValorDesconto.TabIndex = 5;
            this.txtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(372, 278);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "R$";
            // 
            // FrmCalculoDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.lblResultadoCompra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInsiraDesconto);
            this.Controls.Add(this.lblInsiraValor);
            this.Name = "FrmCalculoDesconto";
            this.Text = "Sistema de Cálculo de desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsiraValor;
        private System.Windows.Forms.Label lblInsiraDesconto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultadoCompra;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.Label lblResultado;
    }
}

