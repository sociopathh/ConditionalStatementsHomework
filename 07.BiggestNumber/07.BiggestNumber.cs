/*Task7
 * Write a program that finds the greatest of given 5 variables. */

using System;

class BiggestNumber
{
    static void Main()
    {   
        Console.WriteLine("Please enter five numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int biggestNumber = 0;

        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            biggestNumber += a;
        }
        if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            biggestNumber += b;
        }
        if ((c > a) && (c > b) && (c > d) && (c > e))
        {
            biggestNumber += c;
        }
        if ((d > a) && (d > b) && (d > c) && (d > e))
        {
            biggestNumber += d;
        }
        if ((e > a) && (e > b) && (e > c) && (e > d))
        {
            biggestNumber += e;
        }

        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}