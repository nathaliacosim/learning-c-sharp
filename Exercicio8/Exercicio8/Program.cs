using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Insira o primeiro número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número");
            n3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto número");
            n4 = Int32.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4)
            {
                Console.WriteLine("O menor número é " + n1);
            }
            else if (n2 < n3 && n2 < n4)
            {
                Console.WriteLine("O menor número é " + n2);
            }
            else if (n3 < n4)
            {
                Console.WriteLine("O menor número é " + n3);
            }
            else
            {
                Console.WriteLine("O menor número é " + n4);
            }
        }
    }
}
