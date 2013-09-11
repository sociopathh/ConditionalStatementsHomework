 /*Task4
  * Sort 3 real values in descending order using nested if statements.*/
using System;

class ComparingNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        if ((firstNum == secondNum) || (firstNum == thirdNum) || (thirdNum == secondNum))
        {
            Console.WriteLine("There are some equal numbers");
        }
        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                        firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                        firstNum, thirdNum, secondNum); 
                }
            }
            else
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                    thirdNum, firstNum, secondNum);
            }
        }
        else if ((secondNum > firstNum) && (thirdNum > secondNum))
        {
            Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                thirdNum, secondNum, firstNum);
        }
        else if ((secondNum > firstNum && firstNum > thirdNum))
        {
            Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                secondNum, firstNum, thirdNum); 
        }
        else if ((secondNum > firstNum && thirdNum > firstNum))
        {
            Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                secondNum, thirdNum, firstNum);
        }
    }
}