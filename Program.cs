using System;
using System.Collections.Generic;

namespace ListOfLists
{
    internal class Program
    {
        static void Main()
        {
            List<List<string>> itemBag = new List<List<string>>();
            List<string> weapons = new List<string>
            {
                "Sword",
                "Dagger",
                "Crossbow"
            };

            itemBag.Add(weapons);

            List<string> potions = new List<string>
            {
                "Health Potion",
                "Strength Potion",
                "Luck Potion"
            };

            itemBag.Add(potions);

            for (int i = 0; i < itemBag.Count; i++)
            {
                Console.WriteLine("Лист {0}", i);
                for (int j = 0; j < itemBag[i].Count; j++)
                {
                    Console.WriteLine(itemBag[i][j]);
                }

                Console.WriteLine();
            }

            List<List<string>> myList = new List<List<string>>
            {
                new List<string> { "Один", "Два" },
                new List<string> { "Три", "Четыре", "Пять" },
                new List<string> { "Шесть", "Семь", "Восемь" },
                new List<string> { "Девять", "Десять" }
            };

            for (int i = 0; i < myList.Count; i++)
            {
                List<string> subList = myList[i];
                Console.WriteLine("Лист {0}", i);
                for (int j = 0; j < subList.Count; j++)
                {
                    var item = subList[j];
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            for (int i = 0; i < myList.Count; i++)
            {
                List<string> subList = myList[i];
                Console.WriteLine("Лист {0}", i);
                foreach (string item in subList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            foreach (List<string> subList in myList)
            {
                foreach (string item in subList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}