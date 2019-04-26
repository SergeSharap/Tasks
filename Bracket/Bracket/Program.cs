using System;
using System.Collections.Generic;

namespace Bracket
{
    class Program
    {
        private static bool CheckBracket(string str)
        {
            Stack<char> symbolStorage = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '{' || str[i] == '[' || str[i] == '(')
                {
                    symbolStorage.Push(str[i]);
                    continue;
                }
                if (str[i] == '}' || str[i] == ']' || str[i] == ')')
                {
                    if (symbolStorage.Count > 0)
                    {
                        char symb = symbolStorage.Peek();
                        if ((str[i] == '}' && symb == '{') || (str[i] == ']' && symb == '[') || (str[i] == ')' && symb == '('))
                        {
                            symbolStorage.Pop();
                            continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return symbolStorage.Count == 0;
        }

        public static void Main()
        {
            //string str = "([]()";
            //string str = "([]{(})";
            //string str = "((([]()";
            //string str = "([]()}}";
            //string str = "[]()";
            //string str = "([][()])";

            Console.WriteLine("Введите скобочную последовательность:");
            string str = Console.ReadLine();

            bool f = CheckBracket(str);
            if (f)
                Console.WriteLine("Вы ввели верную скобочную последовательность.");
            else
                Console.WriteLine("Вы ввели неверную скобочную последовательность.");
            Console.ReadKey();
        }
    }
}
