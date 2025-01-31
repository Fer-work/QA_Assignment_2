namespace Assignment_2
{
    public class ProductInventory
    {
        private static int _IdCounter = 0;

        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name cannot be empty.");
                }
                _productName = value;
            }
        }

        private double _itemPrice;
        public double ItemPrice
        {
            get => _itemPrice;
            set
            {
                if (value < 5 || value > 5000)
                {
                    throw new ArgumentOutOfRangeException("Product price should be between 5 - 5000");
                }
                _itemPrice = value;
            }
        }

        private int _stockAmount;
        public int StockAmount
        {
            get => _stockAmount;
            set
            {
                if (value < 5 || value > 500000)
                {
                    throw new ArgumentOutOfRangeException($"Stock amount should be between 5 and 500,000 {value}");
                }
                _stockAmount = value;
            }
        }

        public ProductInventory(string name, double price, int stock)
        {
            ProductName = name;
            ItemPrice = price;
            StockAmount = stock;

            _IdCounter++;
            ProductId = _IdCounter;
        }

        public void IncreaseStock(int stockAmount)
        {
            if (stockAmount <= 0)
            {
                throw new ArgumentException("The stock to add should be a number greater than 0");
            }

            int stockOutOfRangeCheck = StockAmount + stockAmount;

            if (stockOutOfRangeCheck > 500000)
            {
                throw new ArgumentException("The stock is greater than 500,000");
            }

            StockAmount += stockAmount;
        }

        public void DecreaseStock(int stockAmount)
        {
            if (stockAmount <= 0)
            {
                throw new ArgumentException("The stock to decrease should be a number greater than 0");
            }

            int stockOutOfRangeCheck = StockAmount - stockAmount;

            if (stockOutOfRangeCheck < 5)
            {
                throw new ArgumentException("You can't have less than 5 of this item in stock");
            }

            StockAmount -= stockAmount;
        }
    }
}
