using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9P1
{
    internal class Task3
    {
        public static void Tas3()
        {
            Predicate<int> isEven = IsEven;
            Predicate<int> isOdd = IsOdd;
            Predicate<int> isPrime = IsPrime;
            Predicate<int> isFibonacci = IsFibonacci;

            Console.WriteLine($"Is 4 even? {isEven(4)}");
            Console.WriteLine($"Is 5 odd? {isOdd(5)}");
            Console.WriteLine($"Is 7 prime? {isPrime(7)}");
            Console.WriteLine($"Is 8 a Fibonacci number? {isFibonacci(8)}");
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static bool IsFibonacci(int number)
        {
            int a = 0, b = 1, temp;
            while (b < number)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            return number == b || number == 0;
        }
    }
}
