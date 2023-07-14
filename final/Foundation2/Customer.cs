namespace Foundation2
{
    public class Customer
    {    
        private string _name;
        private Adress adress;

        public Customer(string name, Adress adress)
        {
            this._name = name;
            this.adress = adress;
        }

        public string Name {get{return _name;}}
        public Adress Adress {get{return adress;}}
         
        public bool IsInUSA()
        {
            return adress.IsInUSA();
        }



    }
}