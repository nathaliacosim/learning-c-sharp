using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sub;

            Console.WriteLine("Digite o primeiro número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            sub = n1 - n2;
            Console.WriteLine("A subtração é: " + sub);

        }
    }
}
