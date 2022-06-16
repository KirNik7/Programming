using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// ������ ������ � ��������������.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// ���������� ���������������.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// ���������� ������������� ��� ���� �������� ������� ������.
        /// </summary>
        public readonly int _id;

        /// <summary>
        /// ������ ��������������.
        /// </summary>
        private int _height;

        /// <summary>
        /// ������ ��������������.
        /// </summary>
        private int _width;

        /// <summary>
        /// ������ ��������� ������ <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// ������ ��������� ������ <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">������ ��������������. ������ ���� ������������� ������.</param>
        /// <param name="width">������ ��������������. ������ ���� ������������� ������.</param>
        /// <param name="color">���� ��������������.</param>
        /// <param name="center">���������� ������ ��������������.</param>
        public Rectangle(int height,
                         int width,
                         string color,
                         Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// ���������� � ����� ������ ��������������. ������ ���� ������������� ������.
        /// </summary>
        public int Height
        {
            get 
            { 
                return _height; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        /// <summary>
        /// ���������� � ����� ������ ��������������. ������ ���� ������������� ������.
        /// </summary>
        public int Width
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

        /// <summary>
        /// ���������� � ����� ���� ��������������.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// ���������� � ����� ���������� ������ ��������������.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// ���������� ���������� ������������� ��������������.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// ������ ������ �� ������ ������ ��������������.
        /// </summary>
        /// <returns>���������� ������ � ������� � ��������������.</returns>
        public string GetRectangleInfo()
        {
            return $"{_id}: (X={Center.X}; Y={Center.Y}; W={_width}; H={_height})";
        }
    }
}
