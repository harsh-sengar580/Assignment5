using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulating different scenarios that may cause exceptions
            Console.WriteLine("Enter an index to access an array element:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = int.Parse(Console.ReadLine());
            AccessArrayElement(numbers, index);

            Console.WriteLine("Enter a number to parse:");
            string userInput = Console.ReadLine();
            int parsedNumber = ParseStringToInt(userInput);

            PerformOperation();

            Console.WriteLine($"Parsed number: {parsedNumber}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException caught: {ex.Message}");
            // Handle the exception gracefully for IndexOutOfRangeException
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException caught: {ex.Message}");
            // Handle the exception gracefully for FormatException
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"InvalidOperationException caught: {ex.Message}");
            // Handle the exception gracefully for InvalidOperationException
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Generic Exception caught: {ex.Message}");
            // Handle any other exceptions not specifically caught above
        }
    }

    static void AccessArrayElement(int[] array, int index)
    {
        // Attempt to access an element at the specified index in the array
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of bounds.");
        }

        Console.WriteLine($"Value at index {index}: {array[index]}");
    }

    static int ParseStringToInt(string input)
    {
        // Attempt to parse the string to an integer
        return int.Parse(input);
    }

    static void PerformOperation()
    {
        // Simulating an InvalidOperationException scenario
        throw new InvalidOperationException("Invalid operation.");
    }
}
