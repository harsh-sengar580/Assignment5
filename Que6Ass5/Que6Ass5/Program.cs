using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer Try Block Start");

            try
            {
                Console.WriteLine("Inner Try Block Start");

                // Simulating an exception in the inner block
                ThrowInnerException();

                Console.WriteLine("Inner Try Block End");
            }
            catch (Exception innerException)
            {
                Console.WriteLine($"Inner Catch Block: {innerException.Message}");
                // Handle the exception from the inner block in the outer block
                throw; // Rethrow the exception to be caught by the outer catch block
            }
            finally
            {
                Console.WriteLine("Inner Finally Block");
            }

            Console.WriteLine("Outer Try Block End");
        }
        catch (Exception outerException)
        {
            Console.WriteLine($"Outer Catch Block: {outerException.Message}");
            // Handle the exception caught from the inner block
        }
        finally
        {
            Console.WriteLine("Outer Finally Block");
        }

        Console.WriteLine("Program End");
    }

    static void ThrowInnerException()
    {
        // Simulating an exception in the inner block
        throw new ApplicationException("Exception in the inner block.");
    }
}
