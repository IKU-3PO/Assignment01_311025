using System;

class Program
{
    static void Main()
    {
        bool keepRunning = true; // Schleife
        while (keepRunning)

        {
            // Headline
            Console.WriteLine("Welcome to the Basic Calculator");
            Console.WriteLine(""); // Leerzeichen

            // Enter first input (input1) + convert to double (number1)
            Console.WriteLine("Enter the first number:");
            Console.WriteLine(""); // Leerzeichen
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            // Enter second input (input2) + convert to double (number2)
            Console.WriteLine("Enter the second number:");
            Console.WriteLine(""); // Leerzeichen
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            // Definition of Operation
            Console.WriteLine("Enter operation (+, -, *, /; %):");
            string operation = Console.ReadLine();

            // Definition of Data types
            double result = 0;
            string solution = ""; // Show how result is calculated


            switch (operation) // change to switch/case

            {
                case "+": // Plus calculation
                    result = number1 + number2;
                    solution = $"{number1} + {number2} = {result}";
                    break;

                case "-": // Minus calculation
                    result = number1 - number2;
                    solution = $"{number1} - {number2} = {result}";
                    break;

                case "*": // Multiplication calculation
                    result = number1 * number2;
                    solution = $"{number1} * {number2} = {result}";
                    break;

                case "%": // Modulo calculation
                    result = number1 % number2;
                    solution = $"{number1} % {number2} = {result}";
                    break;
                
                case "/": // Dividing calculation
                    if (number2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed!");
                    }
                    else
                    {
                        result = number1 / number2;
                        solution = $"{number1} / {number2} = {result}";
                        
                    }
                    break;
                
                default:
                    Console.WriteLine("Invalid operation!"); // Why do I need that?
                    return;
                }

            Console.WriteLine(""); // Leerzeichen

            // Show solution + result
            Console.WriteLine("Result: ");
            Console.WriteLine(solution);

            Console.WriteLine(""); // Leerzeichen

            // Ask for new calculation (Schleife mit while keepRunning)
            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            Console.WriteLine(""); // Leerzeichen
            string answer = Console.ReadLine();

            if (answer.ToLower() != "yes")
            {
                keepRunning = false;
                Console.WriteLine(""); // Leerzeichen
                Console.WriteLine("Tschüssi, bis zum näxten Mal!");
            }

            Console.WriteLine(""); // Leerzeichen
            Console.WriteLine("-----------------------------------------------------------"); // Trennlinie
            Console.WriteLine(""); // Leerzeichen


        }
    }
}    
