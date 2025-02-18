public class Swimming : Activity
    {
        private int _laps; // number of laps
        private const double LAP_LENGTH = 50; // meters

        public Swimming(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * LAP_LENGTH / 1000 * 0.62;
        }

        public override double GetSpeed()
        {
            return GetDistance() / GetDuration() * 60;
        }

        public override double GetPace()
        {
            return GetDuration() / GetDistance();
        }
    }