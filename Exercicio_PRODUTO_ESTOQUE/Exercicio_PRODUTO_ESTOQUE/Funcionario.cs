using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_PRODUTO_ESTOQUE
{
    internal class Funcionario
    {
        public string Nome;
        public double SBruto;
        public double Imposto;

        public double Sliquido()
        {
            return SBruto - Imposto;
        }

        public void AddSalario(double porcentagem)
        {
            SBruto += porcentagem * SBruto / 100;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Sliquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
