using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace ListOfLists
{
    internal class Program
    {
        static void Main(string[] args)
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

            for (var i = 0; i < myList.Count; i++)
            {
                var subList = myList[i];
                Console.WriteLine("Лист {0}", i);
                for (var index = 0; index < subList.Count; index++)
                {
                    var item = subList[index];
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            for (var i = 0; i < myList.Count; i++)
            {
                var subList = myList[i];
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