using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_PRODUTO_ESTOQUE
{
    internal class Retangulo
    {

        public double Largura, Altura;

        public double Area() {
            return Largura * Altura;
        }
        public double Diagonal() {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 *Altura);
        }



    }
}
