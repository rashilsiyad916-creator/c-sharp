using System;

class Program
{
    static void Main()
    {
        int number = 13;
        bool isPrime = true;

        // 0 and 1 are not prime
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            // Check divisibility
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Output
        if (isPrime)
        {
            Console.WriteLine(number + " is a Prime Number");
        }
        else
        {
            Console.WriteLine(number + " is Not a Prime Number");
        }
    }
}
