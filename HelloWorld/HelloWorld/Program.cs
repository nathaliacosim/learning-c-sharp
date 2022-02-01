using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;

            Console.WriteLine("Escreva o 1° número");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o 2° número");
            num2 = Int32.Parse(Console.ReadLine());
            
            soma = num1 + num2;

            Console.WriteLine("A soma é: " + soma);
        }
    }
}
