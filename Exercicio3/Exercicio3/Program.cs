using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double _base, _altura;

            Console.WriteLine("Insira o valor da base do triangulo");
            _base = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da altura do triangulo");
            _altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("A area do triangulo é: " + (_base * _altura / 2));
        }
    }
}
