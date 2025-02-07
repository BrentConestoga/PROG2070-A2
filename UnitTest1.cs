using NUnit.Framework;
using PROG2070_A2_Group_10;

[TestFixture]
public class ProductTests
{
    //Setting and testing ProdID
    [TestCase(5)]
    [TestCase(10000)]
    [TestCase(50000)]
    public void Test_ProdID_SetterAndGetter(int id)
    {
        var product = new Product(id, "Laptop", 1000.0f, 50);
        product.ProdID = id;
        Assert.That(product.ProdID, Is.EqualTo(id));
    }

    //Setting and testing ItemPrice
    [TestCase(5.0f)]
    [TestCase(999.99f)]
    [TestCase(5000.0f)]
    public void Test_ItemPrice_SetterAndGetter(float price)
    {
        var product = new Product(10, "Laptop", price, 50);
        product.ItemPrice = price;
        Assert.That(product.ItemPrice, Is.EqualTo(price));
    }

    //Setting and testing StockAmount
    [TestCase(5)]
    [TestCase(1000)]
    [TestCase(500000)]
    public void Test_StockAmount_SetterAndGetter(int stock)
    {
        var product = new Product(10, "Laptop", 1000.0f, stock);
        product.StockAmount = stock;
        Assert.That(product.StockAmount, Is.EqualTo(stock));
    }

    //Testing IncreaseStock method.
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

    //Testing DecreaseStock method for values less than initial stock
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

    //Testing DecreaseStock method for values greater than initial stock
    [TestCase(1500)]
    [TestCase(2000)]
    public void Test_StockDecrease_NotNegative(int amount)
    {
        var product = new Product(10, "Laptop", 1000.0f,50);
        product.DecreaseStock(amount);
        Assert.That(product.StockAmount, Is.EqualTo(5));
    }

    //Testing the max and min of ItemPrice
    [TestCase(5.0f)]
    [TestCase(5000.0f)]
    public void Test_ItemPrice_LimitValues(float price)
    {
        var product = new Product(10, "Laptop", price, 50);
        product.ItemPrice = price;
        Assert.That(product.ItemPrice, Is.EqualTo(price));
    }

    //Testing the max and min of ProdID
    [TestCase(5)]
    [TestCase(50000)]
    public void Test_ProdID_LimitValues(int prodID)
    {
        var product = new Product(prodID, "Laptop", 1000.0f, 50);
        product.ProdID = prodID;
        Assert.That(product.ProdID, Is.EqualTo(prodID));
    }

    //Testing the max and min of StockAmount
    [TestCase(5)]
    [TestCase(500000)]
    public void Test_StockAmount_LimitValues(int stock)
    {
        var product = new Product(10, "Laptop", 1000.0f, stock);
        product.StockAmount = stock;
        Assert.That(product.StockAmount, Is.EqualTo(stock));
    }
}

