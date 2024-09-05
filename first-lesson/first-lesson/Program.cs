using System;
using first_lesson.FibonacciLib;

namespace first_lesson {
    class Program {
        static void Main(string[] args) {
            Console.Write("Введите длину последовательности Фибоначчи: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] fib = Fibonacci.Fib(n);

            for (int i = 0; i < n - 1; ++i) {
                Console.Write($"{fib[i]}, ");
            }
            Console.WriteLine($"{fib[n - 1]}");

            Console.ReadKey();
        }
    }
}