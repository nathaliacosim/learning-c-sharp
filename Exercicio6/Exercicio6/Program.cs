using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoKg;
            int numKg;

            Console.WriteLine("Qual o preço do KG?");
            precoKg = Double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos Kg comprou?");
            numKg = Int32.Parse(Console.ReadLine());

            Console.WriteLine("O valor total é: R$" + (precoKg * numKg));
        }
    }
}
