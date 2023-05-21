using System;

namespace FigureLibrary
{
    /// <summary>
    /// Класс для расчета площади фигуры
    /// </summary>
    public static class AreaCalculator<T> where T : IFigure
    {
        /// <summary>
        /// Получить площадь конкретной фигуры
        /// </summary>
        public static double GetArea(params double[] createParams)
        {
            var type = typeof(T);
            var figure = (IFigure)Activator.CreateInstance(type, createParams);
            return figure.СalculateArea();
        }
    }
}
