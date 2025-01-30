public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetPrductID()
    {
        return _productId;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }
}