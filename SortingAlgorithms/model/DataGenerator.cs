using System;

namespace SortingAlgorithms.model
{
    internal class DataGenerator
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
            if ((size == 1) && (order == 3))
            {
                Conf10();
            }

            //caso Generate(0, 4, count)
            if ((size == 1) && (order == 4))
            {
                Conf11();
            }

            //caso Generate(0, 5, count)
            if ((size == 1) && (order == 5))
            {
                Conf12();
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
            int[] data = new int[count];

            for (int i = data.Length - 1; i >= 0; i--)
            {
                data[i] = i;
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

            int[] data = new int[10^(r.Next(1,7))];

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

            int[] data = new int[r.Next(10^(r.Next(1,7))];

            for (int i = data.Length - 1; i >= 0; i--)
            {
                data[i] = i;
            }

            return data;
        }

        //Genera arreglo con tamaño Aleatorio, orden aleatorio
        private static int[] Conf12()
        {
            Random r = new Random();

            int[] data = new int[r.Next(10^(r.Next(1,7)))];

            for (int i = 0; i < data.Length; i++)
            {
                 data[i] = r.Next(0,10000);
            }

            return data;
        }
    }
}