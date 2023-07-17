namespace Foundation4
{
    public class Cycling : Activity
    {
        private decimal speed;

        public Cycling(DateTime date, int minutes, decimal speed) : base(date, minutes)
        {
            this.speed = speed;
        }

        public override decimal GetDistance()
        {
            return (speed / 60) * minutes;
        }

        public override decimal GetSpeed()
        {
            return speed;
        }

        public override decimal GetPace()
        {
            return 60 / speed;
        }
    }
}