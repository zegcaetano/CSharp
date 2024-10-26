using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, par = 0, impar = 0, acum = 0, soma = 0, media = 0;
             
            Console.WriteLine("Olá! Este programa pede números e só para quando for inserido o número -1");
            Console.WriteLine("No final apresenta quantos são pares, quantos impares, a quantidade de números inseridos e a média dos mesmos");
            do
            {
                Console.WriteLine("Por favor insira um número.");
                num1 = Convert.ToInt16(Console.ReadLine());
                if (num1 != -1)
                {
                    acum++;
                    if (num1 % 2 == 0)
                        par++;
                    else
                        impar++;

                    soma += num1;
                }
                else
                    continue;
            } while (num1 != -1);
            media = soma / acum;
            Console.WriteLine("Números inseridos: " + acum);
            Console.WriteLine("Números pares: " + par);
            Console.WriteLine("Números impares: " + impar);
            Console.WriteLine("Média: " + media);
        }
    }
}
