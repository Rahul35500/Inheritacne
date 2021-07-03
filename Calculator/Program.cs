using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int secondInput = int.Parse(Console.ReadLine());
            int result = 0;
            switch (option)
            {
                case 1:
                    {
                        result = Addition(firstInput, secondInput);
                        Console.WriteLine($"The result is {result}");
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(firstInput, secondInput);
                        Console.WriteLine($"The result is {result}");
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(firstInput, secondInput);
                        Console.WriteLine($"The result is {result}");
                        break;
                    }
                case 4:
                    {
                        result = Division(firstInput, secondInput);
                        Console.WriteLine($"The result is {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong option!! try again");
                    break;
            }
        }
        public static int Addition(int FirstInput, int secondInput)
        {
            int result = FirstInput + secondInput;
            return result;
        }
        public static int Subtraction(int FirstInput, int secondInput)
        {
            int result = FirstInput - secondInput;
            return result;
        }
        public static int Multiplication(int FirstInput, int secondInput)
        {
            int result = FirstInput * secondInput;
            return result;
        }
        public static int Division(int FirstInput, int secondInput)
        {
            int result = FirstInput / secondInput;
            return result;
        }

    }
}
