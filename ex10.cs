using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ex2
{
    internal class Program
    {
        public class ContaBancaria
        {
            private int saldo;
            private int montante;
            public void Depositar(int montante)
            {
                Console.WriteLine("Quanto quer depositar?");
                montante = int.Parse(Console.ReadLine());
                saldo += montante;
                Console.WriteLine("Saldo atual: " + saldo + " euros");
            }
            public void Levantar(int montante)
            {
                Console.WriteLine("Quanto quer levantar?");
                montante = int.Parse(Console.ReadLine());
                if (montante <= saldo)
                {
                    saldo -= montante;
                    Console.WriteLine("Saldo atual: " + saldo + " euros");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                    Console.WriteLine("Saldo atual: " + saldo + " euros");
                }
            }

            public ContaBancaria()
            {
                saldo = 0;
                montante = 0;
                Console.WriteLine("Novo objecto da classe ContaBancaria criado");
            }

            public void setSaldo(int saldo)
            {
                this.saldo = saldo;
            }

            public int getSaldo()
            {
                return saldo;
            }

            public void setMontante(int montante)
            {
                this.montante = montante;
            }

            public int getMontante()
            {
                return montante;
            }
        }
            static void Main(string[] args)
            {
                ContaBancaria CB = new ContaBancaria();

                int escolha = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Que operação pretende realizar?");
                    Console.WriteLine("1 - Depositar | 2 - Levantar | 3 - Sair");
                    escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            {
                                CB.Depositar(CB.getMontante());
                                Console.WriteLine("Pressione uma tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                CB.Levantar(CB.getMontante());
                                Console.WriteLine("Pressione uma tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Operação inválida!");
                                Console.WriteLine("Pressione uma tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }

                    }
                        

                } while (escolha != 3);
            }
        }
    }
