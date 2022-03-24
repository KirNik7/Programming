public class rectangle
{
    private double _length;
    private double _width;
    private string _color;

    public double Length
    {
        get { return _length; }
        set
        {
            if (value<0.0)
            {
                throw new ArgumentExeption("Ожидается длина прямоугольника больше 0.");
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
                throw new ArgumentExeption("Ожидается ширина прямоугольника больше 0.");
            }
            _width = value;
        }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
}