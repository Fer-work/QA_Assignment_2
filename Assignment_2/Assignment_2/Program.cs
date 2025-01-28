using Assignment_2;
internal class Program
{
    public static void Main(string[] args)
    {
        // Create some items to see if class is working - Fernando
        ProductInventory item1 = new ProductInventory("Ice cream", 5.99, 5);
        ProductInventory item2 = new ProductInventory("Dog Food", 6.79, 5);
        ProductInventory item3 = new ProductInventory("Bread", 5.84, 5);
        ProductInventory item4 = new ProductInventory("Fish", 7.64, 5);


        // Display current items to the screen - Fernando
        Console.WriteLine($"item 1: {item1.ProductName}\tProduct ID: {item1.ProductId}\tprice: {item1.ItemPrice.ToString("0.00")}\tStock: {item1.StockAmount}");
        Console.WriteLine($"item 2: {item2.ProductName}\tProduct ID: {item2.ProductId}\tprice: {item2.ItemPrice.ToString("0.00")}\tStock: {item2.StockAmount}");
        Console.WriteLine($"item 3: {item3.ProductName}\t\tProduct ID: {item3.ProductId}\tprice: {item3.ItemPrice.ToString("0.00")}\tStock: {item3.StockAmount}");
        Console.WriteLine($"item 4: {item4.ProductName}\t\tProduct ID: {item4.ProductId}\tprice: {item4.ItemPrice.ToString("0.00")}\tStock: {item4.StockAmount}");

        item1.IncreaseStock(5);
        Console.WriteLine($"item 1: {item1.ProductName}\tProduct ID: {item1.ProductId}\tprice: {item1.ItemPrice.ToString("0.00")}\tStock: {item1.StockAmount}");
        item1.DecreaseStock(2);
        Console.WriteLine($"item 1: {item1.ProductName}\tProduct ID: {item1.ProductId}\tprice: {item1.ItemPrice.ToString("0.00")}\tStock: {item1.StockAmount}");

    }
}