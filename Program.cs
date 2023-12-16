using System;
using System.Collections.Generic;

namespace ListOfLists
{
    internal class Program
    {
        static void Main()
        {
            List<List<string>> itembag = new List<List<string>>();
            List<string> weapons = new List<string> { "Меч", "Кинжал", "Арбалет" };

            itembag.Add(weapons);

            List<string> potions = new List<string> { "Зелье здоровья", "Зелье силы", "Зелье удачи" };

            itembag.Add(potions);

            for (int i = 0; i < itembag.Count; i++)
            {
                Console.WriteLine("Лист {0}", i);
                for (int j = 0; j < itembag[i].Count; j++)
                {
                    Console.WriteLine(itembag[i][j]);
                }

                Console.WriteLine();
            }

            List<List<string>> mylist = new List<List<string>>
            {
                new List<string> { "Один", "Два" },
                new List<string> { "Три", "Четыре", "Пять" },
                new List<string> { "Шесть", "Семь", "Восемь" },
                new List<string> { "Девять", "Десять" }
            };

            for (int i = 0; i < mylist.Count; i++)
            {
                List<string> sublist = mylist[i];
                Console.WriteLine("Лист {0}", i);
                for (int j = 0; j < sublist.Count; j++)
                {
                    var item = sublist[j];
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            for (int i = 0; i < mylist.Count; i++)
            {
                List<string> sublist = mylist[i];
                Console.WriteLine("Лист {0}", i);
                foreach (string item in sublist)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            foreach (List<string> sublist in mylist)
            {
                foreach (string item in sublist)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}