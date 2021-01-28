using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz!");
            FizzBuzz fizzBuzz = new FizzBuzz();
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your answer is {fizzBuzz.Get(userInput)}.");
        }
    }
}
