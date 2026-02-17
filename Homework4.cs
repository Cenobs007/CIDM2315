namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Call Question 1 method()
        int a = 3, b = 5;
        int largest = GetLargest(a, b);
        Console.WriteLine("a = " + a + "; b = " + b);
        Console.WriteLine("The largest number is: " + largest);
        Console.WriteLine(); // blank line to give some space between the 2 questions.
        Console.WriteLine("================================"); // Line separating the 2 questions.

        // Call Question 2 method()
        PrintTriangle(5, "left");
        PrintTriangle(5, "right");        
    }

    // Question 1 method to find the largest of two numbers.
    static int GetLargest(int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }

    // Question 2 method on printing a triangle of * with the size of N with left or right alignment.
    static void PrintTriangle(int n, string shape)
    {
        Console.WriteLine($"N is: {n}; shape is {shape}");
        for (int i = 1; i <= n; i++)
        {
            if (shape == "right")
                Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', i));
        }
    }
}
