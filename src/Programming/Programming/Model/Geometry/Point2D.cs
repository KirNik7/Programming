﻿using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о координатах центра фигуры.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительным числом.</param>
        /// <param name="y">Координата Y. Должна быть положительным числом.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D() { }

        /// <summary>
        /// Возвращает и задаёт координату X. Должна быть положительным числом.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт координату Y. Должна быть положительным числом.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }
    }
}