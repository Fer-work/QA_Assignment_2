using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class ProductInventory
    {
        // Product ID min/max between 5 - 50000
        public static int ProductId { get; set; } = 0;

        public string ProductName { get; set; } = " ";

        // Price min/max between $5 - $5000
        public double ItemPrice { get; set; }

        // Stock min/max between 5 - 500000
        public int StockAmount { get; set; } = 0;

        public ProductInventory(string name, double price, int stock)
        {
            ProductId++;
            ProductName = name;
            ItemPrice = price;
            StockAmount = stock;
        }

        public void IncreaseStock(int stockAmount)
        {
            StockAmount += stockAmount;
        }

        public void DecreaseStock(int stockAmount)
        {
            StockAmount -= stockAmount;
        }
    }

}
