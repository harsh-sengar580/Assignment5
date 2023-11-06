using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5Que3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "123Harshit"; 

            try
            {
                int number = int.Parse(userInput);
                Console.WriteLine("Parsed integer: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program completed.");
            }
        }
    }
    }

