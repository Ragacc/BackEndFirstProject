using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Functions_Class
    {
        public int Mimateba(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Gamokleba(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Gamravleba(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Gayofa(int num1, int num2)
        {
            return num1 / num2;
        }

        public void kalkulaciebi()
        {

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Avalible functions: /; *; +; -");
            string func = (Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int rand = 0;
            switch (func)
            {
                case "/":
                    rand = Gayofa(num1, num2);
                    Console.WriteLine($"{rand}");
                    break;

                case "*":
                    rand = Gamravleba(num1, num2);
                    Console.WriteLine($"{rand}");
                    break;
                case "-":
                    rand = Gamokleba(num1, num2);
                    Console.WriteLine($"{rand}");
                    break;
                case "+":
                    rand = Mimateba(num1, num2);
                    Console.WriteLine($"{rand}");
                    break;
            }

        }
    }
}
