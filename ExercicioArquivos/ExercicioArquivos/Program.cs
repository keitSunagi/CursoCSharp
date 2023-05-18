using System.IO;
using System;
using System.Globalization;
using ExercicioArquivos.Entities;

namespace ExercicioArquivos
{
     class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"\Users\lukas\Desktop\Curso C# Completo\Projetos\ExercicioArquivos\ExercicioArquivos\Files";
            string targetPath = @"\Users\lukas\Desktop\Curso C# Completo\Projetos\ExercicioArquivos\ExercicioArquivos\Files\out\Sumary.csv";

            string targetFolderPath = @"out";


            try
            {
                Directory.CreateDirectory(targetFolderPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    string[] strings = line.Split(",");
                    string name = strings[0];
                    double value = double.Parse(strings[1]);
                    int quantity = int.Parse(strings[2]);

                    Product p = new Product(name, quantity, value);

                    using(StreamWriter sw = File.AppendText(targetPath))
                    {
                        sw.WriteLine(p.Name + ", " + p.TotalPrice().ToString("F2",CultureInfo.InvariantCulture));
                    }

                    
                }
                

            }catch(IOException e)
            {
                Console.WriteLine("Error! :");
                Console.WriteLine(e.Message);
            }
        }
    }
}