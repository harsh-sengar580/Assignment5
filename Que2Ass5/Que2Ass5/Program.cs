using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int index = 10;
            int value = GetElementAt(index, numbers);

            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }

    static int GetElementAt(int index, int[] array)
    {
        // Check if the index is within the bounds of the array
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of bounds.");
        }

        // Return the value at the specified index
        return array[index];
    }
}
