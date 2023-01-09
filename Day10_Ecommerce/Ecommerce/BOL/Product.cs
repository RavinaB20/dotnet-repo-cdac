namespace BOL;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    
    public Product(){

    }
    public Product(int productId, string productName){
        this.ProductId = productId;
        this.ProductName = productName;
    }
    public Product(int productId, string productName, double price, int quantity){
        this.ProductId = productId;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }
}
