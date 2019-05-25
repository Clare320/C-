using System;
using System.Collections.Generic;

namespace CSharpRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);
            Console.WriteLine($"--->{1.0 / 3.0 + 2}");
            Console.WriteLine($"max-->{decimal.MaxValue},min-->{decimal.MinValue}");

            // List
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.WriteLine($"One is {names[0]}, total is {names.Count}");
            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is as index {index}");
            
            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            //goto用法
            TestStatements testStatements = new TestStatements();
            // testStatements.learnGotoUsage();
            testStatements.learnYeildUsage();

        }
    }
}
