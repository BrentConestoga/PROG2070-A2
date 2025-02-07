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
        _product = new Product(10, "Laptop", 1000.0f, 50); // Initializing product with sample data
    }

    // 3 Tests for ProdID (using different values)
    // These tests check that the ProdID property is correctly set and retrieved for various valid inputs.
    [TestCase(5)] // Test with lower boundary value
    [TestCase(10000)] // Test with a middle range value
    [TestCase(50000)] // Test with upper boundary value
    public void Test_ProdID_SetterAndGetter(int id)
    {
        _product.ProdID = id;
        Assert.That(_product.ProdID, Is.EqualTo(id));  // Ensures ProdID is set and retrieved correctly
    }

    // 3 Tests for ItemPrice (using different values)
    // These tests check that the ItemPrice property is correctly set and retrieved for various valid inputs.
    [TestCase(5.0f)] // Test with the minimum valid price
    [TestCase(999.99f)] // Test with a middle-range price
    [TestCase(5000.0f)] // Test with the maximum valid price
    public void Test_ItemPrice_SetterAndGetter(float price)
    {
        _product.ItemPrice = price;
        Assert.That(_product.ItemPrice, Is.EqualTo(price));  // Verifies the price is set and retrieved correctly
    }

    // 3 Tests for StockAmount (using different values)
    // These tests check that the StockAmount property is correctly set and retrieved for various valid inputs.
    [TestCase(5)] // Test with the minimum valid stock
    [TestCase(1000)] // Test with a middle-range stock value
    [TestCase(500000)] // Test with the maximum valid stock
    public void Test_StockAmount_SetterAndGetter(int stock)
    {
        _product.StockAmount = stock;
        Assert.That(_product.StockAmount, Is.EqualTo(stock));  // Verifies the stock amount is set and retrieved correctly
    }

    // 3 Tests for IncreaseStock method (testing stock increase)
    // These tests check that the IncreaseStock method works correctly by increasing stock by the specified amounts.
    [TestCase(50)] // Increase stock by 50
    [TestCase(100)] // Increase stock by 100
    [TestCase(200)] // Increase stock by 200
    public void Test_StockIncrease(int amount)
    {
        var initialStock = _product.StockAmount;
        _product.IncreaseStock(amount);
        Assert.That(_product.StockAmount, Is.EqualTo(initialStock + amount));  // Verifies stock is correctly increased
    }

    // 3 Tests for DecreaseStock method (testing stock decrease)
    // These tests check that the DecreaseStock method works correctly by decreasing stock by the specified amounts.
    [TestCase(30)] // Decrease stock by 30
    [TestCase(50)] // Decrease stock by 50
    [TestCase(100)] // Decrease stock by 100
    public void Test_StockDecrease(int amount)
    {
        var initialStock = _product.StockAmount;
        _product.DecreaseStock(amount);
        Assert.That(_product.StockAmount, Is.EqualTo(initialStock - amount));  // Verifies stock is correctly decreased
    }

    // 2 Tests for DecreaseStock when trying to decrease more than available stock
    // These tests ensure that the stock never goes below 0 even if a larger decrease is attempted.
    [TestCase(150)] // Try to decrease more stock than available
    [TestCase(200)] // Try to decrease more stock than available
    public void Test_StockDecrease_NotNegative(int amount)
    {
        _product.DecreaseStock(amount);
        Assert.That(_product.StockAmount, Is.EqualTo(0));  // Verifies stock is set to 0 and doesn't go below 0
    }

    // 2 Tests for checking price boundaries (test price limits)
    // These tests verify that the ItemPrice property correctly handles boundary values (the minimum and maximum allowed).
    [TestCase(5.0f)] // Test with the minimum valid price
    [TestCase(5000.0f)] // Test with the maximum valid price
    public void Test_ItemPrice_LimitValues(float price)
    {
        _product.ItemPrice = price;
        Assert.That(_product.ItemPrice, Is.EqualTo(price));  // Verifies the price is correctly set to boundary values
    }

    // 2 Tests for checking ProdID boundaries (test ProdID limits)
    // These tests ensure the ProdID property can handle the boundary values (minimum and maximum allowed).
    [TestCase(5)] // Test with the minimum valid ProdID
    [TestCase(50000)] // Test with the maximum valid ProdID
    public void Test_ProdID_LimitValues(int prodID)
    {
        _product.ProdID = prodID;
        Assert.That(_product.ProdID, Is.EqualTo(prodID));  // Verifies the ProdID is correctly set to boundary values
    }

    // 2 Tests for checking StockAmount boundaries (test StockAmount limits)
    // These tests ensure the StockAmount property can handle the boundary values (minimum and maximum allowed).
    [TestCase(5)] // Test with the minimum valid StockAmount
    [TestCase(500000)] // Test with the maximum valid StockAmount
    public void Test_StockAmount_LimitValues(int stock)
    {
        _product.StockAmount = stock;
        Assert.That(_product.StockAmount, Is.EqualTo(stock));  // Verifies the stock is correctly set to boundary values
    }
}
