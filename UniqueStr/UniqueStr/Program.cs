using System;
using System.Collections.Generic;

namespace UniqueStr
{
    class Program
    {
        private static string Uniq(string str)
        {
            string[] sp = str.Split();
            Dictionary<string, int> words = new Dictionary<string, int>() { {sp[0], 1 } };
            string uniqWords = "";
            for (int i = 1; i < sp.Length; i++)
            {
                if (words.ContainsKey(sp[i]))
                    words[sp[i]] += 1;
                else
                    words.Add(sp[i], 1);
            }

            foreach(KeyValuePair<string, int> item in words)
            {
                if (item.Value == 1)
                    uniqWords += item.Key + ' ';
            }
            return uniqWords;
        }

        public static void Main()
        {
            string str = "word uniq4 word word text uniq1 text uniq2 word word uniq3";
            Console.WriteLine("Строка: {0}", str);
            Console.WriteLine("Уникальные слова в строке:");
            Console.WriteLine("{0}", Uniq(str));
            Console.ReadKey();
        }
    }
}
