using FigureLibrary;
using System;
using System.IO;

namespace TestTaskForMindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figureType = string.Empty;
            do
            {
                Console.WriteLine("Выберите тип фигуры: ");
                Console.WriteLine("1 - Круг");
                Console.WriteLine("2 - Треугольник");
                figureType = Console.ReadLine();
                try
                {
                    switch (figureType)
                    {
                        case "1":
                            {
                                Console.WriteLine("Введите радиус круга:");
                                var radius = double.Parse(Console.ReadLine());
                                var area = AreaCalculator<Circle>.GetArea(radius);
                                Console.WriteLine($"Площадь круга = {area}");
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Введите сторону A:");
                                var a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите сторону B:");
                                var b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите сторону C:");
                                var c = double.Parse(Console.ReadLine());
                                var area = AreaCalculator<Triangle>.GetArea(a, b, c);
                                Console.WriteLine($"Площадь треугольника = {area}");
                                break;
                            }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }
            while (figureType != "1" && figureType != "2");

        }
    }
}
