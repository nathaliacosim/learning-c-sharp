using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Insira um número");
            num = Int32.Parse(Console.ReadLine());

            if (num > 10)
            {
                Console.WriteLine("Número superior a 10");
            }
            else if (num == 10) 
            {
                Console.WriteLine("Número é igual a 10");
            }
            else 
            {
                Console.WriteLine("Número não é superior a 10");
            }
        }
    }
}
