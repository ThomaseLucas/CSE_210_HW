namespace Foundation4
{
    public class Swimming : Activity
    {
        private int laps; 

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            this.laps = laps;
        }

        public override decimal GetDistance()
        {
            return laps * 50 / 1000;
        }

        public override decimal GetPace()
        {
            return minutes / GetDistance();
        }

        public override decimal GetSpeed()
        {
            return (GetDistance() / minutes) * 60;
        }
    }
}