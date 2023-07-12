namespace Foundation3
{
    public class Adress
    {
        private string _city;
        private string _street;
        private string _state;
        private string _postalcode;

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string city)
        {
            _city = city;
        }

        public string GetStreet()
        {
            return _street;
        }

        public void SetStreet(string street)
        {
            _street = street;
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
        }

        public string GetPostalCode()
        {
            return _postalcode;
        }

        public void SetPostalCode(string postalcode)
        {
            _postalcode = postalcode;
        }  

        public string DisplayFullAdress()
        {
            return $"{_street} {_city}, {_state} {_postalcode}";
        }

        

    }
}