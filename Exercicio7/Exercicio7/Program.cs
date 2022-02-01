using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Insira o primeiro número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O maior número é " + n1);
            }
            else if(n2 > n1) 
            {
                Console.WriteLine("O maior número é " + n2);
            } else {
                Console.WriteLine("Os números são iguais " + n1);
            }
        }
    }
}
