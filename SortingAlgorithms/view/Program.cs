using SortingAlgorithms.model;
using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        public static void menu()
        {
            Console.WriteLine("1. Realizar un experimento.");
            Console.WriteLine("0. Salir del programa");
        }

        private static void Main(string[] args)
        {
            int opt = 0, size, order = 0, count = 0, algType;

            int[] testArray = null;

            Console.WriteLine("AMBIENTE DE EXPERIMENTACION - ALGORITMOS DE ORDENAMIENTO", System.Environment.NewLine);

            do
            {
                menu();

                opt = Int32.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine();

                    Console.WriteLine("Tamaño del arreglo:");
                    Console.WriteLine("1. Fijo");
                    Console.WriteLine("2. Aleatorio");

                    opt = Int32.Parse(Console.ReadLine());

                    if (opt == 1)
                    {
                        size = 0;

                        Console.WriteLine("Ingrese el tamaño del arreglo");

                        count = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        size = 1;
                    }

                    Console.WriteLine("Orden del arreglo a generar:");
                    Console.WriteLine("1. Ascendente");
                    Console.WriteLine("2. Descendente");
                    Console.WriteLine("3. Aleatorio");

                    opt = Int32.Parse(Console.ReadLine());

                    if (opt == 1)
                    {
                        order = 0;
                    }
                    else if (opt == 2)
                    {
                        order = 1;
                    }
                    else
                    {
                        order = 2;
                    }

                    testArray = DataGenerator.Generate(size, order, count);

                    Console.WriteLine("Arreglo generado exitosamente");
                    Console.WriteLine();

                    Console.WriteLine("1. Mostrar arreglo");
                    Console.WriteLine("2. Continuar");

                    opt = Int32.Parse(Console.ReadLine());

                    if (opt == 1)
                    {
                        foreach (int item in testArray)
                        {
                            Console.Write(item + " ");
                        }
                    }

                    Console.WriteLine();

                    Console.WriteLine();

                    Console.WriteLine("Seleccione el algoritmo de ordenamiento:");

                    Console.WriteLine("1. Bubblesort");
                    Console.WriteLine("2. Quicksort de un pivote");

                    algType = Int32.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine();

                    Console.WriteLine("AMBIENTE EXPERIMENTAL PREPARADO");

                    Console.WriteLine("1. Ejecutar experimento");
                    Console.WriteLine("2. Abortar el experimento");

                    opt = Int32.Parse(Console.ReadLine());

                    if (opt == 1)
                    {
                        TimeSpan stop;
                        TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

                        //ORDENAMIENTO
                        testArray = Sorter.sort(testArray, algType);

                        stop = new TimeSpan(DateTime.Now.Ticks);

                        double time = stop.Subtract(start).TotalMilliseconds;
                        Console.WriteLine();

                        Console.WriteLine("Experimento finalizado!", System.Environment.NewLine);
                        Console.WriteLine();

                        Console.WriteLine("ESTADISTICAS:");
                        Console.WriteLine();

                        Console.WriteLine($"Tiempo transcurrido: {time}");
                        Console.WriteLine($"Tamaño del arreglo: {testArray.Length}");

                        String typeOrder = "";
                        if (order == 0)
                        {
                            typeOrder = "Orden Ascendente";
                        }
                        else if (order == 1)
                        {
                            typeOrder = "Orden Descendente";
                        }
                        else
                        {
                            typeOrder = "Orden Aleatorio";
                        }

                        Console.WriteLine($"Orden predefinido del arreglo: {typeOrder}");

                        Console.WriteLine();

                        Console.WriteLine("Ver arreglo ordenado:");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");

                        opt = Int32.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            foreach (int item in testArray)
                            {
                                Console.Write(item + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Finalizar el ambiente: ");
                    Console.WriteLine("0. Si");
                    Console.WriteLine("1. No, volver al menu principal");

                    opt = Int32.Parse(Console.ReadLine());
                }
            } while (opt != 0);
        }
    }
}