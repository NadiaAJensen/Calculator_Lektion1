using System;

namespace Calculator_Lektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminate = true;
            while (terminate)
            {

                Calculator calculator = new Calculator();
                Console.WriteLine("Please select type of calculation");
                Console.WriteLine("1=Add, 2=Subtract, 3=Multiply, 4=Power, 5=Squareroot, 6=Devide");

                try
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    double a = 0;
                    double b = 0;

                    if (key.KeyChar == '5')
                    {
                        Console.WriteLine("Type the number:");
                        a = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Type the two numbers:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                    }
                    
                    double result = 0;
                    string operation = "";

                    switch (key.KeyChar)
                    {
                        case '1':
                            result = calculator.Add(a, b);
                            operation = "Add";
                            break;
                        case '2':
                            result = calculator.Subract(a, b);
                            operation = "Subtract";
                            break;
                        case '3':
                            result = calculator.Multiply(a, b);
                            operation = "Multiply";
                            break;
                        case '4':
                            result = calculator.Power(a, b);
                            operation = "Power";
                            break;
                        case '5':
                            result = calculator.Squareroot(a);
                            operation = "Squareroot";
                            break;
                        case '6':
                            result = calculator.Divide(a, b);
                            operation = "Divide";
                            break;
                        default:
                            throw new Exception("Choice out of index");
                    }

                    Console.WriteLine($"You chose {operation}, and typed: {a}, {b}.\nThe result is: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("No sqaureroot of negative number or division by 0, and operation must be 1-6.");
                    throw;
                }


                Console.WriteLine("\nDo you want to do another operation?");
                var choice = Console.ReadKey(true);
                switch (choice.KeyChar)
                {
                    case 'y':
                    case 'Y':
                        terminate = true;
                        break;
                    case 'n':
                    case 'N':
                        terminate = false;
                        break;
                }
            }

        }
    }
}
