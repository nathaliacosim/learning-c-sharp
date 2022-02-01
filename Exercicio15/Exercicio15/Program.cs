using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double precoFabrica, precoFinal;

            Console.WriteLine("Qual o nome do automóvel?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o preço de fábrica do automóvel?");
            precoFabrica = Double.Parse(Console.ReadLine());

            precoFinal = precoFabrica + (precoFabrica * 0.45) + (precoFabrica * 0.28);

            Console.WriteLine("O automóvel " + nome + " custará no total: R$" + precoFinal);
        }
    }
}
