using PedidoOrdem.Entities;
using PedidoOrdem.Entities.Enums;
using System;
using System.Globalization;

namespace PedidoOrdem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.WriteLine();


            Console.WriteLine("Enter Order Data:");
            Console.Write("Status: ");
            OrderStatus orderstats = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?: ");
            int quantityItems = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, orderstats, client);
            Console.WriteLine();

            
            for (int i = 0; i < quantityItems; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: $");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, priceProduct);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderI = new OrderItem(quantity, product);
                order.AddItem(orderI);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}