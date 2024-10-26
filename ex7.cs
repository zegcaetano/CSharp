using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um nr, o programa calcula se é primo");
            int n = Convert.ToInt32(Console.ReadLine());
            bool prime = Primo(n);
            
            
            if (prime)
            {
                Console.WriteLine("O número é primo");
            }
            else
            {
                Console.WriteLine("O número não é primo");
            }
        }
        static bool Primo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}