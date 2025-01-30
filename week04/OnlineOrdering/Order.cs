public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        if (_customer.LivesInUSA() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost.ToString("F2");
    }

    public string GetNetCost()
    {
        double netCost = 0;
        foreach (Product product in _products)
        {
            netCost += product.GetTotalPrice();
        }
        return netCost.ToString("F2");
    }

    public int GetShippingCost()
    {
        int shippingCost = 0;
        if (_customer.LivesInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            label += $"- ({product.GetProductQty()}) {product.GetProductName()} - ID: {product.GetPrductID()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\nCustomer Name: {_customer.GetCustomerName()}\nShipping Address: {_customer.GetAddress().GetFullAddress()}";
    }
}