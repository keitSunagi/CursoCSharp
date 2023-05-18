using System;
using ExercicioConjuntos.Entities;


namespace ExercicioConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> studentsA = new HashSet<Student>();
            

            Console.Write("How many students in Course A: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Student s = new Student(id);
                studentsA.Add(s);
            }

            Console.Write("How many students in Course B: ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Student s = new Student(id);
                studentsA.Add(s);
            }

            Console.Write("How many students in Course C: ");
            int n3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n3; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Student s = new Student(id);
                studentsA.Add(s);
            }

            Console.WriteLine();
            Console.WriteLine("Total Students: " + studentsA.Count);
        }
    }
}