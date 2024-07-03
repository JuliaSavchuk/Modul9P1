using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9P1
{
    public delegate int ArithmeticOperation2(int a, int b);

    internal class Task4
    {
        public static void Tas4()
        {
            ArithmeticOperation2 add = Add;
            ArithmeticOperation2 subtract = Subtract;
            ArithmeticOperation2 multiply = Multiply;

            Console.WriteLine($"Addition: 5 + 3 = {add.Invoke(5, 3)}");
            Console.WriteLine($"Subtraction: 5 - 3 = {subtract.Invoke(5, 3)}");
            Console.WriteLine($"Multiplication: 5 * 3 = {multiply.Invoke(5, 3)}");
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
