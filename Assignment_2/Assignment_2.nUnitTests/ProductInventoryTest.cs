namespace Assignment_2.nUnitTests
{
    public class Tests
    {
        private ProductInventory _inventory { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            // Initialize a new ProductInventory object to test on
            // name can't be empty
            string name = "Chicken";
            // Price should be between 5-5000
            double price = 5;
            // stock should be between 5-500,000
            int stock = 5;
            _inventory = new ProductInventory(name, price, stock);
        }

        /*
         * We need 18 test cases in total. 18/4 = 4.5
         * Fernando 6 tests
         * Ritika - 4 tests
         * Arshad - 4 tests
         * Khushdeep - 4 tests
         */

        #region Fernando's Tests
        // 6 Tests for Fernando
        // 3 Tests for IncreaseStock method
        [Test]
        public void increaseStock_add500000_outputExceptionMessage()
        {
            // Arrange
            int stockToAdd = 500000;
            _inventory.StockAmount = 5; // reset stock to 5

            // Act
            var exepctionMessage = Assert.Throws<ArgumentException>(() => _inventory.IncreaseStock(stockToAdd));
            var expectedMessage = "The stock is greater than 500,000";

            // Assert
            Assert.That(expectedMessage, Is.EqualTo(exepctionMessage.Message));
        }

        [Test]
        public void increaseStock_add5_output10()
        {
            // Arrange
            int stockAmount = 5;
            _inventory.StockAmount = 5; // reset stock to 5


            // Act
            _inventory.IncreaseStock(stockAmount);
            var itemStock = _inventory.StockAmount;

            // Assert
            Assert.That(itemStock, Is.EqualTo(10));
        }

        [Test]
        public void increaseStock_addString_outputFormatError()
        {
            // Arrange
            string stockAmount = "Two";

            // Act
            var itemStock = _inventory.StockAmount;
            var exepctionMessage = Assert.Throws<FormatException>(() => _inventory.IncreaseStock(int.Parse(stockAmount)));
            string expectedMessageToo = "The input string 'Two' was not in a correct format.";

            // Assert
            Assert.That(expectedMessageToo, Is.EqualTo(exepctionMessage.Message));
        }

        // 3 Tests for DecreaseStock method
        [Test]
        public void DecreaseStock_subtract50_outputExceptionMessage()
        {
            // Arrange
            int stockToSubtract = 50;
            _inventory.StockAmount = 5;

            // Act
            var exepctionMessage = Assert.Throws<ArgumentException>(() => _inventory.DecreaseStock(stockToSubtract));
            var expectedMessage = "You can't have less than 5 of this item in stock";

            // Assert
            Assert.That(expectedMessage, Is.EqualTo(exepctionMessage.Message));
        }

        [Test]
        public void DecreaseStock_subtract5_output5()
        {
            // Arrange
            _inventory.StockAmount = 10; // starting amount
            int stockToSubtract = 5;

            // Act
            _inventory.DecreaseStock(stockToSubtract);
            var currentStock = _inventory.StockAmount;

            // Assert
            Assert.That(currentStock, Is.EqualTo(5));
        }

        [Test]
        public void DecreaseStock_addString_outputFormatError()
        {
            // Arrange
            string stockAmount = "Two";

            // Act
            var exepctionMessage = Assert.Throws<FormatException>(() => _inventory.DecreaseStock(int.Parse(stockAmount)));
            string expectedMessageToo = "The input string 'Two' was not in a correct format.";

            // Assert
            Assert.That(expectedMessageToo, Is.EqualTo(exepctionMessage.Message));
        }

        #endregion

        #region Ritika's Tests
        [Test]
        public void ItemPrice_BelowMinimum_ShouldThrowException()
        {
            // Arrange
            double invalidPrice = 3.99;

            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _inventory.ItemPrice = invalidPrice);
            StringAssert.Contains("Product price should be between 5 - 5000", exception.Message);
        }

        [Test]
        public void ItemPrice_AboveMaximum_ShouldThrowException()
        {
            // Arrange
            double invalidPrice = 6000.00;

            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _inventory.ItemPrice = invalidPrice);
            StringAssert.Contains("Product price should be between 5 - 5000", exception.Message);
        }

        [Test]
        public void ProductName_EmptyString_ShouldThrowException()
        {
            // Arrange
            string invalidName = "";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => _inventory.ProductName = invalidName);
            StringAssert.Contains("Product name cannot be empty.", exception.Message);
        }


        [Test]
        public void ItemPrice_ValidPrice_ShouldSetPriceCorrectly()
        {
            // Arrange
            double validPrice = 250.99;

            // Act
            _inventory.ItemPrice = validPrice;
            double actualPrice = _inventory.ItemPrice;

            // Assert
            Assert.That(actualPrice, Is.EqualTo(validPrice));
        }

        #endregion


        #region Arshad's Tests
        [Test]
        public void StockAmount_BelowMinimum_ShouldThrowException()
        {
            // Arrange
            int invalidStock = 4;

            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _inventory.StockAmount = invalidStock);
            StringAssert.Contains("Stock amount should be between 5 and 500,000", exception.Message);
        }

        [Test]
        public void StockAmount_AboveMaximum_ShouldThrowException()
        {
            // Arrange
            int invalidStock = 500001;

            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _inventory.StockAmount = invalidStock);
            StringAssert.Contains("Stock amount should be between 5 and 500,000", exception.Message);
        }

        [Test]
        public void ProductName_ValidName_ShouldSetCorrectly()
        {
            // Arrange
            string validName = "Laptop";

            // Act
            _inventory.ProductName = validName;
            string actualName = _inventory.ProductName;

            // Assert
            Assert.That(actualName, Is.EqualTo(validName));
        }

        [Test]
        public void StockAmount_ValidAmount_ShouldSetCorrectly()
        {
            // Arrange
            int validStock = 1000;

            // Act
            _inventory.StockAmount = validStock;
            int actualStock = _inventory.StockAmount;

            // Assert
            Assert.That(actualStock, Is.EqualTo(validStock));
        }
        #endregion

        #region Khushdeep's Tests
        /// I choosed 5 because it becomes the minimum value 

        [Test]
        public void SetPrice_ValidMinimumPrice_SetsCorrectly()
        {
            // Arrange
            double validprice = 5; // Minimum valid price

            // Act
            _inventory.ItemPrice = validprice;
            var realPrice = _inventory.ItemPrice;

            // Assert
            Assert.That(realPrice, Is.EqualTo(validprice));
        }

        /// I used 5000 because it becomes the highest value

        [Test]
        public void SetPrice_ValidMaximumPrice_SetsCorrectly()
        {
            // Arrange
            double validprice = 5000; // Highest valid price

            // Act
            _inventory.ItemPrice = validprice;
            var realPrice = _inventory.ItemPrice;

            // Assert
            Assert.That(realPrice, Is.EqualTo(validprice));
        }

        /// I choosed 2500 because it becomes the mid value.

        [Test]
        public void SetPrice_MidRangeValue_SetsCorrectly()
        {
            // Arrange
            double validprice = 2500; // A mid-range valid price

            // Act
            _inventory.ItemPrice = validprice;
            var realPrice = _inventory.ItemPrice;

            // Assert
            Assert.That(realPrice, Is.EqualTo(validprice));
        }

        /// I selected 120 as a random value.

        [Test]
        public void SetPrice_AnotherValidValue_SetsCorrectly()
        {
            // Arrange
            double validprice = 120; // Random valid price

            // Act
            _inventory.ItemPrice = validprice;
            var realPrice = _inventory.ItemPrice;

            // Assert
            Assert.That(realPrice, Is.EqualTo(validprice));
        }
        #endregion
    }
}