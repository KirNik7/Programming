using System;
using Programming.Model.Enums;
using Programming.Model.Geometry;


namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        private const int MaxSizeRectangle = 200;

        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private static Random _random;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleFactory"/>.
        /// </summary>
        static RectangleFactory()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <param name="canvasHeight">Высота элемента размещения.</param>
        /// <param name="canvasWidth">Ширина элемента размещения.</param>
        /// <returns>Возвращает объект Rectangle.</returns>
        public static Rectangle Randomize(int canvasHeight, int canvasWidth)
        {

            Rectangle rectangle = new Rectangle();
            var colors = Enum.GetValues(typeof(Color));
            rectangle.Height = _random.Next(1, MaxSizeRectangle);
            rectangle.Width = _random.Next(1, MaxSizeRectangle);
            rectangle.Center = new Point2D(_random.Next(Margin, canvasWidth - rectangle.Width - Margin),
                                           _random.Next(Margin, canvasHeight - rectangle.Height - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <returns>Возвращает объект Rectangle.</returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 500), _random.Next(1, 500));
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}