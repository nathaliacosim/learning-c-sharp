using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número");
            n1 = Int32.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("é par: " + n1);
            }
            else
            {
                Console.WriteLine("é impar: " + n1);
            }           
        }
    }
}
