using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor insira um nr, " +
                "será apresentado a soma desse número com todos os números, desde o 1 até ele");

            int n = Convert.ToInt32(Console.ReadLine());
            Soma(n);
        }
        static void Soma(int n)
        {
            int total = 0;
            for (int i = 1; i < n; i++)
            {
                total = n + i;
                Console.WriteLine(i + " + " + n + " = " + total);

            }
        }
    }
}
