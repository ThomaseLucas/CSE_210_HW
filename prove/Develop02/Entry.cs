namespace Develop02
{
    public class Entry 
    //The responsibility of an Entry is to hold a prompt, response and a date.
    {
        public string prompt;
        public string response;
        public string date;
        public string ConvertToString()
        {
            return $"{date} \n{prompt} \n{response}\n";
        }
        public void Hold(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date; 
        }
    }
}