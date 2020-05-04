using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Enter Things");
        Label:
            string[] num = Console.ReadLine().Split(' ');
            if (num.Length == 3)
            {
                a = int.Parse(num[0]);
                b = int.Parse(num[2]);
                if (num[1].Equals("+"))
                {
                    x = a + b;
                    Console.WriteLine(x);
                }
                else if (num[1].Equals("-"))
                {
                    x = a - b;
                    Console.WriteLine(x);
                }
                else if (num[1].Equals("*"))
                {
                    x = a * b;
                    Console.WriteLine(x);
                }
                else if (num[1].Equals("/") || num[2].Equals("\""))
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Zero divide");
                    }
                    else
                    {
                        x = a / b;
                        Console.WriteLine(x);
                    }
                }
                Console.WriteLine("Yay, it works!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please, enter all numbers");
                goto Label;
            }
        }
    }
}
