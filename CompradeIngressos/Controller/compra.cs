using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompradeIngressos.Controller
{
    internal class compra
    {
        private int num;
        public int Calculo(int Quantidade, int Valor)
        {

            num = Quantidade * Valor;

            return num;
        }
    }
}
