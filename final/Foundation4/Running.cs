namespace Foundation4
{
    public class Running : Activity
    {
        private decimal distance;

        public Running(DateTime date, int minutes, decimal distance) : base(date, minutes)
        {
            this.distance = distance;
        }

        public override decimal GetDistance()
        {
            return distance;
        }

        public override decimal GetSpeed()
        {
            return (distance/minutes) * 60;
        }

        public override decimal GetPace()
        {
            return minutes / distance;
        }
    }
}