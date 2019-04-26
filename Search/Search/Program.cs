using System;

namespace Search
{
    class Program
    {
        private static int Search(int[] array, int key)
        {
            int max = array.Length - 1;
            int min = 0;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (array[mid] < key)
                    min = mid + 1;
                else if (array[mid] > key)
                    max = mid - 1;
                else
                    return mid;
            }
            return -1;
        }

        private static int[] Init()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            return array;
        }

        private static void Display(int[] array)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }

        public static void Main()
        {  
            int[] array = Init();
            Display(array);
            Console.WriteLine("Пожалуйста, введите значение для поиска:");

            try
            {
                int key = Convert.ToInt32(Console.ReadLine());
                int ind = Search(array, key);
                if (ind == -1)
                    Console.WriteLine("Заданного значения в массиве не найдено");
                else
                    Console.WriteLine("Заданное значение найдено в массиве с индексом: {0}", ind);
            }
            catch
            {
                Console.WriteLine("Вы ввели нечисловое значение!");
            }
            Console.ReadKey();
        }
    }
}
