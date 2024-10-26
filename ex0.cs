using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int media, n1, n2, n3;
            Console.WriteLine("Mequié maltinha!!");
            Console.WriteLine("Este programa efetua a média de 3 números inseridos pelo utilizador");

            Console.WriteLine("Por favor insira o primeiro número: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Por favor insira o segundo número: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Por favor insira o terceiro número: ");
            n3 = Convert.ToInt16(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("Média = " + media);

        }
    }
}
