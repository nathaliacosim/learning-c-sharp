using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            switch (numero) 
            {
                case 10:
                    Console.WriteLine("Número igual a 10");
                    break;
                case 1:
                    Console.WriteLine("Número igual a 1");
                    break;
                default:
                    Console.WriteLine("Valor não encontrado");
                    break;
            }
        }
    }
}
