

using CourseIntermediarie.Entities;

namespace CourseIntermediarie
{
     class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Travelling to New Zealand", "I'm going to visit this wonderful country", 12);
            Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);


            Console.WriteLine();
        }
    }
}