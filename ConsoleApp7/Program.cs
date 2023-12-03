using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Шеленков Кирилл - практикум 8";
            Console.CursorVisible = false;

            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //double c = double.Parse(Console.ReadLine());

            //double dis = Math.Pow(b, 2) - 4 * a * c;
            //double x1, x2;
            //if (dis > 0)
            //{
            //    Console.WriteLine("уравнение имеет два действительных корня");
            //    x1 = (-b + Math.Sqrt(dis)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(dis)) / (2 * a);
            //    Console.WriteLine($"x1 = {x1:f2} \nx2 = {x2:f2}");
            //}
            //else if (dis == 0)
            //{
            //    Console.WriteLine("уравнение имеет один действительный корень");
            //    x1 = (-b) / (2 * a);
            //    Console.WriteLine($"x1 = {x1:f2}");
            //}
            //else
            //{
            //    Console.WriteLine("Уравнение не имеет корней");
            //}




            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double p, s;
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Треугольник существует");
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"S = {s}");
            }
            else
                Console.WriteLine("Треугольника не существует");



            Console.Read();
        }
    }
}
