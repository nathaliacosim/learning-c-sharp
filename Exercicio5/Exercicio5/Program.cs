using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, vlrPago, troco;
            Console.WriteLine("Insira o preço do produto");
            preco = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor pago pelo cliente?");
            vlrPago = Double.Parse(Console.ReadLine());

            Console.WriteLine("O troco é: " + (vlrPago - preco));
        }
    }
}
