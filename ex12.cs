using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        public class Empresa
        {
            private int numFunc;
            ArrayList funcionarios = new ArrayList();
            public void popular()
            {
                Console.WriteLine("Quantos funcionários tem a empresa?");
                numFunc = int.Parse(Console.ReadLine());

                for (int i = 0; i < numFunc; i++)
                {
                    Funcionario funcionario = new Funcionario();

                    Console.WriteLine($"Digite o nome do funcionário {i + 1}:");
                    funcionario.setNome(Console.ReadLine());

                    Console.WriteLine($"Digite o departamento do funcionário {i + 1}:");
                    funcionario.setDepartamento(Console.ReadLine());

                    Console.WriteLine($"Digite o salário do funcionário {i + 1}:");
                    funcionario.setSalario(double.Parse(Console.ReadLine()));

                    funcionarios.Add(funcionario);
                }
            }
            public void MostrarFuncionarios()
            {
                for (int i = 0; i < funcionarios.Count; i++)
                {
                    Funcionario f = (Funcionario)funcionarios[i];
                    Console.WriteLine($"Funcionário {i + 1}: Nome: {f.getNome()}, Departamento: {f.getDepartamento()}, Salário: {f.getSalario()}");
                }
            }
            public Empresa()
            {
                numFunc = 0;
                Console.WriteLine("Novo objecto da classe Empresa criado");

            }
            public class Funcionario
        {
            private string nome;
            private string departamento;
            private double salario;

            public Funcionario()
                {
                    nome = "";
                    departamento = "";
                    salario = 0;
                    Console.WriteLine("Novo objecto da classe Funcionario criado");
                }

                public void setNome(string nome)
                {
                    this.nome = nome;
                }

                public string getNome()
                {
                    return nome;
                }

                public void setDepartamento(string departamento)
                {
                    this.departamento = departamento;
                }

                public string getDepartamento()
                {
                    return departamento;
                }

                public void setSalario(double salario)
                {
                    this.salario = salario;
                }

                public double getSalario()
                {
                    return salario;
                }

            }//fim da classe funcionario
            public void setNumFunc(int numFunc)
            {
                this.numFunc = numFunc;
            }

            public int getNumFunc()
            {
                return numFunc;
            }

        }//fim da classe empresa
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            empresa.popular();
            empresa.MostrarFuncionarios();
        }
    }
}
