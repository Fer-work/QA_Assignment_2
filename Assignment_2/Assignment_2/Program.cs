using Assignment_2;
internal class Program
{
    public static void Main(string[] args)
    {
        // Create some items to see if class is working - Fernando
        ProductInventory item1 = new ProductInventory("Ice cream", 3.99, 5);
        ProductInventory item2 = new ProductInventory("Dog Food", 5.79, 5);
        ProductInventory item3 = new ProductInventory("Bread", 5.84, 5);
        ProductInventory item4 = new ProductInventory("Fish", 7.64, 5);


        // Display current items to the screen - Fernando
        Console.WriteLine($"item 1: {item1.ProductName} \tprice: {item1.ItemPrice.ToString("0.00")}\tStock: {item1.StockAmount}");
        Console.WriteLine($"item 2: {item2.ProductName} \tprice: {item2.ItemPrice.ToString("0.00")}\tStock: {item2.StockAmount}");
        Console.WriteLine($"item 3: {item3.ProductName} \tprice: {item3.ItemPrice.ToString("0.00")}\tStock: {item3.StockAmount}");
        Console.WriteLine($"item 4: {item4.ProductName} \tprice: {item4.ItemPrice.ToString("0.00")}\tStock: {item4.StockAmount}");
    }
}