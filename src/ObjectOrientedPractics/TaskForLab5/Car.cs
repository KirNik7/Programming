namespace TaskForLab5
{
    internal class Car : Vehicle
    {
        private double _speed;

        public void SetSpeed(double speed)
        {
            if (speed < 0) _speed = Math.Abs(speed);
            _speed = speed;
        }

        public double GetSpeed()
        {
            return _speed;
        }

        public double CalculateTime(double Distance)
        {
            if (GetSpeed() != 0) return Math.Abs(Distance) / GetSpeed();
            else return 0;
        }

        public Car(double speed)
        {
            SetSpeed(speed);
        }
    }
}
