using System;
using System.Globalization;
using System.Collections.Generic;
using CSharpProductPolimorfic.Entities;

namespace CSharpProductPolimorfic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used of imported: ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                switch (c)
                {
                    case 'c':
                        list.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, date));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}