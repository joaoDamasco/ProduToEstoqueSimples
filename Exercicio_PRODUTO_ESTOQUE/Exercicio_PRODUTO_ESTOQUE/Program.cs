
using Exercicio_PRODUTO_ESTOQUE;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite Seus Dados: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            f.SBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Funcionário: " + f);

            Console.Write("Digite a porcetagem para aumentar salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AddSalario(porc);

            Console.WriteLine("Dados atualizados: " + f);



        }
    }
}