using NUnit.Framework;
using PROG2070_A2_Group_10;

[TestFixture]
public class ProductTests
{
    private Product _product;

    // SetUp method to initialize Product object before each test
    [SetUp]
    public void SetUp()
    {
        _product = new Product(10, "Laptop", 1000.0f, 50);
    }

    // 3 Tests for ProdID (using different values)
    [TestCase(5)]
    [TestCase(10000)]
    [TestCase(50000)]
    public void Test_ProdID_SetterAndGetter(int id)
    {
        _product.ProdID = id;
        Assert.That(_product.ProdID, Is.EqualTo(id));
    }

    // 3 Tests for ItemPrice (using different values)
    [TestCase(5.0f)]
    [TestCase(999.99f)]
    [TestCase(5000.0f)]
    public void Test_ItemPrice_SetterAndGetter(float price)
    {
        _product.ItemPrice = price;
        Assert.That(_product.ItemPrice, Is.EqualTo(price));
    }

    // 3 Tests for StockAmount (using different values)
    [TestCase(5)]
    [TestCase(1000)]
    [TestCase(500000)]
    public void Test_StockAmount_SetterAndGetter(int stock)
    {
        _product.StockAmount = stock;
        Assert.That(_product.StockAmount, Is.EqualTo(stock));
    }

    // 3 Tests for IncreaseStock method (testing stock increase)
    [TestCase(50)]
    [TestCase(100)]
    [TestCase(200)]
    public void Test_StockIncrease(int amount)
    {
        var initialStock = _product.StockAmount;
        _product.IncreaseStock(amount);
        Assert.That(_product.StockAmount, Is.EqualTo(initialStock + amount));
    }

    // 3 Tests for DecreaseStock method (testing stock decrease)
    [TestCase(30)]
    [TestCase(50)]
    [TestCase(100)]
    public void Test_StockDecrease(int amount)
    {
        var initialStock = _product.StockAmount;
        _product.DecreaseStock(amount);
        Assert.That(_product.StockAmount, Is.EqualTo(initialStock - amount));
    }

    // 2 Tests for DecreaseStock when trying to decrease more than available stock
    [TestCase(150)]
    [TestCase(200)]
    public void Test_StockDecrease_NotNegative(int amount)
    {
        _product.DecreaseStock(amount);
        Assert.That(_product.StockAmount, Is.EqualTo(0));  // Stock should not go below 0
    }

    // 2 Tests for checking price boundaries (test price limits)
    [TestCase(5.0f)]
    [TestCase(5000.0f)]
    public void Test_ItemPrice_LimitValues(float price)
    {
        _product.ItemPrice = price;
        Assert.That(_product.ItemPrice, Is.EqualTo(price));
    }

    // 2 Tests for checking ProdID boundaries (test ProdID limits)
    [TestCase(5)]
    [TestCase(50000)]
    public void Test_ProdID_LimitValues(int prodID)
    {
        _product.ProdID = prodID;
        Assert.That(_product.ProdID, Is.EqualTo(prodID));
    }

    // 2 Tests for checking StockAmount boundaries (test StockAmount limits)
    [TestCase(5)]
    [TestCase(500000)]
    public void Test_StockAmount_LimitValues(int stock)
    {
        _product.StockAmount = stock;
        Assert.That(_product.StockAmount, Is.EqualTo(stock));
    }
}
