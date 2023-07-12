namespace Foundation3
{
    public class Event
    {
        private string _eventTitle;
        private string _date;
        private string _time;
        private string _description;
        private string _adress;
        private string _eventType;

        public string GetTitle()
        {
            return _eventTitle;
        }
        public void SetTitle(string title)
        {
            _eventTitle = title;
        }
        public string GetDate()
        {
            return _date;
        }
        public void SetDate(string date)
        {
            _date = date;
        }
        public string GetTime()
        {
            return _time;
        }
        public void SetTime(string time)
        {
            _time = time;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public string GetAdress()
        {
            return _adress;
        }
        public void SetAdress(string adress)
        {
            _adress = adress;
        }
        public string GetEventType()
        {
            return _eventType;
        }
        public void SetEventType(string type)
        {
            _eventType = type;
        }
        

        public void DisplayEventInfo()
        {
            Console.WriteLine($"|  Event: {_eventTitle}       ");
            Console.WriteLine($"|  Date of event: {_date}     ");
            Console.WriteLine($"|  Time of event: {_time}     ");
            Console.WriteLine($"|  Description: {_description}");
            Console.WriteLine($"|  Adress: {_adress}          ");
        }

        public void DisplayShortDescription()
        {
            Console.WriteLine($"|  Event Type: {_eventType}  ");
            Console.WriteLine($"|  Event: {_eventTitle}      ");
            Console.WriteLine($"|  Date: {_date}             ");
            Console.WriteLine("|");
        }
    }
}