using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double soma = 0;

            for (int i = 0; i < 20; i++)
            {
                int num = rnd.Next(1, 16);
                Console.WriteLine(num);
                soma += num;
            }
            if (soma / 20 >= 8)
            {
                Console.WriteLine("A média é: 10");
            }
            else
            {
                Console.WriteLine("A média é: " + (soma / 20));
            }
        }
    }
}
