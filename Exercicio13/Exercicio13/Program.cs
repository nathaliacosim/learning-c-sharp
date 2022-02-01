using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double soma = 0;
            while (cont < 50)
            {
                soma += cont;
                cont++;
            }

            Console.WriteLine("A média é: " + (soma / cont));
        }
    }
}
