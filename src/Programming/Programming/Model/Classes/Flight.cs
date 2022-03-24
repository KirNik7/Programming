public class Flight
{
	private string _departurePoint;
	private string _destinationPoint;
	private int _flightTime;

	public string DeparturePoint
    {
        get { return _departurePoint; }
		set { _departurePoint = value; }
    }

	public string DestinationPoint
    {
		get { return _destinationPoint; }
        set { _destinationPoint = value; }
    }

	public int FlightTime
    {
        get { return _flightTime; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Ожидается время полёта больше 0.");
            }
            _flightTime = value;
        }
    }
}
