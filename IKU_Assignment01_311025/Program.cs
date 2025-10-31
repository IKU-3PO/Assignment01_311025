using System;

class Program
{
    static void Main()
    {
        bool keepRunning = true; // necessary to define state for program via data type
        string history1 = ""; // saving the history for case 1
        string history2 = ""; // saving the history for case 1
        string history3 = ""; // saving the history for case 1
        string history4 = ""; // saving the history for case 1
        string history5 = ""; // saving the history for case 1
        int historyCount = 0; // necessary to provide var for counting strings

        while (keepRunning)
        {
            Console.WriteLine("Scientific Calculator"); // Headline
            Console.WriteLine(""); // Leerzeichen
            
            Console.WriteLine("Menu:"); //Headline
            Console.WriteLine(""); // Leerzeichen
            
            Console.WriteLine("1. Basic Operations (+, -, *, /, %)"); // Menu
            Console.WriteLine(""); // Leerzeichen
            
            Console.WriteLine("2. Square Root"); // Wurzel
            Console.WriteLine(""); // Leerzeichen
            
            Console.WriteLine("3. Power (x^y)"); // Quadrat
            Console.WriteLine(""); // Leerzeichen
            
            Console.WriteLine("4. View History"); // History
            Console.WriteLine(""); // Leerzeichen
            
            Console.WriteLine("5. Exit"); // Fertig
            Console.WriteLine(""); // Leerzeichen
            
            Console.Write("Choose an option: "); // Wählen zwischen Option 1 bis 5
            string choice = Console.ReadLine();
            Console.WriteLine(""); // Leerzeichen
            Console.WriteLine(""); // Leerzeichen
            
            // ---------------------------------------------

            switch (choice) // statt if/else jetzt switch/case
            {
                case "1": // Case 1 ist Basic Calculation
                    Console.Write("Enter the first number: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(""); // Leerzeichen
                    
                    Console.Write("Enter operation (+, -, *, /, %): ");
                    string operation = Console.ReadLine();
                    Console.WriteLine(""); // Leerzeichen
                    
                    Console.Write("Enter the second number: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(""); // Leerzeichen
                    
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
                            Console.WriteLine("Invalid operation!"); // Why do I need that?
                            continue;
                    }
                    
                    // History for Case 1 + Result
                    Console.WriteLine("Result: " + expression);
                    historyCount++;
                    
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
                    
                    double number = Convert.ToDouble(Console.ReadLine());
                    double sqrtResult = Math.Sqrt(number);
                    string sqrtExpression = $"√{number} = {sqrtResult}";
                    
                    // History for Case 2 + Result
                    Console.WriteLine("Result: " + sqrtExpression);
                    historyCount++;
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
                    Console.Write("Enter base: "); // Basis-Zahl eingeben
                    double baseNum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(""); // Leerzeichen
                    
                    Console.Write("Enter exponent: "); // Quadrat-Zahl eingeben
                    double exponent = Convert.ToDouble(Console.ReadLine());
                    double powerResult = Math.Pow(baseNum, exponent);
                    string powerExpression = $"{baseNum}^{exponent} = {powerResult}";
                    
                    // History for Case 3
                    Console.WriteLine("Result: " + powerExpression);
                    historyCount++;
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
                    Console.WriteLine("Calculation History"); // Überschrift
                    if (historyCount == 0) // Wenn es noch gar keine Calculations gab
                    
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

                    case "5": // Case 5 is Exit
                    keepRunning = false; // Befehl zum Abschalten
                    Console.WriteLine("Sänk ju und tschüssel!");
                    break;

                    default:
                    Console.WriteLine("Invalid choice! Please select 1–5.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
