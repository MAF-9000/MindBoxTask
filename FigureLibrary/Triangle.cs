using System;
using System.IO;

namespace FigureLibrary
{
    /// <summary>
    /// Класс треугольника 
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        public double A { get; private set; }
        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; private set; }
        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; private set; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                return C == Math.Sqrt(A * A + B * B) || A == Math.Sqrt(C * C + B * B) || B == Math.Sqrt(A * A + C * C);
            }
        }

        public Triangle(params double[] args)
        {
            var a = args[0];
            var b = args[1];
            var c = args[2];

            if (!IsValid(a,b,c))
            {
                throw new InvalidDataException($"Треугольник со стронами: {a},{b},{c} невозможен");
            }

            A = a;
            B = b;
            C = c;
        }
        /// <inheritdoc />
        public double СalculateArea()
        {
            var p = (A + B + C) / 2;
            var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
        /// <summary>
        /// Проверка возможности треугольника с заданными сторонами
        /// </summary>
        private static bool IsValid(double a, double b, double c) =>
            a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0;
    }
}
