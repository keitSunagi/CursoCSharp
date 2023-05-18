using DictionaryProblem.Entities;
using System;
using System.Collections.Generic;
using System.IO;


namespace DictionaryProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> _candidates = new Dictionary<string, int>();

            Console.Write("Source file: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int vote = int.Parse(line[1]);
                        if (!_candidates.ContainsKey(name))
                        {
                            _candidates.Add(name, vote);
                        }
                        else
                        {
                            int sum = _candidates[name] + vote;
                            _candidates[name] = sum;
                        }

                    }
                }
                Console.WriteLine();

                foreach (var i in _candidates)
                {
                    Console.WriteLine(i.Key + " : " + i.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}