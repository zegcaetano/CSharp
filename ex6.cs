using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor insira um nr, " +
                "será apresentado a sua tabuada");

            int n = Convert.ToInt32(Console.ReadLine());
            Tabuada(n);
        }
        static void Tabuada(int n)
        {
            int total = 0;
            for (int i = 1; i <= 10; i++)
            {
                total = n * i;
                Console.WriteLine(i + " * " + n + " = " + total);

            }
        }
    }
    
}
