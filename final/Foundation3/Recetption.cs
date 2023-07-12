namespace Foundation3
{
    public class Reception: Event
    {
        private string _email;
        
        public void SetEmail(string email)
        {
            _email = email;
        }
        public string GetEmail()
        {
            return _email;
        }

        public void DisplayRSVPEmail()
        {
            Console.WriteLine($"|  RSVP at: {_email}    ");
            Console.WriteLine("|");
        }
    }
}