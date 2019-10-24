using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            double radius = double.Parse(Console.ReadLine());
            if (radius > 0)
            {
                double pi = Math.PI;
                Console.WriteLine("Area of the Circle is:" + pi * radius * radius + " cm^2");
            }
            else
            {
                Console.WriteLine("Radius cannot be negative.");

            }
            
        }
    }
}
