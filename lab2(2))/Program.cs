using System;

namespace Lab2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Сторона a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона c = ");
            c = double.Parse(Console.ReadLine());
            if (a == b) Console.WriteLine("Треугольник является равнобедренным");
            else if (a == c) Console.WriteLine("Треугольник является равнобедренным");
            else if (b == c) Console.WriteLine("Треугольник является равнобедренным");
            else Console.WriteLine("Треугольник не является равнобедренным");
        }
    }
}
