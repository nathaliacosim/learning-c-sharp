using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Insira o 1° número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2° número");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 3° número");
            n3 = Int32.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("O menor número é: " + n1);
            }
            else if (n2 < n3)
            {
                Console.WriteLine("O menor número é: " + n2);
            }
            else
            {
                Console.WriteLine("O menor número é: " + n3);
            }

        }
    }
}
