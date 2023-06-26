using CompradeIngressos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompradeIngressos.View
{
    public partial class TelaCompra : Form
    {
        public TelaCompra()
        {
            InitializeComponent();
        }
        compra Compra = new compra();
        private void Calcular_Click(object sender, EventArgs e)
        {
            int Quanti = Convert.ToInt32(Quantidade.Text);
            int Valo = Convert.ToInt32(Valor.Text);
            string resul = Compra.Calculo(Quanti, Valo).ToString();
            tx_resultado.Text = resul;
        }
    }
}
