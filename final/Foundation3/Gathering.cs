namespace Foundation3
{
    public class Gathering: Event
    {
        private string _weatherReport;

        public void SetWeather(string weather)
        {
            _weatherReport = weather;
        }
        public string GetWeather()
        {
            return _weatherReport;
        }

        public void DisplayWeather()
        {
            Console.WriteLine($"|  Weather Report: {_weatherReport}   ");
            Console.WriteLine("|");
        }

    }
}