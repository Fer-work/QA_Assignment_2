using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class ProductInventory
    {
        private static int _IdCounter = 0;
        // Product ID min/max between 5 - 50000
        // develop 3 test cases for ProductId
        public int ProductId { get; private set; }

        // develop 3 test cases for ProductName

        public string ProductName { get; set; } = "";

        // Price min/max between $5 - $5000
        // develop 3 test cases for ItemPrice

        public double ItemPrice { get; set; }

        // Stock min/max between 5 - 500000
        // develop 3 test cases for StockAmount

        public int StockAmount { get; set; } = 0;

        public ProductInventory(string name, double price, int stock)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Product name should not be empty");
            }
            if (price < 5 || price > 5000)
            {
                throw new ArgumentOutOfRangeException("Product price should be between 5 - 5000");
            }
            if (stock < 5 || stock > 500000)
            {
                throw new ArgumentOutOfRangeException($"Stock amount should be between 5 and 500,000 {stock}");
            }

            _IdCounter++;
            ProductId = _IdCounter;
            ProductName = name;
            ItemPrice = price;
            StockAmount = stock;
        }

        // develop 3 test cases for IncreaseStock - Fernando
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

        // develop 3 test cases for DecreaseStock
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
