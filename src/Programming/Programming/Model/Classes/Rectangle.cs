using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _count = 0;
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Ожидается длина прямоугольника больше 0.");
                }
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Ожидается ширина прямоугольника больше 0.");
                }
                _width = value;
            }
        }

        public string Color { get; set; }

        public Rectangle(double length, double width, string color)
        {
            _count++;
            Length = length;
            Width = width;
            Color = color;
        }

        public Rectangle()
        {
            _count++;
        }
        public override string ToString()
        {
            return $"Rectangle {_count}";
        }
    }
}
