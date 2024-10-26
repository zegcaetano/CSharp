using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("Este programa faz a tabuada de um nr pedido");
            num1 = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+ " * "+ num1+ " = "+ i * num1);


            }

        }
    }
}
