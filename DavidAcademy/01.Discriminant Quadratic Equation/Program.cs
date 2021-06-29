namespace Discriminant_Quadratic_Equation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            Console.WriteLine($"The discriminant is: {discriminant}");
        }
    }
}
