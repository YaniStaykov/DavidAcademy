namespace _09.Quadratic_Equation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double discriminant, denominator, x1, x2;

            Console.Write("Enter the value of a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of c = ");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine($"The roots are Linear: {x1:f3}");
            }
            else
            {
                discriminant = (b * b) - (4 * a * c);
                denominator = 2 * a;
                if (discriminant > 0)
                {
                    Console.WriteLine("The roots are real and distinct.");
                    x1 = (-b / denominator) + (Math.Sqrt(discriminant) / denominator);
                    x2 = (-b / denominator) - (Math.Sqrt(discriminant) / denominator);
                    Console.WriteLine($"The roots are: {x1:f3} and {x2:f3}");
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("The roots are repeated.");
                    x1 = -b / denominator;
                    Console.WriteLine($"The root is : {x1:f3}");
                }
                else
                {
                    Console.WriteLine("The roots are imaginary.");
                    x1 = -b / denominator;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / denominator);
                    Console.WriteLine($"The first root is : {x1:f3} +i {x2:f3}");
                    Console.WriteLine($"The second root is : {x1:f3} -i {x2:f3}");
                }
            }
        }
    }
}
