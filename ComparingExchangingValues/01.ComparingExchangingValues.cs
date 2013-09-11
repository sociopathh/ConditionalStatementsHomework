/* Task1
 * Write an if statement that examines two integer variables and 
 * exchanges their values if the first one is greater than the second one.*/

using System;

class ComparingExchangingValues
{
    static void Main()
    {
        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        int b = int.Parse(Console.ReadLine());
        int c;
        Console.WriteLine("First Values: a = {0}; b = {1}", a, b);

        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("Exchanged Values: a = {0}; b = {1}", a, b);
    }
}