using System;

namespace SortingAlgorithms.model
{
    public class DataGenerator
    {
        public static int[] Generate(int size, int order, int count)
        {
            int[] data = null;

            //caso Generate(0, 0, count)
            if ((size == 0) && (order == 0))
            {
                data = Conf00(count);
            }

            //caso Generate(0, 1, count)
            if ((size == 0) && (order == 1))
            {
                data = Conf01(count);
            }

            //caso Generate(0, 2, count)
            if ((size == 0) && (order == 2))
            {
                data = Conf02(count);
            }

            //caso Generate(0, 3, count)
            if ((size == 1) && (order == 0))
            {
                data = Conf10();
            }

            //caso Generate(0, 4, count)
            if ((size == 1) && (order == 1))
            {
                data = Conf11();
            }

            //caso Generate(0, 5, count)
            if ((size == 1) && (order == 2))
            {
                data = Conf12();
            }

            return data;
        }

        //Genera arreglo con tamaño fijo, orden ascendente
        private static int[] Conf00(int count)
        {
            int[] data = new int[count];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            return data;
        }

        //Genera arreglo con tamaño fijo, orden descendente
        private static int[] Conf01(int count)
        {
            int[] temp = Conf00(count);
            int[] data = new int[count];

            int index = temp.Length - 1;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = temp[index];

                index--;
            }

            return data;
        }

        //Genera arreglo con tamaño fijo, orden aleatorio
        private static int[] Conf02(int count)
        {
            Random r = new Random();

            int[] data = new int[count];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(0, count + 1);
            }

            return data;
        }

        //Genera arreglo con tamaño Aleatorio, orden ascendente
        private static int[] Conf10()
        {
            Random r = new Random();

            int[] data = new int[(int)Math.Pow(10.0, (double)r.Next(1, 4))];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            return data;
        }

        //Genera arreglo con tamaño Aleatorio, orden descendente
        private static int[] Conf11()
        {
            Random r = new Random();

            int alSize = (int)Math.Pow(10.0, (double)r.Next(1, 4));

            Console.WriteLine(alSize);

            int[] data = new int[alSize];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            int[] data1 = new int[alSize];

            int index = data.Length - 1;

            for (int i = 0; i < data1.Length; i++)
            {
                data1[i] = data[index];

                index--;
            }

            return data1;
        }

        //Genera arreglo con tamaño Aleatorio, orden aleatorio
        private static int[] Conf12()
        {
            Random r = new Random();

            int[] data = new int[(int)Math.Pow(10.0, (double)r.Next(1, 4))];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(0, data.Length);
            }

            return data;
        }
    }
}