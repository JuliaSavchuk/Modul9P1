using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9P1
{
    public delegate int ArithmeticOperation(int a, int b);

    internal class Task2
    {
        public static void Tas2()
        {
            ArithmeticOperation add = Add;
            ArithmeticOperation subtract = Subtract;
            ArithmeticOperation multiply = Multiply;

            Console.WriteLine($"Addition: 5 + 3 = {add(5, 3)}");
            Console.WriteLine($"Subtraction: 5 - 3 = {subtract(5, 3)}");
            Console.WriteLine($"Multiplication: 5 * 3 = {multiply(5, 3)}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
