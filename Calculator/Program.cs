using System;

namespace Calculator
{
    class Program
    {


        static double Addition(double x, double y)
        {
            return x + y;
        }

        static double Subtraction(double x, double y)
        {
            return x - y;
        }

        static double Division(double x, double y)
        {
            return x / y;
        }

        static double Multiplication(double x, double y)
        {
            return x * y;
        }


        static void Main(string[] args)
        {
            bool gameLoop = true;
            while (gameLoop)
            {

                Console.WriteLine("Calculator...\n");
                Console.WriteLine("Lets do some Math <3\n");

                Console.WriteLine("1. Addition - (+)\n");
                Console.WriteLine("2. Subtraction - (-)\n");
                Console.WriteLine("3. Division - (/)\n");
                Console.WriteLine("4. Multiplication - (*)\n");
                Console.WriteLine("First select an operation:\n");
                int inputOperation = Convert.ToInt32(Console.ReadLine());


                Console.Write("Go ahead and enter a number:\n");
                double inputNumberOne = Convert.ToDouble(Console.ReadLine());

                Console.Write("Now please enter your second number:\n");
                double inputNumberTwo = Convert.ToDouble(Console.ReadLine());

                double result;

                switch (inputOperation)
                {
                    case 1:
                        result = Addition(inputNumberOne, inputNumberTwo);
                        Console.WriteLine($"Your answer is:\n{result}");
                        break;
                    case 2:
                        result = Subtraction(inputNumberOne, inputNumberTwo);
                        Console.WriteLine($"Your answer is:\n{result}");
                        break;
                    case 3:
                        result = Division(inputNumberOne, inputNumberTwo);
                        Console.WriteLine($"Your answer is:\n{result}");
                        break;
                    case 4:
                        result = Multiplication(inputNumberOne, inputNumberTwo);
                        Console.WriteLine($"Your answer is:\n{result}");
                        break;
                    default:
                        Console.WriteLine("Sorry that was not a valid option");
                        break;

                }

                gameLoop = false;


            }
        }


    }
}
