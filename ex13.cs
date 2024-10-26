using Classses_Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Classe Pessso com as propriedades Nome, genero, salario
 * Classe ListaPessoas
 * Menu 1 Inserir
 * 2 Listar
 * 3 Editar
 * 4 Apagar
 * 0 Sair
  */
namespace Classses_Listas
{
    public class pessoa
    {
        public string nome;
        public char genero;
        public double salario;

    }
    public class lista_pessoas
    {

        private static List<pessoa> lpessoas = new List<pessoa>();


        public void insere_pessoa()
        {
            pessoa pessoa1 = new pessoa();

            Console.WriteLine("Digite o nome da pessoa: ");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite o género da pessoa :");
            pessoa1.genero = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário da pessoa: ");
            pessoa1.salario = double.Parse(Console.ReadLine());

            lpessoas.Add(pessoa1);
        }
        public void lista_de_pessoas()
        {
            for (int i = 0; i < lpessoas.Count; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}: Nome: {lpessoas[i].nome}, Género: {lpessoas[i].genero}, Salário: {lpessoas[i].salario}");
            }
            Console.WriteLine("---------------");
            Console.ReadKey();
        }

        public void EditaPessoa()
        {
            lista_de_pessoas();
            Console.WriteLine("Digite o número da pessoa a ser editada:");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < lpessoas.Count)
            {
                pessoa pessoa1 = lpessoas[indice];

                Console.WriteLine("Digite o novo nome da pessoa: ");
                string novoNome = Console.ReadLine();
                    pessoa1.nome = novoNome;
                

                Console.WriteLine("Digite o novo género da pessoa: ");
                string novoGenero = Console.ReadLine();
                    pessoa1.genero = char.Parse(novoGenero);


                Console.WriteLine("Digite o novo salário da pessoa: ");
                string novoSalario = Console.ReadLine();
                    pessoa1.salario = double.Parse(novoSalario);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
        }
        public void ApagaPessoa()
        {
            Console.WriteLine("Digite o número da pessoa a ser apagada:");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < lpessoas.Count)
            {
                lpessoas.RemoveAt(indice);
                Console.WriteLine("Pessoa apagada com sucesso.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
        }
    }
}

        
    internal class Program
    {
       
        static void Main(string[] args)
    {

        lista_pessoas lp = new lista_pessoas();
        int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n Menu de Gestão de Pessoas");
                Console.WriteLine("\n 1 - Inserir Pessoa");
                Console.WriteLine("\n 2 - Listar Pessoas");
                Console.WriteLine("\n 3 - Editar Pessoas");
                Console.WriteLine("\n 4 - Apagar Pessoas");
                Console.WriteLine("\n 0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 0: Console.WriteLine("Adeus!");
                            break;
                    case 1:
                        {                           
                        Console.WriteLine("Inserir Pessoa");
                        lp.insere_pessoa();
                        break;
                        }
                    case 2:
                        {
                        Console.WriteLine("Listar Pessoas");
                        lp.lista_de_pessoas();
                        break;
                        }
                    case 3:
                        {
                        Console.WriteLine("Editar Pessoas");
                        lp.EditaPessoa();
                        break;
                        }
                    case 4:
                        {
                        Console.WriteLine("Apagar Pessoas");
                        lp.ApagaPessoa();
                        break;
                        }
                    default: Console.WriteLine("Por favor insira um nr de 0-4");
                        break;
                } 
            } while (opcao != 0);
        }
    }

