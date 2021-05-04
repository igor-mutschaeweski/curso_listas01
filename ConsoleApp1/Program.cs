using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("PROGRAMAÇÃO ORIENTADA A OBJETOS");
            Console.WriteLine("===============================");
            Console.WriteLine("========================================");
            Console.WriteLine("COMPORTAMENTO DE MEMÓRIA, ARRAYS, LISTAS");
            Console.WriteLine("========================================");

            Console.WriteLine();

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Funcionário #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
            }
            Console.WriteLine();

            Console.Write("Entre com o Id do funcionário que terá aumento de salário: ");
            int pesquisarId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == pesquisarId);

            if (emp != null)
            {
                Console.Write("Insira o percentual: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(percentual);
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }
            Console.WriteLine();

            Console.WriteLine("Lista atualizada de funcionários:");
            
            Console.WriteLine();

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
