using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        public class Pessoa
        {
            private string nome;
            private int idade;
            private double altura;
            public void Cumprimentar(String nome)
            {
                Console.WriteLine("Olá, "+nome);
            }
            public Pessoa()
            {
                nome = "";
                idade = 0;
                altura = 0;
                Console.WriteLine("Novo objecto da classe Pessoa criado");
            }
            
            public void setNome(String nome) 
            {
                this.nome = nome;
            }

            public string getNome()
            {
                return nome;
            }

            public void setIdade(int idade)
            {
                this.idade = idade;
            }

            public int getIdade()
            {
                return idade;
            }

            public void setAltura(double altura)
            {
                this.altura = altura;
            }

            public double getAltura()
            {
                return altura;
            }
        }

        public class lista_pessoas
        {
            private static List<Pessoa> lpessoas = new List<Pessoa>();
        }
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.setNome("José Caetano");
            pessoa.setIdade(33);
            pessoa.setAltura(1.80);

            Console.WriteLine("Nome: "+pessoa.getNome()+
                              "\nIdade: "+pessoa.getIdade()+
                              "\nAltura: "+pessoa.getAltura());
            pessoa.Cumprimentar(pessoa.getNome());

            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Insira o nome da pessoa: ");
            pessoa2.setNome(Console.ReadLine());
            Console.WriteLine("Insira a idade da pessoa: ");
            pessoa2.setIdade(int.Parse(Console.ReadLine()));
            Console.WriteLine("Insira a altura da pessoa: ");
            pessoa2.setAltura(double.Parse(Console.ReadLine()));

            Console.WriteLine("Nome: " + pessoa2.getNome() +
                             "\nIdade: " + pessoa2.getIdade() +
                             "\nAltura: " + pessoa2.getAltura());
            pessoa.Cumprimentar(pessoa2.getNome());
            
        }
    }
}
