using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the operation (example: 5 - 2)");

            string[] num = Console.ReadLine().Split(' ');
            while (num.Length != 3)
            {
                Console.WriteLine("Enter the operation (example: 5 - 2)");
                num = Console.ReadLine().Split(' ');
                if (!int.TryParse(num[0], out int resultParseNumber1) || !int.TryParse(num[2], out int resultParseNumber2))
                {
                    num = new string[0];
                }
            }

            int number1, number2, operationResult;
            number1 = int.Parse(num[0]);
            number2 = int.Parse(num[2]);
            if (num[1].Equals("+"))
            {
                operationResult = number1 + number2;
                Console.WriteLine(operationResult);
            }
            else if (num[1].Equals("-"))
            {
                operationResult = number1 - number2;
                Console.WriteLine(operationResult);
            }
            else if (num[1].Equals("*"))
            {
                operationResult = number1 * number2;
                Console.WriteLine(operationResult);
            }
            else if (num[1].Equals("/") || num[2].Equals("\""))
            {
                Console.WriteLine(number2 == 0 ? "Zero divide" : (number1 / number2).ToString());
            }

            Console.WriteLine("Yay, it works!");
            Console.Read();
        }
    }
}
