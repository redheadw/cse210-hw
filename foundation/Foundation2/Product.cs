// Product Class
class Product
{
    private string productName;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    public Product(string productName, string productId, double pricePerUnit, int quantity)
    {
        this.productName = productName;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string GetPackingInfo()
    {
        return $"{productName} (ID: {productId})";
    }
}