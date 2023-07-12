namespace Foundation3
{
    public class Lecture: Event
    {
        private string _speakerName;
        private int _capacity;

        public int GetCapacity()
        {
            return _capacity;
        }

        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }

        public string GetSpeakerName()
        {
            return _speakerName;
        }

        public void SetSpeakerName(string speaker)
        {
            _speakerName = speaker;
        }

        public void DisplayLecutreInfo()
        {
            Console.WriteLine($"|  Speaker: {_speakerName}          ");
            Console.WriteLine($"|  Maximum Participants: {_capacity}");
            Console.WriteLine("|");
        }
    }
}