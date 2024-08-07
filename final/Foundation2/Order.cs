public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _totalCost;
    private float _shippingCost;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;

        if (customer.IsInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        _products = products;
        CalculateTotalCost();

    }
    private void CalculateTotalCost()
    {
        _totalCost = _shippingCost;
        foreach(Product product in _products)
        {
            _totalCost += product.GetTotalPrice();
        }
    }
    public float GetTotalCost()
    {
        return _totalCost;
    }
    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}\nCustomer Address:\n{_customer.GetAddress().GetAddress()}\n";
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        int cont = 1;
        foreach(Product product in _products)
        {
            packingLabel += $"Product {cont}:\n   Product Name: {product.GetProductName()}\n   Product ID: {product.GetID()}\n   Product Price: ${product.GetProductPrice()}\n   Product Quantity: {product.GetQuantity()}\n\n";
            cont += 1;
        }
        return packingLabel;
    }

}