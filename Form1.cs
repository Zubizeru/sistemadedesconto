using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadedesconto
{
    public partial class FrmCalculoDesconto : Form
    {
        public FrmCalculoDesconto()
        {
            InitializeComponent();

            // O evento TextChanged é acionado sempre que o usuário altera o texto nos campos
            txtValorCompra.TextChanged += CalcularDesconto;
            txtValorDesconto.TextChanged += CalcularDesconto;
        }

        private void CalcularDesconto(object sender, EventArgs e)
        {
            decimal valorCompra;
            decimal desconto;

            if (!decimal.TryParse(txtValorCompra.Text, out valorCompra) || !decimal.TryParse(txtValorDesconto.Text, out desconto))
            {
                lblResultado.Text = "Valores inválidos!";
                return;
            }

            decimal resultado = valorCompra - (valorCompra * desconto / 100);

            lblResultado.Text = $"R$ {resultado}";
        }
    }

}
