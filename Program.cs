using System;

namespace Method2
{
    // Step 1: Create a class with a method that takes two integers as parameters.
    public class MathOperations
    {
        // Method that performs a math operation on two integers and returns the result.
        public int PerformMathOperation(int number1, int number2 = 0)
        {
            // If the second number is not provided by the user, it defaults to 0.
            // Perform some math operation on the two numbers.
            int result = number1 * number2; // Example: Multiplication operation

            // Return the result as an integer.
            return result;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                // Step 2: Instantiate the MathOperations class.
                MathOperations mathOperations = new MathOperations();

                // Step 3: Ask the user to input two numbers.
                Console.WriteLine("Enter the first number:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number (optional):");
                string inputNumber2 = Console.ReadLine();

                int number2;
                bool hasSecondNumber = int.TryParse(inputNumber2, out number2);

                Console.WriteLine();

                // Step 4: Call the method in the class, passing in the entered numbers.
                int result;

                if (hasSecondNumber)
                    {
                        // Call the method with two numbers.
                        result = mathOperations.PerformMathOperation(number1, number2);
                        Console.WriteLine($"Result of math operation: {number1} * {number2} = {result}");
                    }
                else
                    {
                        // Call the method with only one number.
                        result = mathOperations.PerformMathOperation(number1);
                        Console.WriteLine($"Result of math operation: {number1} * 0 = {result}");
                    }
            }
        }
}
