using NUnit.Framework;
using PROG2070_A2_Group_10;

[TestFixture]
public class ProductTests
{
    // 3 Tests for ProdID (using different values)
    [TestCase(5)]
    [TestCase(10000)]
    [TestCase(50000)]
    public void Test_ProdID_SetterAndGetter(int id)
    {
        var product = new Product(id, "Laptop", 1000.0f, 50);
        product.ProdID = id;
        Assert.That(product.ProdID, Is.EqualTo(id));
    }

    // 3 Tests for ItemPrice (using different values)
    [TestCase(5.0f)]
    [TestCase(999.99f)]
    [TestCase(5000.0f)]
    public void Test_ItemPrice_SetterAndGetter(float price)
    {
        var product = new Product(10, "Laptop", price, 50);
        product.ItemPrice = price;
        Assert.That(product.ItemPrice, Is.EqualTo(price));
    }

    // 3 Tests for StockAmount (using different values)
    [TestCase(5)]
    [TestCase(1000)]
    [TestCase(500000)]
    public void Test_StockAmount_SetterAndGetter(int stock)
    {
        var product = new Product(10, "Laptop", 1000.0f, stock);
        product.StockAmount = stock;
        Assert.That(product.StockAmount, Is.EqualTo(stock));
    }

    // 3 Tests for IncreaseStock method (testing stock increase)
    [TestCase(50)]
    [TestCase(100)]
    [TestCase(200)]
    public void Test_StockIncrease(int amount)
    {
        var product = new Product(10, "Laptop", 1000.0f, 50);
        var initialStock = product.StockAmount;
        product.IncreaseStock(amount);
        Assert.That(product.StockAmount, Is.EqualTo(initialStock + amount));
    }

    // 3 Tests for DecreaseStock method (testing stock decrease)
    [TestCase(30)]
    [TestCase(20)]
    [TestCase(10)]
    public void Test_StockDecrease(int amount)
    {
        var product = new Product(10, "Laptop", 1000.0f, 50);
        var initialStock = product.StockAmount;
        product.DecreaseStock(amount);
        Assert.That(product.StockAmount, Is.EqualTo(initialStock - amount));
    }

    // 2 Tests for DecreaseStock when trying to decrease more than available stock
    [TestCase(1500)] // Try to decrease more stock than available
    [TestCase(2000)] // Try to decrease more stock than available
    public void Test_StockDecrease_NotNegative(int amount)
    {
        var product = new Product(10, "Laptop", 1000.0f,50);
        product.DecreaseStock(amount);
        Assert.That(product.StockAmount, Is.EqualTo(5));  // Verifies stock is set to 0 and doesn't go below 0
    }

    // 2 Tests for checking price boundaries (test price limits)
    [TestCase(5.0f)]
    [TestCase(5000.0f)]
    public void Test_ItemPrice_LimitValues(float price)
    {
        var product = new Product(10, "Laptop", price, 50);
        product.ItemPrice = price;
        Assert.That(product.ItemPrice, Is.EqualTo(price));
    }

    // 2 Tests for checking ProdID boundaries (test ProdID limits)
    [TestCase(5)]
    [TestCase(50000)]
    public void Test_ProdID_LimitValues(int prodID)
    {
        var product = new Product(prodID, "Laptop", 1000.0f, 50);
        product.ProdID = prodID;
        Assert.That(product.ProdID, Is.EqualTo(prodID));
    }

    // 2 Tests for checking StockAmount boundaries (test StockAmount limits)
    [TestCase(5)]
    [TestCase(500000)]
    public void Test_StockAmount_LimitValues(int stock)
    {
        var product = new Product(10, "Laptop", 1000.0f, stock);
        product.StockAmount = stock;
        Assert.That(product.StockAmount, Is.EqualTo(stock));
    }
}

