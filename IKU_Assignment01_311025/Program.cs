using System;

class Program
{
    static void Main()
    {
        // Überschrift
        Console.WriteLine("Welcome to the Basic Calculator");
        Console.WriteLine(""); //Leerzeichen

        // Enter first input (input1) + convert to double (number1)
        Console.WriteLine("Enter the first number:");
        Console.WriteLine(""); //Leerzeichen
        string input1 = Console.ReadLine();
        double number1 = Convert.ToDouble(input1);

        // Enter second input (input2) + convert to double (number2)
        Console.WriteLine("Enter the second number:");
        Console.WriteLine(""); //Leerzeichen
        string input2 = Console.ReadLine();
        double number2 = Convert.ToDouble(input2);

        // Definition of Operation
        Console.WriteLine("Enter operation (+, -, *, /):");
        string operation = Console.ReadLine();

        // Definition of Data types
        double result = 0;
        string solution = ""; // Show how result is calculated

        if (operation == "+")
        {
            result = number1 + number2;
            solution = $"{number1} + {number2} = {result}";
        }
        else if (operation == "-")
        {
            result = number1 - number2;
            solution = $"{number1} - {number2} = {result}";
        }
        else if (operation == "*")
        {
            result = number1 * number2;
            solution = $"{number1} * {number2} = {result}";
        }
        else if (operation == "/")
        {
            result = number1 / number2;
            solution = $"{number1} / {number2} = {result}";
        }

        Console.WriteLine(""); //Leerzeichen

        // Show solution + result
        Console.WriteLine("Result: ");
        Console.WriteLine(solution);
    }
}