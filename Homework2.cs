namespace Homework2;
using System;
class Program
{
    static void Main()
    {
        // Code for Q1 using the switch statement
        Console.WriteLine("Please input a letter grade:");
        string grade = Console.ReadLine();
        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }
        
        // Code for Q2 to find the smallest number
        Console.WriteLine("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int num3 = Convert.ToInt16(Console.ReadLine());
        int smallest;
        if (num1 < num2)
        {
            if (num1 < num3)
            {
                smallest = num1;
            }
            else
            {
                smallest = num3;
            }
        }
        else
        {
            if (num2 < num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
        }
        Console.WriteLine("The smallest value is: " + smallest);
        
        // Code for Q3 to find Leap Year
        Console.WriteLine("Please input a year:");
        int year = Convert.ToInt16(Console.ReadLine());
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    Console.WriteLine(year + " is a Leap Year.");
                else
                    Console.WriteLine(year + " is not a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}