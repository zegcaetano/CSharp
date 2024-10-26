using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        public class Livro
        {
            private string titulo;
            private string autor;
            private string ano;
            
            public void Mostra()
            {
                Console.WriteLine("Título: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Ano: " + ano);
            }
    
        public Livro()
        {
            titulo = "";
            autor = "";
            ano = "";
            Console.WriteLine("Novo objecto da classe Livro criado");
        }

            public void setTitulo(string titulo)
            {
                this.titulo = titulo;
            }

            public string getTitulo()
            {
                return titulo;
            }

            public void setAutor(string autor)
            {
                this.autor = autor;
            }

            public string getAutor()
            {
                return autor;
            }

            public void setAno(string ano)
            {
                this.ano = ano;
            }

            public string getAno()
            {
                return ano;
            }


        }
    static void Main(string[] args)
        {
            Livro l1 = new Livro();
            Console.WriteLine("Insira o título do livro: ");
            l1.setTitulo(Console.ReadLine());
            Console.WriteLine("Insira o autor do livro: ");
            l1.setAutor(Console.ReadLine());
            Console.WriteLine("Insira o ano em que foi lançado o livro: ");
            l1.setAno(Console.ReadLine());
            l1.Mostra();
        }
    }
}
