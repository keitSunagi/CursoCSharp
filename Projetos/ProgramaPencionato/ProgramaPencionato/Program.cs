using System;
using System.Globalization;
using System.Collections.Generic;
using Programa;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listFuncionarios = new List<Funcionario>();

            //CADASTRO DE FUNCIONARIOS --------------------------------------------------
            Console.Write("Quantos funcionários serão registrados: ");
            int q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Empregado #" + i);
                Console.Write("Id: ");
                int ids = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario f1 = new Funcionario(nome, ids, salario);
                listFuncionarios.Add(f1);
            }
            //--------------------------------------------------------------------------
            //AUMENTO DE SALÁRIO -------------------------------------------------------
            Console.WriteLine("");
            Console.Write("Id do funcionário que terá salário aumentado: ");
            int id = int.Parse(Console.ReadLine());
            Funcionario f = listFuncionarios.Find(x => x.Id == id);
            if (f != null)
            {
                Console.Write("Porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.RiseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("Este funcionário não existe!");
            }
            //--------------------------------------------------------------------------
            //IMPRIMIR NA TELA A LISTA DE FUNCIONARIOS ---------------------------------
            Console.WriteLine("");
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach (Funcionario f1 in listFuncionarios)
            {
                Console.WriteLine(f1.ToString());
            }
            //---------------------------------------------------------------------------

        }
    }
}