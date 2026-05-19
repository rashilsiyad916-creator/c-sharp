using System;

class Program
{
    static void Main()
    {

        //task 1 day 2

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


        //task 2 day 2 


        Console.Write("Enter size: ");

        int n = Convert.ToInt32(Console.ReadLine());

        // Upper part
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Lower part
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
