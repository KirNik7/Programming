using Programming.Model.Classes;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты центра кольца.</param>
        /// <param name="outerRadius">Внешний радиус кольца. Должен быть положительным числом. 
        /// Должен быть больше внутреннего радиуса кольца.</param>
        /// <param name="innerRadius">Внутренний радиус кольца. Должен быть положительным числом. 
        /// Должен быть меньше внешнего радиуса кольца.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

        }

        /// <summary>
        /// Возвращает и задаёт координаты центра кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт внешний радиус кольца. Должен быть положительным числом. 
        /// Должен быть больше внутреннего радиуса кольца.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius),
                                                value);
                Validator.AssertValueInRange(nameof(OuterRadius),
                                             value, _innerRadius,
                                             double.MaxValue);
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт внутренний радиус кольца. Должен быть положительным числом. 
        /// Должен быть меньше внешнего радиуса кольца.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius),
                                                value);
                Validator.AssertValueInRange(nameof(InnerRadius),
                                             value,
                                             0,
                                             _outerRadius);
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}