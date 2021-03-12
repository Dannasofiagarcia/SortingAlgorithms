namespace SortingAlgorithms.model
{
    public class Sorter
    {
        public static int[] sort(int[] array, int sortType)
        {
            if (sortType == 0)
            {
                return bubblesort(array);
            }
            else
            {
                quicksort(array, 0, array.Length - 1);
            }

            return array;
        }

        //
        private static int[] bubblesort(int[] array)
        {
            int[] vector = array;

            int aux;
            for (int i = 1; i < vector.Length; i++)
            {
                for (int j = vector.Length - 1; j >= i; j--)
                {
                    if (vector[j - 1] > vector[j])
                    {
                        aux = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            return vector;
        }

        private static void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }
    }
}