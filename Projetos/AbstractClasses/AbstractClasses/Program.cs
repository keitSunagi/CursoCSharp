using System;
using System.Collections.Generic;
using System.Globalization;
using AbstractClasses.Entities;

namespace AbstractClasses
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (ic)
                {
                    case 'i':
                        Console.Write("Health expeditures: ");
                        double healthExpeditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        IndividualPerson IndivPerson = new IndividualPerson(name,anualIncome,healthExpeditures);
                        list.Add(IndivPerson);
                        break;
                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberEmployees = int.Parse(Console.ReadLine());
                        CompanyPerson CompaPerson = new CompanyPerson(name,anualIncome,numberEmployees);
                        list.Add(CompaPerson);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Person person in list)
            {
                Console.WriteLine(person.Name + ": $ " + person.TaxCalculation().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();

            double sum = 0;
            foreach (Person person in list)
            {
                sum += person.TaxCalculation();
            }
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}