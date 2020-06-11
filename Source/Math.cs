using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        int limite = 350;
        public List<int> Fibonacci()
        {
            List<int> fibonnaciNumbers = new List<int> { 0, 1 };
            for (int n = 2; Fibonacci(n) <= limite; n++)
            {
                fibonnaciNumbers.Add(Fibonacci(n));
            }
            return fibonnaciNumbers;
        }

        public bool IsFibonacci(int numberToTest)
        {
            for(int i = 0; Fibonacci(i) <= numberToTest; i++)
            {
                if (Fibonacci(i) == numberToTest) return true;
            }
            return false;
        }

        private static int Fibonacci(int number)
        {
            return (number == 0 || number == 1) ? number : Fibonacci(number-1) + Fibonacci(number-2);
        }

    }

}
