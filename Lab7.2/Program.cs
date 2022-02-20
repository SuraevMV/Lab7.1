using System;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = Convert.ToInt32(Console.ReadLine());
                double S, V;
                GetParam(a, out S, out V);
                Console.WriteLine("Площадь куба {0}", S);
                Console.WriteLine("Объём куба {0}", V);
            }
            static void GetParam(int a, out double S, out double V)
            {
                S = Math.Pow(a, 2) * 6;
                V = Math.Pow(a, 3);
            }
            Console.ReadKey();
        }
    }
}
