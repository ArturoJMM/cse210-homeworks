public abstract class Activity
    {
        private DateTime _date;
        private int _duration; // in minutes

        protected Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public int GetDuration()
        {
            return _duration;
        }

        public abstract double GetDistance(); // in miles
        public abstract double GetSpeed(); // in mph
        public abstract double GetPace(); // in minutes per mile

        public string GetSummary()
        {
            double distanceMiles = GetDistance();
            double speedMph = GetSpeed();
            double pacePerMile = GetPace();

            double distanceKm = distanceMiles * 1.60934;
            double speedKph = speedMph * 1.60934;
            double pacePerKm = _duration / distanceKm;

            string formattedDate = _date.ToString("MMM dd, yyyy");
            
            string summaryMiles = $"{formattedDate} - Activity: {GetType().Name} ({_duration} min)- Distance: {distanceMiles:F1} miles, Speed: {speedMph:F1} mph, Pace: {pacePerMile:F1} min per mile";
            
            string summaryKm = $"{formattedDate} - Activity: {GetType().Name} ({_duration} min)- Distance: {distanceKm:F1} km, Speed: {speedKph:F1} kph, Pace: {pacePerKm:F1} min per km";

            return $"{summaryMiles}\n{summaryKm}";
        }
    }