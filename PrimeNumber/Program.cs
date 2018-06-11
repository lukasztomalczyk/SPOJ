using System;
using System.Collections.Generic;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime;
            List<int> primeNumbers = new List<int>(new int[] { 2 });
            for (int i = 3; i < 100; i++)
            {
                isPrime = true;
                for (int j = 0; j < primeNumbers.Count; j++)
                    if ((i % primeNumbers[j]) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime) primeNumbers.Add(i);
            }
            foreach (int i in primeNumbers)
                Console.Write(i + ", ");
            Console.WriteLine();
        }
    }
}
