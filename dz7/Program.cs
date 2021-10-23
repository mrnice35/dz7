using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetVS(a, out S, out V);
            Console.WriteLine("Площадь стороны куба равна {0} ", S);
            Console.WriteLine("Объем  куба равен {0} ", V);
            Console.ReadKey();
        }
        static void GetVS(int a, out double S, out double V)
        {
            S = a * a;
            V = a * a * a;
        }

    }
}
