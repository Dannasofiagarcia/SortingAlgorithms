using SortingAlgorithms.model;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] data = DataGenerator.Generate(0,0,90);


            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
