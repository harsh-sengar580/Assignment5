using System;

class Program
{
    static void Main()
    {
        try
        {
            // Attempting to convert a string to an integer
            string input = "abc";
            int result = ConvertStringToInt(input);

            Console.WriteLine($"Converted value: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            // Handle the exception gracefully, you can log the exception or take appropriate actions
        }
    }

    static int ConvertStringToInt(string input)
    {
        // Attempt to convert the string to an integer
        return int.Parse(input);
    }
}
