using System;

namespace CalculatorHomeWork
{

    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();
                Console.WriteLine("\n" + "\t" + "Сalculator V.1.0.0");
                Console.WriteLine("\n" + "Please select the operation option: '+','-','*','/','^','!' or 'E' to Exit");

                string firstValue = FirstNumberWriting();

                string secondValue = SecondNumberWriting();

                var action = Convert.ToString(Console.ReadLine());

                switch (action)
                {
                    case "e":

                        Exit();

                        break;

                    case "+":

                        Console.WriteLine(firstValue);

                        var firstNumberPl = GetValue();

                        Console.WriteLine(secondValue);

                        var secondNumberPl = GetValue();

                        var plus = firstNumberPl + secondNumberPl;

                        Console.WriteLine("\n" + $"{firstNumberPl} + {secondNumberPl} = {plus}");
                        Console.ReadLine();

                        break;

                    case "-":

                        Console.WriteLine(firstValue);

                        var firstNumberMin = GetValue();

                        Console.WriteLine(secondValue);

                        var secondNumberMin = GetValue();

                        var minus = firstNumberMin - secondNumberMin;

                        Console.WriteLine("\n" + $"{firstNumberMin} - {secondNumberMin} = {minus}");
                        Console.ReadLine();

                        break;

                    case "*":

                        Console.WriteLine(firstValue);

                        var firstNumbertMult = GetValue();

                        Console.WriteLine(secondValue);

                        var secondNumberMilt = GetValue();

                        var multiplier = firstNumbertMult * secondNumberMilt;

                        Console.WriteLine("\n" + $"{firstNumbertMult} * {secondNumberMilt} = {multiplier}");
                        Console.ReadLine();

                        break;

                    case "/":

                        Console.WriteLine(firstValue);

                        var firstNumberDiv = GetValue();

                        Console.WriteLine(secondValue);

                        var secondNumberDiv = Convert.ToDouble(Console.ReadLine());


                        if (secondNumberDiv == 0)
                        {
                            Console.WriteLine("\n" + $"{firstNumberDiv} / {secondNumberDiv} = {0}");
                            Console.ReadLine();
                        }

                        else
                        {
                            var division = firstNumberDiv / secondNumberDiv;

                            Console.WriteLine("\n" + $"{firstNumberDiv} / {secondNumberDiv} = {division}");
                            Console.ReadLine();

                        }
                        break;

                    case "^":

                        Console.WriteLine("\n" + "Enter  number:");

                        var firstNumber = GetValue();

                        Console.WriteLine("\n" + "Enter the degree value:");

                        var degreeValue = GetValue();

                        var result = Math.Pow(firstNumber, degreeValue);

                        Console.WriteLine("\n" + $"{firstNumber} ^ {degreeValue} = {result}");
                        Console.ReadLine();

                        break;

                    default:

                    case "!":
                        break;

                }




                if (action == "!")
                {
                    Console.WriteLine("\n" + "Enter  number:");

                    uint factorNumber;

                    bool result = uint.TryParse(Console.ReadLine(), out factorNumber);

                    if (!result)
                    {
                        Console.WriteLine("\n" + "Enter correct numbers");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var factorValeu = 1;


                        for (int i = 1; i <= factorNumber; i++)
                        {
                            factorValeu = factorValeu * i;
                        }

                        Console.WriteLine("\n" + "Your result :" + " = {0}", factorValeu);
                        Console.WriteLine("\n" + "Press 'E' to Exit");

                        string getExit;

                        getExit = Convert.ToString(Console.ReadLine());

                        if (getExit == "e")
                        {
                            Exit();
                        }

                        Console.ReadLine();
                    }

                }


            } while (true);


        }

        static double GetValue()
        {

            while (true)
            {
                var getValue = Console.ReadLine();

                double option;

                bool result = double.TryParse(getValue, out option);

                if (!result)
                {
                    Console.WriteLine("\n" + "Enter correct number");
                    continue;
                }

                return option;
            }

        }
        static string FirstNumberWriting()
        {
            string symbol = "\nEnter first number: ";

            return symbol;

        }

        static string SecondNumberWriting()
        {
            string symbol = "\nEnter second number: ";

            return symbol;

        }

        static void Exit()
        {
            Environment.Exit(1);
        }
    }
}



