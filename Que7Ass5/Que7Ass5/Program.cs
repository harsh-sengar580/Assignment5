﻿using System;

class Program
{
    static void Main()
    {
        bool validInput = false;

        do
        {
            try
            {
                Console.WriteLine("Enter the numerator:");
                int numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the denominator:");
                int denominator = int.Parse(Console.ReadLine());

                // Check for division by zero
                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                // Perform the division
                int result = numerator / denominator;

                Console.WriteLine($"Result of {numerator} / {denominator} = {result}");
                validInput = true; // Set to true if division is successful
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        } while (!validInput);

        Console.WriteLine("Program End");
    }
}
