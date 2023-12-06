using System;

// Custom exception class
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Simulating a condition that triggers the custom exception
            int number = -5;
            CheckPositiveNumber(number);

            Console.WriteLine($"Number is positive: {number}");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"CustomException caught: {ex.Message}");
            // Handle the custom exception gracefully, you can log the exception or take appropriate actions
        }
    }

    static void CheckPositiveNumber(int number)
    {
        // Check if the number is positive; if not, throw the custom exception
        if (number < 0)
        {
            throw new CustomException("Number must be positive.");
        }
    }
}
