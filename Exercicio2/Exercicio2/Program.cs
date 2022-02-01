using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            
            Console.WriteLine("Digite o primeiro número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            soma = n1 + n2;
            Console.WriteLine("A soma é: " + soma);
        }
    }
}
