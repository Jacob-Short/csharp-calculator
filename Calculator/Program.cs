using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Go ahead and enter a number:\n");
            double inputNumberOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Now please enter your second number:\n");
            double inputNumberTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Result:\n{inputNumberOne + inputNumberTwo}");


            Console.ReadLine();
        }
    }
}
