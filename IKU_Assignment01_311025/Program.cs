using System;

class Program
{
    static void Main()
    {
        bool keepRunning = true; // Necessary to define state for program via data type
        string history1 = ""; // Saving the history for case 1
        string history2 = ""; // Saving the history for case 1
        string history3 = ""; // Saving the history for case 1
        string history4 = ""; // Saving the history for case 1
        string history5 = ""; // Saving the history for case 1
        int historyCount = 0; // Necessary to provide variable for counting strings

        while (keepRunning) // Necessary to ???
            
        {
            Console.WriteLine("Welcome to the Scientific Calculator"); // Headline
            Console.WriteLine(""); // Space
            
            Console.WriteLine("Here we go with the Menu:"); // Menu
            Console.WriteLine(""); // Space
            
            Console.WriteLine("1. Basic Operations (+, -, *, /, %)"); // Basic Operations
            Console.WriteLine(""); // Space
            
            Console.WriteLine("2. Square Root"); // Square root
            Console.WriteLine(""); // Space
            
            Console.WriteLine("3. Power (x^y)"); // Power
            Console.WriteLine(""); // Space
            
            Console.WriteLine("4. View History"); // History
            Console.WriteLine(""); // Space
            
            Console.WriteLine("5. Exit"); // Finishing line :)
            Console.WriteLine(""); // Space
            
            Console.Write("Choose one of the options provided: "); // Choose between Option 1 - 5
            string choice = Console.ReadLine();
            Console.WriteLine(""); // Space
            Console.WriteLine(""); // Space
            
            // ---------------------------------------------

            switch (choice) // Using the switch/case/break functionalities per case
            {
                case "1": // Case 1 - Basic Calculation
                    Console.Write("Enter the first number: ");
                    if (!double.TryParse(Console.ReadLine(), out double number1))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine(""); // Space
                    
                    Console.Write("Enter operation (+, -, *, /, %): ");
                    string operation = Console.ReadLine();
                    Console.WriteLine(""); // Space
                    
                    Console.Write("Enter the second number: ");
                    if (!double.TryParse(Console.ReadLine(), out double number2))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine(""); // Space
                    
                    // Data type definition
                    double result = 0; 
                    string expression = ""; 
                    
                    // Change to switch/case
                    switch (operation)
                    {
                        case "+": // Addition calculation
                            result = number1 + number2; 
                            expression = $"{number1} + {number2} = {result}"; 
                            break;
                        
                        case "-": // Minus calculation
                            result = number1 - number2; 
                            expression = $"{number1} - {number2} = {result}"; 
                            break;
                        
                        case "*": // Multiplication calculation
                            result = number1 * number2; 
                            expression = $"{number1} * {number2} = {result}"; 
                            break;
                        
                        case "/": // Dividing calculation
                            if (number2 == 0)
                            {
                                Console.WriteLine("Division by zero is not allowed!");
                                expression = "Invalid operation (division by zero)";
                            }
                            else
                            {
                                result = number1 / number2;
                                expression = $"{number1} / {number2} = {result}";
                            }
                            break;
                        
                        case "%": // Modulo Calculation
                            result = number1 % number2; 
                            expression = $"{number1} % {number2} = {result}"; 
                            break;
                        
                        default:
                            Console.WriteLine("Invalid operation!"); // Necessary when no case applies
                            continue; // Jumps back to beginning of while (keepRunning)-"Schleife"
                    }
                    
                    // History for Case 1 + Result
                    Console.WriteLine("Result: " + expression);
                    historyCount++; // Counts the calculations done so far
                    
                    if (historyCount == 1) history1 = expression;
                    else if (historyCount == 2) history2 = expression;
                    else if (historyCount == 3) history3 = expression;
                    else if (historyCount == 4) history4 = expression;
                    else if (historyCount == 5) history5 = expression;
                    else Console.WriteLine("History full (max. 5 entries");
                    
                    Console.WriteLine();
                    break;
                
                
                // ---------------------------------------------

                    case "2": // Case 2 is Square root Calculation
                    Console.Write("Enter a number: "); // Input of Number to be "square rooted"
                    
                    if (!double.TryParse(Console.ReadLine(), out double number))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    
                    double sqrtResult = Math.Sqrt(number);
                    string sqrtExpression = $"√{number} = {sqrtResult}";
                    
                    // History for Case 2 + Result
                    Console.WriteLine("Result: " + sqrtExpression);
                    historyCount++; // Counts the calculations done so far
                    
                    if (historyCount == 1) history1 = sqrtExpression;
                    else if (historyCount == 2) history2 = sqrtExpression;
                    else if (historyCount == 3) history3 = sqrtExpression;
                    else if (historyCount == 4) history4 = sqrtExpression;
                    else if (historyCount == 5) history5 = sqrtExpression;
                    else Console.WriteLine("History full (max. 5 entries");
                    
                    Console.WriteLine();
                    break;
                        
                    
                // ---------------------------------------------

                    case "3": // Case 3 is Power (x^y) Calculation
                    
                    Console.Write("Enter base: "); // Enter the base number (x)
                    if (!double.TryParse(Console.ReadLine(), out double baseNum))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    
                    Console.Write("Enter exponent: "); // Enter the exponent number (y)
                    if (!double.TryParse(Console.ReadLine(), out double exponent))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    
                    double powerResult = Math.Pow(baseNum, exponent);
                    string powerExpression = $"{baseNum}^{exponent} = {powerResult}";
                    
                    // History for Case 3
                    Console.WriteLine("Result: " + powerExpression);
                    historyCount++; // Counts the calculations done so far
                    
                    if (historyCount == 1) history1 = powerExpression;
                    else if (historyCount == 2) history2 = powerExpression;
                    else if (historyCount == 3) history3 = powerExpression;
                    else if (historyCount == 4) history4 = powerExpression;
                    else if (historyCount == 5) history5 = powerExpression;
                    else Console.WriteLine("History full (max. 5 entries");
                    Console.WriteLine();
                    break;
                    
                    
                // ---------------------------------------------

                    case "4": // Case 4 is Calculation History
                    Console.WriteLine("Calculation History"); // Headline
                    if (historyCount == 0) // Necessary if there were no calculations at all
                    
                    {
                        Console.WriteLine("No calculations yet.");
                    }
                    else
                    {
                    if (history1 != "") Console.WriteLine("1. " + history1);
                    if (history2 != "") Console.WriteLine("2. " + history2);
                    if (history3 != "") Console.WriteLine("3. " + history3);
                    if (history4 != "") Console.WriteLine("4. " + history4);
                    if (history5 != "") Console.WriteLine("5. " + history5);
                    }
                    
                    Console.WriteLine();
                    break;
            
                    
                // ---------------------------------------------
                    
                    case "5": // Case 5 is Exit
                    keepRunning = false; // Necessary to stop program
                    Console.WriteLine("Thank you for using the Scientific Calculator!");
                    break;

                    default:
                    Console.WriteLine("Invalid choice! Please select 1–5."); // Necessary if a different number than 1, 2, 3, 4, 5 was entered
                    Console.WriteLine();
                    break;
            }
        }
    }
}
