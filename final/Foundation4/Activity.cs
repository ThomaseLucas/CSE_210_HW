namespace Foundation4
{
    public abstract class Activity
    {
        private DateTime date;
        protected int minutes;

        public Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public abstract decimal GetDistance();
        public abstract decimal GetSpeed();
        public abstract decimal GetPace();

        public string GetSummary()
        {
            string activityType = GetType().Name;
            decimal distance = GetDistance();
            decimal speed = GetSpeed();
            decimal pace = GetPace();

            string distanceUnit;
            string speedUnit;
            string paceUnit;

            if (activityType == "Swimming")
            {
                distanceUnit = "kmh";                
            }
            else
            {
                distanceUnit = "miles";
            }

            if (activityType == "Swimming")
            {
                speedUnit = "kph";                
            }
            else
            {
                speedUnit = "mph";
            }

            if (activityType == "Swimming")
            {
                paceUnit = "min per km";                
            }
            else
            {
                paceUnit = "min per mile";
            }

            string summary = $"{date:d MMM yyy} {activityType} ({minutes} min) - Distance: {distance:F1} {distanceUnit}, Speed: {speed:F1} {speedUnit}, Pace: {pace:F1} {paceUnit}";
            return summary;
        }


    }
}