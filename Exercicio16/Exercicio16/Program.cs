using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd  = new Random();
            double soma = 0;

            for (int i = 0; i < 20; i++)
            {
                int num = rnd.Next(1,100);
                Console.WriteLine(num);
                soma += num;
            }

            Console.WriteLine("A média é: " + (soma/20));
        }
    }
}
