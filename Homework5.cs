namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1 method()
        Console.WriteLine("=======  Question 1  =========="); // Line separator
        int a = 3, b = 5;
        int largest = GetLargest(a, b);
        Console.WriteLine("a = " + a + "; b = " + b);
        Console.WriteLine("The largest number is: " + largest);
        Console.WriteLine(); // blank line as separator
        
        // User input parameters.
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int userLargest = GetLargest(num1, num2);
        Console.WriteLine("You entered: a = " + num1 + "; b = " + num2);
        Console.WriteLine("The largest number is: " + userLargest);
        Console.WriteLine(); // blank line separtor

        // Call Q2 method
        Console.WriteLine("=======  Question 2  =========="); // Line separator    
        int largestOfFour = GetLargestOfFour();
        Console.WriteLine("The largest number is: " + largestOfFour);
        Console.WriteLine(); // blank line separtor

        //Call Q3 method
        Console.WriteLine("======= Question 3 =======");
        Console.WriteLine("===== Create Account =====");
        createAccount();
    }
    // Q1 method that returns the largest number.
    static int GetLargest(int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }
    // Q2 method that returns the largest number out of four numbers.
    static int GetLargestOfFour()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int d = Convert.ToInt32(Console.ReadLine());
        int max1 = GetLargest(a, b);
        int max2 = GetLargest(c, d);
        int max = GetLargest(max1, max2);
        return max;
    }
    // Method to check age
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        if (age >= 18)
            return true;
        else
            return false;
    }
    // Method to create account
    static void createAccount()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine()!;
        Console.Write("Enter your password: ");
        string password1 = Console.ReadLine()!;
        Console.Write("Enter your password again: ");
        string password2 = Console.ReadLine()!;
        Console.Write("Enter your birth year: ");
        int birthyear = Convert.ToInt32(Console.ReadLine());
        if (checkAge(birthyear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
