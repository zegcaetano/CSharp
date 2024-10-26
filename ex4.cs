using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Por favor insira o {i + 1}º valor");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(numeros);
            Console.WriteLine("\nValores no array:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            double media = numeros.Average();
            int maximo = numeros.Max();
            int minimo = numeros.Min();
            

            Console.WriteLine("\nMédia: " + media);
            Console.WriteLine("Máximo: " + maximo);
            Console.WriteLine("Mínimo: " + minimo);
        }
    }
}