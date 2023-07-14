namespace Foundation2
{
    public class Product
    {    
        private string _productName;
        private string _productID;
        private decimal _price;
        private int _quantity;

        public Product(string productname, string productid, decimal price, int quantity)
        {
            this._price = price;
            this._productName = productname;
            this._productID = productid;
            this._quantity = quantity;
        }

        public string ProductName {get{return _productName;}}
        public string ProductID {get{return _productName;}}

        public decimal CalculateProductPrice()
        {
            return _quantity * _price;
        } 
    }
}