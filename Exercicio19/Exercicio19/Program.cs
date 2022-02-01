using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            double soma = 0;
            int cont = 0;
            Console.WriteLine("Quantos valores pretende inserir?");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("Insira o " + (i + 1) + "° valor");
                int valor = Int32.Parse(Console.ReadLine());
                if (valor > 4) 
                {
                    cont += 1;
                    soma += valor;
                }
            }
            if (cont > 0)
            {
                Console.WriteLine("A média é: " + (soma / cont));
            }
            else {
                Console.WriteLine("Não existem valores superiores a 4!");
            }
        }
    }
}
