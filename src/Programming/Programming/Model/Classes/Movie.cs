public class Movie
{
	private string _title;
	private int _duration;
	private int _year;
	private string _genre;
	private double _rating;

	public string Title
    {
        get { return _title; }
		set { _title = value; }
    }

	public int Duration
    {
        get { return _duration; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Ожидается продолжительность фильма больше 0.");
            }
            _duration = value;
        }
    }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 1900 || value > 2022)
            {
                throw new ArgumentException("Ожидается год выпуска больше 1900 и меньше 2022.");
            }
            _year = value;
        }
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }

    public double Rating
    {
        get { return _rating; }
        set
        {
            if (value < 0.0 || value > 10.0)
            {
                throw new ArgumentException("Ожидается рейтинг больше 0 и меньше 10.");
            }
            _rating = value;
        }
    }
}
