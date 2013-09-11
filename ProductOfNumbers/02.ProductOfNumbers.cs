/*Task2
 * Write a program that shows the sign (+ or -) of the product of 
 * three real numbers without calculating it. Use a sequence of if statements.*/

using System;

class SignOfProduct
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int negativeSign = 0;

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("The product is 0!");
        }
        else
        {
            if (firstNum < 0)
            {
                negativeSign++;
            }
            if (secondNum < 0)
            {
                negativeSign++;
            }
            if (thirdNum < 0)
            {
                negativeSign++;
            }

            if (negativeSign == 1 || negativeSign == 3)
            {
                Console.WriteLine("The product is negative.");
            }
            else
            {
                Console.WriteLine("The product is positive.");
            }
        }
    }
}