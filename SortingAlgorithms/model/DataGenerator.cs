using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.model
{
    class DataGenerator
    {

        public static int[] Generate(int size, int order, int count)
        {

            int[] data = null;

            //caso Generate(0, 0, count)
            if ((size == 0) && (order == 0))
            {
                data = Conf00(count);
            }

            if ((size == 0) && (order == 1))
            {
                data = Conf01(count);

            }


            if ((size == 0) && (order == 2))
            {
                data = Conf02(count);

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


    }
}
