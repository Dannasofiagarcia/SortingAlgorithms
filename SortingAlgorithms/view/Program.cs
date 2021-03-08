using SortingAlgorithms.model;
using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] data = null;
            //Test configuracion = tipo tamaño fijo, orden ascendente, tamaño
            Console.WriteLine("Test configuracion = tipo tamaño fijo, orden ascendente, tamaño");

            data = DataGenerator.Generate(0, 1, 90);

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }

            //_____________________________________________________________________________________________________

            //Test configuracion = tipo tamaño fijo, orden descendente, tamaño
            Console.WriteLine("Test configuracion = tipo tamaño fijo, orden descendente, tamaño");

            data = DataGenerator.Generate(0, 1, 90);

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }

            //_____________________________________________________________________________________________________

            //Test configuracion = tipo tamaño fijo, orden aleatorio, tamaño
            Console.WriteLine("Test configuracion = tipo tamaño fijo, orden aleatorio, tamaño");

            data = DataGenerator.Generate(0, 2, 90);

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}