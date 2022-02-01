using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            for (int i = 0; i < 50; i++) 
            {
                soma += i;
            }
            Console.WriteLine("A média é: " + (soma / 50));
        }
    }
}
