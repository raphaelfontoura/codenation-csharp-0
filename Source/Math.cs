using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        int limite = 350;
        public List<int> Fibonacci()
        {
            List<int> fibonnaciNumbers = new List<int> { 0, 1 };
            int cont = 1;
            int fibNumber;
            while ((fibNumber = fibonnaciNumbers[cont] + fibonnaciNumbers[cont - 1]) <= limite)
            {
                fibonnaciNumbers.Add(fibNumber);
                cont++;
            }
            return fibonnaciNumbers;
        }

        public bool IsFibonacci(int numberToTest)
        {
            int i = 0;
            while (Fibonacci(i) <= numberToTest)
            {
                if (Fibonacci(i) == numberToTest) return true;
                i++;
            }
            return false;
        }

        public static int Fibonacci(int number)
        {
            return (number == 0 || number == 1) ? number : Fibonacci(number-1) + Fibonacci(number-2);
        }

    }

}
