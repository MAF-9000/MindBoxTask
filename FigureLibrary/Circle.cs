using System;
using System.IO;

namespace FigureLibrary
{   /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; private set; }

        public Circle(params double[] args)
        {
            var radius = args[0];
            if(radius<0)
            {
                throw new InvalidDataException($"Создать круг невозможно. Введён отрицательный радиус: {radius}");
            }
            Radius = radius;
        }

        /// <inheritdoc />
        public double СalculateArea()
        {
            var area = Math.PI * (Radius * Radius);
            return area;
        }

    }

    
    
}
