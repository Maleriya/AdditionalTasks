using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Подсчет количества знаков в строке.");

            string str = "В этой строке 23 знака.";
            str.StrWrite();

            str = "";
            str.StrWrite();

            str = null;
            str.StrWrite();

            Console.ReadLine();

            /////////////////////////////////////////////////////////////////
            
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            List<int> listInt = new List<int> { 1, 2, 3, 3, 4, 4, 4, 1, 3, 0 };

            Console.WriteLine($"Подсчет, сколько раз каждый элемент встречается в коллекции {string.Join(",", listInt)}");

            foreach (var item in listInt)
            {
                if (keyValues.ContainsKey(item))
                    keyValues[item]++;
                else
                    keyValues.Add(item, 1);
            }

            foreach (var keyValue in keyValues)
            {
                Console.WriteLine($"{keyValue.Key} повторяется {keyValue.Value} раз");
            }

            Console.WriteLine($"\nПодсчет, сколько раз каждый элемент встречается в коллекции {string.Join(",", listInt)} с помощью LINQ");

            foreach (var item in listInt.GroupBy(x => x))
            {
                Console.WriteLine($"{item.Key} повторяется {item.Count()} раз");
            }

            Console.ReadLine();
        }

    }

    public static class UnionExtension
    {
        public static int CountChar(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            return str.Length;
        }

        public static void StrWrite(this string str)
        {
            Console.WriteLine($"'{str}' - {str.CountChar()}");
        }
    }
}
