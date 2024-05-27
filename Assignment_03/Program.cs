using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;
        bool continueCalculation = true;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); 
            switch (choice)
            {
                case '1':
                    GetNumbersAndOperation(out num1, out num2, '+');
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case '2':
                    GetNumbersAndOperation(out num1, out num2, '-');
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case '3':
                    GetNumbersAndOperation(out num1, out num2, '*');
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case '4':
                    GetNumbersAndOperation(out num1, out num2, '/');
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                case '5':
                    continueCalculation = false;
                    Console.WriteLine("Exiting the calculator.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine(); // Add a newline for readability

        } while (continueCalculation);
    }

    static void GetNumbersAndOperation(out double num1, out double num2, char op)
    {
        Console.Write("Enter the first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the first number: ");
        }

        Console.Write("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the second number: ");
        }

        Console.WriteLine($"Performing {op} operation on {num1} and {num2}...");
    }
}
