using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input format for the first number.");
            return;
        }

        Console.WriteLine("Enter the operation (+, -, *, /):");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); 

        Console.WriteLine("Enter the second number:");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input format for the second number.");
            return;
        }

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
