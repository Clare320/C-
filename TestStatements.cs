using System;

namespace CSharpRoad
{
    public class TestStatements
    {
        public void learnGotoUsage() {
            Console.WriteLine("Goto Usage.");
            Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
            Console.WriteLine("Please enter your selection: ");
            //TODO: -- 这一步执行有问题
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int cost = 0;
            Console.WriteLine(n);
            switch (n)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost += 25;
                    goto case 1;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            // 在Switch语法中 goto用于跳转到具体的case；在普通顺序语句中，goto可以跳转到指定的标签
            /**
                int a = 4;
                if ( a < 5) {
                    goto NotFound;
                }
                
                NotFound:
                    Console.WriteLine("Not Found.");

             */
        }

        public void learnYeildUsage() 
        {
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent) 
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

    }
}