
using System;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиты длинну стороны А первого треугольника ");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиты длинну стороны B первого треугольника ");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиты длинну стороны C первого треугольника ");
            int C1 = Convert.ToInt32(Console.ReadLine());
            double S;
            CalcPlosh(A1, B1, C1, out S);
            double S1 = S;
            
            Console.WriteLine("Введиты длинну стороны А второго треугольника ");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиты длинну стороны B второго треугольника ");
            int B2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиты длинну стороны C второго треугольника ");
            int C2 = Convert.ToInt32(Console.ReadLine());
            CalcPlosh(A2, B2, C2, out S);
            double S2 = S;
            
            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше второго");
            else
                Console.WriteLine("Площадь второго треугольника больше первого");
        }
        static void CalcPlosh(int a, int b, int c, out double S)
        {
            double P = ((double)a + (double)b + (double)c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
    }
    
}
