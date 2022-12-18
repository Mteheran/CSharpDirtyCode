using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultOperation = 0;

            while (resultOperation < 1)
            {
                resultOperation = NewImplementation();
            }
        }

        private static int NewImplementation() {
            string inputMessage = "Type a Two numbers operation. Example: (5 - 3)";
            string[] num = new string[0];
            int result;

            while (num.Length != 3)
            {
                Console.WriteLine(inputMessage);
                num = Console.ReadLine().Trim().Split(' ');
            }

            if (!(int.TryParse(num[0], out int number_1) && int.TryParse(num[2], out int number_2))) return - 1;

            result = num[1] switch
            {
                "+" => number_1 + number_2,
                "-" => number_1 - number_2,
                "*" => number_1 * number_2,
                _ when (num[1] == "/" || num[1] == "\\") && number_2 != 0 => number_1 / number_2,
                _ => -1
            };

            Console.WriteLine(result == -1 ? "Invalid Operation" : $"Result operation is:{result}");
            return result;
        }

        private static void OldImplementation() {
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
