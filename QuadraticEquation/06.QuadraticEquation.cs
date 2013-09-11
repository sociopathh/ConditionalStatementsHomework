/* Task5
 * Write a program that enters the coefficients a, b and c of a quadratic equation 
 * a*x2 + b*x + c = 0  * and calculates and prints its real roots. 
 * Note that quadratic equations may have 0, 1 or 2 real roots.
 */

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient \"a\"");
        Console.Write("a = ");
        string aStr = Console.ReadLine();
        double a = double.Parse(aStr);

        Console.WriteLine("Enter coefficient \"b\"");
        Console.Write("b = ");
        string bStr = Console.ReadLine();
        double b = double.Parse(bStr);

        Console.WriteLine("Enter coefficient \"c\"");
        Console.Write("c = ");
        string cStr = Console.ReadLine();
        double c = double.Parse(cStr);
        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("Equation do not have real roots");
        }
        else if (d == 0)
        {
            d = Math.Sqrt(d);
            double x = (-b + d) / (2 * a);
            Console.WriteLine("Equation have 1 real root X = " + x);
        }
        else
        {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("Equation have 2 real roots \nX1 = {0:0.000}   and   X2 = {1:0.000}", x1, x2);
        }
    }
}