using System;

namespace MultiTask
{
    public delegate void Calculate(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:\n");
            int input1 = int.Parse( Console.ReadLine());

            Console.Write("Enter second number:\n");
            int input2 = int.Parse( Console.ReadLine());

            Calculate calculate = Add;
            calculate += Multiplication;

            calculate(input1, input2);

            
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiplication(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
    }
}
