namespace DAL;
using BOL;
using System.Text.Json;

public class DBManager
{
    public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts.Add(new Product{ProductId = 101, ProductName = "Pen" , Price = 10 , Quantity = 100});
        allProducts.Add(new Product{ProductId = 102, ProductName = "Pensil" , Price = 5 , Quantity = 200});
        allProducts.Add(new Product{ProductId = 103, ProductName = "Eraser" , Price = 7 , Quantity = 75});
        allProducts.Add(new Product{ProductId = 104, ProductName = "Sharpner" , Price = 20 , Quantity = 34});
        allProducts.Add(new Product{ProductId = 105, ProductName = "Scale" , Price = 50 , Quantity = 98});
        return allProducts;
    }   

    public static List<Product> GetAllProductsFromDatabase(){
        List<Product> allProducts = new List<Product>();
        return allProducts;
    }

    public static List<Product> GetAllProductsFromFile(String path){
        string jsonString = File.ReadAllText(path);
        List<Product> allProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
        return allProducts;
    }


}
