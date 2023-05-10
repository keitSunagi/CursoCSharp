using System;

namespace Program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProd = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            //---- SAIDA ---------//

            Console.WriteLine("Bem vindo " + nomeCompleto + ultimoNome);
            Console.WriteLine("Você mora em uma casa que tem " + quartos + " quartos.");
            Console.WriteLine("Cada quarto custa " + precoProd);
            Console.WriteLine("----------------------");
            Console.WriteLine("Altura: "+ altura);
            Console.WriteLine("Idade: " + idade);
        }
    }
}