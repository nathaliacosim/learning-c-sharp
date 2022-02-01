using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod;
            Console.WriteLine("Qual o código do produto?");
            cod = Int32.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    Console.WriteLine("001-Parafuso");
                    break;
                case 2:
                    Console.WriteLine("002-Prego");
                    break;
                case 3:
                    Console.WriteLine("003-Porca");
                    break;
                default:
                    Console.WriteLine("Código Inválido!");
                    break;
            }
        }
    }
}
