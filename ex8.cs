using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = SolicitarQuantidade();
            int[] numeros = SolicitarNumeros(quantidade);
            int soma = Soma(numeros);
            double media = Media(soma, quantidade);
            Resultado(soma, media);
        }
        static int SolicitarQuantidade()
        {
            Console.WriteLine("Indique a quantidade de nrs que quer inserir");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] SolicitarNumeros(int quantidade)
        {
            int[] numeros = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Insira o nr {i+1}");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numeros;
        }

        static int Soma(int[] numeros)
        {
            int soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }
            return soma;

        }
        
        static double Media(int soma, int quantidade)
        {
            return (double)soma / quantidade;
        }

        static void Resultado(int soma, double media)
        {
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
        }
    }
}
