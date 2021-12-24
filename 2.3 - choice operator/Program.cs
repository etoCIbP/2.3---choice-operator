using System;

namespace _2._3___choice_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, R;

            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите R:");
            R = double.Parse(Console.ReadLine());

            if (Math.Sqrt(x * x + y * y) <= R)
                Console.WriteLine("({0};{1}) входит в окружность с радиусом {2}", x, y, R);
            else
                Console.WriteLine("({0};{1}) не входит в окружность с радиусом {2}", x, y, R);
        }
    }
}
