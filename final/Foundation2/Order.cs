namespace Foundation2
{
    public class Order
    {    
        private Customer _customer; 
        private Product[] products;

        public Order(Customer customer, Product[] products)
        {
            this._customer = customer;
            this.products = products;
        }


        public decimal CalculateTotalPrice()
        {
            decimal TotalCost = 0;
            foreach (Product product in products)
            {
                TotalCost += product.CalculateProductPrice();
            }
            if (_customer.IsInUSA() == true)
            {
                TotalCost += 5;
            }
            else
            {
                TotalCost += 35;
            }

            return TotalCost;
        }
        public string GetPackingLabel()
        {
            string packingLabel = $"Packing Label for {_customer.Name}:\n";
            foreach (Product product in products)
            {
                packingLabel += $"{product.ProductName} ({product.ProductID})\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = $"Shipping Label for {_customer.Name}:\n";
            shippingLabel += _customer.Adress.GetFormattedAdress();

            return shippingLabel;
        }
    }
}