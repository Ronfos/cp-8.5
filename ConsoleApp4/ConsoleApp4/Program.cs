using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //Вариант 1 (Уровень А)
        //static void Function(double a = 1,double b = 2, double c = 3)
        //{
        //    double y = ((a + Math.Sin(a)) / 3) + ((b + Math.Sin(b)) / 3) + ((c + Math.Sin(c)) / 3);
        //    Console.Write($"{y:f2}");
        //}
        //static void Main(string[] args)
        //{
        //    Function(1,5,7);
        //    Console.ReadKey();
        //}

        //Вариант 2 (Уровень А)
        static void Secondscount(int h = 1, int m = 10, int s = 20)
        {
            int seconds = h * 60 * 60 + m * 60 + s;
            Console.Write($"Общее количество секунд:{seconds}");
        }
        static void Main()
        {
            Console.Write("Введите часы: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int s = int.Parse(Console.ReadLine());
            Secondscount(h, m, s);
            Console.ReadKey();
        }

    }
}
