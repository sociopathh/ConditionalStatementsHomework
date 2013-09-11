/* Task8
 * Write a program that, depending on the user's choice inputs int, double or string variable.
 * If the variable is integer or double, increases it with 1. If the variable is string,
 * appends "*" at its end. The program must show the value of that variable as a console output.
 * Use switch statement. */

using System;

class ChooseVariables
{
    static void Main()
    {
        Console.WriteLine("Please choose type of the variable");   
        
        Console.WriteLine("\n For type \"Integer\" enter 1 \n For type \"Double\" enter 2 \n For type \"String\" enter 3 ");

        Console.Write("\nYour choice is: ");
        byte option = byte.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Enter your \"Integer\": ");
                int optionInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Your Integer + 1 is: {0}", optionInt + 1);
                break;
            case 2:
                Console.Write("Enter your \"Double\": ");
                double optionDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Double + 1 is: {0}", optionDouble + 1);
                break;
            case 3:
                Console.Write("Enter your \"String\" type: ");
                string optionString = Console.ReadLine();
                Console.WriteLine("Your String + \"*\" is: {0}", optionString + "*");
                break;
            default:
                Console.WriteLine("Invalid Input! You can use ONLY option numbers 1, 2 or 3 \n Please try again!");
                break;
        }
    }
}