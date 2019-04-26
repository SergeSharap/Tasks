using System;

namespace Factorial
{
    class Program
    {
        private static ulong Factorial(int x)
        {
            ulong res = 1;
            if (x == 0 || x == 1)
                return 1;
            else
                for (uint i = 2; i <= x; i++)
                    res *= i;
            return res;
        }

        public static void Main()
        {
            Console.WriteLine("Пожалуйста, введите число, которое находится в диапазоне от 0 до 65:");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 65 || x < 0)
                    Console.WriteLine("Вы ввели недопустимое значение!");
                else
                {
                    ulong res = Factorial(x);
                    Console.WriteLine("Факториал {0} равен: {1}", x, res);
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели нечисловое значение!");
            }
            Console.ReadKey();
        }
    }
}
