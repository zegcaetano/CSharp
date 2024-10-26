using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            Console.WriteLine("Este programa pede 2 números e mostra todos os números entre o menor e o maior");

            Console.WriteLine("Por favor insira o primeiro número");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Por favor insira o segundo número");
            num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 <= num2)
            {
                for (int i = num1 + 1; i < num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
                    else
                    {
                        for (int i = num2 + 1; i < num1; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
        }
    }
}
