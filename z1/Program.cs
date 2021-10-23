using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника 1");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника 2");
            double e = Convert.ToInt32(Console.ReadLine());
            double f = Convert.ToInt32(Console.ReadLine());
            double g = Convert.ToInt32(Console.ReadLine());
            double S, p, S1, S2;
            GetSp(a, b, c, out S, out p);
            S1 = S;
            Console.WriteLine("Площадь первого треугольника S1 {0}. полуперниметр равен {1}", S1, p);
            GetSp(e, f, g, out S, out p);
            S2 = S;
            Console.WriteLine("Площадь второго треугольника S2 {0}. полуперниметр равен {1}", S2, p);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого тругольника большe");
            }
            else if (S1 == S2)
            {
                Console.WriteLine("Площади треугольников равны");
            }
            else
            {
                Console.WriteLine("Площади второго треугольника больше");
            }
        Console.ReadKey();
        }
        static void GetSp(double a, double b, double c, out double S, out double p)
        {
            p = ((a + b + c) / 2);
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
