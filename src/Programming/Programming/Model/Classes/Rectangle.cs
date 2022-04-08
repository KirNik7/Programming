using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _countRectangles = 0;

        public int _id = _countRectangles;

        private double _length;

        private double _width;

        public double Length
        {
            get 
            { 
                return _length; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                _length = value;
            }
        }

        public double Width
        {
            get 
            { 
                return _width; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public static int CountRectangles
        {
            get
            {
                return _countRectangles;
            }
        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            _countRectangles++;
            _id = _countRectangles;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }

        public Rectangle()
        {
            _countRectangles++;
            _id = _countRectangles;
        }
        public override string ToString()
        {
            return $"Rectangle {_countRectangles}";
        }
    }
}
