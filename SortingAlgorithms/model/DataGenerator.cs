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

            //caso Generate(0, 0, ignored number)
            if((size == 0) && (order == 0))
            {
                data = Conf00(count);
            }

            return data;
        }

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
