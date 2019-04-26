using System;

namespace Quicksort
{
    class Program
    {
        private static int Partition(int[] array, int start, int end)
        {
            int tmp;
            int mark = start;  
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end])
                {
                    tmp = array[mark];
                    array[mark] = array[i];
                    array[i] = tmp;
                    mark += 1;
                }
            }
            tmp = array[mark];
            array[mark] = array[end];
            array[end] = tmp;
            return mark;
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }

        private static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }

        private static int[] Init()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(10);
            return array;
        }

        public static void Main()
        {
            
            int[] array = Init();
            Console.WriteLine("Массив до сортировки:");
            Display(array);
            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Массив после сортировки:");
            Display(array);
            Console.ReadKey();
        }
    }
}
