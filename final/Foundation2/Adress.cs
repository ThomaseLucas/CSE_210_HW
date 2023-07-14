namespace Foundation2
{
    public class Adress
    {    
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Adress(string street, string city, string state, string country)
        {
            this._street = street;
            this._city = city;
            this._state = state;
            this._country = country;
        }

        public string GetFormattedAdress()
        {
            return $"{_street} {_city}, {_state} {_country}";
        }
        public bool IsInUSA()
        {
            if (_country == "USA")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}