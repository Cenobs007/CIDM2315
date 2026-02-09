namespace Homework3;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Question 1 on checking if a number is prime or not.
        Console.WriteLine("Input an integer");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
            Console.WriteLine("N is prime");
        else
            Console.WriteLine("N is non-prime");

            // Question 2 on printing a square of # with the size of N.
            Console.WriteLine("Input an integer:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        /* Question 3 on printing a diagonal row of * with the size of X. 
        I decided to use 'X' instead of 'N' because of an error CS0108 that I was 
        getting when I tried to use 'N' for this question. I think it was because 
        I already used 'N' for the previous question and it was causing a conflict.*/
        Console.WriteLine("Assign an int value to X:");
        int X = Convert.ToInt32(Console.ReadLine());
        for (int row = 1; row <= X; row++)
        {
            for (int col = 1; col <= X; col++)
            {
                if (col <= row)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        // Bonus question
        Console.WriteLine("Assign an int value to Y:");
        int Y = Convert.ToInt32(Console.ReadLine());
        for (int row = 1; row <= Y; row++)
        {
            for (int space = 1; space <= Y - row; space++)
            {
                Console.Write(" ");
            }            
            for (int col = 1; col <= row; col++)
            {
                Console.Write(row);
            }
            Console.WriteLine();
        }
    }
}