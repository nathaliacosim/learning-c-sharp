using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod;
            Console.WriteLine("Qual o código do produto?");
            cod = Int32.Parse(Console.ReadLine());

            if (cod == 1)
            {
                Console.WriteLine("001-Parafuso");
            }
            else if (cod == 2)
            {
                Console.WriteLine("002-Prego");
            }
            else if (cod == 3)
            {
                Console.WriteLine("003-Porca");
            }
            else
            {
                Console.WriteLine("Código Inválido!");
            }
        }
    }
}
