using System;

class Program
{
    static void Main()
    {
        try
        {
            // Intentionally dividing by zero to throw DivideByZeroException
            int numerator = 10;
            int denominator = 0;
            int result = DivideNumbers(numerator, denominator);

            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        // Check for zero denominator before performing division
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }
}
